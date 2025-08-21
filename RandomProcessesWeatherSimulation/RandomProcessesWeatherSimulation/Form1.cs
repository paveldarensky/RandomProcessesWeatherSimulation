using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Drawing.Drawing2D;
using static System.Windows.Forms.AxHost;
using System.Windows.Forms.DataVisualization.Charting;

namespace RandomProcessesWeatherSimulation
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
            comboBox_TypeOfSimulation.SelectedIndex = 0;
            panel_ControlPanel.Enabled = false;
        }

        /*
         * Погодные условия (10 состояний) :
         * s0 = state0 - солнечно (солнце);
         * s1 = state1 - малооблачно (солнце + мал.облако);
         * s2 = state2 - переменная облачность (солнце + бол.облако);
         * s3 = state3 - пасмурно (облака);
         * s4 = state4 - дождливо (облако + дождь);
         * s5 = state5 - гроза (облако + гроза);
         * s6 = state6 - гроза и дождь (облако + гроза + дождь);
         * s7 = state7 - снег (снег);
         * s8 = state8 - туман (облако + туман);
         * s9 = state9 - радуга (облака + радуга);
         */

        private double[,] Q; // матрица инфинитезимальных характеристик (интенсивностей перехода) для всех состояний
        private double[,] P; // Матрица P (вероятностей перехода)

        private int current_state = 0; // start state = 0 = s0 = state0 - солнечно

        private double[] statistics; // для сбора статистики, здесь в результате вычислений будут храниться стационарные вероятности состояний
        private List<SimulationEvent> timeline = new List<SimulationEvent>(); // результаты моделирования

        // класс для хранения результатов моделирования
        class SimulationEvent
        {
            public double Time { get; set; } // время перехода в состояние State
            public int State { get; set; } // состояние, которое началось в момент времени Time
        }

        double t; // общее количество временных единиц, накапливаемое интервалами времени (НСВ, экспоненциальный закон распределения) пребывания в состоянии current_state
        int N; // общее смоделированное количество событий
        double T; // общее время моделирования событий
        int n; // количество состояний, для задачи погоды подразумевается 10

        int displayTime; // единица времени для отображения результатов в реальном времени с использованием таймера, к примеру это дни

        double norm; // условие нормировки

        bool flagTypeOfSimulation = true; // по умолчанию - симуляция по количеству событий N

        Random random = new Random(); // seed

        private bool ValidateQMatrix(double[,] matrix, out string errorMessage)
        {
            errorMessage = "";
            for (int i = 0; i < n; i++)
            {
                double rowSum = 0;
                for (int j = 0; j < n; j++)
                {
                    double value = matrix[i, j];
                    rowSum += value;

                    if (i != j && value < 0)
                    {
                        errorMessage = $"Ошибка: недиагональный элемент Q[{i},{j}] = {value} < 0";
                        return false;
                    }

                    if (i == j && value >= 0)
                    {
                        errorMessage = $"Ошибка: диагональный элемент Q[{i},{i}] = {value} должен быть отрицательным";
                        return false;
                    }
                }

                if (Math.Abs(rowSum) > 1e-6) // допуск из-за погрешностей округления
                {
                    errorMessage = $"Ошибка: сумма строки {i} равна {rowSum}, а должна быть равна 0";
                    return false;
                }
            }

            return true;
        }

        private double[,] LoadQMatrixFromCsv(string file_path)
        {
            string[] lines = File.ReadAllLines(file_path);
            n = lines.Length;
            double[,] matrix = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] values = lines[i].Split(';'); // или ',' смотря какой разделитель
                if (values.Length != n)
                    throw new Exception($"Неверное количество столбцов в строке {i}. Ожидается {n}, найдено {values.Length}.");

                for (int j = 0; j < n; j++)
                {
                    if (!double.TryParse(values[j], NumberStyles.Float, CultureInfo.InvariantCulture, out matrix[i, j]))
                        throw new Exception($"Не удалось преобразовать значение [{i},{j}] = \"{values[j]}\" к double.");
                }
            }

            return matrix;
        }

        private double[,] CalculatePMatrix(double[,] Q)
        {
            double[,] P = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                double lambda = -Q[i, i]; // интенсивность выхода из состояния i

                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                        P[i, j] = 0;
                    else
                        P[i, j] = Q[i, j] / lambda;
                }
            }

            return P;
        }

        private void Simulation(double[,] Q, double[,] P)
        {
            timeline.Add(new SimulationEvent { Time = t, State = current_state });

            if (flagTypeOfSimulation)
            {
                // симуляция по количеству событий N
                for (int k = 0; k < N; k++)
                {
                    double alpha = random.NextDouble();
                    var tau = Math.Log(alpha) / Q[current_state, current_state];
                    statistics[current_state] += tau;
                    t += tau;
                    current_state = generateDRV(P, current_state);
                    timeline.Add(new SimulationEvent { Time = t, State = current_state });
                }
            }
            else
            {
                // симуляция по времени T
                while (t < T)
                {
                    double alpha = random.NextDouble();
                    var tau = Math.Log(alpha) / Q[current_state, current_state];
                    statistics[current_state] += tau;
                    t += tau;
                    if (t >= T)
                        break;
                    current_state = generateDRV(P, current_state);
                    timeline.Add(new SimulationEvent { Time = t, State = current_state });
                }
            }

            norm = 0;
            for (int i = 0; i < n; i++)
            {
                statistics[i] /= t;
                norm += statistics[i];
            }
        }

        private int generateDRV(double[,] P, int current_state)
        {
            double alpha = random.NextDouble();
            int k = 0;
            do
            {
                alpha -= P[current_state, k];
                k++;
            }
            while (alpha > 0);
            return k - 1;
        }

        private void timer_forVisualization_Tick(object sender, EventArgs e)
        {
            displayTime += 1; // имитируем 1 день

            if (displayTime > t || displayTime >= 61) // ограничение по визуализации в 2 месяца (60 дней) при большом запросе T
            {
                timer_forVisualization.Stop();
            }
            else
            {
                // находим текущее состояние (последнее, не превышающее displayTime)
                int currentDisplayState = timeline.LastOrDefault(x => x.Time <= displayTime).State;

                // отобразить его на форме
                DrawState(currentDisplayState);
            }
        }

        private void DrawState(int currentDisplayState)
        {
            label_Day.Text = "День: " + displayTime.ToString();

            string[] weatherDescriptions = new string[]
            {
                "Солнечно",
                "Малооблачно",
                "Переменная облачность",
                "Пасмурно",
                "Дождливо",
                "Гроза",
                "Гроза и дождь",
                "Снег",
                "Туман",
                "Радуга"
            };

            // Название состояния
            if (currentDisplayState >= 0 && currentDisplayState < weatherDescriptions.Length)
            {
                label_Weather.Text = "Погода: " + weatherDescriptions[currentDisplayState];

                // Картинка из ресурсов
                string resourceName = "state" + currentDisplayState;
                var image = (Image)Properties.Resources.ResourceManager.GetObject(resourceName);

                if (image != null)
                {
                    pictureBox_Weather.Image = image;
                }
                else
                {
                    MessageBox.Show("Изображение не найдено: " + resourceName);
                }
            }
            else
            {
                label_Weather.Text = "Неизвестное состояние";
                pictureBox_Weather.Image = null;
            }
        }

        private void button_StartSimulation_Click(object sender, EventArgs e)
        {
            string selectedMode = comboBox_TypeOfSimulation.SelectedItem?.ToString();
            string inputText = textBox_Parameter.Text.Trim();

            if (string.IsNullOrEmpty(selectedMode))
            {
                MessageBox.Show("Пожалуйста, выберите режим моделирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(inputText))
            {
                MessageBox.Show("Пожалуйста, введите значение параметра.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isValid = false;

            if (selectedMode == "Моделирование по количеству событий (N)")
            {
                if (int.TryParse(inputText, out int parsedN) && parsedN > 0)
                {
                    N = parsedN;
                    flagTypeOfSimulation = true;
                    isValid = true;
                    MessageBox.Show($"Моделирование по количеству событий: N = {N}", "Успешно");
                }
                else
                {
                    MessageBox.Show("Введите корректное положительное целое число для N.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (selectedMode == "Моделирование по времени (T)")
            {
                if (double.TryParse(inputText, NumberStyles.Float, CultureInfo.InvariantCulture, out double parsedT) && parsedT > 0)
                {
                    T = parsedT;
                    flagTypeOfSimulation = false;
                    isValid = true;
                    MessageBox.Show($"Моделирование по времени: T = {T}", "Успешно");
                }
                else
                {
                    MessageBox.Show("Введите корректное положительное число для T (можно с точкой).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Неизвестный режим моделирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (isValid)
            {
                // сброс параметров моделирования
                current_state = 0;
                t = 0;
                timeline.Clear();
                statistics = new double[n];

                Simulation(Q, P); // запустить симуляцию сразу

                if (checkBox_Visualization.Checked)
                {
                    tableLayoutPanel_Visualization.Visible = true;
                    displayTime = 0;
                    timer_forVisualization.Start();
                }
                else
                {
                    tableLayoutPanel_Visualization.Visible = false;
                }

                if (checkBox_Statistic.Checked)
                {
                    tableLayoutPanel_Statistic.Visible = true;
                    ShowStatistics(statistics);
                }
                else
                {
                    tableLayoutPanel_Statistic.Visible = false;
                }

                if (checkBox_Chart.Checked)
                {
                    chart_StateTransitions.Visible = true;
                    ChartSaveToolStripMenuItem.Enabled = true;
                    DrawStateTimelineChart(timeline);
                }
                else
                {
                    chart_StateTransitions.Visible = false;
                    ChartSaveToolStripMenuItem.Enabled = false;
                }
            }
        }

        private void comboBox_TypeOfSimulation_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMode = comboBox_TypeOfSimulation.SelectedItem?.ToString();

            if (selectedMode == "Моделирование по количеству событий (N)")
            {
                label_Parameter.Text = "Количество событий (N):";
            }
            else if (selectedMode == "Моделирование по времени (T)")
            {
                label_Parameter.Text = "Время (T):";
            }
            else
            {
                label_Parameter.Text = "Количество событий (N):";
            }
        }

        void ShowStatistics(double[] statistics)
        {
            // Проверка длины
            if (statistics.Length != 10)
            {
                MessageBox.Show("Ожидалось 10 значений для отображения статистики.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Формат: 0.000 (до трёх знаков)
            label_Prob0.Text = statistics[0].ToString("F3", CultureInfo.InvariantCulture);
            label_Prob1.Text = statistics[1].ToString("F3", CultureInfo.InvariantCulture);
            label_Prob2.Text = statistics[2].ToString("F3", CultureInfo.InvariantCulture);
            label_Prob3.Text = statistics[3].ToString("F3", CultureInfo.InvariantCulture);
            label_Prob4.Text = statistics[4].ToString("F3", CultureInfo.InvariantCulture);
            label_Prob5.Text = statistics[5].ToString("F3", CultureInfo.InvariantCulture);
            label_Prob6.Text = statistics[6].ToString("F3", CultureInfo.InvariantCulture);
            label_Prob7.Text = statistics[7].ToString("F3", CultureInfo.InvariantCulture);
            label_Prob8.Text = statistics[8].ToString("F3", CultureInfo.InvariantCulture);
            label_Prob9.Text = statistics[9].ToString("F3", CultureInfo.InvariantCulture);

            textBox_OtherInfo.Text = "Точное время моделирования в относительных единицах t = " + t.ToString("F3", CultureInfo.InvariantCulture) + Environment.NewLine
                + "Условие нормировки norm = " + norm.ToString("F3", CultureInfo.InvariantCulture);
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV файлы (*.csv)|*.csv|Все файлы (*.*)|*.*";
            openFileDialog.Title = "Выберите файл с матрицей Q";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Q = LoadQMatrixFromCsv(openFileDialog.FileName);

                    if (ValidateQMatrix(Q, out string error))
                    {
                        MessageBox.Show("Матрица Q успешно загружена и прошла проверку.", "Успех");
                        P = CalculatePMatrix(Q);
                        panel_ControlPanel.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show($"Матрица Q не прошла проверку:\n{error}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке матрицы Q: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Q == null || P == null)
            {
                MessageBox.Show("Матрицы Q и P ещё не загружены/рассчитаны.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            saveDialog.Title = "Сохранить статистику";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine("=== Матрица Q ===");
                sb.AppendLine(MatrixToString(Q));

                sb.AppendLine("\n=== Матрица P ===");
                sb.AppendLine(MatrixToString(P));

                sb.AppendLine($"\n=== Параметры симуляции ===");
                sb.AppendLine($"Тип: {(flagTypeOfSimulation ? "По количеству событий (N)" : "По времени (T)")}");
                sb.AppendLine(flagTypeOfSimulation ? $"N = {N}" : $"T = {T}");

                sb.AppendLine("\n=== Хронология симуляции ===");
                if (timeline != null)
                {
                    foreach (var entry in timeline)
                        sb.AppendLine($"t = {entry.Time:F3}, состояние = s{entry.State}");
                }

                sb.AppendLine("\n=== Стационарное распределение ===");
                for (int i = 0; i < statistics.Length; i++)
                {
                    sb.AppendLine($"s{i}: {statistics[i]:F3}");
                }

                sb.AppendLine("\n=== Вспомогательные оценки ===");
                sb.AppendLine($"Точное время моделирования: t = {t.ToString("F3", CultureInfo.InvariantCulture)}");
                sb.AppendLine($"Условие нормировки: norm = {norm.ToString("F3", CultureInfo.InvariantCulture)}");

                File.WriteAllText(saveDialog.FileName, sb.ToString(), Encoding.UTF8);
                MessageBox.Show("Статистика успешно сохранена.", "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string MatrixToString(double[,] matrix)
        {
            int n = matrix.GetLength(0);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sb.Append(matrix[i, j].ToString("F3", CultureInfo.InvariantCulture)).Append("\t");
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }

        private void DrawStateTimelineChart(List<SimulationEvent> timeline)
        {
            // 1. Очистить график
            var chart = chart_StateTransitions;
            chart.Series.Clear();
            chart.ChartAreas[0].AxisX.LabelStyle.Format = "dd.MM";
            chart.ChartAreas[0].AxisX.Title = "Время";
            chart.ChartAreas[0].AxisY.Title = "Состояние";

            // 2. Словарь состояний
            var states = new List<string> { "Солнечно", "Малооблачно", "Переменная облачность", "Пасмурно", "Дождливо", "Гроза", "Гроза и дождь", "Снег", "Туман", "Радуга" };

            var startTime = DateTime.Today;

            // 3. Создать серию
            var seriesLine = new Series("Пребывание в состоянии")
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = 2,
                Color = Color.MediumBlue,
                XValueType = ChartValueType.DateTime
            };

            // Маркеры переходов
            var seriesMarkers = new Series("Переходы")
            {
                ChartType = SeriesChartType.Point,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 7,
                Color = Color.Red,
                XValueType = ChartValueType.DateTime
            };

            for (int i = 0; i < timeline.Count - 1; i++)
            {
                var currentTime = startTime.AddDays(timeline[i].Time);
                var nextTime = startTime.AddDays(timeline[i + 1].Time);
                int currentState = timeline[i].State;
                int nextState = timeline[i + 1].State;

                seriesLine.Points.AddXY(currentTime, currentState);
                seriesLine.Points.AddXY(nextTime, currentState);

                if (currentState != nextState)
                {
                    seriesLine.Points.AddXY(nextTime, nextState);
                    seriesMarkers.Points.AddXY(nextTime, nextState); // маркер на переходе
                }
            }

            chart.Series.Add(seriesLine);
            chart.Series.Add(seriesMarkers);

            // 5. Установить подписи по Y
            chart.ChartAreas[0].AxisY.Minimum = 0;
            chart.ChartAreas[0].AxisY.Maximum = states.Count - 1;
            chart.ChartAreas[0].AxisY.Interval = 1;
            chart.ChartAreas[0].AxisY.LabelStyle = new LabelStyle { Interval = 1 };
            chart.ChartAreas[0].AxisY.CustomLabels.Clear();

            var chartArea = chart.ChartAreas[0];
            chartArea.CursorX.IsUserEnabled = true;
            chartArea.CursorX.IsUserSelectionEnabled = true;
            chartArea.AxisX.ScaleView.Zoomable = true;
            chartArea.AxisX.ScrollBar.Enabled = true;

            chartArea.CursorY.IsUserEnabled = true;
            chartArea.CursorY.IsUserSelectionEnabled = true;
            chartArea.AxisY.ScaleView.Zoomable = true;
            chartArea.AxisY.ScrollBar.Enabled = true;

            for (int i = 0; i < states.Count; i++)
            {
                var customLabel = new CustomLabel(i - 0.5, i + 0.5, states[i], 0, LabelMarkStyle.None);
                chart.ChartAreas[0].AxisY.CustomLabels.Add(customLabel);
            }
        }

        private void ChartSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
                sfd.Title = "Сохранить график";
                sfd.FileName = "chart.png";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ChartImageFormat format = ChartImageFormat.Png;
                    if (sfd.FilterIndex == 2) format = ChartImageFormat.Jpeg;
                    else if (sfd.FilterIndex == 3) format = ChartImageFormat.Bmp;

                    chart_StateTransitions.SaveImage(sfd.FileName, format);
                }
            }
        }
    }
}

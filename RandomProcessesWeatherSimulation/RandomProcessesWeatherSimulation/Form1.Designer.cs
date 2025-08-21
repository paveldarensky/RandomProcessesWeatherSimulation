namespace RandomProcessesWeatherSimulation
{
    partial class Form_Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.tableLayoutPanel_Main = new System.Windows.Forms.TableLayoutPanel();
            this.panel_ControlPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel_ControlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_ParametersAndButtons = new System.Windows.Forms.TableLayoutPanel();
            this.button_StartSimulation = new System.Windows.Forms.Button();
            this.comboBox_TypeOfSimulation = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel_Parameters = new System.Windows.Forms.TableLayoutPanel();
            this.label_Parameter = new System.Windows.Forms.Label();
            this.textBox_Parameter = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel_CheckBoxes = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox_Visualization = new System.Windows.Forms.CheckBox();
            this.checkBox_Statistic = new System.Windows.Forms.CheckBox();
            this.checkBox_Chart = new System.Windows.Forms.CheckBox();
            this.tabControl_Results = new System.Windows.Forms.TabControl();
            this.tabPage_Visualization = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel_Visualization = new System.Windows.Forms.TableLayoutPanel();
            this.label_Day = new System.Windows.Forms.Label();
            this.tableLayoutPanel_forWeatherSimulation = new System.Windows.Forms.TableLayoutPanel();
            this.label_Weather = new System.Windows.Forms.Label();
            this.pictureBox_Weather = new System.Windows.Forms.PictureBox();
            this.tabPage_Statistic = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel_Statistic = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_forStationaryProbDist = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_State9 = new System.Windows.Forms.TableLayoutPanel();
            this.label_State9 = new System.Windows.Forms.Label();
            this.pictureBox_State9 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel_State8 = new System.Windows.Forms.TableLayoutPanel();
            this.label_State8 = new System.Windows.Forms.Label();
            this.pictureBox_State8 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel_State7 = new System.Windows.Forms.TableLayoutPanel();
            this.label_State7 = new System.Windows.Forms.Label();
            this.pictureBox_State7 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel_State6 = new System.Windows.Forms.TableLayoutPanel();
            this.label_State6 = new System.Windows.Forms.Label();
            this.pictureBox_State6 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel_State5 = new System.Windows.Forms.TableLayoutPanel();
            this.label_State5 = new System.Windows.Forms.Label();
            this.pictureBox_State5 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel_State4 = new System.Windows.Forms.TableLayoutPanel();
            this.label_State4 = new System.Windows.Forms.Label();
            this.pictureBox_State4 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel_State3 = new System.Windows.Forms.TableLayoutPanel();
            this.label_State3 = new System.Windows.Forms.Label();
            this.pictureBox_State3 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel_State2 = new System.Windows.Forms.TableLayoutPanel();
            this.label_State2 = new System.Windows.Forms.Label();
            this.pictureBox_State2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel_State1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_State1 = new System.Windows.Forms.Label();
            this.pictureBox_State1 = new System.Windows.Forms.PictureBox();
            this.label_StatisticState = new System.Windows.Forms.Label();
            this.label_StatisticStationaryDistribution = new System.Windows.Forms.Label();
            this.label_Prob0 = new System.Windows.Forms.Label();
            this.label_Prob1 = new System.Windows.Forms.Label();
            this.label_Prob2 = new System.Windows.Forms.Label();
            this.label_Prob3 = new System.Windows.Forms.Label();
            this.label_Prob4 = new System.Windows.Forms.Label();
            this.label_Prob5 = new System.Windows.Forms.Label();
            this.label_Prob6 = new System.Windows.Forms.Label();
            this.label_Prob7 = new System.Windows.Forms.Label();
            this.label_Prob8 = new System.Windows.Forms.Label();
            this.label_Prob9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel_State0 = new System.Windows.Forms.TableLayoutPanel();
            this.label_State0 = new System.Windows.Forms.Label();
            this.pictureBox_State0 = new System.Windows.Forms.PictureBox();
            this.textBox_OtherInfo = new System.Windows.Forms.TextBox();
            this.tabPage_Chart = new System.Windows.Forms.TabPage();
            this.chart_StateTransitions = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChartSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer_forVisualization = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel_Main.SuspendLayout();
            this.panel_ControlPanel.SuspendLayout();
            this.tableLayoutPanel_ControlPanel.SuspendLayout();
            this.tableLayoutPanel_ParametersAndButtons.SuspendLayout();
            this.tableLayoutPanel_Parameters.SuspendLayout();
            this.tableLayoutPanel_CheckBoxes.SuspendLayout();
            this.tabControl_Results.SuspendLayout();
            this.tabPage_Visualization.SuspendLayout();
            this.tableLayoutPanel_Visualization.SuspendLayout();
            this.tableLayoutPanel_forWeatherSimulation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Weather)).BeginInit();
            this.tabPage_Statistic.SuspendLayout();
            this.tableLayoutPanel_Statistic.SuspendLayout();
            this.tableLayoutPanel_forStationaryProbDist.SuspendLayout();
            this.tableLayoutPanel_State9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_State9)).BeginInit();
            this.tableLayoutPanel_State8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_State8)).BeginInit();
            this.tableLayoutPanel_State7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_State7)).BeginInit();
            this.tableLayoutPanel_State6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_State6)).BeginInit();
            this.tableLayoutPanel_State5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_State5)).BeginInit();
            this.tableLayoutPanel_State4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_State4)).BeginInit();
            this.tableLayoutPanel_State3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_State3)).BeginInit();
            this.tableLayoutPanel_State2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_State2)).BeginInit();
            this.tableLayoutPanel_State1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_State1)).BeginInit();
            this.tableLayoutPanel_State0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_State0)).BeginInit();
            this.tabPage_Chart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_StateTransitions)).BeginInit();
            this.menuStrip_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Main
            // 
            this.tableLayoutPanel_Main.ColumnCount = 1;
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Main.Controls.Add(this.panel_ControlPanel, 0, 0);
            this.tableLayoutPanel_Main.Controls.Add(this.tabControl_Results, 0, 1);
            this.tableLayoutPanel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Main.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel_Main.Name = "tableLayoutPanel_Main";
            this.tableLayoutPanel_Main.RowCount = 2;
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.90419F));
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.09581F));
            this.tableLayoutPanel_Main.Size = new System.Drawing.Size(1385, 664);
            this.tableLayoutPanel_Main.TabIndex = 0;
            // 
            // panel_ControlPanel
            // 
            this.panel_ControlPanel.Controls.Add(this.tableLayoutPanel_ControlPanel);
            this.panel_ControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ControlPanel.Location = new System.Drawing.Point(3, 3);
            this.panel_ControlPanel.Name = "panel_ControlPanel";
            this.panel_ControlPanel.Size = new System.Drawing.Size(1379, 146);
            this.panel_ControlPanel.TabIndex = 0;
            // 
            // tableLayoutPanel_ControlPanel
            // 
            this.tableLayoutPanel_ControlPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel_ControlPanel.ColumnCount = 1;
            this.tableLayoutPanel_ControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_ControlPanel.Controls.Add(this.tableLayoutPanel_ParametersAndButtons, 0, 0);
            this.tableLayoutPanel_ControlPanel.Controls.Add(this.tableLayoutPanel_CheckBoxes, 0, 1);
            this.tableLayoutPanel_ControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_ControlPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_ControlPanel.Name = "tableLayoutPanel_ControlPanel";
            this.tableLayoutPanel_ControlPanel.RowCount = 2;
            this.tableLayoutPanel_ControlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.22835F));
            this.tableLayoutPanel_ControlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.77165F));
            this.tableLayoutPanel_ControlPanel.Size = new System.Drawing.Size(1379, 146);
            this.tableLayoutPanel_ControlPanel.TabIndex = 0;
            // 
            // tableLayoutPanel_ParametersAndButtons
            // 
            this.tableLayoutPanel_ParametersAndButtons.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel_ParametersAndButtons.ColumnCount = 3;
            this.tableLayoutPanel_ParametersAndButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.22222F));
            this.tableLayoutPanel_ParametersAndButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.77778F));
            this.tableLayoutPanel_ParametersAndButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 223F));
            this.tableLayoutPanel_ParametersAndButtons.Controls.Add(this.button_StartSimulation, 2, 0);
            this.tableLayoutPanel_ParametersAndButtons.Controls.Add(this.comboBox_TypeOfSimulation, 0, 0);
            this.tableLayoutPanel_ParametersAndButtons.Controls.Add(this.tableLayoutPanel_Parameters, 1, 0);
            this.tableLayoutPanel_ParametersAndButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_ParametersAndButtons.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel_ParametersAndButtons.Name = "tableLayoutPanel_ParametersAndButtons";
            this.tableLayoutPanel_ParametersAndButtons.RowCount = 1;
            this.tableLayoutPanel_ParametersAndButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_ParametersAndButtons.Size = new System.Drawing.Size(1371, 98);
            this.tableLayoutPanel_ParametersAndButtons.TabIndex = 0;
            // 
            // button_StartSimulation
            // 
            this.button_StartSimulation.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_StartSimulation.AutoSize = true;
            this.button_StartSimulation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_StartSimulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_StartSimulation.Location = new System.Drawing.Point(1192, 31);
            this.button_StartSimulation.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.button_StartSimulation.Name = "button_StartSimulation";
            this.button_StartSimulation.Size = new System.Drawing.Size(168, 35);
            this.button_StartSimulation.TabIndex = 0;
            this.button_StartSimulation.Text = "Моделировать";
            this.button_StartSimulation.UseVisualStyleBackColor = true;
            this.button_StartSimulation.Click += new System.EventHandler(this.button_StartSimulation_Click);
            // 
            // comboBox_TypeOfSimulation
            // 
            this.comboBox_TypeOfSimulation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_TypeOfSimulation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_TypeOfSimulation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TypeOfSimulation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_TypeOfSimulation.FormattingEnabled = true;
            this.comboBox_TypeOfSimulation.Items.AddRange(new object[] {
            "Моделирование по количеству событий (N)",
            "Моделирование по времени (T)"});
            this.comboBox_TypeOfSimulation.Location = new System.Drawing.Point(224, 38);
            this.comboBox_TypeOfSimulation.Name = "comboBox_TypeOfSimulation";
            this.comboBox_TypeOfSimulation.Size = new System.Drawing.Size(379, 28);
            this.comboBox_TypeOfSimulation.TabIndex = 1;
            this.comboBox_TypeOfSimulation.SelectedIndexChanged += new System.EventHandler(this.comboBox_TypeOfSimulation_SelectedIndexChanged);
            // 
            // tableLayoutPanel_Parameters
            // 
            this.tableLayoutPanel_Parameters.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel_Parameters.ColumnCount = 1;
            this.tableLayoutPanel_Parameters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Parameters.Controls.Add(this.label_Parameter, 0, 0);
            this.tableLayoutPanel_Parameters.Controls.Add(this.textBox_Parameter, 0, 1);
            this.tableLayoutPanel_Parameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Parameters.Location = new System.Drawing.Point(831, 4);
            this.tableLayoutPanel_Parameters.Name = "tableLayoutPanel_Parameters";
            this.tableLayoutPanel_Parameters.RowCount = 2;
            this.tableLayoutPanel_Parameters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.74074F));
            this.tableLayoutPanel_Parameters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.25926F));
            this.tableLayoutPanel_Parameters.Size = new System.Drawing.Size(311, 90);
            this.tableLayoutPanel_Parameters.TabIndex = 2;
            // 
            // label_Parameter
            // 
            this.label_Parameter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Parameter.AutoSize = true;
            this.label_Parameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Parameter.Location = new System.Drawing.Point(38, 6);
            this.label_Parameter.Name = "label_Parameter";
            this.label_Parameter.Size = new System.Drawing.Size(235, 24);
            this.label_Parameter.TabIndex = 0;
            this.label_Parameter.Text = "Количество событий (N):";
            // 
            // textBox_Parameter
            // 
            this.textBox_Parameter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Parameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Parameter.Location = new System.Drawing.Point(105, 48);
            this.textBox_Parameter.Name = "textBox_Parameter";
            this.textBox_Parameter.Size = new System.Drawing.Size(100, 29);
            this.textBox_Parameter.TabIndex = 1;
            this.textBox_Parameter.Text = "100";
            // 
            // tableLayoutPanel_CheckBoxes
            // 
            this.tableLayoutPanel_CheckBoxes.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel_CheckBoxes.ColumnCount = 3;
            this.tableLayoutPanel_CheckBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_CheckBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_CheckBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_CheckBoxes.Controls.Add(this.checkBox_Visualization, 0, 0);
            this.tableLayoutPanel_CheckBoxes.Controls.Add(this.checkBox_Statistic, 1, 0);
            this.tableLayoutPanel_CheckBoxes.Controls.Add(this.checkBox_Chart, 2, 0);
            this.tableLayoutPanel_CheckBoxes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_CheckBoxes.Location = new System.Drawing.Point(4, 109);
            this.tableLayoutPanel_CheckBoxes.Name = "tableLayoutPanel_CheckBoxes";
            this.tableLayoutPanel_CheckBoxes.RowCount = 1;
            this.tableLayoutPanel_CheckBoxes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_CheckBoxes.Size = new System.Drawing.Size(1371, 33);
            this.tableLayoutPanel_CheckBoxes.TabIndex = 1;
            // 
            // checkBox_Visualization
            // 
            this.checkBox_Visualization.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Visualization.AutoSize = true;
            this.checkBox_Visualization.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_Visualization.Location = new System.Drawing.Point(161, 4);
            this.checkBox_Visualization.Name = "checkBox_Visualization";
            this.checkBox_Visualization.Size = new System.Drawing.Size(135, 24);
            this.checkBox_Visualization.TabIndex = 0;
            this.checkBox_Visualization.Text = "Визуализация";
            this.checkBox_Visualization.UseVisualStyleBackColor = true;
            // 
            // checkBox_Statistic
            // 
            this.checkBox_Statistic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Statistic.AutoSize = true;
            this.checkBox_Statistic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_Statistic.Location = new System.Drawing.Point(625, 4);
            this.checkBox_Statistic.Name = "checkBox_Statistic";
            this.checkBox_Statistic.Size = new System.Drawing.Size(118, 24);
            this.checkBox_Statistic.TabIndex = 1;
            this.checkBox_Statistic.Text = "Статистика";
            this.checkBox_Statistic.UseVisualStyleBackColor = true;
            // 
            // checkBox_Chart
            // 
            this.checkBox_Chart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Chart.AutoSize = true;
            this.checkBox_Chart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_Chart.Location = new System.Drawing.Point(1098, 4);
            this.checkBox_Chart.Name = "checkBox_Chart";
            this.checkBox_Chart.Size = new System.Drawing.Size(87, 24);
            this.checkBox_Chart.TabIndex = 2;
            this.checkBox_Chart.Text = "График";
            this.checkBox_Chart.UseVisualStyleBackColor = true;
            // 
            // tabControl_Results
            // 
            this.tabControl_Results.Controls.Add(this.tabPage_Visualization);
            this.tabControl_Results.Controls.Add(this.tabPage_Statistic);
            this.tabControl_Results.Controls.Add(this.tabPage_Chart);
            this.tabControl_Results.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl_Results.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Results.Location = new System.Drawing.Point(3, 155);
            this.tabControl_Results.Name = "tabControl_Results";
            this.tabControl_Results.SelectedIndex = 0;
            this.tabControl_Results.Size = new System.Drawing.Size(1379, 506);
            this.tabControl_Results.TabIndex = 1;
            // 
            // tabPage_Visualization
            // 
            this.tabPage_Visualization.Controls.Add(this.tableLayoutPanel_Visualization);
            this.tabPage_Visualization.Location = new System.Drawing.Point(4, 29);
            this.tabPage_Visualization.Name = "tabPage_Visualization";
            this.tabPage_Visualization.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Visualization.Size = new System.Drawing.Size(1371, 473);
            this.tabPage_Visualization.TabIndex = 0;
            this.tabPage_Visualization.Text = "Визуализация";
            this.tabPage_Visualization.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel_Visualization
            // 
            this.tableLayoutPanel_Visualization.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel_Visualization.ColumnCount = 1;
            this.tableLayoutPanel_Visualization.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Visualization.Controls.Add(this.label_Day, 0, 0);
            this.tableLayoutPanel_Visualization.Controls.Add(this.tableLayoutPanel_forWeatherSimulation, 0, 1);
            this.tableLayoutPanel_Visualization.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel_Visualization.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_Visualization.Name = "tableLayoutPanel_Visualization";
            this.tableLayoutPanel_Visualization.RowCount = 2;
            this.tableLayoutPanel_Visualization.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.73118F));
            this.tableLayoutPanel_Visualization.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.26881F));
            this.tableLayoutPanel_Visualization.Size = new System.Drawing.Size(1365, 187);
            this.tableLayoutPanel_Visualization.TabIndex = 3;
            this.tableLayoutPanel_Visualization.Visible = false;
            // 
            // label_Day
            // 
            this.label_Day.AutoSize = true;
            this.label_Day.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Day.Location = new System.Drawing.Point(11, 11);
            this.label_Day.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.label_Day.Name = "label_Day";
            this.label_Day.Size = new System.Drawing.Size(77, 24);
            this.label_Day.TabIndex = 0;
            this.label_Day.Text = "День: 0";
            // 
            // tableLayoutPanel_forWeatherSimulation
            // 
            this.tableLayoutPanel_forWeatherSimulation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel_forWeatherSimulation.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel_forWeatherSimulation.ColumnCount = 1;
            this.tableLayoutPanel_forWeatherSimulation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_forWeatherSimulation.Controls.Add(this.label_Weather, 0, 0);
            this.tableLayoutPanel_forWeatherSimulation.Controls.Add(this.pictureBox_Weather, 0, 1);
            this.tableLayoutPanel_forWeatherSimulation.Location = new System.Drawing.Point(555, 50);
            this.tableLayoutPanel_forWeatherSimulation.Name = "tableLayoutPanel_forWeatherSimulation";
            this.tableLayoutPanel_forWeatherSimulation.RowCount = 2;
            this.tableLayoutPanel_forWeatherSimulation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.23256F));
            this.tableLayoutPanel_forWeatherSimulation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.76744F));
            this.tableLayoutPanel_forWeatherSimulation.Size = new System.Drawing.Size(255, 133);
            this.tableLayoutPanel_forWeatherSimulation.TabIndex = 1;
            // 
            // label_Weather
            // 
            this.label_Weather.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Weather.AutoSize = true;
            this.label_Weather.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Weather.Location = new System.Drawing.Point(4, 8);
            this.label_Weather.Name = "label_Weather";
            this.label_Weather.Size = new System.Drawing.Size(86, 24);
            this.label_Weather.TabIndex = 1;
            this.label_Weather.Text = "Погода: ";
            // 
            // pictureBox_Weather
            // 
            this.pictureBox_Weather.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_Weather.Location = new System.Drawing.Point(95, 54);
            this.pictureBox_Weather.Name = "pictureBox_Weather";
            this.pictureBox_Weather.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_Weather.TabIndex = 2;
            this.pictureBox_Weather.TabStop = false;
            // 
            // tabPage_Statistic
            // 
            this.tabPage_Statistic.Controls.Add(this.tableLayoutPanel_Statistic);
            this.tabPage_Statistic.Location = new System.Drawing.Point(4, 29);
            this.tabPage_Statistic.Name = "tabPage_Statistic";
            this.tabPage_Statistic.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Statistic.Size = new System.Drawing.Size(1371, 473);
            this.tabPage_Statistic.TabIndex = 1;
            this.tabPage_Statistic.Text = "Статистика";
            this.tabPage_Statistic.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel_Statistic
            // 
            this.tableLayoutPanel_Statistic.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel_Statistic.ColumnCount = 1;
            this.tableLayoutPanel_Statistic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Statistic.Controls.Add(this.tableLayoutPanel_forStationaryProbDist, 0, 0);
            this.tableLayoutPanel_Statistic.Controls.Add(this.textBox_OtherInfo, 0, 1);
            this.tableLayoutPanel_Statistic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Statistic.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_Statistic.Name = "tableLayoutPanel_Statistic";
            this.tableLayoutPanel_Statistic.RowCount = 2;
            this.tableLayoutPanel_Statistic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.7551F));
            this.tableLayoutPanel_Statistic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.2449F));
            this.tableLayoutPanel_Statistic.Size = new System.Drawing.Size(1365, 467);
            this.tableLayoutPanel_Statistic.TabIndex = 1;
            this.tableLayoutPanel_Statistic.Visible = false;
            // 
            // tableLayoutPanel_forStationaryProbDist
            // 
            this.tableLayoutPanel_forStationaryProbDist.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel_forStationaryProbDist.ColumnCount = 11;
            this.tableLayoutPanel_forStationaryProbDist.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel_forStationaryProbDist.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel_forStationaryProbDist.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel_forStationaryProbDist.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel_forStationaryProbDist.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel_forStationaryProbDist.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel_forStationaryProbDist.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel_forStationaryProbDist.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel_forStationaryProbDist.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel_forStationaryProbDist.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel_forStationaryProbDist.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel_forStationaryProbDist.Controls.Add(this.tableLayoutPanel_State9, 10, 0);
            this.tableLayoutPanel_forStationaryProbDist.Controls.Add(this.tableLayoutPanel_State8, 9, 0);
            this.tableLayoutPanel_forStationaryProbDist.Controls.Add(this.tableLayoutPanel_State7, 8, 0);
            this.tableLayoutPanel_forStationaryProbDist.Controls.Add(this.tableLayoutPanel_State6, 7, 0);
            this.tableLayoutPanel_forStationaryProbDist.Controls.Add(this.tableLayoutPanel_State5, 6, 0);
            this.tableLayoutPanel_forStationaryProbDist.Controls.Add(this.tableLayoutPanel_State4, 5, 0);
            this.tableLayoutPanel_forStationaryProbDist.Controls.Add(this.tableLayoutPanel_State3, 4, 0);
            this.tableLayoutPanel_forStationaryProbDist.Controls.Add(this.tableLayoutPanel_State2, 3, 0);
            this.tableLayoutPanel_forStationaryProbDist.Controls.Add(this.tableLayoutPanel_State1, 2, 0);
            this.tableLayoutPanel_forStationaryProbDist.Controls.Add(this.label_StatisticState, 0, 0);
            this.tableLayoutPanel_forStationaryProbDist.Controls.Add(this.label_StatisticStationaryDistribution, 0, 1);
            this.tableLayoutPanel_forStationaryProbDist.Controls.Add(this.label_Prob0, 1, 1);
            this.tableLayoutPanel_forStationaryProbDist.Controls.Add(this.label_Prob1, 2, 1);
            this.tableLayoutPanel_forStationaryProbDist.Controls.Add(this.label_Prob2, 3, 1);
            this.tableLayoutPanel_forStationaryProbDist.Controls.Add(this.label_Prob3, 4, 1);
            this.tableLayoutPanel_forStationaryProbDist.Controls.Add(this.label_Prob4, 5, 1);
            this.tableLayoutPanel_forStationaryProbDist.Controls.Add(this.label_Prob5, 6, 1);
            this.tableLayoutPanel_forStationaryProbDist.Controls.Add(this.label_Prob6, 7, 1);
            this.tableLayoutPanel_forStationaryProbDist.Controls.Add(this.label_Prob7, 8, 1);
            this.tableLayoutPanel_forStationaryProbDist.Controls.Add(this.label_Prob8, 9, 1);
            this.tableLayoutPanel_forStationaryProbDist.Controls.Add(this.label_Prob9, 10, 1);
            this.tableLayoutPanel_forStationaryProbDist.Controls.Add(this.tableLayoutPanel_State0, 1, 0);
            this.tableLayoutPanel_forStationaryProbDist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_forStationaryProbDist.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel_forStationaryProbDist.Name = "tableLayoutPanel_forStationaryProbDist";
            this.tableLayoutPanel_forStationaryProbDist.RowCount = 2;
            this.tableLayoutPanel_forStationaryProbDist.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel_forStationaryProbDist.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel_forStationaryProbDist.Size = new System.Drawing.Size(1357, 215);
            this.tableLayoutPanel_forStationaryProbDist.TabIndex = 0;
            // 
            // tableLayoutPanel_State9
            // 
            this.tableLayoutPanel_State9.ColumnCount = 1;
            this.tableLayoutPanel_State9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_State9.Controls.Add(this.label_State9, 0, 0);
            this.tableLayoutPanel_State9.Controls.Add(this.pictureBox_State9, 0, 1);
            this.tableLayoutPanel_State9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_State9.Location = new System.Drawing.Point(1237, 4);
            this.tableLayoutPanel_State9.Name = "tableLayoutPanel_State9";
            this.tableLayoutPanel_State9.RowCount = 2;
            this.tableLayoutPanel_State9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.94495F));
            this.tableLayoutPanel_State9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.05505F));
            this.tableLayoutPanel_State9.Size = new System.Drawing.Size(116, 121);
            this.tableLayoutPanel_State9.TabIndex = 22;
            // 
            // label_State9
            // 
            this.label_State9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_State9.AutoSize = true;
            this.label_State9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_State9.Location = new System.Drawing.Point(31, 12);
            this.label_State9.Name = "label_State9";
            this.label_State9.Size = new System.Drawing.Size(54, 16);
            this.label_State9.TabIndex = 0;
            this.label_State9.Text = "Радуга";
            this.label_State9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_State9
            // 
            this.pictureBox_State9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_State9.Image = global::RandomProcessesWeatherSimulation.Properties.Resources.state9;
            this.pictureBox_State9.Location = new System.Drawing.Point(26, 49);
            this.pictureBox_State9.Name = "pictureBox_State9";
            this.pictureBox_State9.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_State9.TabIndex = 1;
            this.pictureBox_State9.TabStop = false;
            // 
            // tableLayoutPanel_State8
            // 
            this.tableLayoutPanel_State8.ColumnCount = 1;
            this.tableLayoutPanel_State8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_State8.Controls.Add(this.label_State8, 0, 0);
            this.tableLayoutPanel_State8.Controls.Add(this.pictureBox_State8, 0, 1);
            this.tableLayoutPanel_State8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_State8.Location = new System.Drawing.Point(1115, 4);
            this.tableLayoutPanel_State8.Name = "tableLayoutPanel_State8";
            this.tableLayoutPanel_State8.RowCount = 2;
            this.tableLayoutPanel_State8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.94495F));
            this.tableLayoutPanel_State8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.05505F));
            this.tableLayoutPanel_State8.Size = new System.Drawing.Size(115, 121);
            this.tableLayoutPanel_State8.TabIndex = 21;
            // 
            // label_State8
            // 
            this.label_State8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_State8.AutoSize = true;
            this.label_State8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_State8.Location = new System.Drawing.Point(33, 12);
            this.label_State8.Name = "label_State8";
            this.label_State8.Size = new System.Drawing.Size(49, 16);
            this.label_State8.TabIndex = 0;
            this.label_State8.Text = "Туман";
            this.label_State8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_State8
            // 
            this.pictureBox_State8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_State8.Image = global::RandomProcessesWeatherSimulation.Properties.Resources.state8;
            this.pictureBox_State8.Location = new System.Drawing.Point(25, 49);
            this.pictureBox_State8.Name = "pictureBox_State8";
            this.pictureBox_State8.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_State8.TabIndex = 1;
            this.pictureBox_State8.TabStop = false;
            // 
            // tableLayoutPanel_State7
            // 
            this.tableLayoutPanel_State7.ColumnCount = 1;
            this.tableLayoutPanel_State7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_State7.Controls.Add(this.label_State7, 0, 0);
            this.tableLayoutPanel_State7.Controls.Add(this.pictureBox_State7, 0, 1);
            this.tableLayoutPanel_State7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_State7.Location = new System.Drawing.Point(993, 4);
            this.tableLayoutPanel_State7.Name = "tableLayoutPanel_State7";
            this.tableLayoutPanel_State7.RowCount = 2;
            this.tableLayoutPanel_State7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.94495F));
            this.tableLayoutPanel_State7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.05505F));
            this.tableLayoutPanel_State7.Size = new System.Drawing.Size(115, 121);
            this.tableLayoutPanel_State7.TabIndex = 20;
            // 
            // label_State7
            // 
            this.label_State7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_State7.AutoSize = true;
            this.label_State7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_State7.Location = new System.Drawing.Point(38, 12);
            this.label_State7.Name = "label_State7";
            this.label_State7.Size = new System.Drawing.Size(38, 16);
            this.label_State7.TabIndex = 0;
            this.label_State7.Text = "Снег";
            this.label_State7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_State7
            // 
            this.pictureBox_State7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_State7.Image = global::RandomProcessesWeatherSimulation.Properties.Resources.state7;
            this.pictureBox_State7.Location = new System.Drawing.Point(25, 49);
            this.pictureBox_State7.Name = "pictureBox_State7";
            this.pictureBox_State7.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_State7.TabIndex = 1;
            this.pictureBox_State7.TabStop = false;
            // 
            // tableLayoutPanel_State6
            // 
            this.tableLayoutPanel_State6.ColumnCount = 1;
            this.tableLayoutPanel_State6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_State6.Controls.Add(this.label_State6, 0, 0);
            this.tableLayoutPanel_State6.Controls.Add(this.pictureBox_State6, 0, 1);
            this.tableLayoutPanel_State6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_State6.Location = new System.Drawing.Point(871, 4);
            this.tableLayoutPanel_State6.Name = "tableLayoutPanel_State6";
            this.tableLayoutPanel_State6.RowCount = 2;
            this.tableLayoutPanel_State6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.94495F));
            this.tableLayoutPanel_State6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.05505F));
            this.tableLayoutPanel_State6.Size = new System.Drawing.Size(115, 121);
            this.tableLayoutPanel_State6.TabIndex = 19;
            // 
            // label_State6
            // 
            this.label_State6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_State6.AutoSize = true;
            this.label_State6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_State6.Location = new System.Drawing.Point(7, 12);
            this.label_State6.Name = "label_State6";
            this.label_State6.Size = new System.Drawing.Size(100, 16);
            this.label_State6.TabIndex = 0;
            this.label_State6.Text = "Гроза и дождь";
            this.label_State6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_State6
            // 
            this.pictureBox_State6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_State6.Image = global::RandomProcessesWeatherSimulation.Properties.Resources.state6;
            this.pictureBox_State6.Location = new System.Drawing.Point(25, 49);
            this.pictureBox_State6.Name = "pictureBox_State6";
            this.pictureBox_State6.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_State6.TabIndex = 1;
            this.pictureBox_State6.TabStop = false;
            // 
            // tableLayoutPanel_State5
            // 
            this.tableLayoutPanel_State5.ColumnCount = 1;
            this.tableLayoutPanel_State5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_State5.Controls.Add(this.label_State5, 0, 0);
            this.tableLayoutPanel_State5.Controls.Add(this.pictureBox_State5, 0, 1);
            this.tableLayoutPanel_State5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_State5.Location = new System.Drawing.Point(749, 4);
            this.tableLayoutPanel_State5.Name = "tableLayoutPanel_State5";
            this.tableLayoutPanel_State5.RowCount = 2;
            this.tableLayoutPanel_State5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.94495F));
            this.tableLayoutPanel_State5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.05505F));
            this.tableLayoutPanel_State5.Size = new System.Drawing.Size(115, 121);
            this.tableLayoutPanel_State5.TabIndex = 18;
            // 
            // label_State5
            // 
            this.label_State5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_State5.AutoSize = true;
            this.label_State5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_State5.Location = new System.Drawing.Point(34, 12);
            this.label_State5.Name = "label_State5";
            this.label_State5.Size = new System.Drawing.Size(46, 16);
            this.label_State5.TabIndex = 0;
            this.label_State5.Text = "Гроза";
            this.label_State5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_State5
            // 
            this.pictureBox_State5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_State5.Image = global::RandomProcessesWeatherSimulation.Properties.Resources.state5;
            this.pictureBox_State5.Location = new System.Drawing.Point(25, 49);
            this.pictureBox_State5.Name = "pictureBox_State5";
            this.pictureBox_State5.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_State5.TabIndex = 1;
            this.pictureBox_State5.TabStop = false;
            // 
            // tableLayoutPanel_State4
            // 
            this.tableLayoutPanel_State4.ColumnCount = 1;
            this.tableLayoutPanel_State4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_State4.Controls.Add(this.label_State4, 0, 0);
            this.tableLayoutPanel_State4.Controls.Add(this.pictureBox_State4, 0, 1);
            this.tableLayoutPanel_State4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_State4.Location = new System.Drawing.Point(627, 4);
            this.tableLayoutPanel_State4.Name = "tableLayoutPanel_State4";
            this.tableLayoutPanel_State4.RowCount = 2;
            this.tableLayoutPanel_State4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.94495F));
            this.tableLayoutPanel_State4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.05505F));
            this.tableLayoutPanel_State4.Size = new System.Drawing.Size(115, 121);
            this.tableLayoutPanel_State4.TabIndex = 17;
            // 
            // label_State4
            // 
            this.label_State4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_State4.AutoSize = true;
            this.label_State4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_State4.Location = new System.Drawing.Point(21, 12);
            this.label_State4.Name = "label_State4";
            this.label_State4.Size = new System.Drawing.Size(73, 16);
            this.label_State4.TabIndex = 0;
            this.label_State4.Text = "Дождливо";
            this.label_State4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_State4
            // 
            this.pictureBox_State4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_State4.Image = global::RandomProcessesWeatherSimulation.Properties.Resources.state4;
            this.pictureBox_State4.Location = new System.Drawing.Point(25, 49);
            this.pictureBox_State4.Name = "pictureBox_State4";
            this.pictureBox_State4.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_State4.TabIndex = 1;
            this.pictureBox_State4.TabStop = false;
            // 
            // tableLayoutPanel_State3
            // 
            this.tableLayoutPanel_State3.ColumnCount = 1;
            this.tableLayoutPanel_State3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_State3.Controls.Add(this.label_State3, 0, 0);
            this.tableLayoutPanel_State3.Controls.Add(this.pictureBox_State3, 0, 1);
            this.tableLayoutPanel_State3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_State3.Location = new System.Drawing.Point(505, 4);
            this.tableLayoutPanel_State3.Name = "tableLayoutPanel_State3";
            this.tableLayoutPanel_State3.RowCount = 2;
            this.tableLayoutPanel_State3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.94495F));
            this.tableLayoutPanel_State3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.05505F));
            this.tableLayoutPanel_State3.Size = new System.Drawing.Size(115, 121);
            this.tableLayoutPanel_State3.TabIndex = 16;
            // 
            // label_State3
            // 
            this.label_State3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_State3.AutoSize = true;
            this.label_State3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_State3.Location = new System.Drawing.Point(21, 12);
            this.label_State3.Name = "label_State3";
            this.label_State3.Size = new System.Drawing.Size(73, 16);
            this.label_State3.TabIndex = 0;
            this.label_State3.Text = "Пасмурно";
            this.label_State3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_State3
            // 
            this.pictureBox_State3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_State3.Image = global::RandomProcessesWeatherSimulation.Properties.Resources.state3;
            this.pictureBox_State3.Location = new System.Drawing.Point(25, 49);
            this.pictureBox_State3.Name = "pictureBox_State3";
            this.pictureBox_State3.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_State3.TabIndex = 1;
            this.pictureBox_State3.TabStop = false;
            // 
            // tableLayoutPanel_State2
            // 
            this.tableLayoutPanel_State2.ColumnCount = 1;
            this.tableLayoutPanel_State2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_State2.Controls.Add(this.label_State2, 0, 0);
            this.tableLayoutPanel_State2.Controls.Add(this.pictureBox_State2, 0, 1);
            this.tableLayoutPanel_State2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_State2.Location = new System.Drawing.Point(383, 4);
            this.tableLayoutPanel_State2.Name = "tableLayoutPanel_State2";
            this.tableLayoutPanel_State2.RowCount = 2;
            this.tableLayoutPanel_State2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.94495F));
            this.tableLayoutPanel_State2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.05505F));
            this.tableLayoutPanel_State2.Size = new System.Drawing.Size(115, 121);
            this.tableLayoutPanel_State2.TabIndex = 15;
            // 
            // label_State2
            // 
            this.label_State2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_State2.AutoSize = true;
            this.label_State2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_State2.Location = new System.Drawing.Point(13, 4);
            this.label_State2.Name = "label_State2";
            this.label_State2.Size = new System.Drawing.Size(89, 32);
            this.label_State2.TabIndex = 0;
            this.label_State2.Text = "Переменная облачность";
            this.label_State2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_State2
            // 
            this.pictureBox_State2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_State2.Image = global::RandomProcessesWeatherSimulation.Properties.Resources.state2;
            this.pictureBox_State2.Location = new System.Drawing.Point(25, 49);
            this.pictureBox_State2.Name = "pictureBox_State2";
            this.pictureBox_State2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_State2.TabIndex = 1;
            this.pictureBox_State2.TabStop = false;
            // 
            // tableLayoutPanel_State1
            // 
            this.tableLayoutPanel_State1.ColumnCount = 1;
            this.tableLayoutPanel_State1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_State1.Controls.Add(this.label_State1, 0, 0);
            this.tableLayoutPanel_State1.Controls.Add(this.pictureBox_State1, 0, 1);
            this.tableLayoutPanel_State1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_State1.Location = new System.Drawing.Point(261, 4);
            this.tableLayoutPanel_State1.Name = "tableLayoutPanel_State1";
            this.tableLayoutPanel_State1.RowCount = 2;
            this.tableLayoutPanel_State1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.94495F));
            this.tableLayoutPanel_State1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.05505F));
            this.tableLayoutPanel_State1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_State1.Size = new System.Drawing.Size(115, 121);
            this.tableLayoutPanel_State1.TabIndex = 14;
            // 
            // label_State1
            // 
            this.label_State1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_State1.AutoSize = true;
            this.label_State1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_State1.Location = new System.Drawing.Point(8, 12);
            this.label_State1.Name = "label_State1";
            this.label_State1.Size = new System.Drawing.Size(98, 16);
            this.label_State1.TabIndex = 0;
            this.label_State1.Text = "Малооблачно";
            this.label_State1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_State1
            // 
            this.pictureBox_State1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_State1.Image = global::RandomProcessesWeatherSimulation.Properties.Resources.state1;
            this.pictureBox_State1.Location = new System.Drawing.Point(25, 49);
            this.pictureBox_State1.Name = "pictureBox_State1";
            this.pictureBox_State1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_State1.TabIndex = 1;
            this.pictureBox_State1.TabStop = false;
            // 
            // label_StatisticState
            // 
            this.label_StatisticState.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_StatisticState.AutoSize = true;
            this.label_StatisticState.Location = new System.Drawing.Point(22, 54);
            this.label_StatisticState.Name = "label_StatisticState";
            this.label_StatisticState.Size = new System.Drawing.Size(91, 20);
            this.label_StatisticState.TabIndex = 1;
            this.label_StatisticState.Text = "Состояние";
            // 
            // label_StatisticStationaryDistribution
            // 
            this.label_StatisticStationaryDistribution.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_StatisticStationaryDistribution.AutoSize = true;
            this.label_StatisticStationaryDistribution.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_StatisticStationaryDistribution.Location = new System.Drawing.Point(4, 151);
            this.label_StatisticStationaryDistribution.Name = "label_StatisticStationaryDistribution";
            this.label_StatisticStationaryDistribution.Size = new System.Drawing.Size(128, 40);
            this.label_StatisticStationaryDistribution.TabIndex = 2;
            this.label_StatisticStationaryDistribution.Text = "Стационарное распределение";
            this.label_StatisticStationaryDistribution.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Prob0
            // 
            this.label_Prob0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Prob0.AutoSize = true;
            this.label_Prob0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Prob0.Location = new System.Drawing.Point(196, 163);
            this.label_Prob0.Name = "label_Prob0";
            this.label_Prob0.Size = new System.Drawing.Size(0, 16);
            this.label_Prob0.TabIndex = 3;
            this.label_Prob0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Prob1
            // 
            this.label_Prob1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Prob1.AutoSize = true;
            this.label_Prob1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Prob1.Location = new System.Drawing.Point(318, 163);
            this.label_Prob1.Name = "label_Prob1";
            this.label_Prob1.Size = new System.Drawing.Size(0, 16);
            this.label_Prob1.TabIndex = 4;
            this.label_Prob1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Prob2
            // 
            this.label_Prob2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Prob2.AutoSize = true;
            this.label_Prob2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Prob2.Location = new System.Drawing.Point(440, 163);
            this.label_Prob2.Name = "label_Prob2";
            this.label_Prob2.Size = new System.Drawing.Size(0, 16);
            this.label_Prob2.TabIndex = 5;
            this.label_Prob2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Prob3
            // 
            this.label_Prob3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Prob3.AutoSize = true;
            this.label_Prob3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Prob3.Location = new System.Drawing.Point(562, 163);
            this.label_Prob3.Name = "label_Prob3";
            this.label_Prob3.Size = new System.Drawing.Size(0, 16);
            this.label_Prob3.TabIndex = 6;
            this.label_Prob3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Prob4
            // 
            this.label_Prob4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Prob4.AutoSize = true;
            this.label_Prob4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Prob4.Location = new System.Drawing.Point(684, 163);
            this.label_Prob4.Name = "label_Prob4";
            this.label_Prob4.Size = new System.Drawing.Size(0, 16);
            this.label_Prob4.TabIndex = 7;
            this.label_Prob4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Prob5
            // 
            this.label_Prob5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Prob5.AutoSize = true;
            this.label_Prob5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Prob5.Location = new System.Drawing.Point(806, 163);
            this.label_Prob5.Name = "label_Prob5";
            this.label_Prob5.Size = new System.Drawing.Size(0, 16);
            this.label_Prob5.TabIndex = 8;
            this.label_Prob5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Prob6
            // 
            this.label_Prob6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Prob6.AutoSize = true;
            this.label_Prob6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Prob6.Location = new System.Drawing.Point(928, 163);
            this.label_Prob6.Name = "label_Prob6";
            this.label_Prob6.Size = new System.Drawing.Size(0, 16);
            this.label_Prob6.TabIndex = 9;
            this.label_Prob6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Prob7
            // 
            this.label_Prob7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Prob7.AutoSize = true;
            this.label_Prob7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Prob7.Location = new System.Drawing.Point(1050, 163);
            this.label_Prob7.Name = "label_Prob7";
            this.label_Prob7.Size = new System.Drawing.Size(0, 16);
            this.label_Prob7.TabIndex = 10;
            this.label_Prob7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Prob8
            // 
            this.label_Prob8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Prob8.AutoSize = true;
            this.label_Prob8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Prob8.Location = new System.Drawing.Point(1172, 163);
            this.label_Prob8.Name = "label_Prob8";
            this.label_Prob8.Size = new System.Drawing.Size(0, 16);
            this.label_Prob8.TabIndex = 11;
            this.label_Prob8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Prob9
            // 
            this.label_Prob9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Prob9.AutoSize = true;
            this.label_Prob9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Prob9.Location = new System.Drawing.Point(1295, 163);
            this.label_Prob9.Name = "label_Prob9";
            this.label_Prob9.Size = new System.Drawing.Size(0, 16);
            this.label_Prob9.TabIndex = 12;
            this.label_Prob9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel_State0
            // 
            this.tableLayoutPanel_State0.ColumnCount = 1;
            this.tableLayoutPanel_State0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_State0.Controls.Add(this.label_State0, 0, 0);
            this.tableLayoutPanel_State0.Controls.Add(this.pictureBox_State0, 0, 1);
            this.tableLayoutPanel_State0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_State0.Location = new System.Drawing.Point(139, 4);
            this.tableLayoutPanel_State0.Name = "tableLayoutPanel_State0";
            this.tableLayoutPanel_State0.RowCount = 2;
            this.tableLayoutPanel_State0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.94495F));
            this.tableLayoutPanel_State0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.05505F));
            this.tableLayoutPanel_State0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_State0.Size = new System.Drawing.Size(115, 121);
            this.tableLayoutPanel_State0.TabIndex = 13;
            // 
            // label_State0
            // 
            this.label_State0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_State0.AutoSize = true;
            this.label_State0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_State0.Location = new System.Drawing.Point(21, 12);
            this.label_State0.Name = "label_State0";
            this.label_State0.Size = new System.Drawing.Size(72, 16);
            this.label_State0.TabIndex = 0;
            this.label_State0.Text = "Солнечно";
            this.label_State0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_State0
            // 
            this.pictureBox_State0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_State0.Image = global::RandomProcessesWeatherSimulation.Properties.Resources.state0;
            this.pictureBox_State0.Location = new System.Drawing.Point(25, 49);
            this.pictureBox_State0.Name = "pictureBox_State0";
            this.pictureBox_State0.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_State0.TabIndex = 1;
            this.pictureBox_State0.TabStop = false;
            // 
            // textBox_OtherInfo
            // 
            this.textBox_OtherInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_OtherInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_OtherInfo.Location = new System.Drawing.Point(4, 226);
            this.textBox_OtherInfo.Multiline = true;
            this.textBox_OtherInfo.Name = "textBox_OtherInfo";
            this.textBox_OtherInfo.ReadOnly = true;
            this.textBox_OtherInfo.Size = new System.Drawing.Size(1357, 237);
            this.textBox_OtherInfo.TabIndex = 1;
            // 
            // tabPage_Chart
            // 
            this.tabPage_Chart.Controls.Add(this.chart_StateTransitions);
            this.tabPage_Chart.Location = new System.Drawing.Point(4, 29);
            this.tabPage_Chart.Name = "tabPage_Chart";
            this.tabPage_Chart.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Chart.Size = new System.Drawing.Size(1371, 473);
            this.tabPage_Chart.TabIndex = 2;
            this.tabPage_Chart.Text = "График";
            this.tabPage_Chart.UseVisualStyleBackColor = true;
            // 
            // chart_StateTransitions
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_StateTransitions.ChartAreas.Add(chartArea1);
            this.chart_StateTransitions.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart_StateTransitions.Legends.Add(legend1);
            this.chart_StateTransitions.Location = new System.Drawing.Point(3, 3);
            this.chart_StateTransitions.Name = "chart_StateTransitions";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_StateTransitions.Series.Add(series1);
            this.chart_StateTransitions.Size = new System.Drawing.Size(1365, 467);
            this.chart_StateTransitions.TabIndex = 0;
            this.chart_StateTransitions.Text = "chart1";
            this.chart_StateTransitions.Visible = false;
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem});
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Size = new System.Drawing.Size(1385, 28);
            this.menuStrip_Main.TabIndex = 1;
            this.menuStrip_Main.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.toolStripSeparator,
            this.SaveToolStripMenuItem,
            this.ChartSaveToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.FileToolStripMenuItem.Text = "&Файл";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("OpenToolStripMenuItem.Image")));
            this.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
            this.OpenToolStripMenuItem.Text = "&Открыть";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(226, 6);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("SaveToolStripMenuItem.Image")));
            this.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
            this.SaveToolStripMenuItem.Text = "&Сохранить";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // ChartSaveToolStripMenuItem
            // 
            this.ChartSaveToolStripMenuItem.Enabled = false;
            this.ChartSaveToolStripMenuItem.Name = "ChartSaveToolStripMenuItem";
            this.ChartSaveToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
            this.ChartSaveToolStripMenuItem.Text = "&Сохранить график";
            this.ChartSaveToolStripMenuItem.Click += new System.EventHandler(this.ChartSaveToolStripMenuItem_Click);
            // 
            // timer_forVisualization
            // 
            this.timer_forVisualization.Interval = 500;
            this.timer_forVisualization.Tick += new System.EventHandler(this.timer_forVisualization_Tick);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 692);
            this.Controls.Add(this.tableLayoutPanel_Main);
            this.Controls.Add(this.menuStrip_Main);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip_Main;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RandomProcessesWeatherSimulation";
            this.tableLayoutPanel_Main.ResumeLayout(false);
            this.panel_ControlPanel.ResumeLayout(false);
            this.tableLayoutPanel_ControlPanel.ResumeLayout(false);
            this.tableLayoutPanel_ParametersAndButtons.ResumeLayout(false);
            this.tableLayoutPanel_ParametersAndButtons.PerformLayout();
            this.tableLayoutPanel_Parameters.ResumeLayout(false);
            this.tableLayoutPanel_Parameters.PerformLayout();
            this.tableLayoutPanel_CheckBoxes.ResumeLayout(false);
            this.tableLayoutPanel_CheckBoxes.PerformLayout();
            this.tabControl_Results.ResumeLayout(false);
            this.tabPage_Visualization.ResumeLayout(false);
            this.tableLayoutPanel_Visualization.ResumeLayout(false);
            this.tableLayoutPanel_Visualization.PerformLayout();
            this.tableLayoutPanel_forWeatherSimulation.ResumeLayout(false);
            this.tableLayoutPanel_forWeatherSimulation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Weather)).EndInit();
            this.tabPage_Statistic.ResumeLayout(false);
            this.tableLayoutPanel_Statistic.ResumeLayout(false);
            this.tableLayoutPanel_Statistic.PerformLayout();
            this.tableLayoutPanel_forStationaryProbDist.ResumeLayout(false);
            this.tableLayoutPanel_forStationaryProbDist.PerformLayout();
            this.tableLayoutPanel_State9.ResumeLayout(false);
            this.tableLayoutPanel_State9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_State9)).EndInit();
            this.tableLayoutPanel_State8.ResumeLayout(false);
            this.tableLayoutPanel_State8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_State8)).EndInit();
            this.tableLayoutPanel_State7.ResumeLayout(false);
            this.tableLayoutPanel_State7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_State7)).EndInit();
            this.tableLayoutPanel_State6.ResumeLayout(false);
            this.tableLayoutPanel_State6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_State6)).EndInit();
            this.tableLayoutPanel_State5.ResumeLayout(false);
            this.tableLayoutPanel_State5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_State5)).EndInit();
            this.tableLayoutPanel_State4.ResumeLayout(false);
            this.tableLayoutPanel_State4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_State4)).EndInit();
            this.tableLayoutPanel_State3.ResumeLayout(false);
            this.tableLayoutPanel_State3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_State3)).EndInit();
            this.tableLayoutPanel_State2.ResumeLayout(false);
            this.tableLayoutPanel_State2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_State2)).EndInit();
            this.tableLayoutPanel_State1.ResumeLayout(false);
            this.tableLayoutPanel_State1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_State1)).EndInit();
            this.tableLayoutPanel_State0.ResumeLayout(false);
            this.tableLayoutPanel_State0.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_State0)).EndInit();
            this.tabPage_Chart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_StateTransitions)).EndInit();
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Main;
        private System.Windows.Forms.Panel panel_ControlPanel;
        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_ControlPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_ParametersAndButtons;
        private System.Windows.Forms.Button button_StartSimulation;
        private System.Windows.Forms.ComboBox comboBox_TypeOfSimulation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Parameters;
        private System.Windows.Forms.Label label_Parameter;
        private System.Windows.Forms.TextBox textBox_Parameter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_CheckBoxes;
        private System.Windows.Forms.CheckBox checkBox_Visualization;
        private System.Windows.Forms.CheckBox checkBox_Statistic;
        private System.Windows.Forms.CheckBox checkBox_Chart;
        private System.Windows.Forms.TabControl tabControl_Results;
        private System.Windows.Forms.TabPage tabPage_Visualization;
        private System.Windows.Forms.TabPage tabPage_Statistic;
        private System.Windows.Forms.TabPage tabPage_Chart;
        private System.Windows.Forms.Timer timer_forVisualization;
        private System.Windows.Forms.Label label_Day;
        private System.Windows.Forms.Label label_Weather;
        private System.Windows.Forms.PictureBox pictureBox_Weather;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_forStationaryProbDist;
        private System.Windows.Forms.Label label_StatisticState;
        private System.Windows.Forms.Label label_StatisticStationaryDistribution;
        private System.Windows.Forms.Label label_Prob0;
        private System.Windows.Forms.Label label_Prob1;
        private System.Windows.Forms.Label label_Prob2;
        private System.Windows.Forms.Label label_Prob3;
        private System.Windows.Forms.Label label_Prob4;
        private System.Windows.Forms.Label label_Prob5;
        private System.Windows.Forms.Label label_Prob6;
        private System.Windows.Forms.Label label_Prob7;
        private System.Windows.Forms.Label label_Prob8;
        private System.Windows.Forms.Label label_Prob9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_State0;
        private System.Windows.Forms.Label label_State0;
        private System.Windows.Forms.PictureBox pictureBox_State0;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_State9;
        private System.Windows.Forms.Label label_State9;
        private System.Windows.Forms.PictureBox pictureBox_State9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_State8;
        private System.Windows.Forms.Label label_State8;
        private System.Windows.Forms.PictureBox pictureBox_State8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_State7;
        private System.Windows.Forms.Label label_State7;
        private System.Windows.Forms.PictureBox pictureBox_State7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_State6;
        private System.Windows.Forms.Label label_State6;
        private System.Windows.Forms.PictureBox pictureBox_State6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_State5;
        private System.Windows.Forms.Label label_State5;
        private System.Windows.Forms.PictureBox pictureBox_State5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_State4;
        private System.Windows.Forms.Label label_State4;
        private System.Windows.Forms.PictureBox pictureBox_State4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_State3;
        private System.Windows.Forms.Label label_State3;
        private System.Windows.Forms.PictureBox pictureBox_State3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_State2;
        private System.Windows.Forms.Label label_State2;
        private System.Windows.Forms.PictureBox pictureBox_State2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_State1;
        private System.Windows.Forms.Label label_State1;
        private System.Windows.Forms.PictureBox pictureBox_State1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Visualization;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_forWeatherSimulation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Statistic;
        private System.Windows.Forms.TextBox textBox_OtherInfo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_StateTransitions;
        private System.Windows.Forms.ToolStripMenuItem ChartSaveToolStripMenuItem;
    }
}


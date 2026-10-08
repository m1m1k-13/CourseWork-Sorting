namespace Coursework_Anikin_24VP2
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Results = new System.Windows.Forms.GroupBox();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Table = new System.Windows.Forms.DataGridView();
            this.ControlPanel = new System.Windows.Forms.GroupBox();
            this.PanelBtn = new System.Windows.Forms.Panel();
            this.SortBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.PercentUpDown = new System.Windows.Forms.NumericUpDown();
            this.Label3 = new System.Windows.Forms.Label();
            this.RadioBtn4 = new System.Windows.Forms.RadioButton();
            this.RadioBtn3 = new System.Windows.Forms.RadioButton();
            this.RadioBtn2 = new System.Windows.Forms.RadioButton();
            this.RadioBtn1 = new System.Windows.Forms.RadioButton();
            this.Label2 = new System.Windows.Forms.Label();
            this.SizeUpDown = new System.Windows.Forms.NumericUpDown();
            this.Label1 = new System.Windows.Forms.Label();
            this.SortType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size50 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size60 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size70 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size80 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size90 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size100 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Results.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.ControlPanel.SuspendLayout();
            this.PanelBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PercentUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Results
            // 
            this.Results.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Results.BackColor = System.Drawing.Color.Transparent;
            this.Results.Controls.Add(this.Chart);
            this.Results.Controls.Add(this.Table);
            this.Results.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.Results.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(166)))));
            this.Results.Location = new System.Drawing.Point(420, 5);
            this.Results.Margin = new System.Windows.Forms.Padding(0);
            this.Results.Name = "Results";
            this.Results.Padding = new System.Windows.Forms.Padding(0);
            this.Results.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Results.Size = new System.Drawing.Size(1202, 734);
            this.Results.TabIndex = 1;
            this.Results.TabStop = false;
            this.Results.Text = "Результаты работы программы";
            // 
            // Chart
            // 
            this.Chart.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(166)))));
            chartArea1.AxisX.LineWidth = 2;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.Title = "Размерность массива";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(166)))));
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(166)))));
            chartArea1.AxisY.LineWidth = 2;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.Title = "Время сортировки, мс";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(166)))));
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            chartArea1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(166)))));
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea";
            this.Chart.ChartAreas.Add(chartArea1);
            this.Chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.9F, System.Drawing.FontStyle.Bold);
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend";
            legend1.Title = "Вид сортировки";
            legend1.TitleFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            legend1.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(166)))));
            this.Chart.Legends.Add(legend1);
            this.Chart.Location = new System.Drawing.Point(0, 29);
            this.Chart.Margin = new System.Windows.Forms.Padding(0);
            this.Chart.Name = "Chart";
            this.Chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend";
            series1.Name = "Сортировка прямым выбором";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend";
            series2.Name = "Сортировка прямым выбором с одновременным поиском максимума и минимума";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend";
            series3.Name = "Сортировка прямым включением с минимальным барьером";
            this.Chart.Series.Add(series1);
            this.Chart.Series.Add(series2);
            this.Chart.Series.Add(series3);
            this.Chart.Size = new System.Drawing.Size(1202, 505);
            this.Chart.TabIndex = 1;
            this.Chart.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
            // 
            // Table
            // 
            this.Table.AllowUserToAddRows = false;
            this.Table.AllowUserToDeleteRows = false;
            this.Table.AllowUserToResizeColumns = false;
            this.Table.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.Table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Table.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Table.ColumnHeadersHeight = 50;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SortType,
            this.Size10,
            this.Size20,
            this.Size30,
            this.Size40,
            this.Size50,
            this.Size60,
            this.Size70,
            this.Size80,
            this.Size90,
            this.Size100});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Table.DefaultCellStyle = dataGridViewCellStyle4;
            this.Table.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Table.EnableHeadersVisualStyles = false;
            this.Table.GridColor = System.Drawing.Color.White;
            this.Table.Location = new System.Drawing.Point(0, 534);
            this.Table.Margin = new System.Windows.Forms.Padding(0);
            this.Table.Name = "Table";
            this.Table.ReadOnly = true;
            this.Table.RowHeadersVisible = false;
            this.Table.RowHeadersWidth = 50;
            this.Table.RowTemplate.Height = 50;
            this.Table.RowTemplate.ReadOnly = true;
            this.Table.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Table.ShowCellErrors = false;
            this.Table.ShowCellToolTips = false;
            this.Table.ShowEditingIcon = false;
            this.Table.ShowRowErrors = false;
            this.Table.Size = new System.Drawing.Size(1202, 200);
            this.Table.TabIndex = 0;
            // 
            // ControlPanel
            // 
            this.ControlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ControlPanel.BackColor = System.Drawing.Color.Transparent;
            this.ControlPanel.Controls.Add(this.PanelBtn);
            this.ControlPanel.Controls.Add(this.Label4);
            this.ControlPanel.Controls.Add(this.TextBox);
            this.ControlPanel.Controls.Add(this.PercentUpDown);
            this.ControlPanel.Controls.Add(this.Label3);
            this.ControlPanel.Controls.Add(this.RadioBtn4);
            this.ControlPanel.Controls.Add(this.RadioBtn3);
            this.ControlPanel.Controls.Add(this.RadioBtn2);
            this.ControlPanel.Controls.Add(this.RadioBtn1);
            this.ControlPanel.Controls.Add(this.Label2);
            this.ControlPanel.Controls.Add(this.SizeUpDown);
            this.ControlPanel.Controls.Add(this.Label1);
            this.ControlPanel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.ControlPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(166)))));
            this.ControlPanel.Location = new System.Drawing.Point(10, 5);
            this.ControlPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ControlPanel.Size = new System.Drawing.Size(400, 735);
            this.ControlPanel.TabIndex = 12;
            this.ControlPanel.TabStop = false;
            this.ControlPanel.Text = "Панель управления";
            // 
            // PanelBtn
            // 
            this.PanelBtn.Controls.Add(this.SortBtn);
            this.PanelBtn.Controls.Add(this.ExitBtn);
            this.PanelBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBtn.Location = new System.Drawing.Point(3, 631);
            this.PanelBtn.Name = "PanelBtn";
            this.PanelBtn.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.PanelBtn.Size = new System.Drawing.Size(394, 100);
            this.PanelBtn.TabIndex = 25;
            // 
            // SortBtn
            // 
            this.SortBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(166)))));
            this.SortBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.SortBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.SortBtn.ForeColor = System.Drawing.Color.White;
            this.SortBtn.Location = new System.Drawing.Point(15, 10);
            this.SortBtn.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.SortBtn.Name = "SortBtn";
            this.SortBtn.Size = new System.Drawing.Size(200, 80);
            this.SortBtn.TabIndex = 21;
            this.SortBtn.Text = "Сортировать";
            this.SortBtn.UseVisualStyleBackColor = false;
            this.SortBtn.Click += new System.EventHandler(this.Sort);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(166)))));
            this.ExitBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.ExitBtn.ForeColor = System.Drawing.Color.Black;
            this.ExitBtn.Location = new System.Drawing.Point(229, 10);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(150, 80);
            this.ExitBtn.TabIndex = 22;
            this.ExitBtn.Text = "Выход";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.Exit);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(166)))));
            this.Label4.Location = new System.Drawing.Point(10, 426);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(232, 25);
            this.Label4.TabIndex = 24;
            this.Label4.Text = "Состояние программы:";
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.Color.White;
            this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox.ForeColor = System.Drawing.Color.Black;
            this.TextBox.Location = new System.Drawing.Point(15, 455);
            this.TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox.Name = "TextBox";
            this.TextBox.ReadOnly = true;
            this.TextBox.Size = new System.Drawing.Size(300, 100);
            this.TextBox.TabIndex = 23;
            this.TextBox.Text = "Ожидание пользователя...";
            // 
            // PercentUpDown
            // 
            this.PercentUpDown.AutoSize = true;
            this.PercentUpDown.Enabled = false;
            this.PercentUpDown.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.PercentUpDown.Location = new System.Drawing.Point(15, 364);
            this.PercentUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PercentUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.PercentUpDown.MinimumSize = new System.Drawing.Size(100, 0);
            this.PercentUpDown.Name = "PercentUpDown";
            this.PercentUpDown.Size = new System.Drawing.Size(100, 31);
            this.PercentUpDown.TabIndex = 20;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(166)))));
            this.Label3.Location = new System.Drawing.Point(10, 335);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(272, 25);
            this.Label3.TabIndex = 19;
            this.Label3.Text = "Процент упорядоченности:";
            // 
            // RadioBtn4
            // 
            this.RadioBtn4.AutoSize = true;
            this.RadioBtn4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RadioBtn4.ForeColor = System.Drawing.Color.White;
            this.RadioBtn4.Location = new System.Drawing.Point(15, 273);
            this.RadioBtn4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RadioBtn4.Name = "RadioBtn4";
            this.RadioBtn4.Size = new System.Drawing.Size(258, 29);
            this.RadioBtn4.TabIndex = 18;
            this.RadioBtn4.Text = "Частично упорядоченный";
            this.RadioBtn4.UseVisualStyleBackColor = true;
            this.RadioBtn4.CheckedChanged += new System.EventHandler(this.PartOrderChecked);
            // 
            // RadioBtn3
            // 
            this.RadioBtn3.AutoSize = true;
            this.RadioBtn3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RadioBtn3.ForeColor = System.Drawing.Color.White;
            this.RadioBtn3.Location = new System.Drawing.Point(15, 237);
            this.RadioBtn3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RadioBtn3.Name = "RadioBtn3";
            this.RadioBtn3.Size = new System.Drawing.Size(356, 29);
            this.RadioBtn3.TabIndex = 17;
            this.RadioBtn3.Text = "Упорядоченный в обратном порядке";
            this.RadioBtn3.UseVisualStyleBackColor = true;
            this.RadioBtn3.CheckedChanged += new System.EventHandler(this.PartOrderChecked);
            // 
            // RadioBtn2
            // 
            this.RadioBtn2.AutoSize = true;
            this.RadioBtn2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RadioBtn2.ForeColor = System.Drawing.Color.White;
            this.RadioBtn2.Location = new System.Drawing.Point(15, 202);
            this.RadioBtn2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RadioBtn2.Name = "RadioBtn2";
            this.RadioBtn2.Size = new System.Drawing.Size(174, 29);
            this.RadioBtn2.TabIndex = 16;
            this.RadioBtn2.Text = "Упорядоченный";
            this.RadioBtn2.UseVisualStyleBackColor = true;
            this.RadioBtn2.CheckedChanged += new System.EventHandler(this.PartOrderChecked);
            // 
            // RadioBtn1
            // 
            this.RadioBtn1.AutoSize = true;
            this.RadioBtn1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RadioBtn1.ForeColor = System.Drawing.Color.White;
            this.RadioBtn1.Location = new System.Drawing.Point(15, 168);
            this.RadioBtn1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RadioBtn1.Name = "RadioBtn1";
            this.RadioBtn1.Size = new System.Drawing.Size(196, 29);
            this.RadioBtn1.TabIndex = 15;
            this.RadioBtn1.Text = "Неупорядоченный";
            this.RadioBtn1.UseVisualStyleBackColor = true;
            this.RadioBtn1.CheckedChanged += new System.EventHandler(this.PartOrderChecked);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(166)))));
            this.Label2.Location = new System.Drawing.Point(10, 138);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(224, 25);
            this.Label2.TabIndex = 14;
            this.Label2.Text = "Тип упорядоченности:";
            // 
            // SizeUpDown
            // 
            this.SizeUpDown.AutoSize = true;
            this.SizeUpDown.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.SizeUpDown.Location = new System.Drawing.Point(15, 79);
            this.SizeUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SizeUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.SizeUpDown.MinimumSize = new System.Drawing.Size(100, 0);
            this.SizeUpDown.Name = "SizeUpDown";
            this.SizeUpDown.Size = new System.Drawing.Size(132, 31);
            this.SizeUpDown.TabIndex = 13;
            this.SizeUpDown.ThousandsSeparator = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(166)))));
            this.Label1.Location = new System.Drawing.Point(10, 50);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(219, 25);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "Размерность массива:";
            // 
            // SortType
            // 
            this.SortType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.SortType.DefaultCellStyle = dataGridViewCellStyle3;
            this.SortType.HeaderText = "Тип сортировки";
            this.SortType.MinimumWidth = 350;
            this.SortType.Name = "SortType";
            this.SortType.ReadOnly = true;
            this.SortType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Size10
            // 
            this.Size10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Size10.HeaderText = "10%";
            this.Size10.MinimumWidth = 85;
            this.Size10.Name = "Size10";
            this.Size10.ReadOnly = true;
            this.Size10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Size20
            // 
            this.Size20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Size20.HeaderText = "20%";
            this.Size20.MinimumWidth = 85;
            this.Size20.Name = "Size20";
            this.Size20.ReadOnly = true;
            this.Size20.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Size30
            // 
            this.Size30.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Size30.HeaderText = "30%";
            this.Size30.MinimumWidth = 85;
            this.Size30.Name = "Size30";
            this.Size30.ReadOnly = true;
            this.Size30.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Size40
            // 
            this.Size40.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Size40.HeaderText = "40%";
            this.Size40.MinimumWidth = 85;
            this.Size40.Name = "Size40";
            this.Size40.ReadOnly = true;
            this.Size40.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Size50
            // 
            this.Size50.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Size50.HeaderText = "50%";
            this.Size50.MinimumWidth = 85;
            this.Size50.Name = "Size50";
            this.Size50.ReadOnly = true;
            this.Size50.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Size60
            // 
            this.Size60.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Size60.HeaderText = "60%";
            this.Size60.MinimumWidth = 85;
            this.Size60.Name = "Size60";
            this.Size60.ReadOnly = true;
            this.Size60.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Size70
            // 
            this.Size70.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Size70.HeaderText = "70%";
            this.Size70.MinimumWidth = 85;
            this.Size70.Name = "Size70";
            this.Size70.ReadOnly = true;
            this.Size70.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Size80
            // 
            this.Size80.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Size80.HeaderText = "80%";
            this.Size80.MinimumWidth = 85;
            this.Size80.Name = "Size80";
            this.Size80.ReadOnly = true;
            this.Size80.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Size90
            // 
            this.Size90.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Size90.HeaderText = "90%";
            this.Size90.MinimumWidth = 85;
            this.Size90.Name = "Size90";
            this.Size90.ReadOnly = true;
            this.Size90.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Size100
            // 
            this.Size100.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Size100.HeaderText = "100%";
            this.Size100.MinimumWidth = 85;
            this.Size100.Name = "Size100";
            this.Size100.ReadOnly = true;
            this.Size100.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1639, 753);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.Results);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1657, 800);
            this.Name = "MainForm";
            this.Text = "Курсовая работа Аникин 24ВП2";
            this.Load += new System.EventHandler(this.FormLoad);
            this.Results.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            this.PanelBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PercentUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox ControlPanel;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.NumericUpDown SizeUpDown;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.RadioButton RadioBtn1;
        private System.Windows.Forms.RadioButton RadioBtn2;
        private System.Windows.Forms.RadioButton RadioBtn3;
        private System.Windows.Forms.RadioButton RadioBtn4;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.NumericUpDown PercentUpDown;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.RichTextBox TextBox;
        private System.Windows.Forms.Panel PanelBtn;
        private System.Windows.Forms.Button SortBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.GroupBox Results;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn SortType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size30;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size40;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size50;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size60;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size70;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size80;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size90;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size100;
    }
}

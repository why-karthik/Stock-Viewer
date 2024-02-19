namespace WindowsFormsApp_COP_4365
{
    partial class Form_Project_1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.openFileDialog_StockPicker = new System.Windows.Forms.OpenFileDialog();
            this.button_StockPicker = new System.Windows.Forms.Button();
            this.dataGridView_Candlestick = new System.Windows.Forms.DataGridView();
            this.chart_OHLCV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dateTimePicker_startDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_endDate = new System.Windows.Forms.DateTimePicker();
            this.button_Update = new System.Windows.Forms.Button();
            this.textBox_StartDate = new System.Windows.Forms.TextBox();
            this.textBox_EndDate = new System.Windows.Forms.TextBox();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.highDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candlestickBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Candlestick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_OHLCV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candlestickBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog_StockPicker
            // 
            this.openFileDialog_StockPicker.Filter = "All Files (*.*)|*.*|Monthly Files|*-Month.csv|Weekly Files|*-Week.csv|Daily Files" +
    "|*-Day.csv";
            this.openFileDialog_StockPicker.FilterIndex = 2;
            this.openFileDialog_StockPicker.InitialDirectory = "C:\\Users\\KarthikYechuri\\Desktop\\Stock Data";
            this.openFileDialog_StockPicker.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_StockPicker_FileOk);
            // 
            // button_StockPicker
            // 
            this.button_StockPicker.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button_StockPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_StockPicker.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_StockPicker.Location = new System.Drawing.Point(747, 18);
            this.button_StockPicker.Name = "button_StockPicker";
            this.button_StockPicker.Size = new System.Drawing.Size(159, 93);
            this.button_StockPicker.TabIndex = 0;
            this.button_StockPicker.Text = "Pick A Stock";
            this.button_StockPicker.UseVisualStyleBackColor = false;
            this.button_StockPicker.Click += new System.EventHandler(this.button_StockPicker_Click);
            // 
            // dataGridView_Candlestick
            // 
            this.dataGridView_Candlestick.AllowUserToOrderColumns = true;
            this.dataGridView_Candlestick.AutoGenerateColumns = false;
            this.dataGridView_Candlestick.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Candlestick.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.openDataGridViewTextBoxColumn,
            this.highDataGridViewTextBoxColumn,
            this.lowDataGridViewTextBoxColumn,
            this.closeDataGridViewTextBoxColumn,
            this.volumeDataGridViewTextBoxColumn});
            this.dataGridView_Candlestick.DataSource = this.candlestickBindingSource;
            this.dataGridView_Candlestick.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_Candlestick.Name = "dataGridView_Candlestick";
            this.dataGridView_Candlestick.ReadOnly = true;
            this.dataGridView_Candlestick.RowHeadersWidth = 51;
            this.dataGridView_Candlestick.Size = new System.Drawing.Size(643, 207);
            this.dataGridView_Candlestick.TabIndex = 1;
            this.dataGridView_Candlestick.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Candlestick_CellContentClick);
            // 
            // chart_OHLCV
            // 
            chartArea1.Name = "ChartArea_OHLC";
            chartArea2.AlignWithChartArea = "ChartArea_OHLC";
            chartArea2.Name = "ChartArea_Volume";
            this.chart_OHLCV.ChartAreas.Add(chartArea1);
            this.chart_OHLCV.ChartAreas.Add(chartArea2);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.LegendItemOrder = System.Windows.Forms.DataVisualization.Charting.LegendItemOrder.ReversedSeriesOrder;
            legend1.Name = "Legend_OHLCV";
            this.chart_OHLCV.Legends.Add(legend1);
            this.chart_OHLCV.Location = new System.Drawing.Point(12, 225);
            this.chart_OHLCV.Name = "chart_OHLCV";
            series1.ChartArea = "ChartArea_OHLC";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series1.CustomProperties = "PriceDownColor=Red, PriceUpColor=Lime";
            series1.Legend = "Legend_OHLCV";
            series1.Name = "Series_OHLC";
            series1.XValueMember = "Date";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series1.YValueMembers = "High,Low,Open,Close";
            series1.YValuesPerPoint = 4;
            series2.ChartArea = "ChartArea_Volume";
            series2.Legend = "Legend_OHLCV";
            series2.Name = "Series_Volume";
            series2.XValueMember = "Date";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series2.YValueMembers = "Volume";
            this.chart_OHLCV.Series.Add(series1);
            this.chart_OHLCV.Series.Add(series2);
            this.chart_OHLCV.Size = new System.Drawing.Size(643, 295);
            this.chart_OHLCV.TabIndex = 2;
            this.chart_OHLCV.Text = "chart1";
            // 
            // dateTimePicker_startDate
            // 
            this.dateTimePicker_startDate.Location = new System.Drawing.Point(799, 137);
            this.dateTimePicker_startDate.Name = "dateTimePicker_startDate";
            this.dateTimePicker_startDate.Size = new System.Drawing.Size(174, 23);
            this.dateTimePicker_startDate.TabIndex = 3;
            this.dateTimePicker_startDate.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_startDate.ValueChanged += new System.EventHandler(this.dateTimePicker_startDate_ValueChanged);
            // 
            // dateTimePicker_endDate
            // 
            this.dateTimePicker_endDate.Location = new System.Drawing.Point(799, 196);
            this.dateTimePicker_endDate.Name = "dateTimePicker_endDate";
            this.dateTimePicker_endDate.Size = new System.Drawing.Size(174, 23);
            this.dateTimePicker_endDate.TabIndex = 4;
            this.dateTimePicker_endDate.ValueChanged += new System.EventHandler(this.dateTimePicker_endDate_ValueChanged);
            // 
            // button_Update
            // 
            this.button_Update.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_Update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Update.Location = new System.Drawing.Point(700, 238);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(273, 55);
            this.button_Update.TabIndex = 5;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // textBox_StartDate
            // 
            this.textBox_StartDate.Location = new System.Drawing.Point(700, 137);
            this.textBox_StartDate.Name = "textBox_StartDate";
            this.textBox_StartDate.Size = new System.Drawing.Size(79, 23);
            this.textBox_StartDate.TabIndex = 6;
            this.textBox_StartDate.Text = "Start Date";
            // 
            // textBox_EndDate
            // 
            this.textBox_EndDate.Location = new System.Drawing.Point(700, 194);
            this.textBox_EndDate.Name = "textBox_EndDate";
            this.textBox_EndDate.Size = new System.Drawing.Size(79, 23);
            this.textBox_EndDate.TabIndex = 7;
            this.textBox_EndDate.Text = "End Date";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // openDataGridViewTextBoxColumn
            // 
            this.openDataGridViewTextBoxColumn.DataPropertyName = "open";
            this.openDataGridViewTextBoxColumn.HeaderText = "open";
            this.openDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.openDataGridViewTextBoxColumn.Name = "openDataGridViewTextBoxColumn";
            this.openDataGridViewTextBoxColumn.ReadOnly = true;
            this.openDataGridViewTextBoxColumn.Width = 125;
            // 
            // highDataGridViewTextBoxColumn
            // 
            this.highDataGridViewTextBoxColumn.DataPropertyName = "high";
            this.highDataGridViewTextBoxColumn.HeaderText = "high";
            this.highDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.highDataGridViewTextBoxColumn.Name = "highDataGridViewTextBoxColumn";
            this.highDataGridViewTextBoxColumn.ReadOnly = true;
            this.highDataGridViewTextBoxColumn.Width = 125;
            // 
            // lowDataGridViewTextBoxColumn
            // 
            this.lowDataGridViewTextBoxColumn.DataPropertyName = "low";
            this.lowDataGridViewTextBoxColumn.HeaderText = "low";
            this.lowDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lowDataGridViewTextBoxColumn.Name = "lowDataGridViewTextBoxColumn";
            this.lowDataGridViewTextBoxColumn.ReadOnly = true;
            this.lowDataGridViewTextBoxColumn.Width = 125;
            // 
            // closeDataGridViewTextBoxColumn
            // 
            this.closeDataGridViewTextBoxColumn.DataPropertyName = "close";
            this.closeDataGridViewTextBoxColumn.HeaderText = "close";
            this.closeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.closeDataGridViewTextBoxColumn.Name = "closeDataGridViewTextBoxColumn";
            this.closeDataGridViewTextBoxColumn.ReadOnly = true;
            this.closeDataGridViewTextBoxColumn.Width = 125;
            // 
            // volumeDataGridViewTextBoxColumn
            // 
            this.volumeDataGridViewTextBoxColumn.DataPropertyName = "volume";
            this.volumeDataGridViewTextBoxColumn.HeaderText = "volume";
            this.volumeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.volumeDataGridViewTextBoxColumn.Name = "volumeDataGridViewTextBoxColumn";
            this.volumeDataGridViewTextBoxColumn.ReadOnly = true;
            this.volumeDataGridViewTextBoxColumn.Width = 125;
            // 
            // candlestickBindingSource
            // 
            this.candlestickBindingSource.DataSource = typeof(WindowsFormsApp_COP_4365.Candlestick);
            // 
            // Form_Project_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 532);
            this.Controls.Add(this.textBox_EndDate);
            this.Controls.Add(this.textBox_StartDate);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.dateTimePicker_endDate);
            this.Controls.Add(this.dateTimePicker_startDate);
            this.Controls.Add(this.chart_OHLCV);
            this.Controls.Add(this.dataGridView_Candlestick);
            this.Controls.Add(this.button_StockPicker);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "Form_Project_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Stock Viewer";
            this.Load += new System.EventHandler(this.Form_Project_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Candlestick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_OHLCV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candlestickBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog_StockPicker;
        private System.Windows.Forms.Button button_StockPicker;
        private System.Windows.Forms.DataGridView dataGridView_Candlestick;
        private System.Windows.Forms.BindingSource candlestickBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn highDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn closeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_OHLCV;
        private System.Windows.Forms.DateTimePicker dateTimePicker_startDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_endDate;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.TextBox textBox_StartDate;
        private System.Windows.Forms.TextBox textBox_EndDate;
    }
}


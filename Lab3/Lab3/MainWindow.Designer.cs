namespace Lab3
{
  partial class MainWindow
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
      this.Graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
      this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.экспортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
      this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.AParam = new System.Windows.Forms.TextBox();
      this.LeftBorder = new System.Windows.Forms.TextBox();
      this.Step = new System.Windows.Forms.TextBox();
      this.A_par = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.label3 = new System.Windows.Forms.Label();
      this.RightBorder = new System.Windows.Forms.TextBox();
      this.Calc = new System.Windows.Forms.Button();
      this.Clear = new System.Windows.Forms.Button();
      this.DisplayPoints = new System.Windows.Forms.DataGridView();
      this.X_Values = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Y_Values = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.label4 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.Graph)).BeginInit();
      this.toolStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DisplayPoints)).BeginInit();
      this.SuspendLayout();
      // 
      // Graph
      // 
      chartArea1.Name = "ChartArea1";
      this.Graph.ChartAreas.Add(chartArea1);
      legend1.Name = "Legend1";
      this.Graph.Legends.Add(legend1);
      this.Graph.Location = new System.Drawing.Point(12, 38);
      this.Graph.Name = "Graph";
      series1.ChartArea = "ChartArea1";
      series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
      series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      series1.Legend = "Legend1";
      series1.LegendText = "Прямая строфоида";
      series1.Name = "Series1";
      series2.ChartArea = "ChartArea1";
      series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
      series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      series2.IsVisibleInLegend = false;
      series2.Legend = "Legend1";
      series2.Name = "Series2";
      this.Graph.Series.Add(series1);
      this.Graph.Series.Add(series2);
      this.Graph.Size = new System.Drawing.Size(683, 354);
      this.Graph.TabIndex = 0;
      this.Graph.Text = "Прямая строфоида";
      // 
      // toolStrip1
      // 
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2});
      this.toolStrip1.Location = new System.Drawing.Point(0, 0);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(707, 25);
      this.toolStrip1.TabIndex = 1;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // toolStripDropDownButton1
      // 
      this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.экспортToolStripMenuItem,
            this.выходToolStripMenuItem});
      this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
      this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
      this.toolStripDropDownButton1.Size = new System.Drawing.Size(49, 22);
      this.toolStripDropDownButton1.Text = "Файл";
      // 
      // открытьToolStripMenuItem
      // 
      this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
      this.открытьToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
      this.открытьToolStripMenuItem.Text = "Открыть";
      this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
      // 
      // сохранитьToolStripMenuItem
      // 
      this.сохранитьToolStripMenuItem.Enabled = false;
      this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
      this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
      this.сохранитьToolStripMenuItem.Text = "Сохранить начальные данные";
      this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
      // 
      // экспортToolStripMenuItem
      // 
      this.экспортToolStripMenuItem.Enabled = false;
      this.экспортToolStripMenuItem.Name = "экспортToolStripMenuItem";
      this.экспортToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
      this.экспортToolStripMenuItem.Text = "Экспорт результата";
      this.экспортToolStripMenuItem.Click += new System.EventHandler(this.экспортToolStripMenuItem_Click);
      // 
      // выходToolStripMenuItem
      // 
      this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
      this.выходToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
      this.выходToolStripMenuItem.Text = "Выход";
      this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
      // 
      // toolStripDropDownButton2
      // 
      this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
      this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
      this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
      this.toolStripDropDownButton2.Size = new System.Drawing.Size(66, 22);
      this.toolStripDropDownButton2.Text = "Справка";
      // 
      // оПрограммеToolStripMenuItem
      // 
      this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
      this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
      this.оПрограммеToolStripMenuItem.Text = "О программе";
      this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
      // 
      // AParam
      // 
      this.AParam.Location = new System.Drawing.Point(12, 445);
      this.AParam.Name = "AParam";
      this.AParam.Size = new System.Drawing.Size(100, 20);
      this.AParam.TabIndex = 2;
      // 
      // LeftBorder
      // 
      this.LeftBorder.Location = new System.Drawing.Point(149, 445);
      this.LeftBorder.Name = "LeftBorder";
      this.LeftBorder.Size = new System.Drawing.Size(100, 20);
      this.LeftBorder.TabIndex = 3;
      // 
      // Step
      // 
      this.Step.Location = new System.Drawing.Point(422, 445);
      this.Step.Name = "Step";
      this.Step.Size = new System.Drawing.Size(100, 20);
      this.Step.TabIndex = 4;
      // 
      // A_par
      // 
      this.A_par.AutoSize = true;
      this.A_par.Location = new System.Drawing.Point(9, 429);
      this.A_par.Name = "A_par";
      this.A_par.Size = new System.Drawing.Size(70, 13);
      this.A_par.TabIndex = 5;
      this.A_par.Text = "Параметр a ";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(146, 429);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(83, 13);
      this.label1.TabIndex = 6;
      this.label1.Text = "Левая граница";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(419, 429);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(35, 13);
      this.label2.TabIndex = 7;
      this.label2.Text = "Шаг x";
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(528, 71);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(97, 51);
      this.pictureBox1.TabIndex = 8;
      this.pictureBox1.TabStop = false;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(279, 429);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(89, 13);
      this.label3.TabIndex = 10;
      this.label3.Text = "Правая граница";
      // 
      // RightBorder
      // 
      this.RightBorder.Location = new System.Drawing.Point(282, 445);
      this.RightBorder.Name = "RightBorder";
      this.RightBorder.Size = new System.Drawing.Size(100, 20);
      this.RightBorder.TabIndex = 9;
      // 
      // Calc
      // 
      this.Calc.Location = new System.Drawing.Point(556, 444);
      this.Calc.Name = "Calc";
      this.Calc.Size = new System.Drawing.Size(97, 20);
      this.Calc.TabIndex = 11;
      this.Calc.Text = "Построить";
      this.Calc.UseVisualStyleBackColor = true;
      this.Calc.Click += new System.EventHandler(this.Calc_Click);
      // 
      // Clear
      // 
      this.Clear.Location = new System.Drawing.Point(556, 418);
      this.Clear.Name = "Clear";
      this.Clear.Size = new System.Drawing.Size(97, 20);
      this.Clear.TabIndex = 12;
      this.Clear.Text = "Очистить";
      this.Clear.UseVisualStyleBackColor = true;
      this.Clear.Click += new System.EventHandler(this.Clear_Click);
      // 
      // DisplayPoints
      // 
      this.DisplayPoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DisplayPoints.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X_Values,
            this.Y_Values});
      this.DisplayPoints.Location = new System.Drawing.Point(513, 150);
      this.DisplayPoints.Name = "DisplayPoints";
      this.DisplayPoints.Size = new System.Drawing.Size(182, 229);
      this.DisplayPoints.TabIndex = 13;
      // 
      // X_Values
      // 
      this.X_Values.HeaderText = "X";
      this.X_Values.Name = "X_Values";
      this.X_Values.Width = 70;
      // 
      // Y_Values
      // 
      this.Y_Values.HeaderText = "Y";
      this.Y_Values.Name = "Y_Values";
      this.Y_Values.Width = 70;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
      this.label4.Location = new System.Drawing.Point(631, 90);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(40, 13);
      this.label4.TabIndex = 14;
      this.label4.Text = "a >= |x|";
      // 
      // MainWindow
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(707, 477);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.DisplayPoints);
      this.Controls.Add(this.Clear);
      this.Controls.Add(this.Calc);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.RightBorder);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.A_par);
      this.Controls.Add(this.Step);
      this.Controls.Add(this.LeftBorder);
      this.Controls.Add(this.AParam);
      this.Controls.Add(this.toolStrip1);
      this.Controls.Add(this.Graph);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.Name = "MainWindow";
      this.Text = "Лабораторная работа №3, Левинский Илья";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.Graph)).EndInit();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DisplayPoints)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Graph;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экспортToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.TextBox AParam;
        private System.Windows.Forms.TextBox LeftBorder;
        private System.Windows.Forms.TextBox Step;
        private System.Windows.Forms.Label A_par;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RightBorder;
        private System.Windows.Forms.Button Calc;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.DataGridView DisplayPoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn X_Values;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y_Values;
        private System.Windows.Forms.Label label4;
    }
}


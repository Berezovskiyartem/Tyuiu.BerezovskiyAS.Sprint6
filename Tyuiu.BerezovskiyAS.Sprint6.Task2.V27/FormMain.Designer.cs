using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.BerezovskiyAS.Sprint6.Task2.V27
{
    partial class FormMain_YPV
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxTask_YPV = new GroupBox();
            labelTask2_YPV = new Label();
            pictureBox1 = new PictureBox();
            labelTask1_YPV = new Label();
            groupBoxRes_YPV = new GroupBox();
            chart_YPV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            DataGridView_YPV = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            FX = new DataGridViewTextBoxColumn();
            labelRes_YPV = new Label();
            groupBoxData_YPV = new GroupBox();
            textBoxStart_YPV = new TextBox();
            textBoxStop_YPV = new TextBox();
            labelStop_YPV = new Label();
            labelStart_YPV = new Label();
            buttonInfo_YPV = new Button();
            buttonDone_YPV = new Button();
            groupBoxTask_YPV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxRes_YPV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart_YPV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridView_YPV).BeginInit();
            groupBoxData_YPV.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_YPV
            // 
            groupBoxTask_YPV.Controls.Add(labelTask2_YPV);
            groupBoxTask_YPV.Controls.Add(pictureBox1);
            groupBoxTask_YPV.Controls.Add(labelTask1_YPV);
            groupBoxTask_YPV.Location = new Point(18, 14);
            groupBoxTask_YPV.Margin = new Padding(1, 1, 1, 1);
            groupBoxTask_YPV.Name = "groupBoxTask_YPV";
            groupBoxTask_YPV.Padding = new Padding(1, 1, 1, 1);
            groupBoxTask_YPV.Size = new Size(604, 195);
            groupBoxTask_YPV.TabIndex = 0;
            groupBoxTask_YPV.TabStop = false;
            groupBoxTask_YPV.Text = "Условие";
            // 
            // labelTask2_YPV
            // 
            labelTask2_YPV.AutoSize = true;
            labelTask2_YPV.Location = new Point(10, 97);
            labelTask2_YPV.Margin = new Padding(1, 0, 1, 0);
            labelTask2_YPV.Name = "labelTask2_YPV";
            labelTask2_YPV.Size = new Size(359, 15);
            labelTask2_YPV.TabIndex = 2;
            labelTask2_YPV.Text = "Результат вывести в DataGridView и построить график функции.";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(10, 49);
            pictureBox1.Margin = new Padding(1, 1, 1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(280, 32);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // labelTask1_YPV
            // 
            labelTask1_YPV.AutoSize = true;
            labelTask1_YPV.Location = new Point(10, 22);
            labelTask1_YPV.Margin = new Padding(1, 0, 1, 0);
            labelTask1_YPV.Name = "labelTask1_YPV";
            labelTask1_YPV.Size = new Size(295, 15);
            labelTask1_YPV.TabIndex = 0;
            labelTask1_YPV.Text = "Протабулировать функцию на заданном диапазоне.";
            // 
            // groupBoxRes_YPV
            // 
            groupBoxRes_YPV.Controls.Add(chart_YPV);
            groupBoxRes_YPV.Controls.Add(DataGridView_YPV);
            groupBoxRes_YPV.Controls.Add(labelRes_YPV);
            groupBoxRes_YPV.Location = new Point(638, 14);
            groupBoxRes_YPV.Margin = new Padding(1, 1, 1, 1);
            groupBoxRes_YPV.Name = "groupBoxRes_YPV";
            groupBoxRes_YPV.Padding = new Padding(1, 1, 1, 1);
            groupBoxRes_YPV.Size = new Size(475, 283);
            groupBoxRes_YPV.TabIndex = 1;
            groupBoxRes_YPV.TabStop = false;
            groupBoxRes_YPV.Text = "Вывод данных: ";
            // 
            // chart_YPV
            // 
            chartArea2.Name = "ChartArea1";
            chart_YPV.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart_YPV.Legends.Add(legend2);
            chart_YPV.Location = new Point(116, 38);
            chart_YPV.Margin = new Padding(1, 1, 1, 1);
            chart_YPV.Name = "chart_YPV";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart_YPV.Series.Add(series2);
            chart_YPV.Size = new Size(346, 237);
            chart_YPV.TabIndex = 2;
            chart_YPV.Text = "chart1";
            // 
            // DataGridView_YPV
            // 
            DataGridView_YPV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView_YPV.Columns.AddRange(new DataGridViewColumn[] { X, FX });
            DataGridView_YPV.Location = new Point(13, 38);
            DataGridView_YPV.Margin = new Padding(1, 1, 1, 1);
            DataGridView_YPV.Name = "DataGridView_YPV";
            DataGridView_YPV.RowHeadersVisible = false;
            DataGridView_YPV.RowHeadersWidth = 102;
            DataGridView_YPV.Size = new Size(100, 237);
            DataGridView_YPV.TabIndex = 1;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 12;
            X.Name = "X";
            X.Width = 120;
            // 
            // FX
            // 
            FX.HeaderText = "F(x)";
            FX.MinimumWidth = 12;
            FX.Name = "FX";
            FX.Width = 120;
            // 
            // labelRes_YPV
            // 
            labelRes_YPV.AutoSize = true;
            labelRes_YPV.Location = new Point(13, 22);
            labelRes_YPV.Margin = new Padding(1, 0, 1, 0);
            labelRes_YPV.Name = "labelRes_YPV";
            labelRes_YPV.Size = new Size(63, 15);
            labelRes_YPV.TabIndex = 0;
            labelRes_YPV.Text = "Результат:";
            // 
            // groupBoxData_YPV
            // 
            groupBoxData_YPV.Controls.Add(textBoxStart_YPV);
            groupBoxData_YPV.Controls.Add(textBoxStop_YPV);
            groupBoxData_YPV.Controls.Add(labelStop_YPV);
            groupBoxData_YPV.Controls.Add(labelStart_YPV);
            groupBoxData_YPV.Location = new Point(18, 218);
            groupBoxData_YPV.Margin = new Padding(1, 1, 1, 1);
            groupBoxData_YPV.Name = "groupBoxData_YPV";
            groupBoxData_YPV.Padding = new Padding(1, 1, 1, 1);
            groupBoxData_YPV.Size = new Size(347, 78);
            groupBoxData_YPV.TabIndex = 2;
            groupBoxData_YPV.TabStop = false;
            groupBoxData_YPV.Text = "Ввод данных:";
            // 
            // textBoxStart_YPV
            // 
            textBoxStart_YPV.Location = new Point(10, 48);
            textBoxStart_YPV.Margin = new Padding(1, 1, 1, 1);
            textBoxStart_YPV.Name = "textBoxStart_YPV";
            textBoxStart_YPV.Size = new Size(105, 23);
            textBoxStart_YPV.TabIndex = 3;
            // 
            // textBoxStop_YPV
            // 
            textBoxStop_YPV.Location = new Point(163, 48);
            textBoxStop_YPV.Margin = new Padding(1, 1, 1, 1);
            textBoxStop_YPV.Name = "textBoxStop_YPV";
            textBoxStop_YPV.Size = new Size(105, 23);
            textBoxStop_YPV.TabIndex = 2;
            // 
            // labelStop_YPV
            // 
            labelStop_YPV.AutoSize = true;
            labelStop_YPV.Location = new Point(163, 19);
            labelStop_YPV.Margin = new Padding(1, 0, 1, 0);
            labelStop_YPV.Name = "labelStop_YPV";
            labelStop_YPV.Size = new Size(75, 15);
            labelStop_YPV.TabIndex = 1;
            labelStop_YPV.Text = "Конец шага:";
            labelStop_YPV.Click += label2_Click;
            // 
            // labelStart_YPV
            // 
            labelStart_YPV.AutoSize = true;
            labelStart_YPV.Location = new Point(6, 19);
            labelStart_YPV.Margin = new Padding(1, 0, 1, 0);
            labelStart_YPV.Name = "labelStart_YPV";
            labelStart_YPV.Size = new Size(72, 15);
            labelStart_YPV.TabIndex = 0;
            labelStart_YPV.Text = "Старт шага:";
            // 
            // buttonInfo_YPV
            // 
            buttonInfo_YPV.BackColor = Color.FromArgb(192, 192, 255);
            buttonInfo_YPV.FlatStyle = FlatStyle.Flat;
            buttonInfo_YPV.Location = new Point(410, 245);
            buttonInfo_YPV.Margin = new Padding(1, 1, 1, 1);
            buttonInfo_YPV.Name = "buttonInfo_YPV";
            buttonInfo_YPV.Size = new Size(77, 38);
            buttonInfo_YPV.TabIndex = 3;
            buttonInfo_YPV.Text = "Справка";
            buttonInfo_YPV.UseVisualStyleBackColor = false;
            buttonInfo_YPV.Click += ButtonInfo_Click;
            // 
            // buttonDone_YPV
            // 
            buttonDone_YPV.BackColor = Color.FromArgb(192, 255, 192);
            buttonDone_YPV.FlatStyle = FlatStyle.Flat;
            buttonDone_YPV.Location = new Point(524, 240);
            buttonDone_YPV.Margin = new Padding(1, 1, 1, 1);
            buttonDone_YPV.Name = "buttonDone_YPV";
            buttonDone_YPV.Size = new Size(98, 49);
            buttonDone_YPV.TabIndex = 4;
            buttonDone_YPV.Text = "Выполнить";
            buttonDone_YPV.UseVisualStyleBackColor = false;
            buttonDone_YPV.Click += buttonDone_Click;
            buttonDone_YPV.MouseDown += buttonDone_MouseDown;
            buttonDone_YPV.MouseEnter += buttonDone_MouseEnter;
            buttonDone_YPV.MouseLeave += buttonDone_MouseLeave;
            // 
            // FormMain_YPV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 310);
            Controls.Add(buttonDone_YPV);
            Controls.Add(buttonInfo_YPV);
            Controls.Add(groupBoxData_YPV);
            Controls.Add(groupBoxRes_YPV);
            Controls.Add(groupBoxTask_YPV);
            Margin = new Padding(1, 1, 1, 1);
            Name = "FormMain_YPV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2 | Вариант 27 | Березовский А.С";
            Load += FormMain_YPV_Load;
            groupBoxTask_YPV.ResumeLayout(false);
            groupBoxTask_YPV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxRes_YPV.ResumeLayout(false);
            groupBoxRes_YPV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart_YPV).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridView_YPV).EndInit();
            groupBoxData_YPV.ResumeLayout(false);
            groupBoxData_YPV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_YPV;
        private Label labelTask1_YPV;
        private Label labelTask2_YPV;
        private PictureBox pictureBox1;
        private GroupBox groupBoxRes_YPV;
        private Label labelRes_YPV;
        private GroupBox groupBoxData_YPV;
        private Label labelStop_YPV;
        private Label labelStart_YPV;
        private DataGridView DataGridView_YPV;
        private TextBox textBoxStart_YPV;
        private TextBox textBoxStop_YPV;
        private Button buttonInfo_YPV;
        private Button buttonDone_YPV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_YPV;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn FX;
    }
}
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.BerezovskiyAS.Sprint6.Task3.V16
{
    partial class FormMain
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
            groupBoxTask_BLG = new GroupBox();
            dataGridViewTask_BLG = new DataGridView();
            textBoxTask_BLG = new TextBox();
            groupBoxOutput_BLG = new GroupBox();
            dataGridViewResult_BLG = new DataGridView();
            textBoxResult_BLG = new TextBox();
            buttonHelp_BLG = new Button();
            buttonDone_BLG = new Button();
            groupBoxTask_BLG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTask_BLG).BeginInit();
            groupBoxOutput_BLG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_BLG).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_BLG
            // 
            groupBoxTask_BLG.Controls.Add(dataGridViewTask_BLG);
            groupBoxTask_BLG.Controls.Add(textBoxTask_BLG);
            groupBoxTask_BLG.Location = new Point(19, 17);
            groupBoxTask_BLG.Margin = new Padding(2, 1, 2, 1);
            groupBoxTask_BLG.Name = "groupBoxTask_BLG";
            groupBoxTask_BLG.Padding = new Padding(2, 1, 2, 1);
            groupBoxTask_BLG.Size = new Size(344, 257);
            groupBoxTask_BLG.TabIndex = 0;
            groupBoxTask_BLG.TabStop = false;
            groupBoxTask_BLG.Text = "Условие";
            // 
            // dataGridViewTask_BLG
            // 
            dataGridViewTask_BLG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTask_BLG.Location = new Point(9, 55);
            dataGridViewTask_BLG.Margin = new Padding(2, 1, 2, 1);
            dataGridViewTask_BLG.Name = "dataGridViewTask_BLG";
            dataGridViewTask_BLG.RowHeadersVisible = false;
            dataGridViewTask_BLG.RowHeadersWidth = 82;
            dataGridViewTask_BLG.Size = new Size(327, 193);
            dataGridViewTask_BLG.TabIndex = 1;
            // 
            // textBoxTask_BLG
            // 
            textBoxTask_BLG.BorderStyle = BorderStyle.None;
            textBoxTask_BLG.Location = new Point(9, 18);
            textBoxTask_BLG.Margin = new Padding(2, 1, 2, 1);
            textBoxTask_BLG.Multiline = true;
            textBoxTask_BLG.Name = "textBoxTask_BLG";
            textBoxTask_BLG.ReadOnly = true;
            textBoxTask_BLG.Size = new Size(338, 41);
            textBoxTask_BLG.TabIndex = 0;
            textBoxTask_BLG.Text = "Дана матрица 5 на 5. \r\nЗаменить чётные значения в третьей строке на ноль.";
            // 
            // groupBoxOutput_BLG
            // 
            groupBoxOutput_BLG.Controls.Add(dataGridViewResult_BLG);
            groupBoxOutput_BLG.Controls.Add(textBoxResult_BLG);
            groupBoxOutput_BLG.Location = new Point(376, 17);
            groupBoxOutput_BLG.Margin = new Padding(2, 1, 2, 1);
            groupBoxOutput_BLG.Name = "groupBoxOutput_BLG";
            groupBoxOutput_BLG.Padding = new Padding(2, 1, 2, 1);
            groupBoxOutput_BLG.Size = new Size(246, 218);
            groupBoxOutput_BLG.TabIndex = 1;
            groupBoxOutput_BLG.TabStop = false;
            groupBoxOutput_BLG.Text = "Вывод данных";
            // 
            // dataGridViewResult_BLG
            // 
            dataGridViewResult_BLG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_BLG.Location = new Point(11, 40);
            dataGridViewResult_BLG.Margin = new Padding(2, 1, 2, 1);
            dataGridViewResult_BLG.Name = "dataGridViewResult_BLG";
            dataGridViewResult_BLG.ReadOnly = true;
            dataGridViewResult_BLG.RowHeadersVisible = false;
            dataGridViewResult_BLG.RowHeadersWidth = 82;
            dataGridViewResult_BLG.Size = new Size(220, 164);
            dataGridViewResult_BLG.TabIndex = 1;
            // 
            // textBoxResult_BLG
            // 
            textBoxResult_BLG.BackColor = SystemColors.Menu;
            textBoxResult_BLG.BorderStyle = BorderStyle.None;
            textBoxResult_BLG.Location = new Point(11, 18);
            textBoxResult_BLG.Margin = new Padding(2, 1, 2, 1);
            textBoxResult_BLG.Name = "textBoxResult_BLG";
            textBoxResult_BLG.ReadOnly = true;
            textBoxResult_BLG.Size = new Size(194, 16);
            textBoxResult_BLG.TabIndex = 0;
            textBoxResult_BLG.Text = "Результат";
            // 
            // buttonHelp_BLG
            // 
            buttonHelp_BLG.FlatStyle = FlatStyle.Flat;
            buttonHelp_BLG.Location = new Point(460, 242);
            buttonHelp_BLG.Margin = new Padding(2, 1, 2, 1);
            buttonHelp_BLG.Name = "buttonHelp_BLG";
            buttonHelp_BLG.Size = new Size(38, 32);
            buttonHelp_BLG.TabIndex = 2;
            buttonHelp_BLG.Text = "?";
            buttonHelp_BLG.UseVisualStyleBackColor = true;
            buttonHelp_BLG.Click += buttonHelp_BLG_Click;
            // 
            // buttonDone_BLG
            // 
            buttonDone_BLG.Location = new Point(507, 242);
            buttonDone_BLG.Margin = new Padding(2, 1, 2, 1);
            buttonDone_BLG.Name = "buttonDone_BLG";
            buttonDone_BLG.Size = new Size(116, 32);
            buttonDone_BLG.TabIndex = 3;
            buttonDone_BLG.Text = "Выполнить";
            buttonDone_BLG.UseVisualStyleBackColor = true;
            buttonDone_BLG.Click += buttonDone_BLG_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 290);
            Controls.Add(buttonDone_BLG);
            Controls.Add(buttonHelp_BLG);
            Controls.Add(groupBoxOutput_BLG);
            Controls.Add(groupBoxTask_BLG);
            Margin = new Padding(2, 1, 2, 1);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 16 | Березовский А.С";
            Load += FormMain_Load;
            groupBoxTask_BLG.ResumeLayout(false);
            groupBoxTask_BLG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTask_BLG).EndInit();
            groupBoxOutput_BLG.ResumeLayout(false);
            groupBoxOutput_BLG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_BLG).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_BLG;
        private TextBox textBoxTask_BLG;
        private DataGridView dataGridViewTask_BLG;
        private GroupBox groupBoxOutput_BLG;
        private DataGridView dataGridViewResult_BLG;
        private TextBox textBoxResult_BLG;
        private Button buttonHelp_BLG;
        private Button buttonDone_BLG;
    }
}

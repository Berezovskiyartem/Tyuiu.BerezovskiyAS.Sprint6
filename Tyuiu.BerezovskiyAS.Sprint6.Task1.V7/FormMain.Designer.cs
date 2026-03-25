namespace FunctionTabulationApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnCalculate;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtResult = new TextBox();
            btnCalculate = new Button();
            SuspendLayout();
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Consolas", 10F);
            txtResult.Location = new Point(14, 14);
            txtResult.Margin = new Padding(4, 3, 4, 3);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.ScrollBars = ScrollBars.Vertical;
            txtResult.Size = new Size(419, 438);
            txtResult.TabIndex = 0;
            txtResult.TextChanged += txtResult_TextChanged;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(443, 14);
            btnCalculate.Margin = new Padding(4, 3, 4, 3);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(117, 40);
            btnCalculate.TabIndex = 1;
            btnCalculate.Text = "Вычислить";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 465);
            Controls.Add(btnCalculate);
            Controls.Add(txtResult);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Табулирование функции - Вариант 7";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
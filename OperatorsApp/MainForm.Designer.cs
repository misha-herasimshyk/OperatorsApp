namespace OperatorsApp
{
    partial class MainForm
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
            label1 = new Label();
            OpenCalculatorButton = new Button();
            OpenAgeButton = new Button();
            OpenMultiplicationButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 27);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 0;
            label1.Text = "Оберіть дію";
            // 
            // OpenCalculatorButton
            // 
            OpenCalculatorButton.Cursor = Cursors.Hand;
            OpenCalculatorButton.Location = new Point(94, 79);
            OpenCalculatorButton.Name = "OpenCalculatorButton";
            OpenCalculatorButton.Size = new Size(100, 40);
            OpenCalculatorButton.TabIndex = 1;
            OpenCalculatorButton.Text = "Калькулятор";
            OpenCalculatorButton.UseVisualStyleBackColor = true;
            OpenCalculatorButton.Click += OpenCalculatorButton_Click;
            // 
            // OpenAgeButton
            // 
            OpenAgeButton.Cursor = Cursors.Hand;
            OpenAgeButton.Location = new Point(94, 156);
            OpenAgeButton.Name = "OpenAgeButton";
            OpenAgeButton.Size = new Size(100, 40);
            OpenAgeButton.TabIndex = 2;
            OpenAgeButton.Text = "Перевірка віку";
            OpenAgeButton.UseVisualStyleBackColor = true;
            OpenAgeButton.Click += OpenAgeButton_Click;
            // 
            // OpenMultiplicationButton
            // 
            OpenMultiplicationButton.Cursor = Cursors.Hand;
            OpenMultiplicationButton.Location = new Point(94, 233);
            OpenMultiplicationButton.Name = "OpenMultiplicationButton";
            OpenMultiplicationButton.Size = new Size(100, 40);
            OpenMultiplicationButton.TabIndex = 3;
            OpenMultiplicationButton.Text = "Таблиця множення";
            OpenMultiplicationButton.UseVisualStyleBackColor = true;
            OpenMultiplicationButton.Click += OpenMultiplicationButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 324);
            Controls.Add(OpenMultiplicationButton);
            Controls.Add(OpenAgeButton);
            Controls.Add(OpenCalculatorButton);
            Controls.Add(label1);
            Cursor = Cursors.Default;
            Name = "MainForm";
            Text = "Rofls";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button OpenCalculatorButton;
        private Button OpenAgeButton;
        private Button OpenMultiplicationButton;
    }
}

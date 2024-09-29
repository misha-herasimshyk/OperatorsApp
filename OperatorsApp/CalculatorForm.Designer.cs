namespace OperatorsApp
{
    partial class CalculatorForm
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
            textBoxNum1 = new TextBox();
            textBoxNum2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            comboBoxOperation = new ComboBox();
            CalculateButton = new Button();
            label3 = new Label();
            labelResult = new Label();
            SuspendLayout();
            // 
            // textBoxNum1
            // 
            textBoxNum1.Location = new Point(126, 56);
            textBoxNum1.Name = "textBoxNum1";
            textBoxNum1.Size = new Size(100, 23);
            textBoxNum1.TabIndex = 0;
            // 
            // textBoxNum2
            // 
            textBoxNum2.Location = new Point(126, 102);
            textBoxNum2.Name = "textBoxNum2";
            textBoxNum2.Size = new Size(100, 23);
            textBoxNum2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 59);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 2;
            label1.Text = "Перше число";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 105);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 3;
            label2.Text = "Друге число";
            // 
            // comboBoxOperation
            // 
            comboBoxOperation.FormattingEnabled = true;
            comboBoxOperation.Items.AddRange(new object[] { "+", "-", "*", "/" });
            comboBoxOperation.Location = new Point(284, 59);
            comboBoxOperation.Name = "comboBoxOperation";
            comboBoxOperation.Size = new Size(121, 23);
            comboBoxOperation.TabIndex = 4;
            comboBoxOperation.Text = "Тип операції";
            // 
            // CalculateButton
            // 
            CalculateButton.Cursor = Cursors.Hand;
            CalculateButton.Location = new Point(296, 184);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(96, 35);
            CalculateButton.TabIndex = 5;
            CalculateButton.Text = "Обчислити";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 194);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 6;
            label3.Text = "Результат:";
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(142, 194);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(0, 15);
            labelResult.TabIndex = 7;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 269);
            Controls.Add(labelResult);
            Controls.Add(label3);
            Controls.Add(CalculateButton);
            Controls.Add(comboBoxOperation);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxNum2);
            Controls.Add(textBoxNum1);
            Name = "CalculatorForm";
            Text = "Калькулятор";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNum1;
        private TextBox textBoxNum2;
        private Label label1;
        private Label label2;
        private ComboBox comboBoxOperation;
        private Button CalculateButton;
        private Label label3;
        private Label labelResult;
    }
}
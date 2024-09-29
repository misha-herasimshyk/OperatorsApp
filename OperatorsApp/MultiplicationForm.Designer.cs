namespace OperatorsApp
{
    partial class MultiplicationForm
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
            label1 = new Label();
            textBoxNumber = new TextBox();
            GenerateTableButton = new Button();
            label2 = new Label();
            textBoxResult = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 74);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 0;
            label1.Text = "Введіть число";
            // 
            // textBoxNumber
            // 
            textBoxNumber.Location = new Point(120, 71);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(100, 23);
            textBoxNumber.TabIndex = 1;
            // 
            // GenerateTableButton
            // 
            GenerateTableButton.Cursor = Cursors.Hand;
            GenerateTableButton.Location = new Point(280, 66);
            GenerateTableButton.Name = "GenerateTableButton";
            GenerateTableButton.Size = new Size(91, 23);
            GenerateTableButton.TabIndex = 2;
            GenerateTableButton.Text = "Обчислити";
            GenerateTableButton.UseVisualStyleBackColor = true;
            GenerateTableButton.Click += GenerateTableButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 172);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 3;
            label2.Text = "Результат:";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(195, 169);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(176, 185);
            textBoxResult.TabIndex = 4;
            // 
            // MultiplicationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 383);
            Controls.Add(textBoxResult);
            Controls.Add(label2);
            Controls.Add(GenerateTableButton);
            Controls.Add(textBoxNumber);
            Controls.Add(label1);
            Name = "MultiplicationForm";
            Text = "Таблиця множення";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxNumber;
        private Button GenerateTableButton;
        private Label label2;
        private TextBox textBoxResult;
    }
}
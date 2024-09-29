namespace OperatorsApp
{
    partial class AgeForm
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
            textBoxAge = new TextBox();
            CheckAgeButton = new Button();
            label2 = new Label();
            labelCategory = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 65);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "Введіть ваш вік";
            // 
            // textBoxAge
            // 
            textBoxAge.Location = new Point(108, 65);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(100, 23);
            textBoxAge.TabIndex = 1;
            // 
            // CheckAgeButton
            // 
            CheckAgeButton.Cursor = Cursors.Hand;
            CheckAgeButton.Location = new Point(259, 52);
            CheckAgeButton.Name = "CheckAgeButton";
            CheckAgeButton.Size = new Size(85, 40);
            CheckAgeButton.TabIndex = 2;
            CheckAgeButton.Text = "Хто я?";
            CheckAgeButton.UseVisualStyleBackColor = true;
            CheckAgeButton.Click += CheckAgeButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 162);
            label2.Name = "label2";
            label2.Size = new Size(24, 15);
            label2.TabIndex = 3;
            label2.Text = "Ви:";
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Location = new Point(131, 162);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(0, 15);
            labelCategory.TabIndex = 4;
            // 
            // AgeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 209);
            Controls.Add(labelCategory);
            Controls.Add(label2);
            Controls.Add(CheckAgeButton);
            Controls.Add(textBoxAge);
            Controls.Add(label1);
            Name = "AgeForm";
            Text = "Хто ти?????";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxAge;
        private Button CheckAgeButton;
        private Label label2;
        private Label labelCategory;
    }
}
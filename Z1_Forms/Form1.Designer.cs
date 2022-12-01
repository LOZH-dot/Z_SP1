namespace Z1_Forms
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FirstElemTextBox = new System.Windows.Forms.TextBox();
            this.DenominatorTextBox = new System.Windows.Forms.TextBox();
            this.CountTextBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите первый член геометрической прогрессии:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите знаменатель геометрической прогрессии:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(319, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Введите количество элементов геометрической прогрессии:";
            // 
            // FirstElemTextBox
            // 
            this.FirstElemTextBox.Location = new System.Drawing.Point(341, 6);
            this.FirstElemTextBox.Name = "FirstElemTextBox";
            this.FirstElemTextBox.Size = new System.Drawing.Size(100, 20);
            this.FirstElemTextBox.TabIndex = 3;
            // 
            // DenominatorTextBox
            // 
            this.DenominatorTextBox.Location = new System.Drawing.Point(341, 34);
            this.DenominatorTextBox.Name = "DenominatorTextBox";
            this.DenominatorTextBox.Size = new System.Drawing.Size(100, 20);
            this.DenominatorTextBox.TabIndex = 4;
            // 
            // CountTextBox
            // 
            this.CountTextBox.Location = new System.Drawing.Point(341, 63);
            this.CountTextBox.Name = "CountTextBox";
            this.CountTextBox.Size = new System.Drawing.Size(100, 20);
            this.CountTextBox.TabIndex = 5;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(175, 114);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(107, 32);
            this.CalculateButton.TabIndex = 6;
            this.CalculateButton.Text = "Вычислить сумму";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 158);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.CountTextBox);
            this.Controls.Add(this.DenominatorTextBox);
            this.Controls.Add(this.FirstElemTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FirstElemTextBox;
        private System.Windows.Forms.TextBox DenominatorTextBox;
        private System.Windows.Forms.TextBox CountTextBox;
        private System.Windows.Forms.Button CalculateButton;
    }
}


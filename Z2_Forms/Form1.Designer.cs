namespace Z2_Forms
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
            this.FirstSideTextBox = new System.Windows.Forms.TextBox();
            this.SecondSideTextBox = new System.Windows.Forms.TextBox();
            this.ThirdSideTextBox = new System.Windows.Forms.TextBox();
            this.CheckButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите первую сторону треугольника:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите вторую сторону треугольника:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Введите третью сторону треугольника:";
            // 
            // FirstSideTextBox
            // 
            this.FirstSideTextBox.Location = new System.Drawing.Point(225, 6);
            this.FirstSideTextBox.Name = "FirstSideTextBox";
            this.FirstSideTextBox.Size = new System.Drawing.Size(100, 20);
            this.FirstSideTextBox.TabIndex = 3;
            // 
            // SecondSideTextBox
            // 
            this.SecondSideTextBox.Location = new System.Drawing.Point(224, 35);
            this.SecondSideTextBox.Name = "SecondSideTextBox";
            this.SecondSideTextBox.Size = new System.Drawing.Size(100, 20);
            this.SecondSideTextBox.TabIndex = 4;
            // 
            // ThirdSideTextBox
            // 
            this.ThirdSideTextBox.Location = new System.Drawing.Point(224, 63);
            this.ThirdSideTextBox.Name = "ThirdSideTextBox";
            this.ThirdSideTextBox.Size = new System.Drawing.Size(100, 20);
            this.ThirdSideTextBox.TabIndex = 5;
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(131, 125);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(75, 23);
            this.CheckButton.TabIndex = 6;
            this.CheckButton.Text = "Проверить";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 173);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.ThirdSideTextBox);
            this.Controls.Add(this.SecondSideTextBox);
            this.Controls.Add(this.FirstSideTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FirstSideTextBox;
        private System.Windows.Forms.TextBox SecondSideTextBox;
        private System.Windows.Forms.TextBox ThirdSideTextBox;
        private System.Windows.Forms.Button CheckButton;
    }
}


namespace Programming2.View.Panels
{
    partial class WeekdayParsingControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelParse = new System.Windows.Forms.Label();
            this.ButtonParse = new System.Windows.Forms.Button();
            this.TextBoxWeekday = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelParse
            // 
            this.LabelParse.AutoSize = true;
            this.LabelParse.Location = new System.Drawing.Point(31, 96);
            this.LabelParse.Name = "LabelParse";
            this.LabelParse.Size = new System.Drawing.Size(0, 13);
            this.LabelParse.TabIndex = 12;
            // 
            // ButtonParse
            // 
            this.ButtonParse.Location = new System.Drawing.Point(149, 63);
            this.ButtonParse.Name = "ButtonParse";
            this.ButtonParse.Size = new System.Drawing.Size(75, 23);
            this.ButtonParse.TabIndex = 11;
            this.ButtonParse.Text = "Parse";
            this.ButtonParse.UseVisualStyleBackColor = true;
            this.ButtonParse.Click += new System.EventHandler(this.ButtonParse_Click);
            // 
            // TextBoxWeekday
            // 
            this.TextBoxWeekday.Location = new System.Drawing.Point(34, 63);
            this.TextBoxWeekday.Name = "TextBoxWeekday";
            this.TextBoxWeekday.Size = new System.Drawing.Size(100, 20);
            this.TextBoxWeekday.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Type value for parsing:";
            // 
            // WeekdayParsingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelParse);
            this.Controls.Add(this.ButtonParse);
            this.Controls.Add(this.TextBoxWeekday);
            this.Controls.Add(this.label1);
            this.Name = "WeekdayParsingControl";
            this.Size = new System.Drawing.Size(280, 133);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelParse;
        private System.Windows.Forms.Button ButtonParse;
        private System.Windows.Forms.TextBox TextBoxWeekday;
        private System.Windows.Forms.Label label1;
    }
}

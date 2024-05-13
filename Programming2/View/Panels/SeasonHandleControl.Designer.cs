namespace ProjectProgramming.View.Panels
{
    partial class SeasonHandleControl
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
            this.ButtonGoSeson = new System.Windows.Forms.Button();
            this.ComboBoxSeason = new System.Windows.Forms.ComboBox();
            this.LabelSeason = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonGoSeson
            // 
            this.ButtonGoSeson.Location = new System.Drawing.Point(148, 33);
            this.ButtonGoSeson.Name = "ButtonGoSeson";
            this.ButtonGoSeson.Size = new System.Drawing.Size(75, 23);
            this.ButtonGoSeson.TabIndex = 5;
            this.ButtonGoSeson.Text = "Go!";
            this.ButtonGoSeson.UseVisualStyleBackColor = true;
            this.ButtonGoSeson.Click += new System.EventHandler(this.SeasonButton_Click);
            // 
            // ComboBoxSeason
            // 
            this.ComboBoxSeason.FormattingEnabled = true;
            this.ComboBoxSeason.Location = new System.Drawing.Point(21, 34);
            this.ComboBoxSeason.Name = "ComboBoxSeason";
            this.ComboBoxSeason.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxSeason.TabIndex = 4;
            // 
            // LabelSeason
            // 
            this.LabelSeason.AutoSize = true;
            this.LabelSeason.Location = new System.Drawing.Point(21, 19);
            this.LabelSeason.Name = "LabelSeason";
            this.LabelSeason.Size = new System.Drawing.Size(83, 13);
            this.LabelSeason.TabIndex = 3;
            this.LabelSeason.Text = "Choose season:";
            // 
            // SeasonHandleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonGoSeson);
            this.Controls.Add(this.ComboBoxSeason);
            this.Controls.Add(this.LabelSeason);
            this.Name = "SeasonHandleControl";
            this.Size = new System.Drawing.Size(262, 79);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonGoSeson;
        private System.Windows.Forms.ComboBox ComboBoxSeason;
        private System.Windows.Forms.Label LabelSeason;
    }
}

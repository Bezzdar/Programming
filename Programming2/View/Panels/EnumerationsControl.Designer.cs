namespace Programming2.View.Panels
{
    partial class EnumerationsControl
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
            this.TextBoxValue = new System.Windows.Forms.TextBox();
            this.IntValueLabel = new System.Windows.Forms.Label();
            this.ListBoxValue = new System.Windows.Forms.ListBox();
            this.ChooseValueLabel = new System.Windows.Forms.Label();
            this.ChooseEnumLabel = new System.Windows.Forms.Label();
            this.EnumListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TextBoxValue
            // 
            this.TextBoxValue.Location = new System.Drawing.Point(309, 33);
            this.TextBoxValue.Name = "TextBoxValue";
            this.TextBoxValue.Size = new System.Drawing.Size(100, 20);
            this.TextBoxValue.TabIndex = 11;
            // 
            // IntValueLabel
            // 
            this.IntValueLabel.AutoSize = true;
            this.IntValueLabel.Location = new System.Drawing.Point(306, 15);
            this.IntValueLabel.Name = "IntValueLabel";
            this.IntValueLabel.Size = new System.Drawing.Size(51, 13);
            this.IntValueLabel.TabIndex = 10;
            this.IntValueLabel.Text = "Int value:";
            // 
            // ListBoxValue
            // 
            this.ListBoxValue.FormattingEnabled = true;
            this.ListBoxValue.Location = new System.Drawing.Point(163, 33);
            this.ListBoxValue.Name = "ListBoxValue";
            this.ListBoxValue.Size = new System.Drawing.Size(120, 160);
            this.ListBoxValue.TabIndex = 9;
            this.ListBoxValue.SelectedIndexChanged += new System.EventHandler(this.ListBoxValue_SelectedIndexChanged);
            // 
            // ChooseValueLabel
            // 
            this.ChooseValueLabel.AutoSize = true;
            this.ChooseValueLabel.Location = new System.Drawing.Point(160, 15);
            this.ChooseValueLabel.Name = "ChooseValueLabel";
            this.ChooseValueLabel.Size = new System.Drawing.Size(75, 13);
            this.ChooseValueLabel.TabIndex = 8;
            this.ChooseValueLabel.Text = "Choose value:";
            // 
            // ChooseEnumLabel
            // 
            this.ChooseEnumLabel.AutoSize = true;
            this.ChooseEnumLabel.Location = new System.Drawing.Point(18, 17);
            this.ChooseEnumLabel.Name = "ChooseEnumLabel";
            this.ChooseEnumLabel.Size = new System.Drawing.Size(107, 13);
            this.ChooseEnumLabel.TabIndex = 7;
            this.ChooseEnumLabel.Text = "Choose enumeration:";
            // 
            // EnumListBox
            // 
            this.EnumListBox.FormattingEnabled = true;
            this.EnumListBox.Items.AddRange(new object[] {
            "Colors",
            "FormOfEducation",
            "Genre",
            "Manufacturers",
            "Seasons",
            "Weekday"});
            this.EnumListBox.Location = new System.Drawing.Point(21, 33);
            this.EnumListBox.Name = "EnumListBox";
            this.EnumListBox.Size = new System.Drawing.Size(120, 160);
            this.EnumListBox.TabIndex = 6;
            this.EnumListBox.SelectedIndexChanged += new System.EventHandler(this.EnumListBox_SelectedIndexChanged);
            // 
            // EnumerationsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TextBoxValue);
            this.Controls.Add(this.IntValueLabel);
            this.Controls.Add(this.ListBoxValue);
            this.Controls.Add(this.ChooseValueLabel);
            this.Controls.Add(this.ChooseEnumLabel);
            this.Controls.Add(this.EnumListBox);
            this.Name = "EnumerationsControl";
            this.Size = new System.Drawing.Size(776, 208);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxValue;
        private System.Windows.Forms.Label IntValueLabel;
        private System.Windows.Forms.ListBox ListBoxValue;
        private System.Windows.Forms.Label ChooseValueLabel;
        private System.Windows.Forms.Label ChooseEnumLabel;
        private System.Windows.Forms.ListBox EnumListBox;
    }
}

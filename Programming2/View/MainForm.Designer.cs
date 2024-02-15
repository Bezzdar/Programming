namespace Programming2
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabPageEnums = new System.Windows.Forms.TabPage();
            this.WeekdayBox = new System.Windows.Forms.GroupBox();
            this.LabelParse = new System.Windows.Forms.Label();
            this.ButtonParse = new System.Windows.Forms.Button();
            this.TextBoxWeekday = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EnumBox = new System.Windows.Forms.GroupBox();
            this.TextBoxValue = new System.Windows.Forms.TextBox();
            this.IntValueLabel = new System.Windows.Forms.Label();
            this.ListBoxValue = new System.Windows.Forms.ListBox();
            this.ChooseValueLabel = new System.Windows.Forms.Label();
            this.ChooseEnumLabel = new System.Windows.Forms.Label();
            this.EnumListBox = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.TabPageEnums.SuspendLayout();
            this.WeekdayBox.SuspendLayout();
            this.EnumBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabPageEnums);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // TabPageEnums
            // 
            this.TabPageEnums.Controls.Add(this.WeekdayBox);
            this.TabPageEnums.Controls.Add(this.EnumBox);
            this.TabPageEnums.Location = new System.Drawing.Point(4, 22);
            this.TabPageEnums.Name = "TabPageEnums";
            this.TabPageEnums.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageEnums.Size = new System.Drawing.Size(792, 424);
            this.TabPageEnums.TabIndex = 0;
            this.TabPageEnums.Text = "Enums";
            this.TabPageEnums.UseVisualStyleBackColor = true;
            // 
            // WeekdayBox
            // 
            this.WeekdayBox.Controls.Add(this.LabelParse);
            this.WeekdayBox.Controls.Add(this.ButtonParse);
            this.WeekdayBox.Controls.Add(this.TextBoxWeekday);
            this.WeekdayBox.Controls.Add(this.label1);
            this.WeekdayBox.Location = new System.Drawing.Point(8, 220);
            this.WeekdayBox.Name = "WeekdayBox";
            this.WeekdayBox.Size = new System.Drawing.Size(776, 165);
            this.WeekdayBox.TabIndex = 6;
            this.WeekdayBox.TabStop = false;
            this.WeekdayBox.Text = "Weekday Parsing";
            // 
            // LabelParse
            // 
            this.LabelParse.AutoSize = true;
            this.LabelParse.Location = new System.Drawing.Point(6, 75);
            this.LabelParse.Name = "LabelParse";
            this.LabelParse.Size = new System.Drawing.Size(0, 13);
            this.LabelParse.TabIndex = 8;
            // 
            // ButtonParse
            // 
            this.ButtonParse.Location = new System.Drawing.Point(124, 42);
            this.ButtonParse.Name = "ButtonParse";
            this.ButtonParse.Size = new System.Drawing.Size(75, 23);
            this.ButtonParse.TabIndex = 7;
            this.ButtonParse.Text = "Parse";
            this.ButtonParse.UseVisualStyleBackColor = true;
            this.ButtonParse.Click += new System.EventHandler(this.ButtonParse_Click);
            // 
            // TextBoxWeekday
            // 
            this.TextBoxWeekday.Location = new System.Drawing.Point(9, 42);
            this.TextBoxWeekday.Name = "TextBoxWeekday";
            this.TextBoxWeekday.Size = new System.Drawing.Size(100, 20);
            this.TextBoxWeekday.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type value for parsing:";
            // 
            // EnumBox
            // 
            this.EnumBox.Controls.Add(this.TextBoxValue);
            this.EnumBox.Controls.Add(this.IntValueLabel);
            this.EnumBox.Controls.Add(this.ListBoxValue);
            this.EnumBox.Controls.Add(this.ChooseValueLabel);
            this.EnumBox.Controls.Add(this.ChooseEnumLabel);
            this.EnumBox.Controls.Add(this.EnumListBox);
            this.EnumBox.Location = new System.Drawing.Point(8, 6);
            this.EnumBox.Name = "EnumBox";
            this.EnumBox.Size = new System.Drawing.Size(776, 208);
            this.EnumBox.TabIndex = 0;
            this.EnumBox.TabStop = false;
            this.EnumBox.Text = "Enumerations";
            // 
            // TextBoxValue
            // 
            this.TextBoxValue.Location = new System.Drawing.Point(297, 34);
            this.TextBoxValue.Name = "TextBoxValue";
            this.TextBoxValue.Size = new System.Drawing.Size(100, 20);
            this.TextBoxValue.TabIndex = 5;
            // 
            // IntValueLabel
            // 
            this.IntValueLabel.AutoSize = true;
            this.IntValueLabel.Location = new System.Drawing.Point(294, 16);
            this.IntValueLabel.Name = "IntValueLabel";
            this.IntValueLabel.Size = new System.Drawing.Size(51, 13);
            this.IntValueLabel.TabIndex = 4;
            this.IntValueLabel.Text = "Int value:";
            // 
            // ListBoxValue
            // 
            this.ListBoxValue.FormattingEnabled = true;
            this.ListBoxValue.Location = new System.Drawing.Point(151, 34);
            this.ListBoxValue.Name = "ListBoxValue";
            this.ListBoxValue.Size = new System.Drawing.Size(120, 160);
            this.ListBoxValue.TabIndex = 3;
            this.ListBoxValue.SelectedIndexChanged += new System.EventHandler(this.ListBoxValue_SelectedIndexChanged);
            // 
            // ChooseValueLabel
            // 
            this.ChooseValueLabel.AutoSize = true;
            this.ChooseValueLabel.Location = new System.Drawing.Point(148, 16);
            this.ChooseValueLabel.Name = "ChooseValueLabel";
            this.ChooseValueLabel.Size = new System.Drawing.Size(75, 13);
            this.ChooseValueLabel.TabIndex = 2;
            this.ChooseValueLabel.Text = "Choose value:";
            // 
            // ChooseEnumLabel
            // 
            this.ChooseEnumLabel.AutoSize = true;
            this.ChooseEnumLabel.Location = new System.Drawing.Point(6, 18);
            this.ChooseEnumLabel.Name = "ChooseEnumLabel";
            this.ChooseEnumLabel.Size = new System.Drawing.Size(107, 13);
            this.ChooseEnumLabel.TabIndex = 1;
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
            this.EnumListBox.Location = new System.Drawing.Point(9, 34);
            this.EnumListBox.Name = "EnumListBox";
            this.EnumListBox.Size = new System.Drawing.Size(120, 160);
            this.EnumListBox.TabIndex = 0;
            this.EnumListBox.SelectedIndexChanged += new System.EventHandler(this.EnumListBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.TabPageEnums.ResumeLayout(false);
            this.WeekdayBox.ResumeLayout(false);
            this.WeekdayBox.PerformLayout();
            this.EnumBox.ResumeLayout(false);
            this.EnumBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabPageEnums;
        private System.Windows.Forms.GroupBox EnumBox;
        private System.Windows.Forms.Label ChooseEnumLabel;
        private System.Windows.Forms.ListBox EnumListBox;
        private System.Windows.Forms.Label ChooseValueLabel;
        private System.Windows.Forms.Label IntValueLabel;
        private System.Windows.Forms.ListBox ListBoxValue;
        private System.Windows.Forms.TextBox TextBoxValue;
        private System.Windows.Forms.GroupBox WeekdayBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxWeekday;
        private System.Windows.Forms.Label LabelParse;
        private System.Windows.Forms.Button ButtonParse;
    }
}


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
            this.SeasonBox = new System.Windows.Forms.GroupBox();
            this.ButtonGoSeson = new System.Windows.Forms.Button();
            this.ComboBoxSeason = new System.Windows.Forms.ComboBox();
            this.LabelSeason = new System.Windows.Forms.Label();
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
            this.TabPageClasses = new System.Windows.Forms.TabPage();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxRelease = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ClassiesMovieListBox = new System.Windows.Forms.ListBox();
            this.FindButtonRectangle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.labelColor = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.labelWidth = new System.Windows.Forms.Label();
            this.textBoxLength = new System.Windows.Forms.TextBox();
            this.labelLength = new System.Windows.Forms.Label();
            this.ClassesRectanglesListBox = new System.Windows.Forms.ListBox();
            this.labelRectangels = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxRating = new System.Windows.Forms.TextBox();
            this.buttonFindRating = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.TabPageEnums.SuspendLayout();
            this.SeasonBox.SuspendLayout();
            this.WeekdayBox.SuspendLayout();
            this.EnumBox.SuspendLayout();
            this.TabPageClasses.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabPageEnums);
            this.tabControl1.Controls.Add(this.TabPageClasses);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // TabPageEnums
            // 
            this.TabPageEnums.Controls.Add(this.SeasonBox);
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
            // SeasonBox
            // 
            this.SeasonBox.Controls.Add(this.ButtonGoSeson);
            this.SeasonBox.Controls.Add(this.ComboBoxSeason);
            this.SeasonBox.Controls.Add(this.LabelSeason);
            this.SeasonBox.Location = new System.Drawing.Point(411, 220);
            this.SeasonBox.Name = "SeasonBox";
            this.SeasonBox.Size = new System.Drawing.Size(373, 165);
            this.SeasonBox.TabIndex = 9;
            this.SeasonBox.TabStop = false;
            this.SeasonBox.Text = "Season Handle";
            // 
            // ButtonGoSeson
            // 
            this.ButtonGoSeson.Location = new System.Drawing.Point(133, 40);
            this.ButtonGoSeson.Name = "ButtonGoSeson";
            this.ButtonGoSeson.Size = new System.Drawing.Size(75, 23);
            this.ButtonGoSeson.TabIndex = 2;
            this.ButtonGoSeson.Text = "Go!";
            this.ButtonGoSeson.UseVisualStyleBackColor = true;
            this.ButtonGoSeson.Click += new System.EventHandler(this.ButtonGoSeson_Click);
            // 
            // ComboBoxSeason
            // 
            this.ComboBoxSeason.FormattingEnabled = true;
            this.ComboBoxSeason.Location = new System.Drawing.Point(6, 41);
            this.ComboBoxSeason.Name = "ComboBoxSeason";
            this.ComboBoxSeason.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxSeason.TabIndex = 1;
            // 
            // LabelSeason
            // 
            this.LabelSeason.AutoSize = true;
            this.LabelSeason.Location = new System.Drawing.Point(6, 26);
            this.LabelSeason.Name = "LabelSeason";
            this.LabelSeason.Size = new System.Drawing.Size(83, 13);
            this.LabelSeason.TabIndex = 0;
            this.LabelSeason.Text = "Choose season:";
            // 
            // WeekdayBox
            // 
            this.WeekdayBox.Controls.Add(this.LabelParse);
            this.WeekdayBox.Controls.Add(this.ButtonParse);
            this.WeekdayBox.Controls.Add(this.TextBoxWeekday);
            this.WeekdayBox.Controls.Add(this.label1);
            this.WeekdayBox.Location = new System.Drawing.Point(8, 220);
            this.WeekdayBox.Name = "WeekdayBox";
            this.WeekdayBox.Size = new System.Drawing.Size(373, 165);
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
            // TabPageClasses
            // 
            this.TabPageClasses.Controls.Add(this.buttonFindRating);
            this.TabPageClasses.Controls.Add(this.textBoxRating);
            this.TabPageClasses.Controls.Add(this.label8);
            this.TabPageClasses.Controls.Add(this.textBoxGenre);
            this.TabPageClasses.Controls.Add(this.label7);
            this.TabPageClasses.Controls.Add(this.textBoxRelease);
            this.TabPageClasses.Controls.Add(this.label6);
            this.TabPageClasses.Controls.Add(this.textBoxDuration);
            this.TabPageClasses.Controls.Add(this.label5);
            this.TabPageClasses.Controls.Add(this.textBoxName);
            this.TabPageClasses.Controls.Add(this.label4);
            this.TabPageClasses.Controls.Add(this.label3);
            this.TabPageClasses.Controls.Add(this.ClassiesMovieListBox);
            this.TabPageClasses.Controls.Add(this.FindButtonRectangle);
            this.TabPageClasses.Controls.Add(this.label2);
            this.TabPageClasses.Controls.Add(this.textBoxColor);
            this.TabPageClasses.Controls.Add(this.labelColor);
            this.TabPageClasses.Controls.Add(this.textBoxWidth);
            this.TabPageClasses.Controls.Add(this.labelWidth);
            this.TabPageClasses.Controls.Add(this.textBoxLength);
            this.TabPageClasses.Controls.Add(this.labelLength);
            this.TabPageClasses.Controls.Add(this.ClassesRectanglesListBox);
            this.TabPageClasses.Controls.Add(this.labelRectangels);
            this.TabPageClasses.Location = new System.Drawing.Point(4, 22);
            this.TabPageClasses.Name = "TabPageClasses";
            this.TabPageClasses.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageClasses.Size = new System.Drawing.Size(792, 424);
            this.TabPageClasses.TabIndex = 1;
            this.TabPageClasses.Text = "Classes";
            this.TabPageClasses.UseVisualStyleBackColor = true;
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(621, 157);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(100, 20);
            this.textBoxGenre.TabIndex = 19;
            this.textBoxGenre.TextChanged += new System.EventHandler(this.textBoxGenre_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(622, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Genre";
            // 
            // textBoxRelease
            // 
            this.textBoxRelease.Location = new System.Drawing.Point(624, 118);
            this.textBoxRelease.Name = "textBoxRelease";
            this.textBoxRelease.Size = new System.Drawing.Size(100, 20);
            this.textBoxRelease.TabIndex = 17;
            this.textBoxRelease.TextChanged += new System.EventHandler(this.textBoxRelease_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(621, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Release";
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.Location = new System.Drawing.Point(621, 79);
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.Size = new System.Drawing.Size(100, 20);
            this.textBoxDuration.TabIndex = 15;
            this.textBoxDuration.TextChanged += new System.EventHandler(this.textBoxDuration_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(621, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Duration";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(624, 40);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 13;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(621, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Movie";
            // 
            // ClassiesMovieListBox
            // 
            this.ClassiesMovieListBox.FormattingEnabled = true;
            this.ClassiesMovieListBox.Location = new System.Drawing.Point(394, 24);
            this.ClassiesMovieListBox.Name = "ClassiesMovieListBox";
            this.ClassiesMovieListBox.Size = new System.Drawing.Size(221, 381);
            this.ClassiesMovieListBox.TabIndex = 10;
            this.ClassiesMovieListBox.SelectedIndexChanged += new System.EventHandler(this.ClassiesMovieListBox_SelectedIndexChanged);
            // 
            // FindButtonRectangle
            // 
            this.FindButtonRectangle.Location = new System.Drawing.Point(288, 366);
            this.FindButtonRectangle.Name = "FindButtonRectangle";
            this.FindButtonRectangle.Size = new System.Drawing.Size(97, 39);
            this.FindButtonRectangle.TabIndex = 9;
            this.FindButtonRectangle.Text = "Find";
            this.FindButtonRectangle.UseVisualStyleBackColor = true;
            this.FindButtonRectangle.Click += new System.EventHandler(this.FindButtonRectangle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Rectangles";
            // 
            // textBoxColor
            // 
            this.textBoxColor.Location = new System.Drawing.Point(288, 118);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(100, 20);
            this.textBoxColor.TabIndex = 7;
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(285, 102);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(31, 13);
            this.labelColor.TabIndex = 6;
            this.labelColor.Text = "Color";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(288, 79);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(100, 20);
            this.textBoxWidth.TabIndex = 5;
            this.textBoxWidth.TextChanged += new System.EventHandler(this.textBoxWidth_TextChanged);
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(285, 63);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(35, 13);
            this.labelWidth.TabIndex = 4;
            this.labelWidth.Text = "Width";
            // 
            // textBoxLength
            // 
            this.textBoxLength.Location = new System.Drawing.Point(288, 40);
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.Size = new System.Drawing.Size(100, 20);
            this.textBoxLength.TabIndex = 3;
            this.textBoxLength.TextChanged += new System.EventHandler(this.textBoxLength_TextChanged);
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Location = new System.Drawing.Point(285, 24);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(40, 13);
            this.labelLength.TabIndex = 2;
            this.labelLength.Text = "Length";
            // 
            // ClassesRectanglesListBox
            // 
            this.ClassesRectanglesListBox.FormattingEnabled = true;
            this.ClassesRectanglesListBox.Location = new System.Drawing.Point(11, 24);
            this.ClassesRectanglesListBox.Name = "ClassesRectanglesListBox";
            this.ClassesRectanglesListBox.Size = new System.Drawing.Size(268, 381);
            this.ClassesRectanglesListBox.TabIndex = 1;
            this.ClassesRectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.ClassesRectanglesListBox_SelectedIndexChanged);
            // 
            // labelRectangels
            // 
            this.labelRectangels.AutoSize = true;
            this.labelRectangels.Location = new System.Drawing.Point(8, 8);
            this.labelRectangels.Name = "labelRectangels";
            this.labelRectangels.Size = new System.Drawing.Size(0, 13);
            this.labelRectangels.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(622, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Rating";
            // 
            // textBoxRating
            // 
            this.textBoxRating.Location = new System.Drawing.Point(621, 196);
            this.textBoxRating.Name = "textBoxRating";
            this.textBoxRating.Size = new System.Drawing.Size(100, 20);
            this.textBoxRating.TabIndex = 21;
            this.textBoxRating.TextChanged += new System.EventHandler(this.textBoxRating_TextChanged);
            // 
            // buttonFindRating
            // 
            this.buttonFindRating.Location = new System.Drawing.Point(627, 366);
            this.buttonFindRating.Name = "buttonFindRating";
            this.buttonFindRating.Size = new System.Drawing.Size(97, 39);
            this.buttonFindRating.TabIndex = 22;
            this.buttonFindRating.Text = "Find";
            this.buttonFindRating.UseVisualStyleBackColor = true;
            this.buttonFindRating.Click += new System.EventHandler(this.buttonFindRating_Click);
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
            this.SeasonBox.ResumeLayout(false);
            this.SeasonBox.PerformLayout();
            this.WeekdayBox.ResumeLayout(false);
            this.WeekdayBox.PerformLayout();
            this.EnumBox.ResumeLayout(false);
            this.EnumBox.PerformLayout();
            this.TabPageClasses.ResumeLayout(false);
            this.TabPageClasses.PerformLayout();
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
        private System.Windows.Forms.GroupBox SeasonBox;
        private System.Windows.Forms.Label LabelSeason;
        private System.Windows.Forms.Button ButtonGoSeson;
        private System.Windows.Forms.ComboBox ComboBoxSeason;
        private System.Windows.Forms.TabPage TabPageClasses;
        private System.Windows.Forms.Label labelRectangels;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.ListBox ClassesRectanglesListBox;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.TextBox textBoxLength;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button FindButtonRectangle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox ClassiesMovieListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDuration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxRelease;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.TextBox textBoxRating;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonFindRating;
    }
}


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TabControl1 = new System.Windows.Forms.TabControl();
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
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.MidYTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.MidXTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonFindRating = new System.Windows.Forms.Button();
            this.textBoxRating = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
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
            this.ColorTextBoxColor = new System.Windows.Forms.TextBox();
            this.labelColor = new System.Windows.Forms.Label();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.labelWidth = new System.Windows.Forms.Label();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.labelLength = new System.Windows.Forms.Label();
            this.ClassesRectanglesListBox = new System.Windows.Forms.ListBox();
            this.labelRectangels = new System.Windows.Forms.Label();
            this.RectanglesTabPage = new System.Windows.Forms.TabPage();
            this.TextBoxHeight = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.TextBoxRectanglesWidth = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TextBoxY = new System.Windows.Forms.TextBox();
            this.TextBoxX = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TextBoxID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.AddRectangleButton = new System.Windows.Forms.Button();
            this.DeleteRectangleButton = new System.Windows.Forms.Button();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.RectanglesLabel = new System.Windows.Forms.Label();
            this.RectanglesPanel = new System.Windows.Forms.Panel();
            this.TabControl1.SuspendLayout();
            this.TabPageEnums.SuspendLayout();
            this.SeasonBox.SuspendLayout();
            this.WeekdayBox.SuspendLayout();
            this.EnumBox.SuspendLayout();
            this.TabPageClasses.SuspendLayout();
            this.RectanglesTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPageEnums);
            this.TabControl1.Controls.Add(this.TabPageClasses);
            this.TabControl1.Controls.Add(this.RectanglesTabPage);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.Location = new System.Drawing.Point(0, 0);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(798, 451);
            this.TabControl1.TabIndex = 0;
            // 
            // TabPageEnums
            // 
            this.TabPageEnums.Controls.Add(this.SeasonBox);
            this.TabPageEnums.Controls.Add(this.WeekdayBox);
            this.TabPageEnums.Controls.Add(this.EnumBox);
            this.TabPageEnums.Location = new System.Drawing.Point(4, 22);
            this.TabPageEnums.Name = "TabPageEnums";
            this.TabPageEnums.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageEnums.Size = new System.Drawing.Size(790, 425);
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
            this.TabPageClasses.Controls.Add(this.IdTextBox);
            this.TabPageClasses.Controls.Add(this.label11);
            this.TabPageClasses.Controls.Add(this.MidYTextBox);
            this.TabPageClasses.Controls.Add(this.label10);
            this.TabPageClasses.Controls.Add(this.MidXTextBox);
            this.TabPageClasses.Controls.Add(this.label9);
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
            this.TabPageClasses.Controls.Add(this.ColorTextBoxColor);
            this.TabPageClasses.Controls.Add(this.labelColor);
            this.TabPageClasses.Controls.Add(this.WidthTextBox);
            this.TabPageClasses.Controls.Add(this.labelWidth);
            this.TabPageClasses.Controls.Add(this.LengthTextBox);
            this.TabPageClasses.Controls.Add(this.labelLength);
            this.TabPageClasses.Controls.Add(this.ClassesRectanglesListBox);
            this.TabPageClasses.Controls.Add(this.labelRectangels);
            this.TabPageClasses.Location = new System.Drawing.Point(4, 22);
            this.TabPageClasses.Name = "TabPageClasses";
            this.TabPageClasses.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageClasses.Size = new System.Drawing.Size(790, 425);
            this.TabPageClasses.TabIndex = 1;
            this.TabPageClasses.Text = "Classes";
            this.TabPageClasses.UseVisualStyleBackColor = true;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Enabled = false;
            this.IdTextBox.Location = new System.Drawing.Point(288, 235);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(100, 20);
            this.IdTextBox.TabIndex = 28;
            this.IdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxDisable);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(285, 219);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Id";
            // 
            // MidYTextBox
            // 
            this.MidYTextBox.Enabled = false;
            this.MidYTextBox.Location = new System.Drawing.Point(288, 196);
            this.MidYTextBox.Name = "MidYTextBox";
            this.MidYTextBox.Size = new System.Drawing.Size(100, 20);
            this.MidYTextBox.TabIndex = 26;
            this.MidYTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxDisable);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(285, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Middle Y";
            // 
            // MidXTextBox
            // 
            this.MidXTextBox.Enabled = false;
            this.MidXTextBox.Location = new System.Drawing.Point(288, 157);
            this.MidXTextBox.Name = "MidXTextBox";
            this.MidXTextBox.Size = new System.Drawing.Size(100, 20);
            this.MidXTextBox.TabIndex = 24;
            this.MidXTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxDisable);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(285, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Middle X";
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
            // textBoxRating
            // 
            this.textBoxRating.Location = new System.Drawing.Point(621, 196);
            this.textBoxRating.Name = "textBoxRating";
            this.textBoxRating.Size = new System.Drawing.Size(100, 20);
            this.textBoxRating.TabIndex = 21;
            this.textBoxRating.TextChanged += new System.EventHandler(this.textBoxRating_TextChanged);
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
            // ColorTextBoxColor
            // 
            this.ColorTextBoxColor.Location = new System.Drawing.Point(288, 118);
            this.ColorTextBoxColor.Name = "ColorTextBoxColor";
            this.ColorTextBoxColor.Size = new System.Drawing.Size(100, 20);
            this.ColorTextBoxColor.TabIndex = 7;
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
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(288, 79);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(100, 20);
            this.WidthTextBox.TabIndex = 5;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.textBoxWidth_TextChanged);
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
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(288, 40);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.LengthTextBox.TabIndex = 3;
            this.LengthTextBox.TextChanged += new System.EventHandler(this.textBoxLength_TextChanged);
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Location = new System.Drawing.Point(285, 24);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(38, 13);
            this.labelLength.TabIndex = 2;
            this.labelLength.Text = "Height";
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
            // RectanglesTabPage
            // 
            this.RectanglesTabPage.Controls.Add(this.TextBoxHeight);
            this.RectanglesTabPage.Controls.Add(this.label17);
            this.RectanglesTabPage.Controls.Add(this.label16);
            this.RectanglesTabPage.Controls.Add(this.TextBoxRectanglesWidth);
            this.RectanglesTabPage.Controls.Add(this.label15);
            this.RectanglesTabPage.Controls.Add(this.TextBoxY);
            this.RectanglesTabPage.Controls.Add(this.TextBoxX);
            this.RectanglesTabPage.Controls.Add(this.label14);
            this.RectanglesTabPage.Controls.Add(this.label13);
            this.RectanglesTabPage.Controls.Add(this.TextBoxID);
            this.RectanglesTabPage.Controls.Add(this.label12);
            this.RectanglesTabPage.Controls.Add(this.AddRectangleButton);
            this.RectanglesTabPage.Controls.Add(this.DeleteRectangleButton);
            this.RectanglesTabPage.Controls.Add(this.RectanglesListBox);
            this.RectanglesTabPage.Controls.Add(this.RectanglesLabel);
            this.RectanglesTabPage.Controls.Add(this.RectanglesPanel);
            this.RectanglesTabPage.Location = new System.Drawing.Point(4, 22);
            this.RectanglesTabPage.Name = "RectanglesTabPage";
            this.RectanglesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.RectanglesTabPage.Size = new System.Drawing.Size(790, 425);
            this.RectanglesTabPage.TabIndex = 2;
            this.RectanglesTabPage.Text = "Rectangles";
            this.RectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // TextBoxHeight
            // 
            this.TextBoxHeight.Location = new System.Drawing.Point(60, 373);
            this.TextBoxHeight.Name = "TextBoxHeight";
            this.TextBoxHeight.Size = new System.Drawing.Size(100, 20);
            this.TextBoxHeight.TabIndex = 14;
            this.TextBoxHeight.TextChanged += new System.EventHandler(this.TextBoxRectanglesHeight_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 380);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 13);
            this.label17.TabIndex = 13;
            this.label17.Text = "Height:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 360);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "Width:";
            // 
            // TextBoxRectanglesWidth
            // 
            this.TextBoxRectanglesWidth.Location = new System.Drawing.Point(60, 353);
            this.TextBoxRectanglesWidth.Name = "TextBoxRectanglesWidth";
            this.TextBoxRectanglesWidth.Size = new System.Drawing.Size(100, 20);
            this.TextBoxRectanglesWidth.TabIndex = 11;
            this.TextBoxRectanglesWidth.TextChanged += new System.EventHandler(this.TextBoxRectanglesWidth_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(37, 338);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Y:";
            // 
            // TextBoxY
            // 
            this.TextBoxY.Location = new System.Drawing.Point(60, 331);
            this.TextBoxY.Name = "TextBoxY";
            this.TextBoxY.Size = new System.Drawing.Size(100, 20);
            this.TextBoxY.TabIndex = 9;
            this.TextBoxY.TextChanged += new System.EventHandler(this.TextBoxRectanglesY_TextChanged);
            // 
            // TextBoxX
            // 
            this.TextBoxX.Location = new System.Drawing.Point(60, 308);
            this.TextBoxX.Name = "TextBoxX";
            this.TextBoxX.Size = new System.Drawing.Size(100, 20);
            this.TextBoxX.TabIndex = 8;
            this.TextBoxX.TextChanged += new System.EventHandler(this.TextBoxRectanglesX_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(37, 315);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "X:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(37, 293);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "id:";
            // 
            // TextBoxID
            // 
            this.TextBoxID.Location = new System.Drawing.Point(61, 286);
            this.TextBoxID.Name = "TextBoxID";
            this.TextBoxID.Size = new System.Drawing.Size(100, 20);
            this.TextBoxID.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(0, 270);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "SelectedRectangle:";
            // 
            // AddRectangleButton
            // 
            this.AddRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRectangleButton.ForeColor = System.Drawing.SystemColors.Window;
            this.AddRectangleButton.Image = ((System.Drawing.Image)(resources.GetObject("AddRectangleButton.Image")));
            this.AddRectangleButton.Location = new System.Drawing.Point(61, 221);
            this.AddRectangleButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddRectangleButton.Name = "AddRectangleButton";
            this.AddRectangleButton.Size = new System.Drawing.Size(55, 40);
            this.AddRectangleButton.TabIndex = 3;
            this.AddRectangleButton.UseVisualStyleBackColor = true;
            this.AddRectangleButton.Click += new System.EventHandler(this.AddRectangleButton_Click);
            // 
            // DeleteRectangleButton
            // 
            this.DeleteRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteRectangleButton.ForeColor = System.Drawing.SystemColors.Window;
            this.DeleteRectangleButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteRectangleButton.Image")));
            this.DeleteRectangleButton.Location = new System.Drawing.Point(186, 221);
            this.DeleteRectangleButton.Margin = new System.Windows.Forms.Padding(0);
            this.DeleteRectangleButton.Name = "DeleteRectangleButton";
            this.DeleteRectangleButton.Size = new System.Drawing.Size(55, 40);
            this.DeleteRectangleButton.TabIndex = 0;
            this.DeleteRectangleButton.UseVisualStyleBackColor = true;
            this.DeleteRectangleButton.Click += new System.EventHandler(this.DeleteRectangleButton_Click);
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.Location = new System.Drawing.Point(3, 16);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(314, 199);
            this.RectanglesListBox.TabIndex = 2;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // RectanglesLabel
            // 
            this.RectanglesLabel.AutoSize = true;
            this.RectanglesLabel.Location = new System.Drawing.Point(0, 0);
            this.RectanglesLabel.Name = "RectanglesLabel";
            this.RectanglesLabel.Size = new System.Drawing.Size(64, 13);
            this.RectanglesLabel.TabIndex = 1;
            this.RectanglesLabel.Text = "Rectangles:";
            // 
            // RectanglesPanel
            // 
            this.RectanglesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RectanglesPanel.BackColor = System.Drawing.Color.PapayaWhip;
            this.RectanglesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RectanglesPanel.Location = new System.Drawing.Point(323, 6);
            this.RectanglesPanel.Name = "RectanglesPanel";
            this.RectanglesPanel.Size = new System.Drawing.Size(463, 415);
            this.RectanglesPanel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 451);
            this.Controls.Add(this.TabControl1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.TabControl1.ResumeLayout(false);
            this.TabPageEnums.ResumeLayout(false);
            this.SeasonBox.ResumeLayout(false);
            this.SeasonBox.PerformLayout();
            this.WeekdayBox.ResumeLayout(false);
            this.WeekdayBox.PerformLayout();
            this.EnumBox.ResumeLayout(false);
            this.EnumBox.PerformLayout();
            this.TabPageClasses.ResumeLayout(false);
            this.TabPageClasses.PerformLayout();
            this.RectanglesTabPage.ResumeLayout(false);
            this.RectanglesTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl1;
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
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.TextBox LengthTextBox;
        private System.Windows.Forms.TextBox ColorTextBoxColor;
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
        private System.Windows.Forms.TextBox MidYTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox MidXTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage RectanglesTabPage;
        private System.Windows.Forms.Label RectanglesLabel;
        private System.Windows.Forms.Panel RectanglesPanel;
        private System.Windows.Forms.ListBox RectanglesListBox;
        private System.Windows.Forms.Button DeleteRectangleButton;
        private System.Windows.Forms.Button AddRectangleButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TextBoxRectanglesWidth;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TextBoxY;
        private System.Windows.Forms.TextBox TextBoxX;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TextBoxID;
        private System.Windows.Forms.TextBox TextBoxHeight;
        private System.Windows.Forms.Label label17;
    }
}


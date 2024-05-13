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
            this.RectanglesTabPage = new System.Windows.Forms.TabPage();
            this.TabPageClasses = new System.Windows.Forms.TabPage();
            this.TabPageEnums = new System.Windows.Forms.TabPage();
            this.SeasonBox = new System.Windows.Forms.GroupBox();
            this.WeekdayBox = new System.Windows.Forms.GroupBox();
            this.EnumBox = new System.Windows.Forms.GroupBox();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.seasonHandleControl1 = new ProjectProgramming.View.Panels.SeasonHandleControl();
            this.weekdayParsingControl1 = new Programming2.View.Panels.WeekdayParsingControl();
            this.enumerationsControl1 = new Programming2.View.Panels.EnumerationsControl();
            this.rectanglesClassesControl1 = new Programming2.View.Panels.RectanglesClassesControl();
            this.rectanglesCollisionControl1 = new Programming2.View.Panels.RectanglesCollisionControl();
            this.movieClassesControl1 = new Programming2.View.Panels.MovieClassesControl();
            this.RectanglesTabPage.SuspendLayout();
            this.TabPageClasses.SuspendLayout();
            this.TabPageEnums.SuspendLayout();
            this.SeasonBox.SuspendLayout();
            this.WeekdayBox.SuspendLayout();
            this.EnumBox.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RectanglesTabPage
            // 
            this.RectanglesTabPage.Controls.Add(this.rectanglesCollisionControl1);
            this.RectanglesTabPage.Location = new System.Drawing.Point(4, 22);
            this.RectanglesTabPage.Name = "RectanglesTabPage";
            this.RectanglesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.RectanglesTabPage.Size = new System.Drawing.Size(790, 425);
            this.RectanglesTabPage.TabIndex = 2;
            this.RectanglesTabPage.Text = "Rectangles";
            this.RectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // TabPageClasses
            // 
            this.TabPageClasses.Controls.Add(this.movieClassesControl1);
            this.TabPageClasses.Controls.Add(this.rectanglesClassesControl1);
            this.TabPageClasses.Location = new System.Drawing.Point(4, 22);
            this.TabPageClasses.Name = "TabPageClasses";
            this.TabPageClasses.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageClasses.Size = new System.Drawing.Size(790, 425);
            this.TabPageClasses.TabIndex = 1;
            this.TabPageClasses.Text = "Classes";
            this.TabPageClasses.UseVisualStyleBackColor = true;
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
            this.SeasonBox.Controls.Add(this.seasonHandleControl1);
            this.SeasonBox.Location = new System.Drawing.Point(411, 220);
            this.SeasonBox.Name = "SeasonBox";
            this.SeasonBox.Size = new System.Drawing.Size(373, 165);
            this.SeasonBox.TabIndex = 9;
            this.SeasonBox.TabStop = false;
            this.SeasonBox.Text = "Season Handle";
            // 
            // WeekdayBox
            // 
            this.WeekdayBox.Controls.Add(this.weekdayParsingControl1);
            this.WeekdayBox.Location = new System.Drawing.Point(8, 220);
            this.WeekdayBox.Name = "WeekdayBox";
            this.WeekdayBox.Size = new System.Drawing.Size(373, 165);
            this.WeekdayBox.TabIndex = 6;
            this.WeekdayBox.TabStop = false;
            this.WeekdayBox.Text = "Weekday Parsing";
            // 
            // EnumBox
            // 
            this.EnumBox.Controls.Add(this.enumerationsControl1);
            this.EnumBox.Location = new System.Drawing.Point(8, 6);
            this.EnumBox.Name = "EnumBox";
            this.EnumBox.Size = new System.Drawing.Size(776, 208);
            this.EnumBox.TabIndex = 0;
            this.EnumBox.TabStop = false;
            this.EnumBox.Text = "Enumerations";
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
            // seasonHandleControl1
            // 
            this.seasonHandleControl1.Location = new System.Drawing.Point(0, 0);
            this.seasonHandleControl1.Name = "seasonHandleControl1";
            this.seasonHandleControl1.Size = new System.Drawing.Size(239, 68);
            this.seasonHandleControl1.TabIndex = 0;
            this.seasonHandleControl1.SeasonChanged += new System.EventHandler<ProjectProgramming.View.Panels.SeasonChangedEventArgs>(this.seasonHandleControl1_SeasonChanged);
            // 
            // weekdayParsingControl1
            // 
            this.weekdayParsingControl1.Location = new System.Drawing.Point(-2, -21);
            this.weekdayParsingControl1.Name = "weekdayParsingControl1";
            this.weekdayParsingControl1.Size = new System.Drawing.Size(361, 127);
            this.weekdayParsingControl1.TabIndex = 0;
            // 
            // enumerationsControl1
            // 
            this.enumerationsControl1.Location = new System.Drawing.Point(0, -3);
            this.enumerationsControl1.Name = "enumerationsControl1";
            this.enumerationsControl1.Size = new System.Drawing.Size(776, 208);
            this.enumerationsControl1.TabIndex = 0;
            // 
            // rectanglesClassesControl1
            // 
            this.rectanglesClassesControl1.Location = new System.Drawing.Point(-4, -2);
            this.rectanglesClassesControl1.Name = "rectanglesClassesControl1";
            this.rectanglesClassesControl1.Size = new System.Drawing.Size(396, 419);
            this.rectanglesClassesControl1.TabIndex = 23;
            // 
            // rectanglesCollisionControl1
            // 
            this.rectanglesCollisionControl1.Location = new System.Drawing.Point(0, 0);
            this.rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            this.rectanglesCollisionControl1.Size = new System.Drawing.Size(790, 425);
            this.rectanglesCollisionControl1.TabIndex = 0;
            // 
            // movieClassesControl1
            // 
            this.movieClassesControl1.Location = new System.Drawing.Point(389, 3);
            this.movieClassesControl1.Name = "movieClassesControl1";
            this.movieClassesControl1.Size = new System.Drawing.Size(346, 409);
            this.movieClassesControl1.TabIndex = 24;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 451);
            this.Controls.Add(this.TabControl1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.RectanglesTabPage.ResumeLayout(false);
            this.TabPageClasses.ResumeLayout(false);
            this.TabPageEnums.ResumeLayout(false);
            this.SeasonBox.ResumeLayout(false);
            this.WeekdayBox.ResumeLayout(false);
            this.EnumBox.ResumeLayout(false);
            this.TabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage RectanglesTabPage;
        private View.Panels.RectanglesCollisionControl rectanglesCollisionControl1;
        private System.Windows.Forms.TabPage TabPageClasses;
        private System.Windows.Forms.TabPage TabPageEnums;
        private System.Windows.Forms.GroupBox SeasonBox;
        private System.Windows.Forms.GroupBox WeekdayBox;
        private System.Windows.Forms.GroupBox EnumBox;
        private System.Windows.Forms.TabControl TabControl1;
        private View.Panels.EnumerationsControl enumerationsControl1;
        private View.Panels.WeekdayParsingControl weekdayParsingControl1;
        private ProjectProgramming.View.Panels.SeasonHandleControl seasonHandleControl1;
        private View.Panels.RectanglesClassesControl rectanglesClassesControl1;
        private View.Panels.MovieClassesControl movieClassesControl1;
    }
}


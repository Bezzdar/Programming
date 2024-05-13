namespace Programming2.View.Panels
{
    partial class MovieClassesControl
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
            this.textBoxRating = new System.Windows.Forms.TextBox();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.textBoxRelease = new System.Windows.Forms.TextBox();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonFindRating = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ClassiesMovieListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBoxRating
            // 
            this.textBoxRating.Location = new System.Drawing.Point(240, 195);
            this.textBoxRating.Name = "textBoxRating";
            this.textBoxRating.Size = new System.Drawing.Size(100, 20);
            this.textBoxRating.TabIndex = 34;
            this.textBoxRating.TextChanged += new System.EventHandler(this.textBoxRating_TextChanged);
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(240, 156);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(100, 20);
            this.textBoxGenre.TabIndex = 32;
            this.textBoxGenre.TextChanged += new System.EventHandler(this.textBoxGenre_TextChanged);
            // 
            // textBoxRelease
            // 
            this.textBoxRelease.Location = new System.Drawing.Point(243, 117);
            this.textBoxRelease.Name = "textBoxRelease";
            this.textBoxRelease.Size = new System.Drawing.Size(100, 20);
            this.textBoxRelease.TabIndex = 30;
            this.textBoxRelease.TextChanged += new System.EventHandler(this.textBoxRelease_TextChanged);
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.Location = new System.Drawing.Point(240, 78);
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.Size = new System.Drawing.Size(100, 20);
            this.textBoxDuration.TabIndex = 28;
            this.textBoxDuration.TextChanged += new System.EventHandler(this.textBoxDuration_TextChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(243, 39);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 26;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // buttonFindRating
            // 
            this.buttonFindRating.Location = new System.Drawing.Point(246, 365);
            this.buttonFindRating.Name = "buttonFindRating";
            this.buttonFindRating.Size = new System.Drawing.Size(97, 39);
            this.buttonFindRating.TabIndex = 35;
            this.buttonFindRating.Text = "Find";
            this.buttonFindRating.UseVisualStyleBackColor = true;
            this.buttonFindRating.Click += new System.EventHandler(this.buttonFindRating_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(241, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Rating";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(241, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Genre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Release";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Duration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Movie";
            // 
            // ClassiesMovieListBox
            // 
            this.ClassiesMovieListBox.FormattingEnabled = true;
            this.ClassiesMovieListBox.Location = new System.Drawing.Point(13, 23);
            this.ClassiesMovieListBox.Name = "ClassiesMovieListBox";
            this.ClassiesMovieListBox.Size = new System.Drawing.Size(221, 381);
            this.ClassiesMovieListBox.TabIndex = 23;
            this.ClassiesMovieListBox.SelectedIndexChanged += new System.EventHandler(this.ClassiesMovieListBox_SelectedIndexChanged);
            // 
            // MovieClassesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxRating);
            this.Controls.Add(this.textBoxGenre);
            this.Controls.Add(this.textBoxRelease);
            this.Controls.Add(this.textBoxDuration);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonFindRating);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ClassiesMovieListBox);
            this.Name = "MovieClassesControl";
            this.Size = new System.Drawing.Size(346, 409);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRating;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.TextBox textBoxRelease;
        private System.Windows.Forms.TextBox textBoxDuration;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonFindRating;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox ClassiesMovieListBox;
    }
}

namespace Programming2.View.Panels
{
    partial class RectanglesCollisionControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RectanglesCollisionControl));
            this.label12 = new System.Windows.Forms.Label();
            this.AddRectangleButton = new System.Windows.Forms.Button();
            this.DeleteRectangleButton = new System.Windows.Forms.Button();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.RectanglesLabel = new System.Windows.Forms.Label();
            this.RectanglesPanel = new System.Windows.Forms.Panel();
            this.TextBoxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxX = new System.Windows.Forms.TextBox();
            this.TextBoxY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxRectanglesWidth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxHeight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 291);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "SelectedRectangle:";
            // 
            // AddRectangleButton
            // 
            this.AddRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRectangleButton.ForeColor = System.Drawing.SystemColors.Window;
            this.AddRectangleButton.Image = ((System.Drawing.Image)(resources.GetObject("AddRectangleButton.Image")));
            this.AddRectangleButton.Location = new System.Drawing.Point(49, 241);
            this.AddRectangleButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddRectangleButton.Name = "AddRectangleButton";
            this.AddRectangleButton.Size = new System.Drawing.Size(55, 40);
            this.AddRectangleButton.TabIndex = 19;
            this.AddRectangleButton.UseVisualStyleBackColor = true;
            this.AddRectangleButton.Click += new System.EventHandler(this.AddRectangleButton_Click);
            // 
            // DeleteRectangleButton
            // 
            this.DeleteRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteRectangleButton.ForeColor = System.Drawing.SystemColors.Window;
            this.DeleteRectangleButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteRectangleButton.Image")));
            this.DeleteRectangleButton.Location = new System.Drawing.Point(187, 241);
            this.DeleteRectangleButton.Margin = new System.Windows.Forms.Padding(0);
            this.DeleteRectangleButton.Name = "DeleteRectangleButton";
            this.DeleteRectangleButton.Size = new System.Drawing.Size(55, 40);
            this.DeleteRectangleButton.TabIndex = 15;
            this.DeleteRectangleButton.UseVisualStyleBackColor = true;
            this.DeleteRectangleButton.Click += new System.EventHandler(this.DeleteRectangleButton_Click);
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.Location = new System.Drawing.Point(6, 30);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(314, 199);
            this.RectanglesListBox.TabIndex = 18;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // RectanglesLabel
            // 
            this.RectanglesLabel.AutoSize = true;
            this.RectanglesLabel.Location = new System.Drawing.Point(3, 14);
            this.RectanglesLabel.Name = "RectanglesLabel";
            this.RectanglesLabel.Size = new System.Drawing.Size(64, 13);
            this.RectanglesLabel.TabIndex = 17;
            this.RectanglesLabel.Text = "Rectangles:";
            // 
            // RectanglesPanel
            // 
            this.RectanglesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RectanglesPanel.BackColor = System.Drawing.Color.PapayaWhip;
            this.RectanglesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RectanglesPanel.Location = new System.Drawing.Point(338, 32);
            this.RectanglesPanel.Name = "RectanglesPanel";
            this.RectanglesPanel.Size = new System.Drawing.Size(447, 436);
            this.RectanglesPanel.TabIndex = 16;
            // 
            // TextBoxID
            // 
            this.TextBoxID.Location = new System.Drawing.Point(50, 311);
            this.TextBoxID.Name = "TextBoxID";
            this.TextBoxID.Size = new System.Drawing.Size(100, 20);
            this.TextBoxID.TabIndex = 21;
            this.TextBoxID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxDisable);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "X:";
            // 
            // TextBoxX
            // 
            this.TextBoxX.Location = new System.Drawing.Point(49, 333);
            this.TextBoxX.Name = "TextBoxX";
            this.TextBoxX.Size = new System.Drawing.Size(100, 20);
            this.TextBoxX.TabIndex = 24;
            this.TextBoxX.TextChanged += new System.EventHandler(this.TextBoxRectanglesX_TextChanged);
            // 
            // TextBoxY
            // 
            this.TextBoxY.Location = new System.Drawing.Point(49, 356);
            this.TextBoxY.Name = "TextBoxY";
            this.TextBoxY.Size = new System.Drawing.Size(100, 20);
            this.TextBoxY.TabIndex = 25;
            this.TextBoxY.TextChanged += new System.EventHandler(this.TextBoxRectanglesY_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Y:";
            // 
            // TextBoxRectanglesWidth
            // 
            this.TextBoxRectanglesWidth.Location = new System.Drawing.Point(49, 378);
            this.TextBoxRectanglesWidth.Name = "TextBoxRectanglesWidth";
            this.TextBoxRectanglesWidth.Size = new System.Drawing.Size(100, 20);
            this.TextBoxRectanglesWidth.TabIndex = 27;
            this.TextBoxRectanglesWidth.TextChanged += new System.EventHandler(this.TextBoxRectanglesWidth_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Width:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Height:";
            // 
            // TextBoxHeight
            // 
            this.TextBoxHeight.Location = new System.Drawing.Point(49, 398);
            this.TextBoxHeight.Name = "TextBoxHeight";
            this.TextBoxHeight.Size = new System.Drawing.Size(100, 20);
            this.TextBoxHeight.TabIndex = 30;
            this.TextBoxHeight.TextChanged += new System.EventHandler(this.TextBoxRectanglesHeight_TextChanged);
            // 
            // RectanglesCollisionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TextBoxHeight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBoxRectanglesWidth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxY);
            this.Controls.Add(this.TextBoxX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.AddRectangleButton);
            this.Controls.Add(this.DeleteRectangleButton);
            this.Controls.Add(this.RectanglesListBox);
            this.Controls.Add(this.RectanglesLabel);
            this.Controls.Add(this.RectanglesPanel);
            this.Name = "RectanglesCollisionControl";
            this.Size = new System.Drawing.Size(814, 490);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button AddRectangleButton;
        private System.Windows.Forms.Button DeleteRectangleButton;
        private System.Windows.Forms.ListBox RectanglesListBox;
        private System.Windows.Forms.Label RectanglesLabel;
        private System.Windows.Forms.Panel RectanglesPanel;
        private System.Windows.Forms.TextBox TextBoxID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxX;
        private System.Windows.Forms.TextBox TextBoxY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxRectanglesWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBoxHeight;
    }
}

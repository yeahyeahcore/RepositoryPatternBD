
namespace _18
{
    partial class AddChangeTrForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SexBox = new System.Windows.Forms.TextBox();
            this.BirthDayBox = new System.Windows.Forms.TextBox();
            this.PNameBox = new System.Windows.Forms.TextBox();
            this.LNameBox = new System.Windows.Forms.TextBox();
            this.FNameBox = new System.Windows.Forms.TextBox();
            this.RatingBox = new System.Windows.Forms.ComboBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.CityBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SexBox
            // 
            this.SexBox.Location = new System.Drawing.Point(109, 110);
            this.SexBox.MaxLength = 20;
            this.SexBox.Name = "SexBox";
            this.SexBox.Size = new System.Drawing.Size(121, 20);
            this.SexBox.TabIndex = 0;
            // 
            // BirthDayBox
            // 
            this.BirthDayBox.Location = new System.Drawing.Point(109, 136);
            this.BirthDayBox.MaxLength = 4;
            this.BirthDayBox.Name = "BirthDayBox";
            this.BirthDayBox.Size = new System.Drawing.Size(121, 20);
            this.BirthDayBox.TabIndex = 1;
            this.BirthDayBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BirthDay_KeyPress);
            // 
            // PNameBox
            // 
            this.PNameBox.Location = new System.Drawing.Point(109, 84);
            this.PNameBox.MaxLength = 20;
            this.PNameBox.Name = "PNameBox";
            this.PNameBox.Size = new System.Drawing.Size(121, 20);
            this.PNameBox.TabIndex = 3;
            // 
            // LNameBox
            // 
            this.LNameBox.Location = new System.Drawing.Point(109, 58);
            this.LNameBox.MaxLength = 20;
            this.LNameBox.Name = "LNameBox";
            this.LNameBox.Size = new System.Drawing.Size(121, 20);
            this.LNameBox.TabIndex = 4;
            // 
            // FNameBox
            // 
            this.FNameBox.Location = new System.Drawing.Point(109, 32);
            this.FNameBox.MaxLength = 20;
            this.FNameBox.Name = "FNameBox";
            this.FNameBox.Size = new System.Drawing.Size(121, 20);
            this.FNameBox.TabIndex = 5;
            // 
            // RatingBox
            // 
            this.RatingBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RatingBox.FormattingEnabled = true;
            this.RatingBox.Location = new System.Drawing.Point(109, 188);
            this.RatingBox.Name = "RatingBox";
            this.RatingBox.Size = new System.Drawing.Size(121, 21);
            this.RatingBox.TabIndex = 6;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SaveButton.Location = new System.Drawing.Point(12, 223);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Location = new System.Drawing.Point(170, 223);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CityBox
            // 
            this.CityBox.Location = new System.Drawing.Point(109, 162);
            this.CityBox.MaxLength = 20;
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(121, 20);
            this.CityBox.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Город";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Год рождения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Пол";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Отчество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Рэйтинг";
            // 
            // AddChangeTrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 257);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CityBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.RatingBox);
            this.Controls.Add(this.FNameBox);
            this.Controls.Add(this.LNameBox);
            this.Controls.Add(this.PNameBox);
            this.Controls.Add(this.BirthDayBox);
            this.Controls.Add(this.SexBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddChangeTrForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SexBox;
        private System.Windows.Forms.TextBox BirthDayBox;
        private System.Windows.Forms.TextBox PNameBox;
        private System.Windows.Forms.TextBox LNameBox;
        private System.Windows.Forms.TextBox FNameBox;
        private System.Windows.Forms.ComboBox RatingBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox CityBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
namespace _18
{
    partial class MenuSport
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
            this.components = new System.ComponentModel.Container();
            this.TrenerGrid = new System.Windows.Forms.DataGridView();
            this.AddSMButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.SportsManGrid = new System.Windows.Forms.DataGridView();
            this.AddTrButton = new System.Windows.Forms.Button();
            this.ChangeSM = new System.Windows.Forms.Button();
            this.RemoveTR = new System.Windows.Forms.Button();
            this.countButton = new System.Windows.Forms.Button();
            this.trCountButton = new System.Windows.Forms.Button();
            this.SelectNotAllSMButton = new System.Windows.Forms.Button();
            this.trenerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TrenerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SportsManGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trenerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TrenerGrid
            // 
            this.TrenerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TrenerGrid.Location = new System.Drawing.Point(550, 12);
            this.TrenerGrid.Name = "TrenerGrid";
            this.TrenerGrid.Size = new System.Drawing.Size(485, 483);
            this.TrenerGrid.TabIndex = 1;
            // 
            // AddSMButton
            // 
            this.AddSMButton.Location = new System.Drawing.Point(12, 563);
            this.AddSMButton.Name = "AddSMButton";
            this.AddSMButton.Size = new System.Drawing.Size(146, 38);
            this.AddSMButton.TabIndex = 2;
            this.AddSMButton.Text = "Добавить Спортсмена";
            this.AddSMButton.UseVisualStyleBackColor = true;
            this.AddSMButton.Click += new System.EventHandler(this.AddSMButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(739, 563);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(137, 39);
            this.UpdateButton.TabIndex = 3;
            this.UpdateButton.Text = "Изменить элемент таблицы тренеров";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(329, 563);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(153, 38);
            this.RemoveButton.TabIndex = 4;
            this.RemoveButton.Text = "Удалить элемент таблицы со спортсменами";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // SportsManGrid
            // 
            this.SportsManGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SportsManGrid.Location = new System.Drawing.Point(12, 12);
            this.SportsManGrid.Name = "SportsManGrid";
            this.SportsManGrid.Size = new System.Drawing.Size(532, 483);
            this.SportsManGrid.TabIndex = 0;
            // 
            // AddTrButton
            // 
            this.AddTrButton.Location = new System.Drawing.Point(580, 563);
            this.AddTrButton.Name = "AddTrButton";
            this.AddTrButton.Size = new System.Drawing.Size(153, 39);
            this.AddTrButton.TabIndex = 5;
            this.AddTrButton.Text = "Добавить Тренера";
            this.AddTrButton.UseVisualStyleBackColor = true;
            this.AddTrButton.Click += new System.EventHandler(this.AddTrButton_Click);
            // 
            // ChangeSM
            // 
            this.ChangeSM.Location = new System.Drawing.Point(164, 563);
            this.ChangeSM.Name = "ChangeSM";
            this.ChangeSM.Size = new System.Drawing.Size(159, 38);
            this.ChangeSM.TabIndex = 6;
            this.ChangeSM.Text = "Изменить элемент таблицы спортсменов";
            this.ChangeSM.UseVisualStyleBackColor = true;
            this.ChangeSM.Click += new System.EventHandler(this.ChangeSM_Click);
            // 
            // RemoveTR
            // 
            this.RemoveTR.Location = new System.Drawing.Point(882, 563);
            this.RemoveTR.Name = "RemoveTR";
            this.RemoveTR.Size = new System.Drawing.Size(153, 38);
            this.RemoveTR.TabIndex = 7;
            this.RemoveTR.Text = "Удалить элемент таблицы с тренерами";
            this.RemoveTR.UseVisualStyleBackColor = true;
            this.RemoveTR.Click += new System.EventHandler(this.RemoveTR_Click);
            // 
            // countButton
            // 
            this.countButton.Location = new System.Drawing.Point(12, 519);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(146, 38);
            this.countButton.TabIndex = 8;
            this.countButton.Text = "Подсчитать количество спортсменов";
            this.countButton.UseVisualStyleBackColor = true;
            this.countButton.Click += new System.EventHandler(this.countButton_Click);
            // 
            // trCountButton
            // 
            this.trCountButton.Location = new System.Drawing.Point(580, 519);
            this.trCountButton.Name = "trCountButton";
            this.trCountButton.Size = new System.Drawing.Size(153, 38);
            this.trCountButton.TabIndex = 9;
            this.trCountButton.Text = "Подсчитать количество тренеров";
            this.trCountButton.UseVisualStyleBackColor = true;
            this.trCountButton.Click += new System.EventHandler(this.trCountButton_Click);
            // 
            // SelectNotAllSMButton
            // 
            this.SelectNotAllSMButton.Location = new System.Drawing.Point(164, 519);
            this.SelectNotAllSMButton.Name = "SelectNotAllSMButton";
            this.SelectNotAllSMButton.Size = new System.Drawing.Size(159, 38);
            this.SelectNotAllSMButton.TabIndex = 10;
            this.SelectNotAllSMButton.Text = "Вывести определённых спортсменов";
            this.SelectNotAllSMButton.UseVisualStyleBackColor = true;
            this.SelectNotAllSMButton.Click += new System.EventHandler(this.SelectNotAllSMButton_Click);
            // 
            // trenerBindingSource
            // 
            this.trenerBindingSource.DataSource = typeof(_18.Trener);
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(329, 537);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(153, 20);
            this.cityBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 521);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Город";
            // 
            // MenuSport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 613);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.SelectNotAllSMButton);
            this.Controls.Add(this.trCountButton);
            this.Controls.Add(this.countButton);
            this.Controls.Add(this.RemoveTR);
            this.Controls.Add(this.ChangeSM);
            this.Controls.Add(this.AddTrButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AddSMButton);
            this.Controls.Add(this.TrenerGrid);
            this.Controls.Add(this.SportsManGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MenuSport";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TrenerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SportsManGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trenerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView TrenerGrid;
        private System.Windows.Forms.Button AddSMButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.DataGridView SportsManGrid;
        private System.Windows.Forms.BindingSource trenerBindingSource;
        private System.Windows.Forms.Button AddTrButton;
        private System.Windows.Forms.Button ChangeSM;
        private System.Windows.Forms.Button RemoveTR;
        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.Button trCountButton;
        private System.Windows.Forms.Button SelectNotAllSMButton;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.Label label1;
    }
}


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuSport));
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.countButton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.stripButton1 = new System.Windows.Forms.ToolStripButton();
            this.stripButton2 = new System.Windows.Forms.ToolStripButton();
            this.trenerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FilterButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.diagramButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trenerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 508);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(114, 38);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(12, 552);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(114, 38);
            this.RemoveButton.TabIndex = 4;
            this.RemoveButton.Text = "Удалить элемент таблицы";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(12, 57);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(1023, 438);
            this.dataGrid.TabIndex = 0;
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(130, 508);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(115, 38);
            this.ChangeButton.TabIndex = 6;
            this.ChangeButton.Text = "Изменить элемент таблицы";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // countButton
            // 
            this.countButton.Location = new System.Drawing.Point(130, 552);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(115, 38);
            this.countButton.TabIndex = 8;
            this.countButton.Text = "Подсчитать количество";
            this.countButton.UseVisualStyleBackColor = true;
            this.countButton.Click += new System.EventHandler(this.countButton_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripButton1,
            this.stripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1047, 25);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // stripButton1
            // 
            this.stripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.stripButton1.Image = ((System.Drawing.Image)(resources.GetObject("stripButton1.Image")));
            this.stripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stripButton1.Name = "stripButton1";
            this.stripButton1.Size = new System.Drawing.Size(82, 22);
            this.stripButton1.Text = "Спортсмены";
            this.stripButton1.ToolTipText = "Спортсмены";
            this.stripButton1.Click += new System.EventHandler(this.stripButton1_Click);
            // 
            // stripButton2
            // 
            this.stripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.stripButton2.Image = ((System.Drawing.Image)(resources.GetObject("stripButton2.Image")));
            this.stripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stripButton2.Name = "stripButton2";
            this.stripButton2.Size = new System.Drawing.Size(60, 22);
            this.stripButton2.Text = "Тренеры";
            this.stripButton2.ToolTipText = "Тренеры";
            this.stripButton2.Click += new System.EventHandler(this.stripButton2_Click);
            // 
            // trenerBindingSource
            // 
            this.trenerBindingSource.DataSource = typeof(_18.Trener);
            // 
            // FilterButton
            // 
            this.FilterButton.Location = new System.Drawing.Point(892, 552);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(143, 38);
            this.FilterButton.TabIndex = 15;
            this.FilterButton.Text = "Поиск данных";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(892, 509);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(143, 37);
            this.reportButton.TabIndex = 16;
            this.reportButton.Text = "Отчёт";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // diagramButton
            // 
            this.diagramButton.Location = new System.Drawing.Point(744, 552);
            this.diagramButton.Name = "diagramButton";
            this.diagramButton.Size = new System.Drawing.Size(142, 38);
            this.diagramButton.TabIndex = 17;
            this.diagramButton.Text = "Диаграмма";
            this.diagramButton.UseVisualStyleBackColor = true;
            this.diagramButton.Click += new System.EventHandler(this.diagramButton_Click);
            // 
            // MenuSport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 599);
            this.Controls.Add(this.diagramButton);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.countButton);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.dataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MenuSport";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trenerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.BindingSource trenerBindingSource;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton stripButton1;
        private System.Windows.Forms.ToolStripButton stripButton2;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Button diagramButton;
    }
}


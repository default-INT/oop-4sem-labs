namespace WindowsFormsEventPlanning
{
    partial class Form1
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
            this.header = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.outputButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.headerListEventLable = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.MondayCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TuesdayCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WednesdayCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThursdayCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FridayCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaturdayCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SundayCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.outputButtonDate = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.dateTimeEntry = new System.Windows.Forms.DateTimePicker();
            this.nameLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.header.Location = new System.Drawing.Point(12, 118);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(334, 53);
            this.header.TabIndex = 0;
            this.header.Text = "Главное меню";
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.menuButton.FlatAppearance.BorderSize = 0;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuButton.Location = new System.Drawing.Point(25, 23);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(219, 67);
            this.menuButton.TabIndex = 2;
            this.menuButton.Text = "МЕНЮ";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addButton.Location = new System.Drawing.Point(267, 23);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(251, 67);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "ДОБАВИТЬ";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteButton.Location = new System.Drawing.Point(537, 23);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(251, 67);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "УДАЛИТЬ";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(624, 127);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 3;
            this.monthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.Calendar_DateSelect);
            // 
            // outputButton
            // 
            this.outputButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.outputButton.FlatAppearance.BorderSize = 0;
            this.outputButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outputButton.Font = new System.Drawing.Font("Impact", 20F);
            this.outputButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.outputButton.Location = new System.Drawing.Point(352, 127);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(251, 44);
            this.outputButton.TabIndex = 2;
            this.outputButton.Text = "ВЫВОД";
            this.outputButton.UseVisualStyleBackColor = false;
            this.outputButton.Click += new System.EventHandler(this.OutputButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(60, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Мероприятия";
            // 
            // headerListEventLable
            // 
            this.headerListEventLable.AutoSize = true;
            this.headerListEventLable.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerListEventLable.Location = new System.Drawing.Point(39, 180);
            this.headerListEventLable.Name = "headerListEventLable";
            this.headerListEventLable.Size = new System.Drawing.Size(532, 25);
            this.headerListEventLable.TabIndex = 5;
            this.headerListEventLable.Text = "Вывести даты проведения указаного мероприятия";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MondayCol,
            this.TuesdayCol,
            this.WednesdayCol,
            this.ThursdayCol,
            this.FridayCol,
            this.SaturdayCol,
            this.SundayCol});
            this.dataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView.Location = new System.Drawing.Point(21, 400);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 14F);
            this.dataGridView.RowTemplate.ReadOnly = true;
            this.dataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.Size = new System.Drawing.Size(746, 78);
            this.dataGridView.TabIndex = 6;
            // 
            // MondayCol
            // 
            this.MondayCol.HeaderText = "Понедельник";
            this.MondayCol.Name = "MondayCol";
            this.MondayCol.ReadOnly = true;
            // 
            // TuesdayCol
            // 
            this.TuesdayCol.HeaderText = "Вторник";
            this.TuesdayCol.Name = "TuesdayCol";
            this.TuesdayCol.ReadOnly = true;
            // 
            // WednesdayCol
            // 
            this.WednesdayCol.HeaderText = "Среда";
            this.WednesdayCol.Name = "WednesdayCol";
            this.WednesdayCol.ReadOnly = true;
            // 
            // ThursdayCol
            // 
            this.ThursdayCol.HeaderText = "Четверг";
            this.ThursdayCol.Name = "ThursdayCol";
            this.ThursdayCol.ReadOnly = true;
            // 
            // FridayCol
            // 
            this.FridayCol.HeaderText = "Пятница";
            this.FridayCol.Name = "FridayCol";
            this.FridayCol.ReadOnly = true;
            // 
            // SaturdayCol
            // 
            this.SaturdayCol.HeaderText = "Суббота";
            this.SaturdayCol.Name = "SaturdayCol";
            this.SaturdayCol.ReadOnly = true;
            // 
            // SundayCol
            // 
            this.SundayCol.HeaderText = "Воскресенье";
            this.SundayCol.Name = "SundayCol";
            this.SundayCol.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "D:\\Other\\GSTU\\semester_4\\OOP\\Lab_6\\WindowsFormsEventPlanning\\Properties\\image\\foo" +
    "ter.jpg";
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(-6, -15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(817, 130);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // outputButtonDate
            // 
            this.outputButtonDate.BackColor = System.Drawing.Color.CadetBlue;
            this.outputButtonDate.FlatAppearance.BorderSize = 0;
            this.outputButtonDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outputButtonDate.Font = new System.Drawing.Font("Impact", 12F);
            this.outputButtonDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.outputButtonDate.Location = new System.Drawing.Point(286, 345);
            this.outputButtonDate.Name = "outputButtonDate";
            this.outputButtonDate.Size = new System.Drawing.Size(71, 30);
            this.outputButtonDate.TabIndex = 2;
            this.outputButtonDate.Text = "ВЫВОД";
            this.outputButtonDate.UseVisualStyleBackColor = false;
            this.outputButtonDate.Click += new System.EventHandler(this.OutputDateButton_Click);
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Arial", 10F);
            this.nameBox.Location = new System.Drawing.Point(157, 275);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(200, 23);
            this.nameBox.TabIndex = 7;
            // 
            // dateTimeEntry
            // 
            this.dateTimeEntry.Font = new System.Drawing.Font("Arial", 10F);
            this.dateTimeEntry.Location = new System.Drawing.Point(157, 311);
            this.dateTimeEntry.Name = "dateTimeEntry";
            this.dateTimeEntry.Size = new System.Drawing.Size(200, 23);
            this.dateTimeEntry.TabIndex = 8;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(39, 276);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(98, 22);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Название:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLabel.Location = new System.Drawing.Point(39, 312);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(56, 22);
            this.dateLabel.TabIndex = 4;
            this.dateLabel.Text = "Дата:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.dateTimeEntry);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.headerListEventLable);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.outputButtonDate);
            this.Controls.Add(this.outputButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.header);
            this.Name = "Form1";
            this.Text = "Планирование мероприятий";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Button outputButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label headerListEventLable;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn MondayCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TuesdayCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn WednesdayCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThursdayCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FridayCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaturdayCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SundayCol;
        private System.Windows.Forms.Button outputButtonDate;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.DateTimePicker dateTimeEntry;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label dateLabel;
    }
}


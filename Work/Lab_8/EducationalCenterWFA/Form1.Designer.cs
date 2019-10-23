namespace EducationalCenterWFA
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прочитатьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьРабочегоToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.функцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вывестиВсехУчащихсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вывестиВсехРаботающихToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вывестиВсеСпискиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отсортироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияОДвоюшниковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентыСПовышеннойСтипендиейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.msgLabel = new System.Windows.Forms.Label();
            this.schoolComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.функцииToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(630, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.прочитатьФайлToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.добавитьРабочегоToolStripMenuItem1,
            this.удалитьToolStripMenuItem1});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 19);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // прочитатьФайлToolStripMenuItem
            // 
            this.прочитатьФайлToolStripMenuItem.Name = "прочитатьФайлToolStripMenuItem";
            this.прочитатьФайлToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.прочитатьФайлToolStripMenuItem.Text = "Прочитать файл";
            this.прочитатьФайлToolStripMenuItem.Click += new System.EventHandler(this.OpenFileDialog_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.удалитьToolStripMenuItem.Text = "Добавить учащегося";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.AddLearner_Click);
            // 
            // добавитьРабочегоToolStripMenuItem1
            // 
            this.добавитьРабочегоToolStripMenuItem1.Name = "добавитьРабочегоToolStripMenuItem1";
            this.добавитьРабочегоToolStripMenuItem1.Size = new System.Drawing.Size(189, 22);
            this.добавитьРабочегоToolStripMenuItem1.Text = "Добавить рабочего";
            this.добавитьРабочегоToolStripMenuItem1.Click += new System.EventHandler(this.AddWorker_Click);
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(189, 22);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            this.удалитьToolStripMenuItem1.Click += new System.EventHandler(this.DeleteHuman_Click);
            // 
            // функцииToolStripMenuItem
            // 
            this.функцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вывестиВсехУчащихсяToolStripMenuItem,
            this.вывестиВсехРаботающихToolStripMenuItem,
            this.вывестиВсеСпискиToolStripMenuItem,
            this.отсортироватьToolStripMenuItem,
            this.информацияОДвоюшниковToolStripMenuItem,
            this.студентыСПовышеннойСтипендиейToolStripMenuItem});
            this.функцииToolStripMenuItem.Name = "функцииToolStripMenuItem";
            this.функцииToolStripMenuItem.Size = new System.Drawing.Size(68, 19);
            this.функцииToolStripMenuItem.Text = "Функции";
            // 
            // вывестиВсехУчащихсяToolStripMenuItem
            // 
            this.вывестиВсехУчащихсяToolStripMenuItem.Name = "вывестиВсехУчащихсяToolStripMenuItem";
            this.вывестиВсехУчащихсяToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.вывестиВсехУчащихсяToolStripMenuItem.Text = "Вывести всех учащихся";
            this.вывестиВсехУчащихсяToolStripMenuItem.Click += new System.EventHandler(this.ShowLearners_Click);
            // 
            // вывестиВсехРаботающихToolStripMenuItem
            // 
            this.вывестиВсехРаботающихToolStripMenuItem.Name = "вывестиВсехРаботающихToolStripMenuItem";
            this.вывестиВсехРаботающихToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.вывестиВсехРаботающихToolStripMenuItem.Text = "Вывести всех работающих";
            this.вывестиВсехРаботающихToolStripMenuItem.Click += new System.EventHandler(this.ShowWorkers_Click);
            // 
            // вывестиВсеСпискиToolStripMenuItem
            // 
            this.вывестиВсеСпискиToolStripMenuItem.Name = "вывестиВсеСпискиToolStripMenuItem";
            this.вывестиВсеСпискиToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.вывестиВсеСпискиToolStripMenuItem.Text = "Вывести все списки";
            this.вывестиВсеСпискиToolStripMenuItem.Click += new System.EventHandler(this.ShowAllHumans_Click);
            // 
            // отсортироватьToolStripMenuItem
            // 
            this.отсортироватьToolStripMenuItem.Name = "отсортироватьToolStripMenuItem";
            this.отсортироватьToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.отсортироватьToolStripMenuItem.Text = "Отсортировать по алфавиту";
            this.отсортироватьToolStripMenuItem.Click += new System.EventHandler(this.HumansSort_Click);
            // 
            // информацияОДвоюшниковToolStripMenuItem
            // 
            this.информацияОДвоюшниковToolStripMenuItem.Name = "информацияОДвоюшниковToolStripMenuItem";
            this.информацияОДвоюшниковToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.информацияОДвоюшниковToolStripMenuItem.Text = "Информация о двоечников";
            this.информацияОДвоюшниковToolStripMenuItem.Click += new System.EventHandler(this.InfoBadSchoolboy_Click);
            // 
            // студентыСПовышеннойСтипендиейToolStripMenuItem
            // 
            this.студентыСПовышеннойСтипендиейToolStripMenuItem.Name = "студентыСПовышеннойСтипендиейToolStripMenuItem";
            this.студентыСПовышеннойСтипендиейToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.студентыСПовышеннойСтипендиейToolStripMenuItem.Text = "Студенты с повышенной стипендией";
            this.студентыСПовышеннойСтипендиейToolStripMenuItem.Click += new System.EventHandler(this.GoodStudent_Click);
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.Location = new System.Drawing.Point(18, 102);
            this.panel.Margin = new System.Windows.Forms.Padding(4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(599, 469);
            this.panel.TabIndex = 1;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 16F);
            this.titleLabel.Location = new System.Drawing.Point(15, 60);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(348, 25);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Список всех рабочих и учащихся";
            // 
            // msgLabel
            // 
            this.msgLabel.AutoSize = true;
            this.msgLabel.Location = new System.Drawing.Point(17, 587);
            this.msgLabel.Name = "msgLabel";
            this.msgLabel.Size = new System.Drawing.Size(0, 18);
            this.msgLabel.TabIndex = 3;
            // 
            // schoolComboBox
            // 
            this.schoolComboBox.Enabled = false;
            this.schoolComboBox.FormattingEnabled = true;
            this.schoolComboBox.Location = new System.Drawing.Point(496, 28);
            this.schoolComboBox.Name = "schoolComboBox";
            this.schoolComboBox.Size = new System.Drawing.Size(121, 26);
            this.schoolComboBox.TabIndex = 4;
            this.schoolComboBox.SelectedValueChanged += new System.EventHandler(this.SchoolComboBox_Selected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(432, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Школа:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(630, 624);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.schoolComboBox);
            this.Controls.Add(this.msgLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form_Activated);
            this.Load += new System.EventHandler(this.Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прочитатьФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьРабочегоToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label msgLabel;
        private System.Windows.Forms.ToolStripMenuItem функцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вывестиВсехУчащихсяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вывестиВсехРаботающихToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вывестиВсеСпискиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отсортироватьToolStripMenuItem;
        private System.Windows.Forms.ComboBox schoolComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem информацияОДвоюшниковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентыСПовышеннойСтипендиейToolStripMenuItem;
    }
}


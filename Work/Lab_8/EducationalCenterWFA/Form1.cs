using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EducationalCenter;

namespace EducationalCenterWFA
{
    public partial class Form1 : Form
    {
        EduCenter eduCenter;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            try
            {
                eduCenter = new EduCenter("D:\\Other\\GSTU\\semester_4\\OOP\\Work\\Lab_8\\human.txt");
                RefreshData();
            }
            catch
            {
                msgLabel.Text = "Неудалось прочитать файл";
            }
        }

        private void OpenFileDialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.Cancel) return;
            string way = openFileDialog.FileName;
            eduCenter.ReadToFile(way);
            RefreshData();
        }

        private void RefreshData()
        {
            schoolComboBox.Enabled = false;
            msgLabel.Text = "";
            Human[] humans = eduCenter.GetHumans();
            int height = 20;
            panel.Controls.Clear();

            foreach (Human human in humans)
            {
                Label rowLable = new Label();
                rowLable.Width = panel.Width - 30;
                rowLable.Font = new Font("Arial", 16);

                if (DateTime.Now.Year - human.bithdayYear > 12 && human is Schoolboy)
                    rowLable.ForeColor = Color.Yellow;

                rowLable.Text = human.InfoHuman();
                rowLable.Location = new Point(10, height);
                panel.Controls.Add(rowLable);
                height += 30;
            }

        }

        private void ShowAllInfoLearners(ref Learner[] humans)
        {
            msgLabel.Text = "";
            int height = 20;
            panel.Controls.Clear();

            foreach (Human human in humans)
            {
                Label rowLable = new Label();
                rowLable.Width = panel.Width - 30;
                rowLable.Font = new Font("Arial", 16);
                rowLable.Height = 150;

                rowLable.Text = human.ToString();
                rowLable.Text += "\n___________________________________________";
                rowLable.Location = new Point(10, height);
                panel.Controls.Add(rowLable);
                height += 160;
            }
        }

        private void ShowAllInfoWorkers(ref Worker[] humans)
        {
            msgLabel.Text = "";
            int height = 20;
            panel.Controls.Clear();

            foreach (Human human in humans)
            {
                Label rowLable = new Label();
                rowLable.Width = panel.Width - 30;
                rowLable.Font = new Font("Arial", 16);
                rowLable.Height = 150;

                rowLable.Text = human.ToString();
                rowLable.Text += "\n___________________________________________";
                rowLable.Location = new Point(10, height);
                panel.Controls.Add(rowLable);
                height += 160;
            }
        }

        private void AddLearner_Click(object sender, EventArgs e)
        {
            AddLearnerForm addLearnerForm = new AddLearnerForm(ref eduCenter);
            addLearnerForm.Show();
        }

        private void Form_Activated(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void AddWorker_Click(object sender, EventArgs e)
        {
            AddWorkerForm addWorkerForm = new AddWorkerForm(ref eduCenter);
            addWorkerForm.Show();
        }

        private void HumansSort_Click(object sender, EventArgs e)
        {
            eduCenter.SortHumans();
        }

        private void ShowAllHumans_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void ShowLearners_Click(object sender, EventArgs e)
        {
            schoolComboBox.Enabled = false;
            Learner[] learners = eduCenter.GetLearners();
            titleLabel.Text = "Список всех учащихся";
            ShowAllInfoLearners(ref learners);

        }

        private void ShowWorkers_Click(object sender, EventArgs e)
        {
            schoolComboBox.Enabled = false;
            Worker[] workers = eduCenter.GetWorkers();
            titleLabel.Text = "Список всех работающих";
            ShowAllInfoWorkers(ref workers);
        }

        private void InfoBadSchoolboy_Click(object sender, EventArgs e)
        {
            schoolComboBox.Enabled = true;
            panel.Controls.Clear();
            titleLabel.Text = "Выберите школу ...";
            string[] schools = eduCenter.GetSchoolName();

            schoolComboBox.Items.Clear();
            foreach (string school in schools)
                schoolComboBox.Items.Add(school);
        }

        private void SchoolComboBox_Selected(object sender, EventArgs e)
        {
            string school = schoolComboBox.SelectedItem.ToString();
            Learner[] learner = eduCenter.GetBadSchoolboys(school);
            titleLabel.Text = "Информация о всех двоечников в \"" + school + "\"";
            msgLabel.Text = "Количество двоечников в данной шокле: " + learner.Length;
            ShowAllInfoLearners(ref learner);
        }

        private void GoodStudent_Click(object sender, EventArgs e)
        {
            schoolComboBox.Enabled = false;
            titleLabel.Text = "Список студентов претендующх на повышенную стипендию";
            Learner[] learners = eduCenter.GetGoodStudents();
            ShowAllInfoLearners(ref learners);
        }

        private void DeleteHuman_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm(ref eduCenter);
            deleteForm.Show();
        }
    }
}

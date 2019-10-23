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
    public partial class AddLearnerForm : Form
    {
        EduCenter eduCenter;

        public AddLearnerForm(ref EduCenter eduCenter)
        {
            InitializeComponent();
            this.eduCenter = eduCenter;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                Status status = EduCenter.GetStatus(statusComboBox.Text);

                if (status == Status.Student)
                    eduCenter.AddHuman(new Student(
                        fullnameTextBox.Text, Convert.ToInt32(yearTextBox.Text),
                        status, nameOfInstTextBox.Text, numTextBox.Text,
                        EduCenter.ParseArr(marksTextBox.Text)));
                else
                    eduCenter.AddHuman(new Schoolboy(
                        fullnameTextBox.Text, Convert.ToInt32(yearTextBox.Text), status,
                        nameOfInstTextBox.Text, Convert.ToInt32(numTextBox.Text),
                        EduCenter.ParseArr(marksTextBox.Text)));
                msgLabel.ForeColor = Color.Green;
                msgLabel.Text = "Учащейся успешно добавлен.";
            }
            catch
            {
                msgLabel.ForeColor = Color.Red;
                msgLabel.Text = "Неудалось добавить учащегося";
            }
        }
    }
}

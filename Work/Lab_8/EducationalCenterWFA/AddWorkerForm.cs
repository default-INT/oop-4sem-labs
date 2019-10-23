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
    public partial class AddWorkerForm : Form
    {
        EduCenter eduCenter;

        public AddWorkerForm(ref EduCenter eduCenter)
        {
            InitializeComponent();
            this.eduCenter = eduCenter;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                Status status = EduCenter.GetStatus(statusComboBox.Text);

                eduCenter.AddHuman(new Worker(fullnameTextBox.Text,
                    Convert.ToInt32(yearTextBox.Text), status, placeOfWorkTextBox.Text,
                    postTextBox.Text, EduCenter.ParseArr(salaryTextBox.Text)));

                msgLabel.ForeColor = Color.Green;
                msgLabel.Text = "Работающий успешно добавлен.";
            }
            catch
            {
                msgLabel.ForeColor = Color.Red;
                msgLabel.Text = "Неудалось добавить работающего.";
            }
            
        }

        private void AddWorkerForm_Load(object sender, EventArgs e)
        {

        }
    }
}

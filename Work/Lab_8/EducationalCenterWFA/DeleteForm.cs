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
    public partial class DeleteForm : Form
    {
        EduCenter eduCenter;

        public DeleteForm(ref EduCenter eduCenter)
        {
            InitializeComponent();
            this.eduCenter = eduCenter;
        }

        private void RefreshList()
        {
            string[] names = eduCenter.GetFullnames();
            humansComboBox.Items.Clear();

            foreach (string name in names)
            {
                humansComboBox.Items.Add(name);
            }
        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                eduCenter.DeleteHuman(humansComboBox.Text);
                msgLabel.ForeColor = Color.Green;
                msgLabel.Text = "Человек был успешно удалён.";
                RefreshList();
            }
            catch
            {
                msgLabel.ForeColor = Color.Red;
                msgLabel.Text = "Не удалось провести удаление...";
            }
        }
    }
}

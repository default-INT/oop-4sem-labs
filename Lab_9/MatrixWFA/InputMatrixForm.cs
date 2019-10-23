using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MatrixException;

namespace MatrixWFA
{
    public partial class InputMatrixForm : Form
    {
        public int[,] matrix;

        public InputMatrixForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string str = inMatrixRichTextBox.Text.Split('\n')[0];
            try
            {
                matrix = ParseTextToMatrix(inMatrixRichTextBox.Text);
                msgLabel.ForeColor = Color.FromName("Green");
                msgLabel.Text = "Матрица успешно прочитана.";
            }
            catch (Exception ex)
            {
                msgLabel.ForeColor = Color.FromName("Red");
                msgLabel.Text = ex.Message;
            }
            
        }

        private int[,] ParseTextToMatrix(string str)
        {
            string[] lines = str.Split('\n');
            int m = lines.Length;
            int n = lines[0].Split().Length;
            int[,] matrix = new int[m, n];
            
            for (int i = 0; i < lines.Length; i++)
            {
                string[] line = lines[i].Split();
                if (n != line.Length) throw new IncorrectMatrixException("Невверный формат матрицы.");

                for (int j = 0; j < line.Length; j++)
                {
                    matrix[i, j] = Convert.ToInt32(line[j]);
                }
            }
           
            
            return matrix;
        }
    }
}

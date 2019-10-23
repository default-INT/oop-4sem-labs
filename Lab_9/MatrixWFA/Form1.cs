using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MatrixClassLibrary;
using MatrixException;

namespace MatrixWFA
{
    public partial class Form1 : Form
    {
        int[,] matrixA = null;
        int[,] matrixB = null;
        int[,] matrixC = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void RefreshData()
        {
            if (matrixA != null)
            {
                matrixALable.Text = "";
                for (int i = 0; i < matrixA.GetUpperBound(0) + 1; i++)
                {
                    for (int j = 0; j < matrixA.GetUpperBound(1) + 1; j++)
                    {
                        matrixALable.Text += matrixA[i, j] + " ";
                    }
                    matrixALable.Text += "\n";
                }
            }
            if (matrixB != null)
            {
                matrixBLable.Text = "";
                for (int i = 0; i < matrixB.GetUpperBound(0) + 1; i++)
                {
                    for (int j = 0; j < matrixB.GetUpperBound(1) + 1; j++)
                    {
                        matrixBLable.Text += matrixB[i, j] + " ";
                    }
                    matrixBLable.Text += "\n";
                }
            }
        }

        private void RefreshMatrixC()
        {
            msgLable.Text = "";
            if (matrixC != null)
            {
                matrixCLable.Text = "";
                for (int i = 0; i < matrixC.GetUpperBound(0) + 1; i++)
                {
                    for (int j = 0; j < matrixC.GetUpperBound(1) + 1; j++)
                    {
                        matrixCLable.Text += matrixC[i, j] + " ";
                    }
                    matrixCLable.Text += "\n";
                }
            }
        }

        private void InputBMatrixButton_Click(object sender, EventArgs e)
        {
            InputMatrixForm inputMatrixForm = new InputMatrixForm();
            inputMatrixForm.ShowDialog();
            matrixB = inputMatrixForm.matrix;
            RefreshData();
        }

        private void InputAMatrixButton_Click(object sender, EventArgs e)
        {
            InputMatrixForm inputMatrixForm = new InputMatrixForm();
            inputMatrixForm.ShowDialog();
            matrixA = inputMatrixForm.matrix;
            RefreshData();
        }

        private void sumABButton_Click(object sender, EventArgs e)
        {
            try
            {
                matrixC = Matrix.sumMatrix(matrixA, matrixB);
                RefreshMatrixC();
            }
            catch (DimensionMismatchException ex)
            {
                msgLable.ForeColor = Color.FromName("Red");
                msgLable.Text = ex.Message;
            }
            catch
            {
                msgLable.ForeColor = Color.FromName("Red");
                msgLable.Text = "Вы не ввели матрицу.";
            }
        }

        private void SubMatrixCButton_Click(object sender, EventArgs e)
        {
            try
            {
                matrixC = Matrix.subMatrix(matrixA, matrixB);
                RefreshMatrixC();
            }
            catch (DimensionMismatchException ex)
            {
                msgLable.ForeColor = Color.FromName("Red");
                msgLable.Text = ex.Message;
            }
            catch
            {
                msgLable.ForeColor = Color.FromName("Red");
                msgLable.Text = "Вы не ввели матрицу.";
            }
        }

        private void ProdMatrixButton_Click(object sender, EventArgs e)
        {
            try
            {
                matrixC = Matrix.prodMatrix(matrixA, matrixB);
                RefreshMatrixC();
            }
            catch (WrongMultiplicationException ex)
            {
                msgLable.ForeColor = Color.FromName("Red");
                msgLable.Text = ex.Message;
            }
            catch
            {
                msgLable.ForeColor = Color.FromName("Red");
                msgLable.Text = "Вы не ввели матрицу.";
            }
            
        }

        private void ProdMatrixOnNumButton_Click(object sender, EventArgs e)
        {
            if (inputCTextBox.Text.Length > 0)
            {
                try
                {
                    int c = Convert.ToInt32(inputCTextBox.Text);
                    matrixC = Matrix.prodMatrix(matrixA, c);
                    RefreshMatrixC();
                }
                catch (FormatException ex)
                {
                    msgLable.ForeColor = Color.FromName("Red");
                    msgLable.Text = ex.Message;
                }
                catch
                {
                    msgLable.ForeColor = Color.FromName("Red");
                    msgLable.Text = "Вы не ввели матрицу А";
                }
                

            }
            else
            {
                msgLable.ForeColor = Color.FromName("Red");
                msgLable.Text = "Вы не ввели число с.";
            }
            
        }
    }
}

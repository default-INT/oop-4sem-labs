namespace MatrixWFA
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputAMatrixButton = new System.Windows.Forms.Button();
            this.inputBMatrixButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inputCTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sumABButton = new System.Windows.Forms.Button();
            this.subMatrixCButton = new System.Windows.Forms.Button();
            this.prodMatrixButton = new System.Windows.Forms.Button();
            this.prodMatrixOnNumButton = new System.Windows.Forms.Button();
            this.matrixALable = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.matrixBLable = new System.Windows.Forms.Label();
            this.msgLable = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.matrixCLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "ОПЕРАЦИИ НАД\r\nМАТРИЦАМИ";
            // 
            // inputAMatrixButton
            // 
            this.inputAMatrixButton.BackColor = System.Drawing.Color.Indigo;
            this.inputAMatrixButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputAMatrixButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.inputAMatrixButton.Location = new System.Drawing.Point(331, 12);
            this.inputAMatrixButton.Name = "inputAMatrixButton";
            this.inputAMatrixButton.Size = new System.Drawing.Size(228, 39);
            this.inputAMatrixButton.TabIndex = 1;
            this.inputAMatrixButton.Text = "Ввести матрицу А";
            this.inputAMatrixButton.UseVisualStyleBackColor = false;
            this.inputAMatrixButton.Click += new System.EventHandler(this.InputAMatrixButton_Click);
            // 
            // inputBMatrixButton
            // 
            this.inputBMatrixButton.BackColor = System.Drawing.Color.Indigo;
            this.inputBMatrixButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputBMatrixButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.inputBMatrixButton.Location = new System.Drawing.Point(331, 57);
            this.inputBMatrixButton.Name = "inputBMatrixButton";
            this.inputBMatrixButton.Size = new System.Drawing.Size(228, 39);
            this.inputBMatrixButton.TabIndex = 1;
            this.inputBMatrixButton.Text = "Ввести матрицу B";
            this.inputBMatrixButton.UseVisualStyleBackColor = false;
            this.inputBMatrixButton.Click += new System.EventHandler(this.InputBMatrixButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16F);
            this.label2.Location = new System.Drawing.Point(29, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "C=A+B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 16F);
            this.label3.Location = new System.Drawing.Point(29, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "C=A-B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 16F);
            this.label4.Location = new System.Drawing.Point(29, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "C=A*B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 16F);
            this.label5.Location = new System.Drawing.Point(29, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "C=A*c";
            // 
            // inputCTextBox
            // 
            this.inputCTextBox.Font = new System.Drawing.Font("Arial", 16F);
            this.inputCTextBox.Location = new System.Drawing.Point(157, 310);
            this.inputCTextBox.Name = "inputCTextBox";
            this.inputCTextBox.Size = new System.Drawing.Size(100, 32);
            this.inputCTextBox.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 16F);
            this.label6.Location = new System.Drawing.Point(29, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Введите c:";
            // 
            // sumABButton
            // 
            this.sumABButton.BackColor = System.Drawing.Color.Indigo;
            this.sumABButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumABButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sumABButton.Location = new System.Drawing.Point(119, 122);
            this.sumABButton.Name = "sumABButton";
            this.sumABButton.Size = new System.Drawing.Size(163, 39);
            this.sumABButton.TabIndex = 1;
            this.sumABButton.Text = "Вычислить";
            this.sumABButton.UseVisualStyleBackColor = false;
            this.sumABButton.Click += new System.EventHandler(this.sumABButton_Click);
            // 
            // subMatrixCButton
            // 
            this.subMatrixCButton.BackColor = System.Drawing.Color.Indigo;
            this.subMatrixCButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subMatrixCButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.subMatrixCButton.Location = new System.Drawing.Point(119, 167);
            this.subMatrixCButton.Name = "subMatrixCButton";
            this.subMatrixCButton.Size = new System.Drawing.Size(163, 39);
            this.subMatrixCButton.TabIndex = 1;
            this.subMatrixCButton.Text = "Вычислить";
            this.subMatrixCButton.UseVisualStyleBackColor = false;
            this.subMatrixCButton.Click += new System.EventHandler(this.SubMatrixCButton_Click);
            // 
            // prodMatrixButton
            // 
            this.prodMatrixButton.BackColor = System.Drawing.Color.Indigo;
            this.prodMatrixButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prodMatrixButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.prodMatrixButton.Location = new System.Drawing.Point(119, 210);
            this.prodMatrixButton.Name = "prodMatrixButton";
            this.prodMatrixButton.Size = new System.Drawing.Size(163, 39);
            this.prodMatrixButton.TabIndex = 1;
            this.prodMatrixButton.Text = "Вычислить";
            this.prodMatrixButton.UseVisualStyleBackColor = false;
            this.prodMatrixButton.Click += new System.EventHandler(this.ProdMatrixButton_Click);
            // 
            // prodMatrixOnNumButton
            // 
            this.prodMatrixOnNumButton.BackColor = System.Drawing.Color.Indigo;
            this.prodMatrixOnNumButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prodMatrixOnNumButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.prodMatrixOnNumButton.Location = new System.Drawing.Point(119, 252);
            this.prodMatrixOnNumButton.Name = "prodMatrixOnNumButton";
            this.prodMatrixOnNumButton.Size = new System.Drawing.Size(163, 39);
            this.prodMatrixOnNumButton.TabIndex = 1;
            this.prodMatrixOnNumButton.Text = "Вычислить";
            this.prodMatrixOnNumButton.UseVisualStyleBackColor = false;
            this.prodMatrixOnNumButton.Click += new System.EventHandler(this.ProdMatrixOnNumButton_Click);
            // 
            // matrixALable
            // 
            this.matrixALable.AutoSize = true;
            this.matrixALable.Font = new System.Drawing.Font("Arial", 16F);
            this.matrixALable.Location = new System.Drawing.Point(326, 136);
            this.matrixALable.Name = "matrixALable";
            this.matrixALable.Size = new System.Drawing.Size(24, 25);
            this.matrixALable.TabIndex = 2;
            this.matrixALable.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 16F);
            this.label7.Location = new System.Drawing.Point(316, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Матрица А:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 16F);
            this.label8.Location = new System.Drawing.Point(506, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Матрица В:";
            // 
            // matrixBLable
            // 
            this.matrixBLable.AutoSize = true;
            this.matrixBLable.Font = new System.Drawing.Font("Arial", 16F);
            this.matrixBLable.Location = new System.Drawing.Point(517, 136);
            this.matrixBLable.Name = "matrixBLable";
            this.matrixBLable.Size = new System.Drawing.Size(24, 25);
            this.matrixBLable.TabIndex = 2;
            this.matrixBLable.Text = "0";
            // 
            // msgLable
            // 
            this.msgLable.AutoSize = true;
            this.msgLable.Font = new System.Drawing.Font("Arial", 16F);
            this.msgLable.Location = new System.Drawing.Point(293, 313);
            this.msgLable.Name = "msgLable";
            this.msgLable.Size = new System.Drawing.Size(0, 25);
            this.msgLable.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 16F);
            this.label9.Location = new System.Drawing.Point(704, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Матрица C:";
            // 
            // matrixCLable
            // 
            this.matrixCLable.AutoSize = true;
            this.matrixCLable.Font = new System.Drawing.Font("Arial", 16F);
            this.matrixCLable.Location = new System.Drawing.Point(715, 136);
            this.matrixCLable.Name = "matrixCLable";
            this.matrixCLable.Size = new System.Drawing.Size(24, 25);
            this.matrixCLable.TabIndex = 2;
            this.matrixCLable.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(957, 426);
            this.Controls.Add(this.inputCTextBox);
            this.Controls.Add(this.msgLable);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.matrixCLable);
            this.Controls.Add(this.matrixBLable);
            this.Controls.Add(this.matrixALable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prodMatrixOnNumButton);
            this.Controls.Add(this.prodMatrixButton);
            this.Controls.Add(this.subMatrixCButton);
            this.Controls.Add(this.sumABButton);
            this.Controls.Add(this.inputBMatrixButton);
            this.Controls.Add(this.inputAMatrixButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button inputAMatrixButton;
        private System.Windows.Forms.Button inputBMatrixButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputCTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button sumABButton;
        private System.Windows.Forms.Button subMatrixCButton;
        private System.Windows.Forms.Button prodMatrixButton;
        private System.Windows.Forms.Button prodMatrixOnNumButton;
        private System.Windows.Forms.Label matrixALable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label matrixBLable;
        private System.Windows.Forms.Label msgLable;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label matrixCLable;
    }
}


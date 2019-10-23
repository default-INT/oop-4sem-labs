namespace PolygonsWFA
{
    partial class AddPolygonForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.sidesTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.msgLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите размеры сторон:";
            // 
            // sidesTextBox
            // 
            this.sidesTextBox.Font = new System.Drawing.Font("Arial", 14F);
            this.sidesTextBox.Location = new System.Drawing.Point(257, 30);
            this.sidesTextBox.Name = "sidesTextBox";
            this.sidesTextBox.Size = new System.Drawing.Size(204, 29);
            this.sidesTextBox.TabIndex = 1;
            this.sidesTextBox.TextChanged += new System.EventHandler(this.sidesTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F);
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Введите цвет:";
            // 
            // colorTextBox
            // 
            this.colorTextBox.Font = new System.Drawing.Font("Arial", 14F);
            this.colorTextBox.Location = new System.Drawing.Point(257, 76);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(204, 29);
            this.colorTextBox.TabIndex = 1;
            this.colorTextBox.TextChanged += new System.EventHandler(this.sidesTextBox_TextChanged);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Arial", 24F);
            this.addButton.Location = new System.Drawing.Point(140, 164);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(181, 43);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // msgLabel
            // 
            this.msgLabel.AutoSize = true;
            this.msgLabel.Font = new System.Drawing.Font("Arial", 10F);
            this.msgLabel.Location = new System.Drawing.Point(40, 129);
            this.msgLabel.Name = "msgLabel";
            this.msgLabel.Size = new System.Drawing.Size(0, 16);
            this.msgLabel.TabIndex = 3;
            // 
            // AddPolygonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 254);
            this.Controls.Add(this.msgLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.colorTextBox);
            this.Controls.Add(this.sidesTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddPolygonForm";
            this.Text = "AddPolygonForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sidesTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label msgLabel;
    }
}
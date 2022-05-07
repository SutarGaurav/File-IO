
namespace FileIOHomework.May062022
{
    partial class ProductForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.btnBinaryWrite = new System.Windows.Forms.Button();
            this.btnBinaryRead = new System.Windows.Forms.Button();
            this.btnSoapWrite = new System.Windows.Forms.Button();
            this.btnSoapRead = new System.Windows.Forms.Button();
            this.btnXmlWrite = new System.Windows.Forms.Button();
            this.btnXmlRead = new System.Windows.Forms.Button();
            this.btnJsonWrite = new System.Windows.Forms.Button();
            this.btnJsonRead = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(49, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(49, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(49, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(49, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Category";
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Cursor = System.Windows.Forms.Cursors.No;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(163, 37);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(275, 28);
            this.txtId.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(163, 82);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(275, 35);
            this.txtName.TabIndex = 5;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(163, 125);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(275, 35);
            this.txtPrice.TabIndex = 6;
            // 
            // txtCategory
            // 
            this.txtCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategory.Location = new System.Drawing.Point(163, 172);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(275, 35);
            this.txtCategory.TabIndex = 7;
            // 
            // btnBinaryWrite
            // 
            this.btnBinaryWrite.BackColor = System.Drawing.Color.White;
            this.btnBinaryWrite.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBinaryWrite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBinaryWrite.ForeColor = System.Drawing.Color.Black;
            this.btnBinaryWrite.Location = new System.Drawing.Point(480, 32);
            this.btnBinaryWrite.Name = "btnBinaryWrite";
            this.btnBinaryWrite.Size = new System.Drawing.Size(110, 40);
            this.btnBinaryWrite.TabIndex = 8;
            this.btnBinaryWrite.Text = "Binary Write";
            this.btnBinaryWrite.UseVisualStyleBackColor = false;
            // 
            // btnBinaryRead
            // 
            this.btnBinaryRead.BackColor = System.Drawing.Color.White;
            this.btnBinaryRead.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBinaryRead.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBinaryRead.ForeColor = System.Drawing.Color.Black;
            this.btnBinaryRead.Location = new System.Drawing.Point(608, 32);
            this.btnBinaryRead.Name = "btnBinaryRead";
            this.btnBinaryRead.Size = new System.Drawing.Size(110, 40);
            this.btnBinaryRead.TabIndex = 9;
            this.btnBinaryRead.Text = "Binary Read";
            this.btnBinaryRead.UseVisualStyleBackColor = false;
            // 
            // btnSoapWrite
            // 
            this.btnSoapWrite.BackColor = System.Drawing.Color.White;
            this.btnSoapWrite.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSoapWrite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSoapWrite.ForeColor = System.Drawing.Color.Black;
            this.btnSoapWrite.Location = new System.Drawing.Point(480, 77);
            this.btnSoapWrite.Name = "btnSoapWrite";
            this.btnSoapWrite.Size = new System.Drawing.Size(110, 40);
            this.btnSoapWrite.TabIndex = 10;
            this.btnSoapWrite.Text = "Soap Write";
            this.btnSoapWrite.UseVisualStyleBackColor = false;
            // 
            // btnSoapRead
            // 
            this.btnSoapRead.BackColor = System.Drawing.Color.White;
            this.btnSoapRead.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSoapRead.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSoapRead.ForeColor = System.Drawing.Color.Black;
            this.btnSoapRead.Location = new System.Drawing.Point(608, 77);
            this.btnSoapRead.Name = "btnSoapRead";
            this.btnSoapRead.Size = new System.Drawing.Size(110, 40);
            this.btnSoapRead.TabIndex = 11;
            this.btnSoapRead.Text = "Soap Read";
            this.btnSoapRead.UseVisualStyleBackColor = false;
            // 
            // btnXmlWrite
            // 
            this.btnXmlWrite.BackColor = System.Drawing.Color.White;
            this.btnXmlWrite.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnXmlWrite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnXmlWrite.ForeColor = System.Drawing.Color.Black;
            this.btnXmlWrite.Location = new System.Drawing.Point(480, 122);
            this.btnXmlWrite.Name = "btnXmlWrite";
            this.btnXmlWrite.Size = new System.Drawing.Size(110, 40);
            this.btnXmlWrite.TabIndex = 12;
            this.btnXmlWrite.Text = "XML Write";
            this.btnXmlWrite.UseVisualStyleBackColor = false;
            // 
            // btnXmlRead
            // 
            this.btnXmlRead.BackColor = System.Drawing.Color.White;
            this.btnXmlRead.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnXmlRead.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnXmlRead.ForeColor = System.Drawing.Color.Black;
            this.btnXmlRead.Location = new System.Drawing.Point(608, 122);
            this.btnXmlRead.Name = "btnXmlRead";
            this.btnXmlRead.Size = new System.Drawing.Size(110, 40);
            this.btnXmlRead.TabIndex = 13;
            this.btnXmlRead.Text = "XML Read";
            this.btnXmlRead.UseVisualStyleBackColor = false;
            // 
            // btnJsonWrite
            // 
            this.btnJsonWrite.BackColor = System.Drawing.Color.White;
            this.btnJsonWrite.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnJsonWrite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnJsonWrite.ForeColor = System.Drawing.Color.Black;
            this.btnJsonWrite.Location = new System.Drawing.Point(480, 167);
            this.btnJsonWrite.Name = "btnJsonWrite";
            this.btnJsonWrite.Size = new System.Drawing.Size(110, 40);
            this.btnJsonWrite.TabIndex = 14;
            this.btnJsonWrite.Text = "JSon Write";
            this.btnJsonWrite.UseVisualStyleBackColor = false;
            // 
            // btnJsonRead
            // 
            this.btnJsonRead.BackColor = System.Drawing.Color.White;
            this.btnJsonRead.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnJsonRead.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnJsonRead.ForeColor = System.Drawing.Color.Black;
            this.btnJsonRead.Location = new System.Drawing.Point(608, 167);
            this.btnJsonRead.Name = "btnJsonRead";
            this.btnJsonRead.Size = new System.Drawing.Size(110, 40);
            this.btnJsonRead.TabIndex = 15;
            this.btnJsonRead.Text = "JSon Read";
            this.btnJsonRead.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(54, 225);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 213);
            this.panel1.TabIndex = 17;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(779, 481);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnJsonRead);
            this.Controls.Add(this.btnJsonWrite);
            this.Controls.Add(this.btnXmlRead);
            this.Controls.Add(this.btnXmlWrite);
            this.Controls.Add(this.btnSoapRead);
            this.Controls.Add(this.btnSoapWrite);
            this.Controls.Add(this.btnBinaryRead);
            this.Controls.Add(this.btnBinaryWrite);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Name = "ProductForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Button btnBinaryWrite;
        private System.Windows.Forms.Button btnBinaryRead;
        private System.Windows.Forms.Button btnSoapWrite;
        private System.Windows.Forms.Button btnSoapRead;
        private System.Windows.Forms.Button btnXmlWrite;
        private System.Windows.Forms.Button btnXmlRead;
        private System.Windows.Forms.Button btnJsonWrite;
        private System.Windows.Forms.Button btnJsonRead;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
    }
}
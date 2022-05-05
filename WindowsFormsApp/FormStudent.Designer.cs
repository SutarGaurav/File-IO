
namespace WindowsFormsApp
{
    partial class FormStudent
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
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnCreateFolder = new System.Windows.Forms.Button();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblRollNo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPerc = new System.Windows.Forms.Label();
            this.lblStream = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtRollNo = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStream = new System.Windows.Forms.TextBox();
            this.txtPerc = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnWrite
            // 
            this.btnWrite.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnWrite.Location = new System.Drawing.Point(120, 352);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(87, 38);
            this.btnWrite.TabIndex = 5;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = false;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRead.Location = new System.Drawing.Point(279, 352);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(87, 38);
            this.btnRead.TabIndex = 6;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = false;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnCreateFolder
            // 
            this.btnCreateFolder.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCreateFolder.Location = new System.Drawing.Point(120, 413);
            this.btnCreateFolder.Name = "btnCreateFolder";
            this.btnCreateFolder.Size = new System.Drawing.Size(148, 38);
            this.btnCreateFolder.TabIndex = 8;
            this.btnCreateFolder.Text = "Create Folder";
            this.btnCreateFolder.UseVisualStyleBackColor = false;
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCreateFile.Location = new System.Drawing.Point(120, 470);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(120, 38);
            this.btnCreateFile.TabIndex = 9;
            this.btnCreateFile.Text = "Create File";
            this.btnCreateFile.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClear.Location = new System.Drawing.Point(436, 352);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 38);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblRollNo
            // 
            this.lblRollNo.AutoSize = true;
            this.lblRollNo.Location = new System.Drawing.Point(115, 51);
            this.lblRollNo.Name = "lblRollNo";
            this.lblRollNo.Size = new System.Drawing.Size(79, 25);
            this.lblRollNo.TabIndex = 11;
            this.lblRollNo.Text = "Roll No.";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(115, 107);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 25);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Name";
            // 
            // lblPerc
            // 
            this.lblPerc.AutoSize = true;
            this.lblPerc.Location = new System.Drawing.Point(115, 163);
            this.lblPerc.Name = "lblPerc";
            this.lblPerc.Size = new System.Drawing.Size(112, 25);
            this.lblPerc.TabIndex = 13;
            this.lblPerc.Text = "Percentage";
            // 
            // lblStream
            // 
            this.lblStream.AutoSize = true;
            this.lblStream.Location = new System.Drawing.Point(115, 221);
            this.lblStream.Name = "lblStream";
            this.lblStream.Size = new System.Drawing.Size(75, 25);
            this.lblStream.TabIndex = 14;
            this.lblStream.Text = "Stream";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(115, 282);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(46, 25);
            this.lblCity.TabIndex = 15;
            this.lblCity.Text = "City";
            // 
            // txtRollNo
            // 
            this.txtRollNo.BackColor = System.Drawing.Color.White;
            this.txtRollNo.Location = new System.Drawing.Point(279, 51);
            this.txtRollNo.Name = "txtRollNo";
            this.txtRollNo.Size = new System.Drawing.Size(244, 30);
            this.txtRollNo.TabIndex = 0;
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.Color.White;
            this.txtCity.Location = new System.Drawing.Point(279, 282);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(244, 30);
            this.txtCity.TabIndex = 4;
            // 
            // txtStream
            // 
            this.txtStream.BackColor = System.Drawing.Color.White;
            this.txtStream.Location = new System.Drawing.Point(279, 221);
            this.txtStream.Name = "txtStream";
            this.txtStream.Size = new System.Drawing.Size(244, 30);
            this.txtStream.TabIndex = 3;
            // 
            // txtPerc
            // 
            this.txtPerc.BackColor = System.Drawing.Color.White;
            this.txtPerc.Location = new System.Drawing.Point(279, 163);
            this.txtPerc.Name = "txtPerc";
            this.txtPerc.Size = new System.Drawing.Size(244, 30);
            this.txtPerc.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(279, 107);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(244, 30);
            this.txtName.TabIndex = 1;
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(660, 572);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPerc);
            this.Controls.Add(this.txtStream);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtRollNo);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblStream);
            this.Controls.Add(this.lblPerc);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblRollNo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCreateFile);
            this.Controls.Add(this.btnCreateFolder);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnWrite);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormStudent";
            this.Opacity = 0.98D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnCreateFolder;
        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblRollNo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPerc;
        private System.Windows.Forms.Label lblStream;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtRollNo;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtStream;
        private System.Windows.Forms.TextBox txtPerc;
        private System.Windows.Forms.TextBox txtName;
    }
}
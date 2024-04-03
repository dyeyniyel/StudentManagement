namespace StudentManagement
{
    partial class editForm
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
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnShowAllStudents = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtSem = new System.Windows.Forms.TextBox();
            this.lblSem = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(106, 72);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(233, 20);
            this.txtid.TabIndex = 22;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // btnShowAllStudents
            // 
            this.btnShowAllStudents.Location = new System.Drawing.Point(62, 301);
            this.btnShowAllStudents.Name = "btnShowAllStudents";
            this.btnShowAllStudents.Size = new System.Drawing.Size(277, 23);
            this.btnShowAllStudents.TabIndex = 21;
            this.btnShowAllStudents.Text = "Show All Students";
            this.btnShowAllStudents.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(62, 256);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(277, 23);
            this.btnSubmit.TabIndex = 20;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtSem
            // 
            this.txtSem.Location = new System.Drawing.Point(106, 219);
            this.txtSem.Name = "txtSem";
            this.txtSem.Size = new System.Drawing.Size(233, 20);
            this.txtSem.TabIndex = 19;
            // 
            // lblSem
            // 
            this.lblSem.AutoSize = true;
            this.lblSem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblSem.Location = new System.Drawing.Point(59, 222);
            this.lblSem.Name = "lblSem";
            this.lblSem.Size = new System.Drawing.Size(34, 13);
            this.lblSem.TabIndex = 18;
            this.lblSem.Text = "Sem: ";
            this.lblSem.UseMnemonic = false;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(106, 183);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(233, 20);
            this.txtPhone.TabIndex = 17;
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblPhoneNum.Location = new System.Drawing.Point(59, 186);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(44, 13);
            this.lblPhoneNum.TabIndex = 16;
            this.lblPhoneNum.Text = "Phone: ";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(106, 144);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(233, 20);
            this.txtAddress.TabIndex = 15;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblAddress.Location = new System.Drawing.Point(59, 147);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(51, 13);
            this.lblAddress.TabIndex = 14;
            this.lblAddress.Text = "Address: ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(106, 108);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(233, 20);
            this.txtName.TabIndex = 13;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblName.Location = new System.Drawing.Point(59, 111);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Name: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Location = new System.Drawing.Point(59, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Id: ";
            // 
            // editForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btnShowAllStudents);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtSem);
            this.Controls.Add(this.lblSem);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhoneNum);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "editForm";
            this.Text = "editForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnShowAllStudents;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtSem;
        private System.Windows.Forms.Label lblSem;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhoneNum;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
    }
}

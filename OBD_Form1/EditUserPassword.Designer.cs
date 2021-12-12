namespace HotelAdmin
{
    partial class EditUserPassword
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEditPasswordUser = new System.Windows.Forms.Button();
            this.txtPassword2User = new System.Windows.Forms.TextBox();
            this.txtPassword1User = new System.Windows.Forms.TextBox();
            this.cmbNameUser = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(332, 261);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(220, 90);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Вихід";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEditPasswordUser
            // 
            this.btnEditPasswordUser.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditPasswordUser.Location = new System.Drawing.Point(39, 261);
            this.btnEditPasswordUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditPasswordUser.Name = "btnEditPasswordUser";
            this.btnEditPasswordUser.Size = new System.Drawing.Size(217, 90);
            this.btnEditPasswordUser.TabIndex = 14;
            this.btnEditPasswordUser.Text = "Змінити";
            this.btnEditPasswordUser.UseVisualStyleBackColor = true;
            this.btnEditPasswordUser.Click += new System.EventHandler(this.btnEditPasswordUser_Click);
            // 
            // txtPassword2User
            // 
            this.txtPassword2User.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassword2User.Location = new System.Drawing.Point(373, 174);
            this.txtPassword2User.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword2User.Name = "txtPassword2User";
            this.txtPassword2User.Size = new System.Drawing.Size(179, 38);
            this.txtPassword2User.TabIndex = 13;
            this.txtPassword2User.UseSystemPasswordChar = true;
            // 
            // txtPassword1User
            // 
            this.txtPassword1User.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassword1User.Location = new System.Drawing.Point(373, 100);
            this.txtPassword1User.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword1User.Name = "txtPassword1User";
            this.txtPassword1User.Size = new System.Drawing.Size(179, 38);
            this.txtPassword1User.TabIndex = 12;
            this.txtPassword1User.UseSystemPasswordChar = true;
            // 
            // cmbNameUser
            // 
            this.cmbNameUser.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cmbNameUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNameUser.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbNameUser.FormattingEnabled = true;
            this.cmbNameUser.Location = new System.Drawing.Point(373, 32);
            this.cmbNameUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbNameUser.Name = "cmbNameUser";
            this.cmbNameUser.Size = new System.Drawing.Size(179, 35);
            this.cmbNameUser.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(21, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 27);
            this.label3.TabIndex = 10;
            this.label3.Text = "Підтвердження паролю";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 27);
            this.label2.TabIndex = 9;
            this.label2.Text = "Новий пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "Користувач";
            // 
            // EditUserPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(599, 445);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEditPasswordUser);
            this.Controls.Add(this.txtPassword2User);
            this.Controls.Add(this.txtPassword1User);
            this.Controls.Add(this.cmbNameUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EditUserPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Зміна паролю користувача";
            this.Load += new System.EventHandler(this.EditUserPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEditPasswordUser;
        private System.Windows.Forms.TextBox txtPassword2User;
        private System.Windows.Forms.TextBox txtPassword1User;
        private System.Windows.Forms.ComboBox cmbNameUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
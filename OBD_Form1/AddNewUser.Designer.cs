namespace HotelAdmin
{
    partial class AddNewUser
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
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.txtPassword2User = new System.Windows.Forms.TextBox();
            this.txtPassword1User = new System.Windows.Forms.TextBox();
            this.txtTypeUser = new System.Windows.Forms.TextBox();
            this.txtNameUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(302, 253);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(205, 84);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Вихід";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddNewUser.Location = new System.Drawing.Point(23, 253);
            this.btnAddNewUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(217, 84);
            this.btnAddNewUser.TabIndex = 18;
            this.btnAddNewUser.Text = "Додати";
            this.btnAddNewUser.UseVisualStyleBackColor = true;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // txtPassword2User
            // 
            this.txtPassword2User.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassword2User.Location = new System.Drawing.Point(302, 162);
            this.txtPassword2User.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword2User.Name = "txtPassword2User";
            this.txtPassword2User.Size = new System.Drawing.Size(205, 35);
            this.txtPassword2User.TabIndex = 17;
            this.txtPassword2User.UseSystemPasswordChar = true;
            // 
            // txtPassword1User
            // 
            this.txtPassword1User.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassword1User.Location = new System.Drawing.Point(302, 117);
            this.txtPassword1User.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword1User.Name = "txtPassword1User";
            this.txtPassword1User.Size = new System.Drawing.Size(205, 35);
            this.txtPassword1User.TabIndex = 16;
            this.txtPassword1User.UseSystemPasswordChar = true;
            // 
            // txtTypeUser
            // 
            this.txtTypeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTypeUser.Location = new System.Drawing.Point(302, 71);
            this.txtTypeUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTypeUser.Name = "txtTypeUser";
            this.txtTypeUser.Size = new System.Drawing.Size(205, 35);
            this.txtTypeUser.TabIndex = 15;
            this.txtTypeUser.Leave += new System.EventHandler(this.txtTypeUser_Leave);
            // 
            // txtNameUser
            // 
            this.txtNameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNameUser.Location = new System.Drawing.Point(302, 30);
            this.txtNameUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNameUser.Name = "txtNameUser";
            this.txtNameUser.Size = new System.Drawing.Size(205, 35);
            this.txtNameUser.TabIndex = 14;
            this.txtNameUser.Leave += new System.EventHandler(this.txtNameUser_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(10, 168);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(288, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "Підтвердження паролю";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Тип доступу";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Користувач";
            // 
            // AddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(571, 402);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.txtPassword2User);
            this.Controls.Add(this.txtPassword1User);
            this.Controls.Add(this.txtTypeUser);
            this.Controls.Add(this.txtNameUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddNewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додати нового користувача";
            this.Load += new System.EventHandler(this.AddNewUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.TextBox txtPassword2User;
        private System.Windows.Forms.TextBox txtPassword1User;
        private System.Windows.Forms.TextBox txtTypeUser;
        private System.Windows.Forms.TextBox txtNameUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
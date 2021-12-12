namespace HotelAdmin
{
    partial class EditUserType
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
            this.btnEditTypeUser = new System.Windows.Forms.Button();
            this.cmbTypeUser = new System.Windows.Forms.ComboBox();
            this.cmbNameUser = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(264, 240);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(159, 84);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Вихід";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEditTypeUser
            // 
            this.btnEditTypeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditTypeUser.Location = new System.Drawing.Point(77, 240);
            this.btnEditTypeUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditTypeUser.Name = "btnEditTypeUser";
            this.btnEditTypeUser.Size = new System.Drawing.Size(155, 84);
            this.btnEditTypeUser.TabIndex = 10;
            this.btnEditTypeUser.Text = "Змінити";
            this.btnEditTypeUser.UseVisualStyleBackColor = true;
            this.btnEditTypeUser.Click += new System.EventHandler(this.btnEditTypeUser_Click);
            // 
            // cmbTypeUser
            // 
            this.cmbTypeUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbTypeUser.FormattingEnabled = true;
            this.cmbTypeUser.Location = new System.Drawing.Point(264, 167);
            this.cmbTypeUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbTypeUser.Name = "cmbTypeUser";
            this.cmbTypeUser.Size = new System.Drawing.Size(153, 37);
            this.cmbTypeUser.TabIndex = 9;
            // 
            // cmbNameUser
            // 
            this.cmbNameUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbNameUser.FormattingEnabled = true;
            this.cmbNameUser.Location = new System.Drawing.Point(264, 97);
            this.cmbNameUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbNameUser.Name = "cmbNameUser";
            this.cmbNameUser.Size = new System.Drawing.Size(153, 37);
            this.cmbNameUser.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(72, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Тип доступу ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(85, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Користувач";
            // 
            // EditUserType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(571, 405);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEditTypeUser);
            this.Controls.Add(this.cmbTypeUser);
            this.Controls.Add(this.cmbNameUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EditUserType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Зміна типу користувача";
            this.Load += new System.EventHandler(this.EditUserType_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEditTypeUser;
        private System.Windows.Forms.ComboBox cmbTypeUser;
        private System.Windows.Forms.ComboBox cmbNameUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
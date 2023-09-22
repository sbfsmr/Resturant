
namespace Resturant
{
    partial class New_User
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.rePassword = new System.Windows.Forms.TextBox();
            this.FName = new System.Windows.Forms.TextBox();
            this.LName = new System.Windows.Forms.TextBox();
            this.HintAns = new System.Windows.Forms.TextBox();
            this.cmbHintQues = new System.Windows.Forms.ComboBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Retype Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "First Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Hint Question";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Hint Answer";
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(224, 42);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(229, 28);
            this.UserName.TabIndex = 1;
            this.UserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValidation);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(224, 87);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(229, 28);
            this.Password.TabIndex = 1;
            this.Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValidation);
            // 
            // rePassword
            // 
            this.rePassword.Location = new System.Drawing.Point(224, 131);
            this.rePassword.Name = "rePassword";
            this.rePassword.PasswordChar = '*';
            this.rePassword.Size = new System.Drawing.Size(229, 28);
            this.rePassword.TabIndex = 1;
            this.rePassword.TextChanged += new System.EventHandler(this.New_User_Load);
            this.rePassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValidation);
            this.rePassword.Leave += new System.EventHandler(this.rePassword_Leave);
            // 
            // FName
            // 
            this.FName.Location = new System.Drawing.Point(224, 174);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(229, 28);
            this.FName.TabIndex = 1;
            this.FName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValidation);
            // 
            // LName
            // 
            this.LName.Location = new System.Drawing.Point(224, 217);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(229, 28);
            this.LName.TabIndex = 1;
            this.LName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValidation);
            // 
            // HintAns
            // 
            this.HintAns.Location = new System.Drawing.Point(224, 305);
            this.HintAns.Name = "HintAns";
            this.HintAns.Size = new System.Drawing.Size(229, 28);
            this.HintAns.TabIndex = 1;
            // 
            // cmbHintQues
            // 
            this.cmbHintQues.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHintQues.FormattingEnabled = true;
            this.cmbHintQues.Location = new System.Drawing.Point(224, 261);
            this.cmbHintQues.Name = "cmbHintQues";
            this.cmbHintQues.Size = new System.Drawing.Size(229, 30);
            this.cmbHintQues.TabIndex = 2;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(49, 383);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(103, 43);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(194, 383);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 43);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(350, 383);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 43);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // New_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 465);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.cmbHintQues);
            this.Controls.Add(this.HintAns);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.FName);
            this.Controls.Add(this.rePassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "New_User";
            this.Text = "New User";
            this.Load += new System.EventHandler(this.New_User_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox rePassword;
        private System.Windows.Forms.TextBox FName;
        private System.Windows.Forms.TextBox LName;
        private System.Windows.Forms.TextBox HintAns;
        private System.Windows.Forms.ComboBox cmbHintQues;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
    }
}
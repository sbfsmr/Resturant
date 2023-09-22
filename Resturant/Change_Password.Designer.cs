
namespace Resturant
{
    partial class Change_Password
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
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.txtNPass = new System.Windows.Forms.TextBox();
            this.txtRePass = new System.Windows.Forms.TextBox();
            this.plnPass = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.plnhint = new System.Windows.Forms.Panel();
            this.cmbQuest = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHSubmit = new System.Windows.Forms.Button();
            this.txtHRePass = new System.Windows.Forms.TextBox();
            this.txtNHPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHAns = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.optPass = new System.Windows.Forms.RadioButton();
            this.optHint = new System.Windows.Forms.RadioButton();
            this.plnPass.SuspendLayout();
            this.plnhint.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Old Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "New Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Re-Type Password";
            // 
            // txtOldPass
            // 
            this.txtOldPass.Location = new System.Drawing.Point(214, 26);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.PasswordChar = '*';
            this.txtOldPass.Size = new System.Drawing.Size(240, 28);
            this.txtOldPass.TabIndex = 1;
            this.txtOldPass.Leave += new System.EventHandler(this.txtOldPass_Leave);
            // 
            // txtNPass
            // 
            this.txtNPass.Location = new System.Drawing.Point(214, 68);
            this.txtNPass.Name = "txtNPass";
            this.txtNPass.PasswordChar = '*';
            this.txtNPass.Size = new System.Drawing.Size(240, 28);
            this.txtNPass.TabIndex = 1;
            this.txtNPass.Leave += new System.EventHandler(this.txtNPass_Leave);
            // 
            // txtRePass
            // 
            this.txtRePass.Location = new System.Drawing.Point(214, 108);
            this.txtRePass.Name = "txtRePass";
            this.txtRePass.PasswordChar = '*';
            this.txtRePass.Size = new System.Drawing.Size(240, 28);
            this.txtRePass.TabIndex = 1;
            this.txtRePass.Leave += new System.EventHandler(this.txtRePass_Leave);
            // 
            // plnPass
            // 
            this.plnPass.Controls.Add(this.btnCancel);
            this.plnPass.Controls.Add(this.btnSubmit);
            this.plnPass.Controls.Add(this.txtRePass);
            this.plnPass.Controls.Add(this.label2);
            this.plnPass.Controls.Add(this.txtNPass);
            this.plnPass.Controls.Add(this.label3);
            this.plnPass.Controls.Add(this.txtOldPass);
            this.plnPass.Controls.Add(this.label4);
            this.plnPass.Location = new System.Drawing.Point(12, 166);
            this.plnPass.Name = "plnPass";
            this.plnPass.Size = new System.Drawing.Size(480, 313);
            this.plnPass.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(238, 176);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 45);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(100, 176);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(111, 45);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // plnhint
            // 
            this.plnhint.Controls.Add(this.cmbQuest);
            this.plnhint.Controls.Add(this.button1);
            this.plnhint.Controls.Add(this.btnHSubmit);
            this.plnhint.Controls.Add(this.txtHRePass);
            this.plnhint.Controls.Add(this.txtNHPass);
            this.plnhint.Controls.Add(this.label5);
            this.plnhint.Controls.Add(this.txtHAns);
            this.plnhint.Controls.Add(this.label6);
            this.plnhint.Controls.Add(this.label8);
            this.plnhint.Controls.Add(this.label7);
            this.plnhint.Location = new System.Drawing.Point(12, 166);
            this.plnhint.Name = "plnhint";
            this.plnhint.Size = new System.Drawing.Size(480, 313);
            this.plnhint.TabIndex = 2;
            // 
            // cmbQuest
            // 
            this.cmbQuest.FormattingEnabled = true;
            this.cmbQuest.Location = new System.Drawing.Point(214, 26);
            this.cmbQuest.Name = "cmbQuest";
            this.cmbQuest.Size = new System.Drawing.Size(240, 30);
            this.cmbQuest.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnHSubmit
            // 
            this.btnHSubmit.Location = new System.Drawing.Point(103, 221);
            this.btnHSubmit.Name = "btnHSubmit";
            this.btnHSubmit.Size = new System.Drawing.Size(111, 45);
            this.btnHSubmit.TabIndex = 2;
            this.btnHSubmit.Text = "Submit";
            this.btnHSubmit.UseVisualStyleBackColor = true;
            this.btnHSubmit.Click += new System.EventHandler(this.btnHSubmit_Click);
            // 
            // txtHRePass
            // 
            this.txtHRePass.Location = new System.Drawing.Point(214, 147);
            this.txtHRePass.Name = "txtHRePass";
            this.txtHRePass.Size = new System.Drawing.Size(240, 28);
            this.txtHRePass.TabIndex = 1;
            // 
            // txtNHPass
            // 
            this.txtNHPass.Location = new System.Drawing.Point(214, 108);
            this.txtNHPass.Name = "txtNHPass";
            this.txtNHPass.Size = new System.Drawing.Size(240, 28);
            this.txtNHPass.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Hint Questions";
            // 
            // txtHAns
            // 
            this.txtHAns.Location = new System.Drawing.Point(214, 68);
            this.txtHAns.Name = "txtHAns";
            this.txtHAns.Size = new System.Drawing.Size(240, 28);
            this.txtHAns.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 68);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Hint Answer";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 150);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Re-Type Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 111);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "New Password";
            // 
            // optPass
            // 
            this.optPass.AutoSize = true;
            this.optPass.Location = new System.Drawing.Point(54, 115);
            this.optPass.Name = "optPass";
            this.optPass.Size = new System.Drawing.Size(201, 28);
            this.optPass.TabIndex = 3;
            this.optPass.Text = "Using Old Password";
            this.optPass.UseVisualStyleBackColor = true;
            this.optPass.CheckedChanged += new System.EventHandler(this.optPass_CheckedChanged);
            // 
            // optHint
            // 
            this.optHint.AutoSize = true;
            this.optHint.Location = new System.Drawing.Point(268, 115);
            this.optHint.Name = "optHint";
            this.optHint.Size = new System.Drawing.Size(198, 28);
            this.optHint.TabIndex = 3;
            this.optHint.Text = "Using Hint Question";
            this.optHint.UseVisualStyleBackColor = true;
            this.optHint.CheckedChanged += new System.EventHandler(this.optHint_CheckedChanged);
            // 
            // Change_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 495);
            this.Controls.Add(this.optHint);
            this.Controls.Add(this.optPass);
            this.Controls.Add(this.plnhint);
            this.Controls.Add(this.plnPass);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Change_Password";
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.Change_Password_Load);
            this.plnPass.ResumeLayout(false);
            this.plnPass.PerformLayout();
            this.plnhint.ResumeLayout(false);
            this.plnhint.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOldPass;
        private System.Windows.Forms.TextBox txtNPass;
        private System.Windows.Forms.TextBox txtRePass;
        private System.Windows.Forms.Panel plnPass;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel plnhint;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnHSubmit;
        private System.Windows.Forms.TextBox txtHRePass;
        private System.Windows.Forms.TextBox txtNHPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHAns;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton optPass;
        private System.Windows.Forms.RadioButton optHint;
        private System.Windows.Forms.ComboBox cmbQuest;
    }
}

namespace Resturant
{
    partial class Bill_Master
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
            this.txtBillNum = new System.Windows.Forms.TextBox();
            this.txtBillDate = new System.Windows.Forms.TextBox();
            this.txtBillAmt = new System.Windows.Forms.TextBox();
            this.txtCGST = new System.Windows.Forms.TextBox();
            this.txtSGST = new System.Windows.Forms.TextBox();
            this.txtDIsco = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bill Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bill Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bill Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "CGST";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "SGST";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Discount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Total Bill";
            // 
            // txtBillNum
            // 
            this.txtBillNum.Enabled = false;
            this.txtBillNum.Location = new System.Drawing.Point(168, 46);
            this.txtBillNum.Name = "txtBillNum";
            this.txtBillNum.Size = new System.Drawing.Size(193, 28);
            this.txtBillNum.TabIndex = 1;
            // 
            // txtBillDate
            // 
            this.txtBillDate.Enabled = false;
            this.txtBillDate.Location = new System.Drawing.Point(168, 82);
            this.txtBillDate.Name = "txtBillDate";
            this.txtBillDate.Size = new System.Drawing.Size(193, 28);
            this.txtBillDate.TabIndex = 1;
            // 
            // txtBillAmt
            // 
            this.txtBillAmt.Enabled = false;
            this.txtBillAmt.Location = new System.Drawing.Point(168, 117);
            this.txtBillAmt.Name = "txtBillAmt";
            this.txtBillAmt.Size = new System.Drawing.Size(193, 28);
            this.txtBillAmt.TabIndex = 1;
            // 
            // txtCGST
            // 
            this.txtCGST.Enabled = false;
            this.txtCGST.Location = new System.Drawing.Point(168, 152);
            this.txtCGST.Name = "txtCGST";
            this.txtCGST.Size = new System.Drawing.Size(193, 28);
            this.txtCGST.TabIndex = 1;
            // 
            // txtSGST
            // 
            this.txtSGST.Enabled = false;
            this.txtSGST.Location = new System.Drawing.Point(168, 192);
            this.txtSGST.Name = "txtSGST";
            this.txtSGST.Size = new System.Drawing.Size(193, 28);
            this.txtSGST.TabIndex = 1;
            // 
            // txtDIsco
            // 
            this.txtDIsco.Location = new System.Drawing.Point(168, 228);
            this.txtDIsco.Name = "txtDIsco";
            this.txtDIsco.Size = new System.Drawing.Size(193, 28);
            this.txtDIsco.TabIndex = 1;
            this.txtDIsco.TextChanged += new System.EventHandler(this.txtDIsco_TextChanged);
            this.txtDIsco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDIsco_KeyPress);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(168, 266);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(193, 28);
            this.txtTotal.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(68, 331);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 43);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(194, 331);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 43);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(322, 331);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(101, 43);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdItem
            // 
            this.btnAdItem.Location = new System.Drawing.Point(389, 39);
            this.btnAdItem.Name = "btnAdItem";
            this.btnAdItem.Size = new System.Drawing.Size(101, 43);
            this.btnAdItem.TabIndex = 2;
            this.btnAdItem.Text = "Add Item";
            this.btnAdItem.UseVisualStyleBackColor = true;
            this.btnAdItem.Click += new System.EventHandler(this.btnAdItem_Click);
            // 
            // Bill_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 413);
            this.Controls.Add(this.btnAdItem);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDIsco);
            this.Controls.Add(this.txtSGST);
            this.Controls.Add(this.txtCGST);
            this.Controls.Add(this.txtBillDate);
            this.Controls.Add(this.txtBillAmt);
            this.Controls.Add(this.txtBillNum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Bill_Master";
            this.Text = "Bill Master";
            this.Load += new System.EventHandler(this.Bill_Master_Load);
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
        private System.Windows.Forms.TextBox txtBillNum;
        private System.Windows.Forms.TextBox txtBillDate;
        private System.Windows.Forms.TextBox txtBillAmt;
        private System.Windows.Forms.TextBox txtCGST;
        private System.Windows.Forms.TextBox txtSGST;
        private System.Windows.Forms.TextBox txtDIsco;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdItem;
    }
}
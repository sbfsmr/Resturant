
namespace Resturant
{
    partial class Bill_Trans
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
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.tctQuant = new System.Windows.Forms.TextBox();
            this.txtTotPrice = new System.Windows.Forms.TextBox();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.BillTransGrid = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BillTransGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enter Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(171, 79);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(163, 28);
            this.txtPrice.TabIndex = 1;
            // 
            // tctQuant
            // 
            this.tctQuant.Location = new System.Drawing.Point(171, 119);
            this.tctQuant.Name = "tctQuant";
            this.tctQuant.Size = new System.Drawing.Size(163, 28);
            this.tctQuant.TabIndex = 1;
            this.tctQuant.TextChanged += new System.EventHandler(this.tctQuant_TextChanged);
            this.tctQuant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tctQuant_KeyPress);
            // 
            // txtTotPrice
            // 
            this.txtTotPrice.Location = new System.Drawing.Point(171, 160);
            this.txtTotPrice.Name = "txtTotPrice";
            this.txtTotPrice.ReadOnly = true;
            this.txtTotPrice.Size = new System.Drawing.Size(163, 28);
            this.txtTotPrice.TabIndex = 1;
            // 
            // cmbItem
            // 
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(171, 38);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(163, 30);
            this.cmbItem.TabIndex = 0;
            this.cmbItem.SelectedIndexChanged += new System.EventHandler(this.cmbItem_SelectedIndexChanged);
            // 
            // BillTransGrid
            // 
            this.BillTransGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillTransGrid.Location = new System.Drawing.Point(366, 12);
            this.BillTransGrid.Name = "BillTransGrid";
            this.BillTransGrid.RowHeadersWidth = 51;
            this.BillTransGrid.RowTemplate.Height = 24;
            this.BillTransGrid.Size = new System.Drawing.Size(560, 275);
            this.BillTransGrid.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(73, 232);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 41);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(198, 232);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(94, 41);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // Bill_Trans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 297);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.BillTransGrid);
            this.Controls.Add(this.cmbItem);
            this.Controls.Add(this.txtTotPrice);
            this.Controls.Add(this.tctQuant);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Bill_Trans";
            this.Text = "Bill Trans";
            this.Load += new System.EventHandler(this.Bill_Trans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BillTransGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox tctQuant;
        private System.Windows.Forms.TextBox txtTotPrice;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.DataGridView BillTransGrid;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnOk;
    }
}
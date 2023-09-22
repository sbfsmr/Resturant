
namespace Resturant
{
    partial class View_Bill
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
            this.cmbBill = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BDGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.IDGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.BDGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBill
            // 
            this.cmbBill.FormattingEnabled = true;
            this.cmbBill.Location = new System.Drawing.Point(343, 27);
            this.cmbBill.Name = "cmbBill";
            this.cmbBill.Size = new System.Drawing.Size(163, 30);
            this.cmbBill.TabIndex = 0;
            this.cmbBill.SelectedIndexChanged += new System.EventHandler(this.cmbBill_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Bill Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bill Details";
            // 
            // BDGrid
            // 
            this.BDGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BDGrid.Location = new System.Drawing.Point(29, 112);
            this.BDGrid.Name = "BDGrid";
            this.BDGrid.RowHeadersWidth = 51;
            this.BDGrid.RowTemplate.Height = 24;
            this.BDGrid.Size = new System.Drawing.Size(711, 150);
            this.BDGrid.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Items Details";
            // 
            // IDGrid
            // 
            this.IDGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IDGrid.Location = new System.Drawing.Point(29, 310);
            this.IDGrid.Name = "IDGrid";
            this.IDGrid.RowHeadersWidth = 51;
            this.IDGrid.RowTemplate.Height = 24;
            this.IDGrid.Size = new System.Drawing.Size(711, 284);
            this.IDGrid.TabIndex = 2;
            // 
            // View_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 619);
            this.Controls.Add(this.IDGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BDGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBill);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "View_Bill";
            this.Text = "View Bill";
            this.Load += new System.EventHandler(this.View_Bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BDGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView BDGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView IDGrid;
    }
}
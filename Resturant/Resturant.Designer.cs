
namespace Resturant
{
    partial class Resturant
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resturant));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.itemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menAddItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menEditItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menDeleteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menAddUSer = new System.Windows.Forms.ToolStripMenuItem();
            this.menAdUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menDeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menCngPass = new System.Windows.Forms.ToolStripMenuItem();
            this.menViewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.billToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menNewBill = new System.Windows.Forms.ToolStripMenuItem();
            this.menViewBill = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemsToolStripMenuItem,
            this.menAddUSer,
            this.billToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1332, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // itemsToolStripMenuItem
            // 
            this.itemsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menAddItem,
            this.menEditItem,
            this.menDeleteItem,
            this.toolStripMenuItem1,
            this.menExit});
            this.itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            this.itemsToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.itemsToolStripMenuItem.Text = "Items";
            // 
            // menAddItem
            // 
            this.menAddItem.Name = "menAddItem";
            this.menAddItem.Size = new System.Drawing.Size(170, 26);
            this.menAddItem.Text = "Add Item";
            this.menAddItem.Click += new System.EventHandler(this.menAddItem_Click);
            // 
            // menEditItem
            // 
            this.menEditItem.Name = "menEditItem";
            this.menEditItem.Size = new System.Drawing.Size(170, 26);
            this.menEditItem.Text = "Edit Item";
            this.menEditItem.Click += new System.EventHandler(this.menEditItem_Click);
            // 
            // menDeleteItem
            // 
            this.menDeleteItem.Name = "menDeleteItem";
            this.menDeleteItem.Size = new System.Drawing.Size(170, 26);
            this.menDeleteItem.Text = "Delete Item";
            this.menDeleteItem.Click += new System.EventHandler(this.menDeleteItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(167, 6);
            // 
            // menExit
            // 
            this.menExit.Name = "menExit";
            this.menExit.Size = new System.Drawing.Size(170, 26);
            this.menExit.Text = "Exit";
            this.menExit.Click += new System.EventHandler(this.menExit_Click);
            // 
            // menAddUSer
            // 
            this.menAddUSer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menAdUser,
            this.menDeleteUser,
            this.menCngPass,
            this.menViewUser});
            this.menAddUSer.Name = "menAddUSer";
            this.menAddUSer.Size = new System.Drawing.Size(52, 24);
            this.menAddUSer.Text = "User";
            // 
            // menAdUser
            // 
            this.menAdUser.Name = "menAdUser";
            this.menAdUser.Size = new System.Drawing.Size(207, 26);
            this.menAdUser.Text = "Add User";
            this.menAdUser.Click += new System.EventHandler(this.menAdUser_Click);
            // 
            // menDeleteUser
            // 
            this.menDeleteUser.Name = "menDeleteUser";
            this.menDeleteUser.Size = new System.Drawing.Size(207, 26);
            this.menDeleteUser.Text = "Delete User";
            this.menDeleteUser.Click += new System.EventHandler(this.menDeleteUser_Click);
            // 
            // menCngPass
            // 
            this.menCngPass.Name = "menCngPass";
            this.menCngPass.Size = new System.Drawing.Size(207, 26);
            this.menCngPass.Text = "Change Password";
            this.menCngPass.Click += new System.EventHandler(this.menCngPass_Click);
            // 
            // menViewUser
            // 
            this.menViewUser.Name = "menViewUser";
            this.menViewUser.Size = new System.Drawing.Size(207, 26);
            this.menViewUser.Text = "View User";
            this.menViewUser.Click += new System.EventHandler(this.menViewUser_Click);
            // 
            // billToolStripMenuItem
            // 
            this.billToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menNewBill,
            this.menViewBill});
            this.billToolStripMenuItem.Name = "billToolStripMenuItem";
            this.billToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.billToolStripMenuItem.Text = "Bill";
            // 
            // menNewBill
            // 
            this.menNewBill.Name = "menNewBill";
            this.menNewBill.Size = new System.Drawing.Size(224, 26);
            this.menNewBill.Text = "New Bill";
            this.menNewBill.Click += new System.EventHandler(this.menNewBill_Click);
            // 
            // menViewBill
            // 
            this.menViewBill.Name = "menViewBill";
            this.menViewBill.Size = new System.Drawing.Size(224, 26);
            this.menViewBill.Text = "View Bill";
            this.menViewBill.Click += new System.EventHandler(this.menViewBill_Click);
            // 
            // Resturant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1332, 740);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Resturant";
            this.Text = "Resturant Manager";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menAddItem;
        private System.Windows.Forms.ToolStripMenuItem menEditItem;
        private System.Windows.Forms.ToolStripMenuItem menDeleteItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menExit;
        private System.Windows.Forms.ToolStripMenuItem menAddUSer;
        private System.Windows.Forms.ToolStripMenuItem menAdUser;
        private System.Windows.Forms.ToolStripMenuItem menDeleteUser;
        private System.Windows.Forms.ToolStripMenuItem menCngPass;
        private System.Windows.Forms.ToolStripMenuItem menViewUser;
        private System.Windows.Forms.ToolStripMenuItem billToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menNewBill;
        private System.Windows.Forms.ToolStripMenuItem menViewBill;
    }
}




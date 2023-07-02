﻿namespace PerfumeShop
{
    partial class AdminUsersList
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
            this.BtnBackMenuWindow = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.DGVUsers = new System.Windows.Forms.DataGridView();
            this.BtnRemoveItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBackMenuWindow
            // 
            this.BtnBackMenuWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.BtnBackMenuWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBackMenuWindow.FlatAppearance.BorderSize = 0;
            this.BtnBackMenuWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBackMenuWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnBackMenuWindow.ForeColor = System.Drawing.Color.White;
            this.BtnBackMenuWindow.Location = new System.Drawing.Point(731, 483);
            this.BtnBackMenuWindow.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBackMenuWindow.Name = "BtnBackMenuWindow";
            this.BtnBackMenuWindow.Size = new System.Drawing.Size(249, 70);
            this.BtnBackMenuWindow.TabIndex = 29;
            this.BtnBackMenuWindow.Text = "Back to menu window";
            this.BtnBackMenuWindow.UseVisualStyleBackColor = false;
            this.BtnBackMenuWindow.Click += new System.EventHandler(this.BtnBackMenuWindow_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.BtnClose.FlatAppearance.BorderSize = 4;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(470, 483);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(222, 74);
            this.BtnClose.TabIndex = 30;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // DGVUsers
            // 
            this.DGVUsers.BackgroundColor = System.Drawing.Color.White;
            this.DGVUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUsers.Location = new System.Drawing.Point(301, 48);
            this.DGVUsers.Name = "DGVUsers";
            this.DGVUsers.RowHeadersWidth = 62;
            this.DGVUsers.RowTemplate.Height = 28;
            this.DGVUsers.Size = new System.Drawing.Size(378, 366);
            this.DGVUsers.TabIndex = 31;
            // 
            // BtnRemoveItem
            // 
            this.BtnRemoveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.BtnRemoveItem.FlatAppearance.BorderSize = 4;
            this.BtnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemoveItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnRemoveItem.ForeColor = System.Drawing.Color.White;
            this.BtnRemoveItem.Location = new System.Drawing.Point(158, 483);
            this.BtnRemoveItem.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRemoveItem.Name = "BtnRemoveItem";
            this.BtnRemoveItem.Size = new System.Drawing.Size(289, 74);
            this.BtnRemoveItem.TabIndex = 32;
            this.BtnRemoveItem.Text = "Remove Item";
            this.BtnRemoveItem.UseVisualStyleBackColor = false;
            this.BtnRemoveItem.Click += new System.EventHandler(this.BtnRemoveItem_Click);
            // 
            // AdminUsersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1021, 630);
            this.Controls.Add(this.BtnRemoveItem);
            this.Controls.Add(this.DGVUsers);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnBackMenuWindow);
            this.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminUsersList";
            this.Text = "AdminUsersList";
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnBackMenuWindow;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.DataGridView DGVUsers;
        private System.Windows.Forms.Button BtnRemoveItem;
    }
}
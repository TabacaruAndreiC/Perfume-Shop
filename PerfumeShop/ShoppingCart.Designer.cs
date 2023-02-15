namespace PerfumeShop
{
    partial class ShoppingCart
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
            this.DGVHim = new System.Windows.Forms.DataGridView();
            this.BtnBackToMenuWindow = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnRemoveItem = new System.Windows.Forms.Button();
            this.BtnDeleteItems = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVHim)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVHim
            // 
            this.DGVHim.BackgroundColor = System.Drawing.Color.White;
            this.DGVHim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVHim.Location = new System.Drawing.Point(267, 216);
            this.DGVHim.Name = "DGVHim";
            this.DGVHim.RowHeadersWidth = 62;
            this.DGVHim.RowTemplate.Height = 28;
            this.DGVHim.Size = new System.Drawing.Size(698, 447);
            this.DGVHim.TabIndex = 15;
            // 
            // BtnBackToMenuWindow
            // 
            this.BtnBackToMenuWindow.FlatAppearance.BorderSize = 4;
            this.BtnBackToMenuWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBackToMenuWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnBackToMenuWindow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.BtnBackToMenuWindow.Location = new System.Drawing.Point(643, 728);
            this.BtnBackToMenuWindow.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBackToMenuWindow.Name = "BtnBackToMenuWindow";
            this.BtnBackToMenuWindow.Size = new System.Drawing.Size(305, 74);
            this.BtnBackToMenuWindow.TabIndex = 16;
            this.BtnBackToMenuWindow.Text = "Back to menu window";
            this.BtnBackToMenuWindow.UseVisualStyleBackColor = true;
            this.BtnBackToMenuWindow.Click += new System.EventHandler(this.BtnBackToMenuWindow_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.BtnClose.FlatAppearance.BorderSize = 4;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(978, 728);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(234, 74);
            this.BtnClose.TabIndex = 17;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnRemoveItem
            // 
            this.BtnRemoveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.BtnRemoveItem.FlatAppearance.BorderSize = 4;
            this.BtnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemoveItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnRemoveItem.ForeColor = System.Drawing.Color.White;
            this.BtnRemoveItem.Location = new System.Drawing.Point(325, 728);
            this.BtnRemoveItem.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRemoveItem.Name = "BtnRemoveItem";
            this.BtnRemoveItem.Size = new System.Drawing.Size(289, 74);
            this.BtnRemoveItem.TabIndex = 18;
            this.BtnRemoveItem.Text = "Remove Item";
            this.BtnRemoveItem.UseVisualStyleBackColor = false;
            this.BtnRemoveItem.Click += new System.EventHandler(this.BtnRemoveItem_Click);
            // 
            // BtnDeleteItems
            // 
            this.BtnDeleteItems.FlatAppearance.BorderSize = 4;
            this.BtnDeleteItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnDeleteItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.BtnDeleteItems.Location = new System.Drawing.Point(22, 728);
            this.BtnDeleteItems.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDeleteItems.Name = "BtnDeleteItems";
            this.BtnDeleteItems.Size = new System.Drawing.Size(269, 74);
            this.BtnDeleteItems.TabIndex = 19;
            this.BtnDeleteItems.Text = "Delete all items";
            this.BtnDeleteItems.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(425, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 52);
            this.label1.TabIndex = 20;
            this.label1.Text = "Your shopping cart";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShoppingCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1248, 849);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnDeleteItems);
            this.Controls.Add(this.BtnRemoveItem);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnBackToMenuWindow);
            this.Controls.Add(this.DGVHim);
            this.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ShoppingCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShoppingCart";
            ((System.ComponentModel.ISupportInitialize)(this.DGVHim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVHim;
        private System.Windows.Forms.Button BtnBackToMenuWindow;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnRemoveItem;
        private System.Windows.Forms.Button BtnDeleteItems;
        private System.Windows.Forms.Label label1;
    }
}
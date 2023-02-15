namespace PerfumeShop
{
    partial class MenuWindow
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
            this.BtnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnAddToCart = new System.Windows.Forms.Button();
            this.BtnGoToCart = new System.Windows.Forms.Button();
            this.BtnBackToFirstWindow = new System.Windows.Forms.Button();
            this.DGVHim = new System.Windows.Forms.DataGridView();
            this.DGVHer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVHim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVHer)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.BtnClose.FlatAppearance.BorderSize = 4;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(1084, 805);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(222, 74);
            this.BtnClose.TabIndex = 4;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(385, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(805, 52);
            this.label1.TabIndex = 8;
            this.label1.Text = "Choose your favourite perfume";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label2.Location = new System.Drawing.Point(48, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 40);
            this.label2.TabIndex = 9;
            this.label2.Text = "For him";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label3.Location = new System.Drawing.Point(705, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 40);
            this.label3.TabIndex = 10;
            this.label3.Text = "For her";
            // 
            // BtnAddToCart
            // 
            this.BtnAddToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.BtnAddToCart.FlatAppearance.BorderSize = 4;
            this.BtnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnAddToCart.ForeColor = System.Drawing.Color.White;
            this.BtnAddToCart.Location = new System.Drawing.Point(382, 805);
            this.BtnAddToCart.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAddToCart.Name = "BtnAddToCart";
            this.BtnAddToCart.Size = new System.Drawing.Size(408, 74);
            this.BtnAddToCart.TabIndex = 11;
            this.BtnAddToCart.Text = "add to shopping cart";
            this.BtnAddToCart.UseVisualStyleBackColor = false;
            this.BtnAddToCart.Click += new System.EventHandler(this.BtnAddToCart_Click);
            // 
            // BtnGoToCart
            // 
            this.BtnGoToCart.FlatAppearance.BorderSize = 4;
            this.BtnGoToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGoToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnGoToCart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.BtnGoToCart.Location = new System.Drawing.Point(19, 805);
            this.BtnGoToCart.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGoToCart.Name = "BtnGoToCart";
            this.BtnGoToCart.Size = new System.Drawing.Size(355, 74);
            this.BtnGoToCart.TabIndex = 12;
            this.BtnGoToCart.Text = "View shopping cart";
            this.BtnGoToCart.UseVisualStyleBackColor = true;
            this.BtnGoToCart.Click += new System.EventHandler(this.BtnGoToCart_Click);
            // 
            // BtnBackToFirstWindow
            // 
            this.BtnBackToFirstWindow.FlatAppearance.BorderSize = 4;
            this.BtnBackToFirstWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBackToFirstWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnBackToFirstWindow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.BtnBackToFirstWindow.Location = new System.Drawing.Point(798, 805);
            this.BtnBackToFirstWindow.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBackToFirstWindow.Name = "BtnBackToFirstWindow";
            this.BtnBackToFirstWindow.Size = new System.Drawing.Size(278, 74);
            this.BtnBackToFirstWindow.TabIndex = 13;
            this.BtnBackToFirstWindow.Text = "Back to first window";
            this.BtnBackToFirstWindow.UseVisualStyleBackColor = true;
            this.BtnBackToFirstWindow.Click += new System.EventHandler(this.BtnBackToFirstWindow_Click);
            // 
            // DGVHim
            // 
            this.DGVHim.BackgroundColor = System.Drawing.Color.White;
            this.DGVHim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVHim.Location = new System.Drawing.Point(55, 162);
            this.DGVHim.Name = "DGVHim";
            this.DGVHim.RowHeadersWidth = 62;
            this.DGVHim.RowTemplate.Height = 28;
            this.DGVHim.Size = new System.Drawing.Size(567, 614);
            this.DGVHim.TabIndex = 14;
            // 
            // DGVHer
            // 
            this.DGVHer.BackgroundColor = System.Drawing.Color.White;
            this.DGVHer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVHer.Location = new System.Drawing.Point(712, 162);
            this.DGVHer.Name = "DGVHer";
            this.DGVHer.RowHeadersWidth = 62;
            this.DGVHer.RowTemplate.Height = 28;
            this.DGVHer.Size = new System.Drawing.Size(565, 614);
            this.DGVHer.TabIndex = 15;
            // 
            // MenuWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1319, 912);
            this.Controls.Add(this.DGVHer);
            this.Controls.Add(this.DGVHim);
            this.Controls.Add(this.BtnBackToFirstWindow);
            this.Controls.Add(this.BtnGoToCart);
            this.Controls.Add(this.BtnAddToCart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnClose);
            this.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuWindow";
            ((System.ComponentModel.ISupportInitialize)(this.DGVHim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVHer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnAddToCart;
        private System.Windows.Forms.Button BtnGoToCart;
        private System.Windows.Forms.Button BtnBackToFirstWindow;
        private System.Windows.Forms.DataGridView DGVHim;
        private System.Windows.Forms.DataGridView DGVHer;
    }
}
namespace HamburgueriaMordidaPerfeita {
    partial class InitialMenu {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitialMenu));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.lblDesc = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Futura Md BT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(260, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Menu Principal";
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(36, 102);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(253, 58);
            this.btnOrders.TabIndex = 1;
            this.btnOrders.Text = "Comandas";
            this.btnOrders.UseVisualStyleBackColor = true;
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(36, 166);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(253, 58);
            this.btnProduct.TabIndex = 2;
            this.btnProduct.Text = "Produtos";
            this.btnProduct.UseVisualStyleBackColor = true;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(36, 230);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(253, 58);
            this.btnCheckout.TabIndex = 3;
            this.btnCheckout.Text = "Caixa";
            this.btnCheckout.UseVisualStyleBackColor = true;
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(36, 294);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(253, 58);
            this.btnUsers.TabIndex = 4;
            this.btnUsers.Text = "Usuários";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(34, 67);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(0, 32);
            this.lblDesc.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HamburgueriaMordidaPerfeita.Properties.Resources.LogoIcon;
            this.pictureBox1.Location = new System.Drawing.Point(349, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 301);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // InitialMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(697, 375);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Dubai Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MinimizeBox = false;
            this.Name = "InitialMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InitialMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDesc;
    }
}
namespace HamburgueriaMordidaPerfeita {
    partial class FormUsers {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsers));
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.grbApagar = new System.Windows.Forms.GroupBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblApagar = new System.Windows.Forms.Label();
            this.grbCadastro = new System.Windows.Forms.GroupBox();
            this.brnCadastrar = new System.Windows.Forms.Button();
            this.txbSenhaCadastro = new System.Windows.Forms.TextBox();
            this.lblSenhaCadastro = new System.Windows.Forms.Label();
            this.txbEmailCadastro = new System.Windows.Forms.TextBox();
            this.lblEmailCadastro = new System.Windows.Forms.Label();
            this.txbNomeCompletoCadastro = new System.Windows.Forms.TextBox();
            this.lblNomeCompletoCadastro = new System.Windows.Forms.Label();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txbSenhaEditar = new System.Windows.Forms.TextBox();
            this.lblSenhaEditar = new System.Windows.Forms.Label();
            this.txbEmailEditar = new System.Windows.Forms.TextBox();
            this.lblEmailEditar = new System.Windows.Forms.Label();
            this.txbNomeCompletoEditar = new System.Windows.Forms.TextBox();
            this.lblNomeCompletoEditar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.grbApagar.SuspendLayout();
            this.grbCadastro.SuspendLayout();
            this.grbEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToResizeColumns = false;
            this.dgvUsers.AllowUserToResizeRows = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(12, 12);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.Size = new System.Drawing.Size(585, 200);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            // 
            // grbApagar
            // 
            this.grbApagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(173)))));
            this.grbApagar.Controls.Add(this.btnApagar);
            this.grbApagar.Controls.Add(this.lblApagar);
            this.grbApagar.Enabled = false;
            this.grbApagar.Location = new System.Drawing.Point(12, 388);
            this.grbApagar.Name = "grbApagar";
            this.grbApagar.Size = new System.Drawing.Size(585, 60);
            this.grbApagar.TabIndex = 1;
            this.grbApagar.TabStop = false;
            this.grbApagar.Text = "Apagar";
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.IndianRed;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApagar.ForeColor = System.Drawing.Color.Black;
            this.btnApagar.Location = new System.Drawing.Point(333, 13);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(232, 41);
            this.btnApagar.TabIndex = 1;
            this.btnApagar.Text = "APAGAR";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // lblApagar
            // 
            this.lblApagar.AutoSize = true;
            this.lblApagar.Location = new System.Drawing.Point(20, 26);
            this.lblApagar.Name = "lblApagar";
            this.lblApagar.Size = new System.Drawing.Size(160, 13);
            this.lblApagar.TabIndex = 0;
            this.lblApagar.Text = "Selecione o usuário para apagar";
            // 
            // grbCadastro
            // 
            this.grbCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grbCadastro.Controls.Add(this.brnCadastrar);
            this.grbCadastro.Controls.Add(this.txbSenhaCadastro);
            this.grbCadastro.Controls.Add(this.lblSenhaCadastro);
            this.grbCadastro.Controls.Add(this.txbEmailCadastro);
            this.grbCadastro.Controls.Add(this.lblEmailCadastro);
            this.grbCadastro.Controls.Add(this.txbNomeCompletoCadastro);
            this.grbCadastro.Controls.Add(this.lblNomeCompletoCadastro);
            this.grbCadastro.Location = new System.Drawing.Point(35, 230);
            this.grbCadastro.Name = "grbCadastro";
            this.grbCadastro.Size = new System.Drawing.Size(243, 138);
            this.grbCadastro.TabIndex = 2;
            this.grbCadastro.TabStop = false;
            this.grbCadastro.Text = "Cadastro";
            // 
            // brnCadastrar
            // 
            this.brnCadastrar.Location = new System.Drawing.Point(20, 99);
            this.brnCadastrar.Name = "brnCadastrar";
            this.brnCadastrar.Size = new System.Drawing.Size(206, 33);
            this.brnCadastrar.TabIndex = 6;
            this.brnCadastrar.Text = "Cadastrar";
            this.brnCadastrar.UseVisualStyleBackColor = true;
            this.brnCadastrar.Click += new System.EventHandler(this.brnCadastrar_Click);
            // 
            // txbSenhaCadastro
            // 
            this.txbSenhaCadastro.Location = new System.Drawing.Point(100, 72);
            this.txbSenhaCadastro.Name = "txbSenhaCadastro";
            this.txbSenhaCadastro.Size = new System.Drawing.Size(137, 20);
            this.txbSenhaCadastro.TabIndex = 5;
            // 
            // lblSenhaCadastro
            // 
            this.lblSenhaCadastro.AutoSize = true;
            this.lblSenhaCadastro.Location = new System.Drawing.Point(53, 75);
            this.lblSenhaCadastro.Name = "lblSenhaCadastro";
            this.lblSenhaCadastro.Size = new System.Drawing.Size(41, 13);
            this.lblSenhaCadastro.TabIndex = 4;
            this.lblSenhaCadastro.Text = "Senha:";
            // 
            // txbEmailCadastro
            // 
            this.txbEmailCadastro.Location = new System.Drawing.Point(98, 46);
            this.txbEmailCadastro.Name = "txbEmailCadastro";
            this.txbEmailCadastro.Size = new System.Drawing.Size(139, 20);
            this.txbEmailCadastro.TabIndex = 3;
            // 
            // lblEmailCadastro
            // 
            this.lblEmailCadastro.AutoSize = true;
            this.lblEmailCadastro.Location = new System.Drawing.Point(57, 49);
            this.lblEmailCadastro.Name = "lblEmailCadastro";
            this.lblEmailCadastro.Size = new System.Drawing.Size(35, 13);
            this.lblEmailCadastro.TabIndex = 2;
            this.lblEmailCadastro.Text = "Email:";
            // 
            // txbNomeCompletoCadastro
            // 
            this.txbNomeCompletoCadastro.Location = new System.Drawing.Point(98, 19);
            this.txbNomeCompletoCadastro.Name = "txbNomeCompletoCadastro";
            this.txbNomeCompletoCadastro.Size = new System.Drawing.Size(139, 20);
            this.txbNomeCompletoCadastro.TabIndex = 1;
            // 
            // lblNomeCompletoCadastro
            // 
            this.lblNomeCompletoCadastro.AutoSize = true;
            this.lblNomeCompletoCadastro.Location = new System.Drawing.Point(8, 22);
            this.lblNomeCompletoCadastro.Name = "lblNomeCompletoCadastro";
            this.lblNomeCompletoCadastro.Size = new System.Drawing.Size(85, 13);
            this.lblNomeCompletoCadastro.TabIndex = 0;
            this.lblNomeCompletoCadastro.Text = "Nome Completo:";
            // 
            // grbEditar
            // 
            this.grbEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Controls.Add(this.txbSenhaEditar);
            this.grbEditar.Controls.Add(this.lblSenhaEditar);
            this.grbEditar.Controls.Add(this.txbEmailEditar);
            this.grbEditar.Controls.Add(this.lblEmailEditar);
            this.grbEditar.Controls.Add(this.txbNomeCompletoEditar);
            this.grbEditar.Controls.Add(this.lblNomeCompletoEditar);
            this.grbEditar.Enabled = false;
            this.grbEditar.ForeColor = System.Drawing.Color.Black;
            this.grbEditar.Location = new System.Drawing.Point(334, 230);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(243, 138);
            this.grbEditar.TabIndex = 7;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(20, 99);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(206, 33);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txbSenhaEditar
            // 
            this.txbSenhaEditar.Location = new System.Drawing.Point(100, 72);
            this.txbSenhaEditar.Name = "txbSenhaEditar";
            this.txbSenhaEditar.Size = new System.Drawing.Size(137, 20);
            this.txbSenhaEditar.TabIndex = 5;
            // 
            // lblSenhaEditar
            // 
            this.lblSenhaEditar.AutoSize = true;
            this.lblSenhaEditar.Location = new System.Drawing.Point(53, 75);
            this.lblSenhaEditar.Name = "lblSenhaEditar";
            this.lblSenhaEditar.Size = new System.Drawing.Size(41, 13);
            this.lblSenhaEditar.TabIndex = 4;
            this.lblSenhaEditar.Text = "Senha:";
            // 
            // txbEmailEditar
            // 
            this.txbEmailEditar.Location = new System.Drawing.Point(98, 46);
            this.txbEmailEditar.Name = "txbEmailEditar";
            this.txbEmailEditar.Size = new System.Drawing.Size(139, 20);
            this.txbEmailEditar.TabIndex = 3;
            // 
            // lblEmailEditar
            // 
            this.lblEmailEditar.AutoSize = true;
            this.lblEmailEditar.Location = new System.Drawing.Point(57, 49);
            this.lblEmailEditar.Name = "lblEmailEditar";
            this.lblEmailEditar.Size = new System.Drawing.Size(35, 13);
            this.lblEmailEditar.TabIndex = 2;
            this.lblEmailEditar.Text = "Email:";
            // 
            // txbNomeCompletoEditar
            // 
            this.txbNomeCompletoEditar.Location = new System.Drawing.Point(98, 19);
            this.txbNomeCompletoEditar.Name = "txbNomeCompletoEditar";
            this.txbNomeCompletoEditar.Size = new System.Drawing.Size(139, 20);
            this.txbNomeCompletoEditar.TabIndex = 1;
            // 
            // lblNomeCompletoEditar
            // 
            this.lblNomeCompletoEditar.AutoSize = true;
            this.lblNomeCompletoEditar.Location = new System.Drawing.Point(8, 22);
            this.lblNomeCompletoEditar.Name = "lblNomeCompletoEditar";
            this.lblNomeCompletoEditar.Size = new System.Drawing.Size(85, 13);
            this.lblNomeCompletoEditar.TabIndex = 0;
            this.lblNomeCompletoEditar.Text = "Nome Completo:";
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(609, 450);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbCadastro);
            this.Controls.Add(this.grbApagar);
            this.Controls.Add(this.dgvUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FormUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUsers";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.grbApagar.ResumeLayout(false);
            this.grbApagar.PerformLayout();
            this.grbCadastro.ResumeLayout(false);
            this.grbCadastro.PerformLayout();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.GroupBox grbApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblApagar;
        private System.Windows.Forms.GroupBox grbCadastro;
        private System.Windows.Forms.TextBox txbEmailCadastro;
        private System.Windows.Forms.Label lblEmailCadastro;
        private System.Windows.Forms.TextBox txbNomeCompletoCadastro;
        private System.Windows.Forms.Label lblNomeCompletoCadastro;
        private System.Windows.Forms.TextBox txbSenhaCadastro;
        private System.Windows.Forms.Label lblSenhaCadastro;
        private System.Windows.Forms.Button brnCadastrar;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txbSenhaEditar;
        private System.Windows.Forms.Label lblSenhaEditar;
        private System.Windows.Forms.TextBox txbEmailEditar;
        private System.Windows.Forms.Label lblEmailEditar;
        private System.Windows.Forms.TextBox txbNomeCompletoEditar;
        private System.Windows.Forms.Label lblNomeCompletoEditar;
    }
}
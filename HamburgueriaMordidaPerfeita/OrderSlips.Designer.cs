namespace HamburgueriaMordidaPerfeita {
    partial class OrderSlips {
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
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.grbInformacoes = new System.Windows.Forms.GroupBox();
            this.btnComanda = new System.Windows.Forms.Button();
            this.txbCodProduto = new System.Windows.Forms.TextBox();
            this.lblCodProduto = new System.Windows.Forms.Label();
            this.txbComanda = new System.Windows.Forms.TextBox();
            this.lblComanda = new System.Windows.Forms.Label();
            this.grbLancamentos = new System.Windows.Forms.GroupBox();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLanca = new System.Windows.Forms.Button();
            this.txbProduto = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.grbInformacoes.SuspendLayout();
            this.grbLancamentos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToResizeColumns = false;
            this.dgvProdutos.AllowUserToResizeRows = false;
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(326, 12);
            this.dgvProdutos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(594, 426);
            this.dgvProdutos.TabIndex = 0;
            // 
            // grbInformacoes
            // 
            this.grbInformacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grbInformacoes.Controls.Add(this.btnComanda);
            this.grbInformacoes.Controls.Add(this.txbCodProduto);
            this.grbInformacoes.Controls.Add(this.lblCodProduto);
            this.grbInformacoes.Controls.Add(this.txbComanda);
            this.grbInformacoes.Controls.Add(this.lblComanda);
            this.grbInformacoes.Location = new System.Drawing.Point(14, 30);
            this.grbInformacoes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbInformacoes.Name = "grbInformacoes";
            this.grbInformacoes.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbInformacoes.Size = new System.Drawing.Size(295, 174);
            this.grbInformacoes.TabIndex = 1;
            this.grbInformacoes.TabStop = false;
            this.grbInformacoes.Text = "Informações";
            // 
            // btnComanda
            // 
            this.btnComanda.Location = new System.Drawing.Point(20, 103);
            this.btnComanda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnComanda.Name = "btnComanda";
            this.btnComanda.Size = new System.Drawing.Size(247, 38);
            this.btnComanda.TabIndex = 4;
            this.btnComanda.Text = "continuar";
            this.btnComanda.UseVisualStyleBackColor = true;
            // 
            // txbCodProduto
            // 
            this.txbCodProduto.Location = new System.Drawing.Point(104, 63);
            this.txbCodProduto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txbCodProduto.Name = "txbCodProduto";
            this.txbCodProduto.Size = new System.Drawing.Size(163, 20);
            this.txbCodProduto.TabIndex = 3;
            // 
            // lblCodProduto
            // 
            this.lblCodProduto.AutoSize = true;
            this.lblCodProduto.Location = new System.Drawing.Point(16, 70);
            this.lblCodProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodProduto.Name = "lblCodProduto";
            this.lblCodProduto.Size = new System.Drawing.Size(81, 13);
            this.lblCodProduto.TabIndex = 2;
            this.lblCodProduto.Text = "Cod Produto:";
            // 
            // txbComanda
            // 
            this.txbComanda.Location = new System.Drawing.Point(104, 37);
            this.txbComanda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txbComanda.Name = "txbComanda";
            this.txbComanda.Size = new System.Drawing.Size(163, 20);
            this.txbComanda.TabIndex = 1;
            // 
            // lblComanda
            // 
            this.lblComanda.AutoSize = true;
            this.lblComanda.Location = new System.Drawing.Point(33, 40);
            this.lblComanda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComanda.Name = "lblComanda";
            this.lblComanda.Size = new System.Drawing.Size(63, 13);
            this.lblComanda.TabIndex = 0;
            this.lblComanda.Text = "Comanda:";
            // 
            // grbLancamentos
            // 
            this.grbLancamentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grbLancamentos.Controls.Add(this.txbQuantidade);
            this.grbLancamentos.Controls.Add(this.lblQuantidade);
            this.grbLancamentos.Controls.Add(this.btnCancelar);
            this.grbLancamentos.Controls.Add(this.btnLanca);
            this.grbLancamentos.Controls.Add(this.txbProduto);
            this.grbLancamentos.Controls.Add(this.lblProduto);
            this.grbLancamentos.Location = new System.Drawing.Point(14, 236);
            this.grbLancamentos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbLancamentos.Name = "grbLancamentos";
            this.grbLancamentos.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbLancamentos.Size = new System.Drawing.Size(295, 187);
            this.grbLancamentos.TabIndex = 5;
            this.grbLancamentos.TabStop = false;
            this.grbLancamentos.Text = "Lançamentos";
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.Location = new System.Drawing.Point(104, 63);
            this.txbQuantidade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(163, 20);
            this.txbQuantidade.TabIndex = 7;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(21, 66);
            this.lblQuantidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(76, 13);
            this.lblQuantidade.TabIndex = 6;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(7, 141);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(276, 38);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnLanca
            // 
            this.btnLanca.Location = new System.Drawing.Point(7, 97);
            this.btnLanca.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLanca.Name = "btnLanca";
            this.btnLanca.Size = new System.Drawing.Size(276, 38);
            this.btnLanca.TabIndex = 4;
            this.btnLanca.Text = "lançar";
            this.btnLanca.UseVisualStyleBackColor = true;
            // 
            // txbProduto
            // 
            this.txbProduto.Location = new System.Drawing.Point(94, 37);
            this.txbProduto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txbProduto.Name = "txbProduto";
            this.txbProduto.ReadOnly = true;
            this.txbProduto.Size = new System.Drawing.Size(172, 20);
            this.txbProduto.TabIndex = 1;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(33, 40);
            this.lblProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(55, 13);
            this.lblProduto.TabIndex = 0;
            this.lblProduto.Text = "Produto:";
            // 
            // OrderSlips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.grbLancamentos);
            this.Controls.Add(this.grbInformacoes);
            this.Controls.Add(this.dgvProdutos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "OrderSlips";
            this.Text = "Comandas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.grbInformacoes.ResumeLayout(false);
            this.grbInformacoes.PerformLayout();
            this.grbLancamentos.ResumeLayout(false);
            this.grbLancamentos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.GroupBox grbInformacoes;
        private System.Windows.Forms.Button btnComanda;
        private System.Windows.Forms.TextBox txbCodProduto;
        private System.Windows.Forms.Label lblCodProduto;
        private System.Windows.Forms.TextBox txbComanda;
        private System.Windows.Forms.Label lblComanda;
        private System.Windows.Forms.GroupBox grbLancamentos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLanca;
        private System.Windows.Forms.TextBox txbProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.TextBox txbQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
    }
}
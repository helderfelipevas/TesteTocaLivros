namespace ProjetoTesteTocaLivros.View
{
    partial class Pedidos
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.lblQtProduto = new System.Windows.Forms.Label();
            this.lblValorProduto = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtValorProduto = new System.Windows.Forms.TextBox();
            this.txtQtProduto = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(197, 227);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(101, 227);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Location = new System.Drawing.Point(13, 13);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(93, 13);
            this.lblNomeProduto.TabIndex = 11;
            this.lblNomeProduto.Text = "Nome do Produto:";
            // 
            // lblQtProduto
            // 
            this.lblQtProduto.AutoSize = true;
            this.lblQtProduto.Location = new System.Drawing.Point(13, 155);
            this.lblQtProduto.Name = "lblQtProduto";
            this.lblQtProduto.Size = new System.Drawing.Size(82, 13);
            this.lblQtProduto.TabIndex = 12;
            this.lblQtProduto.Text = "Quant. Produto:";
            // 
            // lblValorProduto
            // 
            this.lblValorProduto.AutoSize = true;
            this.lblValorProduto.Location = new System.Drawing.Point(13, 82);
            this.lblValorProduto.Name = "lblValorProduto";
            this.lblValorProduto.Size = new System.Drawing.Size(89, 13);
            this.lblValorProduto.TabIndex = 13;
            this.lblValorProduto.Text = "Valor do Produto:";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(76, 29);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(196, 20);
            this.txtNomeProduto.TabIndex = 14;
            // 
            // txtValorProduto
            // 
            this.txtValorProduto.Location = new System.Drawing.Point(76, 98);
            this.txtValorProduto.Name = "txtValorProduto";
            this.txtValorProduto.Size = new System.Drawing.Size(196, 20);
            this.txtValorProduto.TabIndex = 15;
            // 
            // txtQtProduto
            // 
            this.txtQtProduto.Location = new System.Drawing.Point(76, 171);
            this.txtQtProduto.Name = "txtQtProduto";
            this.txtQtProduto.Size = new System.Drawing.Size(196, 20);
            this.txtQtProduto.TabIndex = 16;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(13, 201);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(39, 13);
            this.lblCodigo.TabIndex = 23;
            this.lblCodigo.Text = "codigo";
            this.lblCodigo.Visible = false;
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtQtProduto);
            this.Controls.Add(this.txtValorProduto);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.lblValorProduto);
            this.Controls.Add(this.lblQtProduto);
            this.Controls.Add(this.lblNomeProduto);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnVoltar);
            this.Name = "Pedidos";
            this.Text = "Pedidos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.Label lblQtProduto;
        private System.Windows.Forms.Label lblValorProduto;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.TextBox txtValorProduto;
        private System.Windows.Forms.TextBox txtQtProduto;
        private System.Windows.Forms.Label lblCodigo;
    }
}
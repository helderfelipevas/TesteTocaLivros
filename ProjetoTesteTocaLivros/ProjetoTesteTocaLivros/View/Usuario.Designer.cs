namespace ProjetoTesteTocaLivros.View
{
    partial class Usuario
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
            this.lblShowNome = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnPedido = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblShowEmail = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblShowEndereco = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.bntVisualizarPedidos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblShowNome
            // 
            this.lblShowNome.AutoSize = true;
            this.lblShowNome.Location = new System.Drawing.Point(13, 13);
            this.lblShowNome.Name = "lblShowNome";
            this.lblShowNome.Size = new System.Drawing.Size(92, 13);
            this.lblShowNome.TabIndex = 0;
            this.lblShowNome.Text = "Nome do Usuário:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(49, 30);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(144, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "nomeDoUsuarioApareceAqui";
            // 
            // btnPedido
            // 
            this.btnPedido.Location = new System.Drawing.Point(197, 210);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(75, 40);
            this.btnPedido.TabIndex = 4;
            this.btnPedido.Text = "Fazer Pedido";
            this.btnPedido.UseVisualStyleBackColor = true;
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(16, 219);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 10;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(106, 210);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 40);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar Usuario";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblShowEmail
            // 
            this.lblShowEmail.AutoSize = true;
            this.lblShowEmail.Location = new System.Drawing.Point(13, 60);
            this.lblShowEmail.Name = "lblShowEmail";
            this.lblShowEmail.Size = new System.Drawing.Size(93, 13);
            this.lblShowEmail.TabIndex = 12;
            this.lblShowEmail.Text = "E-Mail do Usuario:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(52, 76);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(142, 13);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "emailDoUsuarioApareceAqui";
            // 
            // lblShowEndereco
            // 
            this.lblShowEndereco.AutoSize = true;
            this.lblShowEndereco.Location = new System.Drawing.Point(13, 116);
            this.lblShowEndereco.Name = "lblShowEndereco";
            this.lblShowEndereco.Size = new System.Drawing.Size(110, 13);
            this.lblShowEndereco.TabIndex = 14;
            this.lblShowEndereco.Text = "Endereco do Usuario:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(52, 139);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(163, 13);
            this.lblEndereco.TabIndex = 15;
            this.lblEndereco.Text = "enderecoDoUsuarioApareceAqui";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(52, 30);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(220, 20);
            this.txtNome.TabIndex = 16;
            this.txtNome.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(52, 76);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(220, 20);
            this.txtEmail.TabIndex = 17;
            this.txtEmail.Visible = false;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(52, 136);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(220, 20);
            this.txtEndereco.TabIndex = 18;
            this.txtEndereco.Visible = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(197, 219);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 19;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Visible = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.ForeColor = System.Drawing.Color.Firebrick;
            this.btnExcluir.Location = new System.Drawing.Point(16, 219);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 20;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Visible = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(13, 173);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(39, 13);
            this.lblCodigo.TabIndex = 22;
            this.lblCodigo.Text = "codigo";
            this.lblCodigo.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(106, 219);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // bntVisualizarPedidos
            // 
            this.bntVisualizarPedidos.Location = new System.Drawing.Point(106, 173);
            this.bntVisualizarPedidos.Name = "bntVisualizarPedidos";
            this.bntVisualizarPedidos.Size = new System.Drawing.Size(75, 23);
            this.bntVisualizarPedidos.TabIndex = 23;
            this.bntVisualizarPedidos.Text = "Ver Pedidos";
            this.bntVisualizarPedidos.UseVisualStyleBackColor = true;
            this.bntVisualizarPedidos.Click += new System.EventHandler(this.bntVisualizarPedidos_Click);
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.bntVisualizarPedidos);
            this.Controls.Add(this.btnPedido);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblShowEndereco);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblShowEmail);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblShowNome);
            this.Name = "Usuario";
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.Usuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShowNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblShowEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblShowEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button bntVisualizarPedidos;
    }
}
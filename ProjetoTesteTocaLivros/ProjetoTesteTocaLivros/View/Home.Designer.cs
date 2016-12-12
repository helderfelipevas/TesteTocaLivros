namespace ProjetoTesteTocaLivros.View
{
    partial class Home
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
            this.btnNovoUsuario = new System.Windows.Forms.Button();
            this.btnFazerPedido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNovoUsuario
            // 
            this.btnNovoUsuario.Location = new System.Drawing.Point(54, 94);
            this.btnNovoUsuario.Name = "btnNovoUsuario";
            this.btnNovoUsuario.Size = new System.Drawing.Size(75, 41);
            this.btnNovoUsuario.TabIndex = 0;
            this.btnNovoUsuario.Text = "Novo Usuário";
            this.btnNovoUsuario.UseVisualStyleBackColor = true;
            this.btnNovoUsuario.Click += new System.EventHandler(this.btnNovoUsuario_Click);
            // 
            // btnFazerPedido
            // 
            this.btnFazerPedido.Location = new System.Drawing.Point(161, 94);
            this.btnFazerPedido.Name = "btnFazerPedido";
            this.btnFazerPedido.Size = new System.Drawing.Size(75, 41);
            this.btnFazerPedido.TabIndex = 1;
            this.btnFazerPedido.Text = "Fazer Pedido";
            this.btnFazerPedido.UseVisualStyleBackColor = true;
            this.btnFazerPedido.Click += new System.EventHandler(this.btnFazerPedido_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnFazerPedido);
            this.Controls.Add(this.btnNovoUsuario);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNovoUsuario;
        private System.Windows.Forms.Button btnFazerPedido;
    }
}
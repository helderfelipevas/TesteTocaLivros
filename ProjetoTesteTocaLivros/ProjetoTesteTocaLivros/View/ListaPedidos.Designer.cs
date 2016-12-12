namespace ProjetoTesteTocaLivros.View
{
    partial class ListaPedidos
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
            this.lbPedidos = new System.Windows.Forms.ListBox();
            this.btnApagarPedido = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblShowValorTotal = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbPedidos
            // 
            this.lbPedidos.FormattingEnabled = true;
            this.lbPedidos.Location = new System.Drawing.Point(12, 41);
            this.lbPedidos.Name = "lbPedidos";
            this.lbPedidos.Size = new System.Drawing.Size(260, 160);
            this.lbPedidos.TabIndex = 0;
            // 
            // btnApagarPedido
            // 
            this.btnApagarPedido.ForeColor = System.Drawing.Color.Firebrick;
            this.btnApagarPedido.Location = new System.Drawing.Point(197, 207);
            this.btnApagarPedido.Name = "btnApagarPedido";
            this.btnApagarPedido.Size = new System.Drawing.Size(75, 43);
            this.btnApagarPedido.TabIndex = 1;
            this.btnApagarPedido.Text = "Apagar Pedido";
            this.btnApagarPedido.UseVisualStyleBackColor = true;
            this.btnApagarPedido.Click += new System.EventHandler(this.btnAPagarPedido_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(12, 217);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(39, 13);
            this.lblCodigo.TabIndex = 24;
            this.lblCodigo.Text = "codigo";
            this.lblCodigo.Visible = false;
            // 
            // lblShowValorTotal
            // 
            this.lblShowValorTotal.AutoSize = true;
            this.lblShowValorTotal.Location = new System.Drawing.Point(137, 9);
            this.lblShowValorTotal.Name = "lblShowValorTotal";
            this.lblShowValorTotal.Size = new System.Drawing.Size(61, 13);
            this.lblShowValorTotal.TabIndex = 25;
            this.lblShowValorTotal.Text = "Valor Total:";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(204, 9);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(34, 13);
            this.lblValorTotal.TabIndex = 26;
            this.lblValorTotal.Text = "00,00";
            // 
            // ListaPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.lblShowValorTotal);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnApagarPedido);
            this.Controls.Add(this.lbPedidos);
            this.Name = "ListaPedidos";
            this.Text = "ListaPedidos";
            this.Load += new System.EventHandler(this.ListaPedidos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPedidos;
        private System.Windows.Forms.Button btnApagarPedido;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblShowValorTotal;
        private System.Windows.Forms.Label lblValorTotal;
    }
}
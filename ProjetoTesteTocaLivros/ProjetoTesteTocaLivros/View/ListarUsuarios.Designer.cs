namespace ProjetoTesteTocaLivros.View
{
    partial class ListarUsuarios
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblLista = new System.Windows.Forms.Label();
            this.lbUsuarios = new System.Windows.Forms.ListBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(108, 227);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Location = new System.Drawing.Point(13, 13);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(88, 13);
            this.lblLista.TabIndex = 1;
            this.lblLista.Text = "Lista de Usuários";
            // 
            // lbUsuarios
            // 
            this.lbUsuarios.FormattingEnabled = true;
            this.lbUsuarios.Location = new System.Drawing.Point(16, 39);
            this.lbUsuarios.Name = "lbUsuarios";
            this.lbUsuarios.Size = new System.Drawing.Size(256, 173);
            this.lbUsuarios.TabIndex = 2;
            this.lbUsuarios.SelectedIndexChanged += new System.EventHandler(this.lbUsuarios_SelectedIndexChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(190, 227);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // ListarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lbUsuarios);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.btnVoltar);
            this.Name = "ListarUsuarios";
            this.Text = "ListarUsuarios";
            this.Load += new System.EventHandler(this.ListarUsuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.ListBox lbUsuarios;
        private System.Windows.Forms.Button btnBuscar;
    }
}
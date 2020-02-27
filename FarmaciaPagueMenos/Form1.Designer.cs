namespace FarmaciaPagueMenos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_jaSouCliente = new System.Windows.Forms.Button();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_jaSouCliente
            // 
            this.btn_jaSouCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_jaSouCliente.BackColor = System.Drawing.Color.White;
            this.btn_jaSouCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_jaSouCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_jaSouCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_jaSouCliente.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_jaSouCliente.ForeColor = System.Drawing.Color.Navy;
            this.btn_jaSouCliente.Location = new System.Drawing.Point(123, 317);
            this.btn_jaSouCliente.Name = "btn_jaSouCliente";
            this.btn_jaSouCliente.Size = new System.Drawing.Size(239, 100);
            this.btn_jaSouCliente.TabIndex = 0;
            this.btn_jaSouCliente.Text = "Já sou cliente";
            this.btn_jaSouCliente.UseVisualStyleBackColor = false;
            this.btn_jaSouCliente.Click += new System.EventHandler(this.btn_jaSouCliente_Click);
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Cadastrar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cadastrar.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cadastrar.ForeColor = System.Drawing.Color.Navy;
            this.btn_Cadastrar.Location = new System.Drawing.Point(449, 317);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(239, 98);
            this.btn_Cadastrar.TabIndex = 1;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = false;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::FarmaciaPagueMenos.Properties.Resources.logo_farmacias_pague_menos_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.btn_jaSouCliente);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "PagueMenos";
            this.TransparencyKey = System.Drawing.Color.Aqua;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.Button btn_jaSouCliente;
    }
}


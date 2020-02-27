namespace FarmaciaPagueMenos
{
    partial class form_JaSouCliente
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
            this.lbl_Cpf = new System.Windows.Forms.Label();
            this.lbl_Senha = new System.Windows.Forms.Label();
            this.btn_Entrar = new System.Windows.Forms.Button();
            this.mskBox_Cpf = new System.Windows.Forms.MaskedTextBox();
            this.mskBox_Senha = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lbl_Cpf
            // 
            this.lbl_Cpf.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Cpf.AutoSize = true;
            this.lbl_Cpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(4)))));
            this.lbl_Cpf.Font = new System.Drawing.Font("MS Reference Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cpf.Location = new System.Drawing.Point(80, 90);
            this.lbl_Cpf.Name = "lbl_Cpf";
            this.lbl_Cpf.Size = new System.Drawing.Size(106, 46);
            this.lbl_Cpf.TabIndex = 0;
            this.lbl_Cpf.Text = "CPF:";
            // 
            // lbl_Senha
            // 
            this.lbl_Senha.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Senha.AutoSize = true;
            this.lbl_Senha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(4)))));
            this.lbl_Senha.Font = new System.Drawing.Font("MS Reference Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Senha.Location = new System.Drawing.Point(34, 287);
            this.lbl_Senha.Name = "lbl_Senha";
            this.lbl_Senha.Size = new System.Drawing.Size(152, 46);
            this.lbl_Senha.TabIndex = 1;
            this.lbl_Senha.Text = "Senha:";
            // 
            // btn_Entrar
            // 
            this.btn_Entrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Entrar.BackColor = System.Drawing.Color.MintCream;
            this.btn_Entrar.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Entrar.Location = new System.Drawing.Point(244, 365);
            this.btn_Entrar.Name = "btn_Entrar";
            this.btn_Entrar.Size = new System.Drawing.Size(268, 73);
            this.btn_Entrar.TabIndex = 4;
            this.btn_Entrar.Text = "ENTRAR";
            this.btn_Entrar.UseVisualStyleBackColor = false;
            this.btn_Entrar.Click += new System.EventHandler(this.btn_Entrar_Click);
            // 
            // mskBox_Cpf
            // 
            this.mskBox_Cpf.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mskBox_Cpf.Font = new System.Drawing.Font("MS Reference Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskBox_Cpf.Location = new System.Drawing.Point(201, 90);
            this.mskBox_Cpf.Mask = "000-000-000-00";
            this.mskBox_Cpf.Name = "mskBox_Cpf";
            this.mskBox_Cpf.Size = new System.Drawing.Size(384, 52);
            this.mskBox_Cpf.TabIndex = 5;
            this.mskBox_Cpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mskBox_Senha
            // 
            this.mskBox_Senha.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mskBox_Senha.Font = new System.Drawing.Font("MS Reference Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskBox_Senha.Location = new System.Drawing.Point(201, 287);
            this.mskBox_Senha.Name = "mskBox_Senha";
            this.mskBox_Senha.Size = new System.Drawing.Size(384, 52);
            this.mskBox_Senha.TabIndex = 6;
            this.mskBox_Senha.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskBox_Senha.UseSystemPasswordChar = true;
            // 
            // form_JaSouCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::FarmaciaPagueMenos.Properties.Resources.logo_farmacias_pague_menos_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(797, 476);
            this.Controls.Add(this.mskBox_Senha);
            this.Controls.Add(this.mskBox_Cpf);
            this.Controls.Add(this.btn_Entrar);
            this.Controls.Add(this.lbl_Senha);
            this.Controls.Add(this.lbl_Cpf);
            this.Name = "form_JaSouCliente";
            this.Text = "PagueMenos";
            this.Load += new System.EventHandler(this.form_JaSouCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Cpf;
        private System.Windows.Forms.Label lbl_Senha;
        private System.Windows.Forms.Button btn_Entrar;
        private System.Windows.Forms.MaskedTextBox mskBox_Cpf;
        private System.Windows.Forms.MaskedTextBox mskBox_Senha;
    }
}
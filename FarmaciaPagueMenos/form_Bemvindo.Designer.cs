namespace FarmaciaPagueMenos
{
    partial class form_Bemvindo
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
            this.lbl_Bemvindo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.promoçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promoçõesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Bemvindo
            // 
            this.lbl_Bemvindo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Bemvindo.AutoSize = true;
            this.lbl_Bemvindo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(4)))));
            this.lbl_Bemvindo.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bemvindo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(4)))));
            this.lbl_Bemvindo.Location = new System.Drawing.Point(310, 54);
            this.lbl_Bemvindo.Name = "lbl_Bemvindo";
            this.lbl_Bemvindo.Size = new System.Drawing.Size(153, 29);
            this.lbl_Bemvindo.TabIndex = 0;
            this.lbl_Bemvindo.Text = "Bem-Vindo!";
            this.lbl_Bemvindo.Click += new System.EventHandler(this.lbl_Bemvindo_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.promoçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // promoçõesToolStripMenuItem
            // 
            this.promoçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.promoçõesToolStripMenuItem1});
            this.promoçõesToolStripMenuItem.Name = "promoçõesToolStripMenuItem";
            this.promoçõesToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.promoçõesToolStripMenuItem.Text = "Menu";
            this.promoçõesToolStripMenuItem.Click += new System.EventHandler(this.promoçõesToolStripMenuItem_Click);
            // 
            // promoçõesToolStripMenuItem1
            // 
            this.promoçõesToolStripMenuItem1.Name = "promoçõesToolStripMenuItem1";
            this.promoçõesToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.promoçõesToolStripMenuItem1.Text = "Promoções";
            this.promoçõesToolStripMenuItem1.Click += new System.EventHandler(this.promoçõesToolStripMenuItem1_Click);
            // 
            // form_Bemvindo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FarmaciaPagueMenos.Properties.Resources.logo_farmacias_pague_menos_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Bemvindo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "form_Bemvindo";
            this.Text = "PagueMenos";
            this.Load += new System.EventHandler(this.form_Bemvindo_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Bemvindo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem promoçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promoçõesToolStripMenuItem1;
    }
}
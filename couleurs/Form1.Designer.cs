namespace Menu
{
    partial class couleurtexte
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(couleurtexte));
            this.EtiquetteSaisie = new System.Windows.Forms.Label();
            this.texte = new System.Windows.Forms.TextBox();
            this.checkboxfond = new System.Windows.Forms.CheckBox();
            this.checkboxcarac = new System.Windows.Forms.CheckBox();
            this.checkboxcasse = new System.Windows.Forms.CheckBox();
            this.affichage = new System.Windows.Forms.TextBox();
            this.listechoix = new System.Windows.Forms.GroupBox();
            this.listefond = new System.Windows.Forms.GroupBox();
            this.brfondbleu = new System.Windows.Forms.RadioButton();
            this.brfondvert = new System.Windows.Forms.RadioButton();
            this.brfondrouge = new System.Windows.Forms.RadioButton();
            this.listecoulcarc = new System.Windows.Forms.GroupBox();
            this.brcNoir = new System.Windows.Forms.RadioButton();
            this.brcblanc = new System.Windows.Forms.RadioButton();
            this.brcrouge = new System.Windows.Forms.RadioButton();
            this.listecasse = new System.Windows.Forms.GroupBox();
            this.brmaj = new System.Windows.Forms.RadioButton();
            this.brmin = new System.Windows.Forms.RadioButton();
            this.listechoix.SuspendLayout();
            this.listefond.SuspendLayout();
            this.listecoulcarc.SuspendLayout();
            this.listecasse.SuspendLayout();
            this.SuspendLayout();
            // 
            // EtiquetteSaisie
            // 
            this.EtiquetteSaisie.AutoSize = true;
            this.EtiquetteSaisie.Location = new System.Drawing.Point(12, 9);
            this.EtiquetteSaisie.Name = "EtiquetteSaisie";
            this.EtiquetteSaisie.Size = new System.Drawing.Size(104, 13);
            this.EtiquetteSaisie.TabIndex = 0;
            this.EtiquetteSaisie.Text = "Saisir votre texte ici :";
            // 
            // texte
            // 
            this.texte.Location = new System.Drawing.Point(13, 38);
            this.texte.Name = "texte";
            this.texte.Size = new System.Drawing.Size(413, 20);
            this.texte.TabIndex = 1;
            this.texte.TextChanged += new System.EventHandler(this.texte_TextChanged);
            // 
            // checkboxfond
            // 
            this.checkboxfond.AutoSize = true;
            this.checkboxfond.Location = new System.Drawing.Point(6, 19);
            this.checkboxfond.Name = "checkboxfond";
            this.checkboxfond.Size = new System.Drawing.Size(101, 17);
            this.checkboxfond.TabIndex = 2;
            this.checkboxfond.Text = "Couleur du fond";
            this.checkboxfond.UseVisualStyleBackColor = true;
            this.checkboxfond.CheckedChanged += new System.EventHandler(this.checkboxfond_CheckedChanged);
            // 
            // checkboxcarac
            // 
            this.checkboxcarac.AutoSize = true;
            this.checkboxcarac.Location = new System.Drawing.Point(6, 42);
            this.checkboxcarac.Name = "checkboxcarac";
            this.checkboxcarac.Size = new System.Drawing.Size(135, 17);
            this.checkboxcarac.TabIndex = 3;
            this.checkboxcarac.Text = "Couleur des caractères";
            this.checkboxcarac.UseVisualStyleBackColor = true;
            this.checkboxcarac.CheckedChanged += new System.EventHandler(this.checkboxcarac_CheckedChanged);
            // 
            // checkboxcasse
            // 
            this.checkboxcasse.AutoSize = true;
            this.checkboxcasse.Location = new System.Drawing.Point(6, 65);
            this.checkboxcasse.Name = "checkboxcasse";
            this.checkboxcasse.Size = new System.Drawing.Size(55, 17);
            this.checkboxcasse.TabIndex = 4;
            this.checkboxcasse.Text = "Casse";
            this.checkboxcasse.UseVisualStyleBackColor = true;
            this.checkboxcasse.CheckedChanged += new System.EventHandler(this.checkboxcasse_CheckedChanged);
            // 
            // affichage
            // 
            this.affichage.ForeColor = System.Drawing.Color.Teal;
            this.affichage.Location = new System.Drawing.Point(15, 87);
            this.affichage.Name = "affichage";
            this.affichage.Size = new System.Drawing.Size(410, 20);
            this.affichage.TabIndex = 5;
            this.affichage.Visible = false;
            // 
            // listechoix
            // 
            this.listechoix.Controls.Add(this.checkboxfond);
            this.listechoix.Controls.Add(this.checkboxcarac);
            this.listechoix.Controls.Add(this.checkboxcasse);
            this.listechoix.Enabled = false;
            this.listechoix.Location = new System.Drawing.Point(459, 9);
            this.listechoix.Name = "listechoix";
            this.listechoix.Size = new System.Drawing.Size(141, 98);
            this.listechoix.TabIndex = 6;
            this.listechoix.TabStop = false;
            this.listechoix.Text = "Choix";
            // 
            // listefond
            // 
            this.listefond.Controls.Add(this.brfondbleu);
            this.listefond.Controls.Add(this.brfondvert);
            this.listefond.Controls.Add(this.brfondrouge);
            this.listefond.Location = new System.Drawing.Point(15, 133);
            this.listefond.Name = "listefond";
            this.listefond.Size = new System.Drawing.Size(113, 117);
            this.listefond.TabIndex = 7;
            this.listefond.TabStop = false;
            this.listefond.Text = "Fond";
            this.listefond.Visible = false;
            // 
            // brfondbleu
            // 
            this.brfondbleu.AutoSize = true;
            this.brfondbleu.Location = new System.Drawing.Point(7, 94);
            this.brfondbleu.Name = "brfondbleu";
            this.brfondbleu.Size = new System.Drawing.Size(46, 17);
            this.brfondbleu.TabIndex = 2;
            this.brfondbleu.TabStop = true;
            this.brfondbleu.Text = "Bleu";
            this.brfondbleu.UseVisualStyleBackColor = true;
            this.brfondbleu.CheckedChanged += new System.EventHandler(this.brfondbleu_CheckedChanged);
            // 
            // brfondvert
            // 
            this.brfondvert.AutoSize = true;
            this.brfondvert.Location = new System.Drawing.Point(7, 56);
            this.brfondvert.Name = "brfondvert";
            this.brfondvert.Size = new System.Drawing.Size(44, 17);
            this.brfondvert.TabIndex = 1;
            this.brfondvert.TabStop = true;
            this.brfondvert.Text = "Vert";
            this.brfondvert.UseVisualStyleBackColor = true;
            this.brfondvert.CheckedChanged += new System.EventHandler(this.brfondvert_CheckedChanged);
            // 
            // brfondrouge
            // 
            this.brfondrouge.AutoSize = true;
            this.brfondrouge.Location = new System.Drawing.Point(7, 20);
            this.brfondrouge.Name = "brfondrouge";
            this.brfondrouge.Size = new System.Drawing.Size(57, 17);
            this.brfondrouge.TabIndex = 0;
            this.brfondrouge.TabStop = true;
            this.brfondrouge.Text = "Rouge";
            this.brfondrouge.UseVisualStyleBackColor = true;
            this.brfondrouge.CheckedChanged += new System.EventHandler(this.brfondrouge_CheckedChanged);
            // 
            // listecoulcarc
            // 
            this.listecoulcarc.Controls.Add(this.brcNoir);
            this.listecoulcarc.Controls.Add(this.brcblanc);
            this.listecoulcarc.Controls.Add(this.brcrouge);
            this.listecoulcarc.Location = new System.Drawing.Point(134, 133);
            this.listecoulcarc.Name = "listecoulcarc";
            this.listecoulcarc.Size = new System.Drawing.Size(120, 117);
            this.listecoulcarc.TabIndex = 8;
            this.listecoulcarc.TabStop = false;
            this.listecoulcarc.Text = "Caractères";
            this.listecoulcarc.Visible = false;
            // 
            // brcNoir
            // 
            this.brcNoir.AutoSize = true;
            this.brcNoir.Location = new System.Drawing.Point(7, 94);
            this.brcNoir.Name = "brcNoir";
            this.brcNoir.Size = new System.Drawing.Size(44, 17);
            this.brcNoir.TabIndex = 2;
            this.brcNoir.TabStop = true;
            this.brcNoir.Text = "Noir";
            this.brcNoir.UseVisualStyleBackColor = true;
            this.brcNoir.Click += new System.EventHandler(this.brcc_CheckedChanged);
            // 
            // brcblanc
            // 
            this.brcblanc.AutoSize = true;
            this.brcblanc.Location = new System.Drawing.Point(7, 56);
            this.brcblanc.Name = "brcblanc";
            this.brcblanc.Size = new System.Drawing.Size(52, 17);
            this.brcblanc.TabIndex = 1;
            this.brcblanc.TabStop = true;
            this.brcblanc.Text = "Blanc";
            this.brcblanc.UseVisualStyleBackColor = true;
            this.brcblanc.CheckedChanged += new System.EventHandler(this.brcc_CheckedChanged);
            // 
            // brcrouge
            // 
            this.brcrouge.AutoSize = true;
            this.brcrouge.Location = new System.Drawing.Point(7, 20);
            this.brcrouge.Name = "brcrouge";
            this.brcrouge.Size = new System.Drawing.Size(57, 17);
            this.brcrouge.TabIndex = 0;
            this.brcrouge.TabStop = true;
            this.brcrouge.Text = "Rouge";
            this.brcrouge.UseVisualStyleBackColor = true;
            this.brcrouge.CheckedChanged += new System.EventHandler(this.brcc_CheckedChanged);
            // 
            // listecasse
            // 
            this.listecasse.Controls.Add(this.brmaj);
            this.listecasse.Controls.Add(this.brmin);
            this.listecasse.Location = new System.Drawing.Point(260, 163);
            this.listecasse.Name = "listecasse";
            this.listecasse.Size = new System.Drawing.Size(107, 87);
            this.listecasse.TabIndex = 9;
            this.listecasse.TabStop = false;
            this.listecasse.Text = "Casse";
            this.listecasse.Visible = false;
            // 
            // brmaj
            // 
            this.brmaj.AutoSize = true;
            this.brmaj.Location = new System.Drawing.Point(7, 64);
            this.brmaj.Name = "brmaj";
            this.brmaj.Size = new System.Drawing.Size(73, 17);
            this.brmaj.TabIndex = 1;
            this.brmaj.TabStop = true;
            this.brmaj.Text = "Majuscule";
            this.brmaj.UseVisualStyleBackColor = true;
            this.brmaj.CheckedChanged += new System.EventHandler(this.casse_CheckedChanged);
            // 
            // brmin
            // 
            this.brmin.AutoSize = true;
            this.brmin.Location = new System.Drawing.Point(7, 26);
            this.brmin.Name = "brmin";
            this.brmin.Size = new System.Drawing.Size(73, 17);
            this.brmin.TabIndex = 0;
            this.brmin.TabStop = true;
            this.brmin.Text = "Minuscule";
            this.brmin.UseVisualStyleBackColor = true;
            this.brmin.CheckedChanged += new System.EventHandler(this.casse_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 262);
            this.Controls.Add(this.listecasse);
            this.Controls.Add(this.listecoulcarc);
            this.Controls.Add(this.listefond);
            this.Controls.Add(this.listechoix);
            this.Controls.Add(this.affichage);
            this.Controls.Add(this.texte);
            this.Controls.Add(this.EtiquetteSaisie);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teste de couleurs";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.listechoix.ResumeLayout(false);
            this.listechoix.PerformLayout();
            this.listefond.ResumeLayout(false);
            this.listefond.PerformLayout();
            this.listecoulcarc.ResumeLayout(false);
            this.listecoulcarc.PerformLayout();
            this.listecasse.ResumeLayout(false);
            this.listecasse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EtiquetteSaisie;
        private System.Windows.Forms.TextBox texte;
        private System.Windows.Forms.CheckBox checkboxfond;
        private System.Windows.Forms.CheckBox checkboxcarac;
        private System.Windows.Forms.CheckBox checkboxcasse;
        private System.Windows.Forms.TextBox affichage;
        private System.Windows.Forms.GroupBox listechoix;
        private System.Windows.Forms.GroupBox listefond;
        private System.Windows.Forms.RadioButton brfondbleu;
        private System.Windows.Forms.RadioButton brfondvert;
        private System.Windows.Forms.RadioButton brfondrouge;
        private System.Windows.Forms.GroupBox listecoulcarc;
        private System.Windows.Forms.RadioButton brcNoir;
        private System.Windows.Forms.RadioButton brcblanc;
        private System.Windows.Forms.RadioButton brcrouge;
        private System.Windows.Forms.GroupBox listecasse;
        private System.Windows.Forms.RadioButton brmaj;
        private System.Windows.Forms.RadioButton brmin;
    }
}


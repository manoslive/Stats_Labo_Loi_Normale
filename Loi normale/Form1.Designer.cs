namespace Loi_normale
{
    partial class Form1
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
            this.TB_TailleEchantillon = new System.Windows.Forms.TextBox();
            this.TB_Niveau = new System.Windows.Forms.TextBox();
            this.TB_Marge = new System.Windows.Forms.TextBox();
            this.TB_Moyenne = new System.Windows.Forms.TextBox();
            this.TB_Ecart = new System.Windows.Forms.TextBox();
            this.LB_TailleEchantillon = new System.Windows.Forms.Label();
            this.LB_Niveau = new System.Windows.Forms.Label();
            this.LB_Marge = new System.Windows.Forms.Label();
            this.LB_Moyenne = new System.Windows.Forms.Label();
            this.LB_Ecart = new System.Windows.Forms.Label();
            this.BTN_Calculer = new System.Windows.Forms.Button();
            this.BTN_Vider = new System.Windows.Forms.Button();
            this.TB_Reponse = new System.Windows.Forms.TextBox();
            this.LB_Reponse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_TailleEchantillon
            // 
            this.TB_TailleEchantillon.Location = new System.Drawing.Point(246, 38);
            this.TB_TailleEchantillon.Name = "TB_TailleEchantillon";
            this.TB_TailleEchantillon.Size = new System.Drawing.Size(229, 26);
            this.TB_TailleEchantillon.TabIndex = 0;
            // 
            // TB_Niveau
            // 
            this.TB_Niveau.Location = new System.Drawing.Point(246, 74);
            this.TB_Niveau.Name = "TB_Niveau";
            this.TB_Niveau.Size = new System.Drawing.Size(229, 26);
            this.TB_Niveau.TabIndex = 0;
            // 
            // TB_Marge
            // 
            this.TB_Marge.Location = new System.Drawing.Point(246, 113);
            this.TB_Marge.Name = "TB_Marge";
            this.TB_Marge.Size = new System.Drawing.Size(229, 26);
            this.TB_Marge.TabIndex = 0;
            // 
            // TB_Moyenne
            // 
            this.TB_Moyenne.Location = new System.Drawing.Point(246, 152);
            this.TB_Moyenne.Name = "TB_Moyenne";
            this.TB_Moyenne.Size = new System.Drawing.Size(229, 26);
            this.TB_Moyenne.TabIndex = 0;
            // 
            // TB_Ecart
            // 
            this.TB_Ecart.Location = new System.Drawing.Point(246, 189);
            this.TB_Ecart.Name = "TB_Ecart";
            this.TB_Ecart.Size = new System.Drawing.Size(229, 26);
            this.TB_Ecart.TabIndex = 0;
            // 
            // LB_TailleEchantillon
            // 
            this.LB_TailleEchantillon.AutoSize = true;
            this.LB_TailleEchantillon.Location = new System.Drawing.Point(26, 41);
            this.LB_TailleEchantillon.Name = "LB_TailleEchantillon";
            this.LB_TailleEchantillon.Size = new System.Drawing.Size(129, 20);
            this.LB_TailleEchantillon.TabIndex = 2;
            this.LB_TailleEchantillon.Text = "Taille échantillon:";
            // 
            // LB_Niveau
            // 
            this.LB_Niveau.AutoSize = true;
            this.LB_Niveau.Location = new System.Drawing.Point(26, 77);
            this.LB_Niveau.Name = "LB_Niveau";
            this.LB_Niveau.Size = new System.Drawing.Size(206, 20);
            this.LB_Niveau.TabIndex = 2;
            this.LB_Niveau.Text = "Niveau de confiance (en %):";
            // 
            // LB_Marge
            // 
            this.LB_Marge.AutoSize = true;
            this.LB_Marge.Location = new System.Drawing.Point(26, 116);
            this.LB_Marge.Name = "LB_Marge";
            this.LB_Marge.Size = new System.Drawing.Size(116, 20);
            this.LB_Marge.TabIndex = 2;
            this.LB_Marge.Text = "Marge d\'erreur:";
            // 
            // LB_Moyenne
            // 
            this.LB_Moyenne.AutoSize = true;
            this.LB_Moyenne.Location = new System.Drawing.Point(26, 155);
            this.LB_Moyenne.Name = "LB_Moyenne";
            this.LB_Moyenne.Size = new System.Drawing.Size(186, 20);
            this.LB_Moyenne.TabIndex = 2;
            this.LB_Moyenne.Text = "Moyenne de l\'échantillon:";
            // 
            // LB_Ecart
            // 
            this.LB_Ecart.AutoSize = true;
            this.LB_Ecart.Location = new System.Drawing.Point(26, 192);
            this.LB_Ecart.Name = "LB_Ecart";
            this.LB_Ecart.Size = new System.Drawing.Size(193, 20);
            this.LB_Ecart.TabIndex = 2;
            this.LB_Ecart.Text = "Écart type de l\'échantillon:";
            // 
            // BTN_Calculer
            // 
            this.BTN_Calculer.Location = new System.Drawing.Point(368, 279);
            this.BTN_Calculer.Name = "BTN_Calculer";
            this.BTN_Calculer.Size = new System.Drawing.Size(107, 31);
            this.BTN_Calculer.TabIndex = 3;
            this.BTN_Calculer.Text = "Calculer";
            this.BTN_Calculer.UseVisualStyleBackColor = true;
            // 
            // BTN_Vider
            // 
            this.BTN_Vider.Location = new System.Drawing.Point(246, 279);
            this.BTN_Vider.Name = "BTN_Vider";
            this.BTN_Vider.Size = new System.Drawing.Size(107, 31);
            this.BTN_Vider.TabIndex = 3;
            this.BTN_Vider.Text = "Vider";
            this.BTN_Vider.UseVisualStyleBackColor = true;
            this.BTN_Vider.Click += new System.EventHandler(this.BTN_Vider_Click);
            // 
            // TB_Reponse
            // 
            this.TB_Reponse.Location = new System.Drawing.Point(246, 227);
            this.TB_Reponse.Name = "TB_Reponse";
            this.TB_Reponse.Size = new System.Drawing.Size(229, 26);
            this.TB_Reponse.TabIndex = 0;
            // 
            // LB_Reponse
            // 
            this.LB_Reponse.AutoSize = true;
            this.LB_Reponse.Location = new System.Drawing.Point(26, 230);
            this.LB_Reponse.Name = "LB_Reponse";
            this.LB_Reponse.Size = new System.Drawing.Size(78, 20);
            this.LB_Reponse.TabIndex = 2;
            this.LB_Reponse.Text = "Réponse:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 323);
            this.Controls.Add(this.BTN_Vider);
            this.Controls.Add(this.BTN_Calculer);
            this.Controls.Add(this.LB_Reponse);
            this.Controls.Add(this.LB_Ecart);
            this.Controls.Add(this.LB_Moyenne);
            this.Controls.Add(this.LB_Marge);
            this.Controls.Add(this.LB_Niveau);
            this.Controls.Add(this.LB_TailleEchantillon);
            this.Controls.Add(this.TB_Reponse);
            this.Controls.Add(this.TB_Ecart);
            this.Controls.Add(this.TB_Moyenne);
            this.Controls.Add(this.TB_Marge);
            this.Controls.Add(this.TB_Niveau);
            this.Controls.Add(this.TB_TailleEchantillon);
            this.Name = "Form1";
            this.Text = "Calculer loi normale";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_TailleEchantillon;
        private System.Windows.Forms.TextBox TB_Niveau;
        private System.Windows.Forms.TextBox TB_Marge;
        private System.Windows.Forms.TextBox TB_Moyenne;
        private System.Windows.Forms.TextBox TB_Ecart;
        private System.Windows.Forms.Label LB_TailleEchantillon;
        private System.Windows.Forms.Label LB_Niveau;
        private System.Windows.Forms.Label LB_Marge;
        private System.Windows.Forms.Label LB_Moyenne;
        private System.Windows.Forms.Label LB_Ecart;
        private System.Windows.Forms.Button BTN_Calculer;
        private System.Windows.Forms.Button BTN_Vider;
        private System.Windows.Forms.TextBox TB_Reponse;
        private System.Windows.Forms.Label LB_Reponse;
    }
}


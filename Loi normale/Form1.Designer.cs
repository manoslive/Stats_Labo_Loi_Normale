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
            this.TB_Moyenne = new System.Windows.Forms.TextBox();
            this.TB_Ecart = new System.Windows.Forms.TextBox();
            this.LB_Moyenne = new System.Windows.Forms.Label();
            this.LB_Ecart = new System.Windows.Forms.Label();
            this.BTN_Calculer = new System.Windows.Forms.Button();
            this.BTN_Vider = new System.Windows.Forms.Button();
            this.TB_Reponse = new System.Windows.Forms.TextBox();
            this.LB_Reponse = new System.Windows.Forms.Label();
            this.DGV_Table = new System.Windows.Forms.DataGridView();
            this.TB_Min = new System.Windows.Forms.TextBox();
            this.TB_Max = new System.Windows.Forms.TextBox();
            this.LB_Min = new System.Windows.Forms.Label();
            this.LB_Max = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_Moyenne
            // 
            this.TB_Moyenne.Location = new System.Drawing.Point(166, 70);
            this.TB_Moyenne.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB_Moyenne.Name = "TB_Moyenne";
            this.TB_Moyenne.Size = new System.Drawing.Size(154, 20);
            this.TB_Moyenne.TabIndex = 0;
            // 
            // TB_Ecart
            // 
            this.TB_Ecart.Location = new System.Drawing.Point(166, 97);
            this.TB_Ecart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB_Ecart.Name = "TB_Ecart";
            this.TB_Ecart.Size = new System.Drawing.Size(154, 20);
            this.TB_Ecart.TabIndex = 0;
            // 
            // LB_Moyenne
            // 
            this.LB_Moyenne.AutoSize = true;
            this.LB_Moyenne.Location = new System.Drawing.Point(19, 72);
            this.LB_Moyenne.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Moyenne.Name = "LB_Moyenne";
            this.LB_Moyenne.Size = new System.Drawing.Size(127, 13);
            this.LB_Moyenne.TabIndex = 2;
            this.LB_Moyenne.Text = "Moyenne de l\'échantillon:";
            // 
            // LB_Ecart
            // 
            this.LB_Ecart.AutoSize = true;
            this.LB_Ecart.Location = new System.Drawing.Point(19, 99);
            this.LB_Ecart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Ecart.Name = "LB_Ecart";
            this.LB_Ecart.Size = new System.Drawing.Size(131, 13);
            this.LB_Ecart.TabIndex = 2;
            this.LB_Ecart.Text = "Écart type de l\'échantillon:";
            // 
            // BTN_Calculer
            // 
            this.BTN_Calculer.Location = new System.Drawing.Point(245, 181);
            this.BTN_Calculer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_Calculer.Name = "BTN_Calculer";
            this.BTN_Calculer.Size = new System.Drawing.Size(71, 20);
            this.BTN_Calculer.TabIndex = 3;
            this.BTN_Calculer.Text = "Calculer";
            this.BTN_Calculer.UseVisualStyleBackColor = true;
            this.BTN_Calculer.Click += new System.EventHandler(this.BTN_Calculer_Click);
            // 
            // BTN_Vider
            // 
            this.BTN_Vider.Location = new System.Drawing.Point(164, 181);
            this.BTN_Vider.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_Vider.Name = "BTN_Vider";
            this.BTN_Vider.Size = new System.Drawing.Size(71, 20);
            this.BTN_Vider.TabIndex = 3;
            this.BTN_Vider.Text = "Vider";
            this.BTN_Vider.UseVisualStyleBackColor = true;
            this.BTN_Vider.Click += new System.EventHandler(this.BTN_Vider_Click);
            // 
            // TB_Reponse
            // 
            this.TB_Reponse.Location = new System.Drawing.Point(166, 123);
            this.TB_Reponse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB_Reponse.Name = "TB_Reponse";
            this.TB_Reponse.Size = new System.Drawing.Size(154, 20);
            this.TB_Reponse.TabIndex = 0;
            // 
            // LB_Reponse
            // 
            this.LB_Reponse.AutoSize = true;
            this.LB_Reponse.Location = new System.Drawing.Point(19, 123);
            this.LB_Reponse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Reponse.Name = "LB_Reponse";
            this.LB_Reponse.Size = new System.Drawing.Size(53, 13);
            this.LB_Reponse.TabIndex = 2;
            this.LB_Reponse.Text = "Réponse:";
            // 
            // DGV_Table
            // 
            this.DGV_Table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGV_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Table.ColumnHeadersVisible = false;
            this.DGV_Table.Location = new System.Drawing.Point(354, 12);
            this.DGV_Table.Name = "DGV_Table";
            this.DGV_Table.Size = new System.Drawing.Size(269, 186);
            this.DGV_Table.TabIndex = 4;
            // 
            // TB_Min
            // 
            this.TB_Min.Location = new System.Drawing.Point(166, 16);
            this.TB_Min.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB_Min.Name = "TB_Min";
            this.TB_Min.Size = new System.Drawing.Size(154, 20);
            this.TB_Min.TabIndex = 0;
            // 
            // TB_Max
            // 
            this.TB_Max.Location = new System.Drawing.Point(166, 43);
            this.TB_Max.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB_Max.Name = "TB_Max";
            this.TB_Max.Size = new System.Drawing.Size(154, 20);
            this.TB_Max.TabIndex = 0;
            // 
            // LB_Min
            // 
            this.LB_Min.AutoSize = true;
            this.LB_Min.Location = new System.Drawing.Point(19, 18);
            this.LB_Min.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Min.Name = "LB_Min";
            this.LB_Min.Size = new System.Drawing.Size(122, 13);
            this.LB_Min.TabIndex = 2;
            this.LB_Min.Text = "Minimum / Supérieure à:";
            // 
            // LB_Max
            // 
            this.LB_Max.AutoSize = true;
            this.LB_Max.Location = new System.Drawing.Point(19, 45);
            this.LB_Max.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Max.Name = "LB_Max";
            this.LB_Max.Size = new System.Drawing.Size(118, 13);
            this.LB_Max.TabIndex = 2;
            this.LB_Max.Text = "Maximum / Inférieure à:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 210);
            this.Controls.Add(this.DGV_Table);
            this.Controls.Add(this.BTN_Vider);
            this.Controls.Add(this.BTN_Calculer);
            this.Controls.Add(this.LB_Reponse);
            this.Controls.Add(this.LB_Max);
            this.Controls.Add(this.LB_Ecart);
            this.Controls.Add(this.LB_Min);
            this.Controls.Add(this.LB_Moyenne);
            this.Controls.Add(this.TB_Max);
            this.Controls.Add(this.TB_Reponse);
            this.Controls.Add(this.TB_Min);
            this.Controls.Add(this.TB_Ecart);
            this.Controls.Add(this.TB_Moyenne);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Calculer loi normale";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Moyenne;
        private System.Windows.Forms.TextBox TB_Ecart;
        private System.Windows.Forms.Label LB_Moyenne;
        private System.Windows.Forms.Label LB_Ecart;
        private System.Windows.Forms.Button BTN_Calculer;
        private System.Windows.Forms.Button BTN_Vider;
        private System.Windows.Forms.TextBox TB_Reponse;
        private System.Windows.Forms.Label LB_Reponse;
        private System.Windows.Forms.DataGridView DGV_Table;
        private System.Windows.Forms.TextBox TB_Min;
        private System.Windows.Forms.TextBox TB_Max;
        private System.Windows.Forms.Label LB_Min;
        private System.Windows.Forms.Label LB_Max;
    }
}


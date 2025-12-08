namespace Office_Büromaterialienbestellung
{
    partial class FormMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelBestellungen = new System.Windows.Forms.Label();
            this.listViewAllProducts = new System.Windows.Forms.ListView();
            this.buttonAllesBestellt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelBestellungen
            // 
            this.labelBestellungen.AutoSize = true;
            this.labelBestellungen.Location = new System.Drawing.Point(24, 32);
            this.labelBestellungen.Name = "labelBestellungen";
            this.labelBestellungen.Size = new System.Drawing.Size(179, 25);
            this.labelBestellungen.TabIndex = 1;
            this.labelBestellungen.Text = "Alle Bestellungen";
            // 
            // listViewAllProducts
            // 
            this.listViewAllProducts.HideSelection = false;
            this.listViewAllProducts.Location = new System.Drawing.Point(12, 103);
            this.listViewAllProducts.Name = "listViewAllProducts";
            this.listViewAllProducts.Size = new System.Drawing.Size(787, 950);
            this.listViewAllProducts.TabIndex = 2;
            this.listViewAllProducts.UseCompatibleStateImageBehavior = false;
            this.listViewAllProducts.DoubleClick += new System.EventHandler(this.listViewAllProducts_DoubleClick);
            // 
            // buttonAllesBestellt
            // 
            this.buttonAllesBestellt.Location = new System.Drawing.Point(209, 20);
            this.buttonAllesBestellt.Name = "buttonAllesBestellt";
            this.buttonAllesBestellt.Size = new System.Drawing.Size(217, 48);
            this.buttonAllesBestellt.TabIndex = 4;
            this.buttonAllesBestellt.Text = "Alles Bestellt";
            this.buttonAllesBestellt.UseVisualStyleBackColor = true;
            this.buttonAllesBestellt.Click += new System.EventHandler(this.allesBestellt_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 1101);
            this.Controls.Add(this.buttonAllesBestellt);
            this.Controls.Add(this.listViewAllProducts);
            this.Controls.Add(this.labelBestellungen);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelBestellungen;
        private System.Windows.Forms.ListView listViewAllProducts;
        private System.Windows.Forms.Button buttonAllesBestellt;
    }
}


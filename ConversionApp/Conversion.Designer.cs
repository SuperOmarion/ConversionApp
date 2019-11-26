namespace ConversionApp
{
    partial class Conversion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conversion));
            this.Historique = new System.Windows.Forms.GroupBox();
            this.ConversionHistory = new System.Windows.Forms.ListBox();
            this.Effacer_btn = new System.Windows.Forms.Button();
            this.EuroText = new System.Windows.Forms.TextBox();
            this.FrancText = new System.Windows.Forms.TextBox();
            this.FrancsToEuros_btn = new System.Windows.Forms.Button();
            this.EurosToFrancs_btn = new System.Windows.Forms.Button();
            this.BillsPicture = new System.Windows.Forms.PictureBox();
            this.EuroTextLabel = new System.Windows.Forms.Label();
            this.FrancTextLabel = new System.Windows.Forms.Label();
            this.Historique.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BillsPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // Historique
            // 
            this.Historique.Controls.Add(this.ConversionHistory);
            this.Historique.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Historique.Location = new System.Drawing.Point(12, 23);
            this.Historique.Name = "Historique";
            this.Historique.Size = new System.Drawing.Size(241, 362);
            this.Historique.TabIndex = 1;
            this.Historique.TabStop = false;
            this.Historique.Text = "Historique";
            // 
            // ConversionHistory
            // 
            this.ConversionHistory.FormattingEnabled = true;
            this.ConversionHistory.ItemHeight = 18;
            this.ConversionHistory.Location = new System.Drawing.Point(7, 23);
            this.ConversionHistory.Name = "ConversionHistory";
            this.ConversionHistory.Size = new System.Drawing.Size(228, 328);
            this.ConversionHistory.TabIndex = 0;
            // 
            // Effacer_btn
            // 
            this.Effacer_btn.Location = new System.Drawing.Point(66, 391);
            this.Effacer_btn.Name = "Effacer_btn";
            this.Effacer_btn.Size = new System.Drawing.Size(129, 48);
            this.Effacer_btn.TabIndex = 2;
            this.Effacer_btn.Text = "Effacer";
            this.Effacer_btn.UseVisualStyleBackColor = true;
            this.Effacer_btn.Click += new System.EventHandler(this.Effacer_btn_Click);
            // 
            // EuroText
            // 
            this.EuroText.Location = new System.Drawing.Point(344, 107);
            this.EuroText.Name = "EuroText";
            this.EuroText.Size = new System.Drawing.Size(160, 20);
            this.EuroText.TabIndex = 3;
            // 
            // FrancText
            // 
            this.FrancText.Location = new System.Drawing.Point(566, 107);
            this.FrancText.Name = "FrancText";
            this.FrancText.Size = new System.Drawing.Size(160, 20);
            this.FrancText.TabIndex = 3;
            // 
            // FrancsToEuros_btn
            // 
            this.FrancsToEuros_btn.Location = new System.Drawing.Point(469, 148);
            this.FrancsToEuros_btn.Name = "FrancsToEuros_btn";
            this.FrancsToEuros_btn.Size = new System.Drawing.Size(129, 48);
            this.FrancsToEuros_btn.TabIndex = 2;
            this.FrancsToEuros_btn.Text = "Francs -> Euros";
            this.FrancsToEuros_btn.UseVisualStyleBackColor = true;
            this.FrancsToEuros_btn.Click += new System.EventHandler(this.FrancsToEuros_btn_Click);
            // 
            // EurosToFrancs_btn
            // 
            this.EurosToFrancs_btn.Location = new System.Drawing.Point(469, 202);
            this.EurosToFrancs_btn.Name = "EurosToFrancs_btn";
            this.EurosToFrancs_btn.Size = new System.Drawing.Size(129, 48);
            this.EurosToFrancs_btn.TabIndex = 2;
            this.EurosToFrancs_btn.Text = "Euros -> Francs";
            this.EurosToFrancs_btn.UseVisualStyleBackColor = true;
            this.EurosToFrancs_btn.Click += new System.EventHandler(this.EurosToFrancs_btn_Click);
            // 
            // BillsPicture
            // 
            this.BillsPicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("BillsPicture.InitialImage")));
            this.BillsPicture.Location = new System.Drawing.Point(408, 272);
            this.BillsPicture.Name = "BillsPicture";
            this.BillsPicture.Size = new System.Drawing.Size(249, 194);
            this.BillsPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BillsPicture.TabIndex = 4;
            this.BillsPicture.TabStop = false;
            // 
            // EuroTextLabel
            // 
            this.EuroTextLabel.AutoSize = true;
            this.EuroTextLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EuroTextLabel.Location = new System.Drawing.Point(380, 75);
            this.EuroTextLabel.Name = "EuroTextLabel";
            this.EuroTextLabel.Size = new System.Drawing.Size(87, 29);
            this.EuroTextLabel.TabIndex = 5;
            this.EuroTextLabel.Text = "Euros €";
            // 
            // FrancTextLabel
            // 
            this.FrancTextLabel.AutoSize = true;
            this.FrancTextLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrancTextLabel.Location = new System.Drawing.Point(604, 75);
            this.FrancTextLabel.Name = "FrancTextLabel";
            this.FrancTextLabel.Size = new System.Drawing.Size(77, 29);
            this.FrancTextLabel.TabIndex = 5;
            this.FrancTextLabel.Text = "Francs";
            // 
            // Conversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 490);
            this.Controls.Add(this.FrancTextLabel);
            this.Controls.Add(this.EuroTextLabel);
            this.Controls.Add(this.BillsPicture);
            this.Controls.Add(this.FrancText);
            this.Controls.Add(this.EuroText);
            this.Controls.Add(this.EurosToFrancs_btn);
            this.Controls.Add(this.FrancsToEuros_btn);
            this.Controls.Add(this.Effacer_btn);
            this.Controls.Add(this.Historique);
            this.Name = "Conversion";
            this.Text = "Conversion";
            this.Load += new System.EventHandler(this.Conversion_Load);
            this.Historique.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BillsPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox Historique;
        private System.Windows.Forms.Button Effacer_btn;
        private System.Windows.Forms.TextBox EuroText;
        private System.Windows.Forms.TextBox FrancText;
        private System.Windows.Forms.Button FrancsToEuros_btn;
        private System.Windows.Forms.Button EurosToFrancs_btn;
        private System.Windows.Forms.PictureBox BillsPicture;
        private System.Windows.Forms.Label EuroTextLabel;
        private System.Windows.Forms.Label FrancTextLabel;
        private System.Windows.Forms.ListBox ConversionHistory;
    }
}


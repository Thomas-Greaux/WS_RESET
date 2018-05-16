namespace GUIClient
{
    partial class ClientForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.bikes_nb_text_box = new System.Windows.Forms.TextBox();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.stationComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Send request";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Send_request);
            // 
            // bikes_nb_text_box
            // 
            this.bikes_nb_text_box.Location = new System.Drawing.Point(64, 187);
            this.bikes_nb_text_box.Name = "bikes_nb_text_box";
            this.bikes_nb_text_box.Size = new System.Drawing.Size(185, 22);
            this.bikes_nb_text_box.TabIndex = 1;
            // 
            // cityComboBox
            // 
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Location = new System.Drawing.Point(64, 24);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(185, 24);
            this.cityComboBox.TabIndex = 2;
            this.cityComboBox.SelectedIndexChanged += new System.EventHandler(this.cityComboBox_SelectedIndexChanged);
            // 
            // stationComboBox
            // 
            this.stationComboBox.FormattingEnabled = true;
            this.stationComboBox.Location = new System.Drawing.Point(64, 86);
            this.stationComboBox.Name = "stationComboBox";
            this.stationComboBox.Size = new System.Drawing.Size(185, 24);
            this.stationComboBox.TabIndex = 3;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.stationComboBox);
            this.Controls.Add(this.cityComboBox);
            this.Controls.Add(this.bikes_nb_text_box);
            this.Controls.Add(this.button1);
            this.Name = "ClientForm";
            this.Text = "Client Form";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox bikes_nb_text_box;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.ComboBox stationComboBox;
    }
}


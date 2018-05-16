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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.stationComboBox = new System.Windows.Forms.ComboBox();
            this.bikes_nb_text_box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cityLabel = new System.Windows.Forms.Label();
            this.stationLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cityComboBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.stationComboBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.bikes_nb_text_box, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cityLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.stationLabel, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(460, 217);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // cityComboBox
            // 
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Location = new System.Drawing.Point(233, 3);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(224, 24);
            this.cityComboBox.TabIndex = 2;
            this.cityComboBox.SelectedIndexChanged += new System.EventHandler(this.cityComboBox_SelectedIndexChanged);
            // 
            // stationComboBox
            // 
            this.stationComboBox.FormattingEnabled = true;
            this.stationComboBox.Location = new System.Drawing.Point(233, 61);
            this.stationComboBox.Name = "stationComboBox";
            this.stationComboBox.Size = new System.Drawing.Size(224, 24);
            this.stationComboBox.TabIndex = 3;
            // 
            // bikes_nb_text_box
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.bikes_nb_text_box, 2);
            this.bikes_nb_text_box.Location = new System.Drawing.Point(3, 167);
            this.bikes_nb_text_box.Name = "bikes_nb_text_box";
            this.bikes_nb_text_box.Size = new System.Drawing.Size(454, 22);
            this.bikes_nb_text_box.TabIndex = 1;
            // 
            // button1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.button1, 2);
            this.button1.Location = new System.Drawing.Point(3, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(454, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Send request";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Send_request);
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(3, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(97, 17);
            this.cityLabel.TabIndex = 4;
            this.cityLabel.Text = "Choose a city:";
            // 
            // stationLabel
            // 
            this.stationLabel.AutoSize = true;
            this.stationLabel.Location = new System.Drawing.Point(3, 58);
            this.stationLabel.Name = "stationLabel";
            this.stationLabel.Size = new System.Drawing.Size(118, 17);
            this.stationLabel.TabIndex = 5;
            this.stationLabel.Text = "Choose a station:";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 253);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ClientForm";
            this.Text = "Client Form";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.ComboBox stationComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox bikes_nb_text_box;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label stationLabel;
    }
}


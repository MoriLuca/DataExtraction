namespace DataExtraction
{
    partial class Home
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listBoxElencoDataBase = new System.Windows.Forms.ListBox();
            this.listBoxColonne = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dateTimePickerPeriodoFine = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerPeriodoInizio = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBoxCommentoColonna = new System.Windows.Forms.RichTextBox();
            this.dataGridViewRisultatoRicerca = new System.Windows.Forms.DataGridView();
            this.listBoxTavole = new System.Windows.Forms.ListBox();
            this.buttonFiltraColonna = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRisultatoRicerca)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxElencoDataBase
            // 
            this.listBoxElencoDataBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxElencoDataBase.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxElencoDataBase.FormattingEnabled = true;
            this.listBoxElencoDataBase.ItemHeight = 17;
            this.listBoxElencoDataBase.Location = new System.Drawing.Point(12, 68);
            this.listBoxElencoDataBase.Name = "listBoxElencoDataBase";
            this.listBoxElencoDataBase.Size = new System.Drawing.Size(260, 259);
            this.listBoxElencoDataBase.TabIndex = 0;
            this.listBoxElencoDataBase.SelectedIndexChanged += new System.EventHandler(this.listBoxElencoDataBase_SelectedIndexChanged);
            // 
            // listBoxColonne
            // 
            this.listBoxColonne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxColonne.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxColonne.FormattingEnabled = true;
            this.listBoxColonne.ItemHeight = 17;
            this.listBoxColonne.Location = new System.Drawing.Point(295, 68);
            this.listBoxColonne.Name = "listBoxColonne";
            this.listBoxColonne.Size = new System.Drawing.Size(260, 412);
            this.listBoxColonne.TabIndex = 0;
            this.listBoxColonne.SelectedIndexChanged += new System.EventHandler(this.listBoxColonne_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dateTimePickerPeriodoFine);
            this.panel4.Controls.Add(this.dateTimePickerPeriodoInizio);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(12, 656);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(543, 84);
            this.panel4.TabIndex = 6;
            // 
            // dateTimePickerPeriodoFine
            // 
            this.dateTimePickerPeriodoFine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerPeriodoFine.Location = new System.Drawing.Point(226, 46);
            this.dateTimePickerPeriodoFine.Name = "dateTimePickerPeriodoFine";
            this.dateTimePickerPeriodoFine.Size = new System.Drawing.Size(183, 20);
            this.dateTimePickerPeriodoFine.TabIndex = 5;
            this.dateTimePickerPeriodoFine.Value = new System.DateTime(2017, 5, 22, 11, 39, 0, 0);
            // 
            // dateTimePickerPeriodoInizio
            // 
            this.dateTimePickerPeriodoInizio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerPeriodoInizio.Location = new System.Drawing.Point(226, 12);
            this.dateTimePickerPeriodoInizio.Name = "dateTimePickerPeriodoInizio";
            this.dateTimePickerPeriodoInizio.Size = new System.Drawing.Size(183, 20);
            this.dateTimePickerPeriodoInizio.TabIndex = 4;
            this.dateTimePickerPeriodoInizio.Value = new System.DateTime(2017, 5, 22, 11, 39, 0, 0);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(139, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data Fine";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data Inizio";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(12, 623);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(543, 34);
            this.panel3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(171, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Range Selezionato";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1734, 53);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(785, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Estrazione Dati";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(-3, 765);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1735, 10);
            this.panel2.TabIndex = 8;
            // 
            // richTextBoxCommentoColonna
            // 
            this.richTextBoxCommentoColonna.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxCommentoColonna.Location = new System.Drawing.Point(565, 70);
            this.richTextBoxCommentoColonna.Name = "richTextBoxCommentoColonna";
            this.richTextBoxCommentoColonna.Size = new System.Drawing.Size(1152, 41);
            this.richTextBoxCommentoColonna.TabIndex = 9;
            this.richTextBoxCommentoColonna.Text = "";
            // 
            // dataGridViewRisultatoRicerca
            // 
            this.dataGridViewRisultatoRicerca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRisultatoRicerca.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRisultatoRicerca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRisultatoRicerca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRisultatoRicerca.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewRisultatoRicerca.EnableHeadersVisualStyles = false;
            this.dataGridViewRisultatoRicerca.Location = new System.Drawing.Point(569, 117);
            this.dataGridViewRisultatoRicerca.Name = "dataGridViewRisultatoRicerca";
            this.dataGridViewRisultatoRicerca.Size = new System.Drawing.Size(1147, 623);
            this.dataGridViewRisultatoRicerca.TabIndex = 10;
            // 
            // listBoxTavole
            // 
            this.listBoxTavole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxTavole.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTavole.FormattingEnabled = true;
            this.listBoxTavole.ItemHeight = 17;
            this.listBoxTavole.Location = new System.Drawing.Point(12, 341);
            this.listBoxTavole.Name = "listBoxTavole";
            this.listBoxTavole.Size = new System.Drawing.Size(260, 259);
            this.listBoxTavole.TabIndex = 11;
            this.listBoxTavole.SelectedIndexChanged += new System.EventHandler(this.listBoxTavole_SelectedIndexChanged);
            // 
            // buttonFiltraColonna
            // 
            this.buttonFiltraColonna.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFiltraColonna.Location = new System.Drawing.Point(295, 495);
            this.buttonFiltraColonna.Name = "buttonFiltraColonna";
            this.buttonFiltraColonna.Size = new System.Drawing.Size(259, 52);
            this.buttonFiltraColonna.TabIndex = 12;
            this.buttonFiltraColonna.Text = "Filtra Singola Colonna";
            this.buttonFiltraColonna.UseVisualStyleBackColor = true;
            this.buttonFiltraColonna.Click += new System.EventHandler(this.buttonFiltraColonna_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(295, 553);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(259, 52);
            this.button2.TabIndex = 13;
            this.button2.Text = "Elenco Tavola Completa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1729, 778);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonFiltraColonna);
            this.Controls.Add(this.listBoxTavole);
            this.Controls.Add(this.dataGridViewRisultatoRicerca);
            this.Controls.Add(this.richTextBoxCommentoColonna);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.listBoxColonne);
            this.Controls.Add(this.listBoxElencoDataBase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[ Home ]";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRisultatoRicerca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxElencoDataBase;
        private System.Windows.Forms.ListBox listBoxColonne;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerPeriodoFine;
        private System.Windows.Forms.DateTimePicker dateTimePickerPeriodoInizio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBoxCommentoColonna;
        private System.Windows.Forms.DataGridView dataGridViewRisultatoRicerca;
        private System.Windows.Forms.ListBox listBoxTavole;
        private System.Windows.Forms.Button buttonFiltraColonna;
        private System.Windows.Forms.Button button2;
    }
}


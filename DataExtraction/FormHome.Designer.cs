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
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panelInfoTabella = new System.Windows.Forms.Panel();
            this.labelInfoTabella = new System.Windows.Forms.Label();
            this.ExportCSV = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRisultatoRicerca)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panelInfoTabella.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxElencoDataBase
            // 
            this.listBoxElencoDataBase.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxElencoDataBase.FormattingEnabled = true;
            this.listBoxElencoDataBase.ItemHeight = 19;
            this.listBoxElencoDataBase.Location = new System.Drawing.Point(12, 118);
            this.listBoxElencoDataBase.Name = "listBoxElencoDataBase";
            this.listBoxElencoDataBase.Size = new System.Drawing.Size(213, 194);
            this.listBoxElencoDataBase.TabIndex = 0;
            this.listBoxElencoDataBase.SelectedIndexChanged += new System.EventHandler(this.listBoxElencoDataBase_SelectedIndexChanged);
            // 
            // listBoxColonne
            // 
            this.listBoxColonne.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxColonne.FormattingEnabled = true;
            this.listBoxColonne.ItemHeight = 19;
            this.listBoxColonne.Location = new System.Drawing.Point(236, 119);
            this.listBoxColonne.Name = "listBoxColonne";
            this.listBoxColonne.Size = new System.Drawing.Size(213, 289);
            this.listBoxColonne.TabIndex = 0;
            this.listBoxColonne.SelectedIndexChanged += new System.EventHandler(this.listBoxColonne_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dateTimePickerPeriodoFine);
            this.panel4.Controls.Add(this.dateTimePickerPeriodoInizio);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(12, 656);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(437, 84);
            this.panel4.TabIndex = 6;
            // 
            // dateTimePickerPeriodoFine
            // 
            this.dateTimePickerPeriodoFine.Location = new System.Drawing.Point(117, 50);
            this.dateTimePickerPeriodoFine.Name = "dateTimePickerPeriodoFine";
            this.dateTimePickerPeriodoFine.Size = new System.Drawing.Size(183, 20);
            this.dateTimePickerPeriodoFine.TabIndex = 5;
            this.dateTimePickerPeriodoFine.Value = new System.DateTime(2017, 5, 22, 11, 39, 0, 0);
            // 
            // dateTimePickerPeriodoInizio
            // 
            this.dateTimePickerPeriodoInizio.Location = new System.Drawing.Point(117, 16);
            this.dateTimePickerPeriodoInizio.Name = "dateTimePickerPeriodoInizio";
            this.dateTimePickerPeriodoInizio.Size = new System.Drawing.Size(183, 20);
            this.dateTimePickerPeriodoInizio.TabIndex = 4;
            this.dateTimePickerPeriodoInizio.Value = new System.DateTime(2018, 8, 6, 12, 26, 47, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "FINE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "INIZIO";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(12, 623);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(437, 34);
            this.panel3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-297, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1422, 53);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(309, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "EXTRACTION";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(-298, 765);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1423, 10);
            this.panel2.TabIndex = 8;
            // 
            // richTextBoxCommentoColonna
            // 
            this.richTextBoxCommentoColonna.Enabled = false;
            this.richTextBoxCommentoColonna.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxCommentoColonna.Location = new System.Drawing.Point(236, 453);
            this.richTextBoxCommentoColonna.Name = "richTextBoxCommentoColonna";
            this.richTextBoxCommentoColonna.Size = new System.Drawing.Size(213, 41);
            this.richTextBoxCommentoColonna.TabIndex = 9;
            this.richTextBoxCommentoColonna.Text = "";
            // 
            // dataGridViewRisultatoRicerca
            // 
            this.dataGridViewRisultatoRicerca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewRisultatoRicerca.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRisultatoRicerca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRisultatoRicerca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRisultatoRicerca.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewRisultatoRicerca.EnableHeadersVisualStyles = false;
            this.dataGridViewRisultatoRicerca.Location = new System.Drawing.Point(465, 127);
            this.dataGridViewRisultatoRicerca.Name = "dataGridViewRisultatoRicerca";
            this.dataGridViewRisultatoRicerca.Size = new System.Drawing.Size(648, 613);
            this.dataGridViewRisultatoRicerca.TabIndex = 10;
            // 
            // listBoxTavole
            // 
            this.listBoxTavole.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTavole.FormattingEnabled = true;
            this.listBoxTavole.ItemHeight = 19;
            this.listBoxTavole.Location = new System.Drawing.Point(12, 375);
            this.listBoxTavole.Name = "listBoxTavole";
            this.listBoxTavole.Size = new System.Drawing.Size(213, 213);
            this.listBoxTavole.TabIndex = 11;
            this.listBoxTavole.SelectedIndexChanged += new System.EventHandler(this.listBoxTavole_SelectedIndexChanged);
            // 
            // buttonFiltraColonna
            // 
            this.buttonFiltraColonna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonFiltraColonna.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFiltraColonna.ForeColor = System.Drawing.Color.Blue;
            this.buttonFiltraColonna.Location = new System.Drawing.Point(236, 504);
            this.buttonFiltraColonna.Name = "buttonFiltraColonna";
            this.buttonFiltraColonna.Size = new System.Drawing.Size(213, 48);
            this.buttonFiltraColonna.TabIndex = 12;
            this.buttonFiltraColonna.Text = "Filtra singola colonna";
            this.buttonFiltraColonna.UseVisualStyleBackColor = false;
            this.buttonFiltraColonna.Click += new System.EventHandler(this.buttonFiltraColonna_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(236, 557);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(213, 48);
            this.button2.TabIndex = 13;
            this.button2.Text = "Elenco Tavola Completa";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(12, 87);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(213, 32);
            this.panel5.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Database";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(236, 88);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(213, 32);
            this.panel6.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Colonne";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label7);
            this.panel7.Location = new System.Drawing.Point(12, 344);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(213, 32);
            this.panel7.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(14, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tabelle";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.label8);
            this.panel8.Location = new System.Drawing.Point(236, 422);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(213, 32);
            this.panel8.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Info Colonne";
            // 
            // panelInfoTabella
            // 
            this.panelInfoTabella.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelInfoTabella.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInfoTabella.Controls.Add(this.ExportCSV);
            this.panelInfoTabella.Controls.Add(this.labelInfoTabella);
            this.panelInfoTabella.Location = new System.Drawing.Point(465, 88);
            this.panelInfoTabella.Name = "panelInfoTabella";
            this.panelInfoTabella.Size = new System.Drawing.Size(648, 42);
            this.panelInfoTabella.TabIndex = 18;
            // 
            // labelInfoTabella
            // 
            this.labelInfoTabella.AutoSize = true;
            this.labelInfoTabella.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoTabella.ForeColor = System.Drawing.Color.White;
            this.labelInfoTabella.Location = new System.Drawing.Point(21, 7);
            this.labelInfoTabella.Name = "labelInfoTabella";
            this.labelInfoTabella.Size = new System.Drawing.Size(49, 25);
            this.labelInfoTabella.TabIndex = 2;
            this.labelInfoTabella.Text = "Dati";
            // 
            // ExportCSV
            // 
            this.ExportCSV.Location = new System.Drawing.Point(515, 4);
            this.ExportCSV.Name = "ExportCSV";
            this.ExportCSV.Size = new System.Drawing.Size(128, 33);
            this.ExportCSV.TabIndex = 3;
            this.ExportCSV.Text = "Export CSV";
            this.ExportCSV.UseVisualStyleBackColor = true;
            this.ExportCSV.Click += new System.EventHandler(this.ExportCSV_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 777);
            this.Controls.Add(this.panelInfoTabella);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panelInfoTabella.ResumeLayout(false);
            this.panelInfoTabella.PerformLayout();
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
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelInfoTabella;
        private System.Windows.Forms.Label labelInfoTabella;
        private System.Windows.Forms.Button ExportCSV;
    }
}


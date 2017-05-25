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
            this.listBoxElencoDataBase = new System.Windows.Forms.ListBox();
            this.listBoxColonne = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
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
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRisultatoRicerca)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxElencoDataBase
            // 
            this.listBoxElencoDataBase.FormattingEnabled = true;
            this.listBoxElencoDataBase.Location = new System.Drawing.Point(12, 68);
            this.listBoxElencoDataBase.Name = "listBoxElencoDataBase";
            this.listBoxElencoDataBase.Size = new System.Drawing.Size(260, 264);
            this.listBoxElencoDataBase.TabIndex = 0;
            this.listBoxElencoDataBase.SelectedIndexChanged += new System.EventHandler(this.listBoxElencoDataBase_SelectedIndexChanged);
            // 
            // listBoxColonne
            // 
            this.listBoxColonne.FormattingEnabled = true;
            this.listBoxColonne.Location = new System.Drawing.Point(295, 68);
            this.listBoxColonne.Name = "listBoxColonne";
            this.listBoxColonne.Size = new System.Drawing.Size(260, 537);
            this.listBoxColonne.TabIndex = 0;
            this.listBoxColonne.SelectedIndexChanged += new System.EventHandler(this.listBoxColonne_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dateTimePicker2);
            this.panel4.Controls.Add(this.dateTimePicker1);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(12, 656);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(543, 84);
            this.panel4.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(226, 46);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(183, 20);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(226, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(183, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label4
            // 
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
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1734, 53);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
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
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(-3, 765);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(977, 10);
            this.panel2.TabIndex = 8;
            // 
            // richTextBoxCommentoColonna
            // 
            this.richTextBoxCommentoColonna.Location = new System.Drawing.Point(565, 70);
            this.richTextBoxCommentoColonna.Name = "richTextBoxCommentoColonna";
            this.richTextBoxCommentoColonna.Size = new System.Drawing.Size(1152, 41);
            this.richTextBoxCommentoColonna.TabIndex = 9;
            this.richTextBoxCommentoColonna.Text = "";
            // 
            // dataGridViewRisultatoRicerca
            // 
            this.dataGridViewRisultatoRicerca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRisultatoRicerca.Location = new System.Drawing.Point(569, 123);
            this.dataGridViewRisultatoRicerca.Name = "dataGridViewRisultatoRicerca";
            this.dataGridViewRisultatoRicerca.Size = new System.Drawing.Size(1147, 616);
            this.dataGridViewRisultatoRicerca.TabIndex = 10;
            // 
            // listBoxTavole
            // 
            this.listBoxTavole.FormattingEnabled = true;
            this.listBoxTavole.Location = new System.Drawing.Point(12, 341);
            this.listBoxTavole.Name = "listBoxTavole";
            this.listBoxTavole.Size = new System.Drawing.Size(260, 264);
            this.listBoxTavole.TabIndex = 11;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1729, 778);
            this.Controls.Add(this.listBoxTavole);
            this.Controls.Add(this.dataGridViewRisultatoRicerca);
            this.Controls.Add(this.richTextBoxCommentoColonna);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.listBoxColonne);
            this.Controls.Add(this.listBoxElencoDataBase);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[ Home ]";
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
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBoxCommentoColonna;
        private System.Windows.Forms.DataGridView dataGridViewRisultatoRicerca;
        private System.Windows.Forms.ListBox listBoxTavole;
    }
}


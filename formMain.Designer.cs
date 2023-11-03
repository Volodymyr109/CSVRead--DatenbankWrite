namespace InvoiceManagement
{
    partial class formMain
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
            this.RetriveDataKunden = new System.Windows.Forms.Button();
            this.dataGridViewKunde = new System.Windows.Forms.DataGridView();
            this.dataGridViewRechnung = new System.Windows.Forms.DataGridView();
            this.RetriveDataArtikel = new System.Windows.Forms.Button();
            this.dataGridViewArtikel = new System.Windows.Forms.DataGridView();
            this.RetriveDataRechnung = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKunde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRechnung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtikel)).BeginInit();
            this.SuspendLayout();
            // 
            // RetriveDataKunden
            // 
            this.RetriveDataKunden.Location = new System.Drawing.Point(3, 2);
            this.RetriveDataKunden.Name = "RetriveDataKunden";
            this.RetriveDataKunden.Size = new System.Drawing.Size(126, 35);
            this.RetriveDataKunden.TabIndex = 0;
            this.RetriveDataKunden.Text = "RetriveDataKunden";
            this.RetriveDataKunden.UseVisualStyleBackColor = true;
            this.RetriveDataKunden.Click += new System.EventHandler(this.RetriveDataKunden_Click);
            // 
            // dataGridViewKunde
            // 
            this.dataGridViewKunde.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKunde.Location = new System.Drawing.Point(3, 79);
            this.dataGridViewKunde.Name = "dataGridViewKunde";
            this.dataGridViewKunde.Size = new System.Drawing.Size(251, 359);
            this.dataGridViewKunde.TabIndex = 1;
            // 
            // dataGridViewRechnung
            // 
            this.dataGridViewRechnung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRechnung.Location = new System.Drawing.Point(549, 79);
            this.dataGridViewRechnung.Name = "dataGridViewRechnung";
            this.dataGridViewRechnung.Size = new System.Drawing.Size(248, 359);
            this.dataGridViewRechnung.TabIndex = 5;
            // 
            // RetriveDataArtikel
            // 
            this.RetriveDataArtikel.Location = new System.Drawing.Point(278, 2);
            this.RetriveDataArtikel.Name = "RetriveDataArtikel";
            this.RetriveDataArtikel.Size = new System.Drawing.Size(126, 35);
            this.RetriveDataArtikel.TabIndex = 6;
            this.RetriveDataArtikel.Text = "RetriveDataArtikel";
            this.RetriveDataArtikel.UseVisualStyleBackColor = true;
            this.RetriveDataArtikel.Click += new System.EventHandler(this.RetriveDataArtikel_Click);
            // 
            // dataGridViewArtikel
            // 
            this.dataGridViewArtikel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArtikel.Location = new System.Drawing.Point(278, 79);
            this.dataGridViewArtikel.Name = "dataGridViewArtikel";
            this.dataGridViewArtikel.Size = new System.Drawing.Size(251, 359);
            this.dataGridViewArtikel.TabIndex = 7;
            this.dataGridViewArtikel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewArtikeln_CellContentClick);
            // 
            // RetriveDataRechnung
            // 
            this.RetriveDataRechnung.AutoEllipsis = true;
            this.RetriveDataRechnung.Location = new System.Drawing.Point(549, 3);
            this.RetriveDataRechnung.Name = "RetriveDataRechnung";
            this.RetriveDataRechnung.Size = new System.Drawing.Size(126, 34);
            this.RetriveDataRechnung.TabIndex = 8;
            this.RetriveDataRechnung.Text = "Retrive Data Rechnung";
            this.RetriveDataRechnung.UseVisualStyleBackColor = true;
            this.RetriveDataRechnung.Click += new System.EventHandler(this.RetriveDataRechnung_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Search by name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Search by name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(546, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Search by Rechnung id";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(365, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(126, 20);
            this.textBox2.TabIndex = 14;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(671, 47);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(126, 20);
            this.textBox3.TabIndex = 15;
            this.textBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyDown);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.RetriveDataRechnung);
            this.Controls.Add(this.dataGridViewArtikel);
            this.Controls.Add(this.RetriveDataArtikel);
            this.Controls.Add(this.dataGridViewRechnung);
            this.Controls.Add(this.dataGridViewKunde);
            this.Controls.Add(this.RetriveDataKunden);
            this.Name = "formMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.formMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKunde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRechnung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtikel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RetriveDataKunden;
        private System.Windows.Forms.DataGridView dataGridViewKunde;
        private System.Windows.Forms.DataGridView dataGridViewRechnung;
        private System.Windows.Forms.Button RetriveDataArtikel;
        private System.Windows.Forms.DataGridView dataGridViewArtikel;
        private System.Windows.Forms.Button RetriveDataRechnung;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}


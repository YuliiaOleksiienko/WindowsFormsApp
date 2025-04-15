namespace Yrkesprov
{
    partial class frmOrderCompletion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrderCompletion));
            this.lblDinBestallning = new System.Windows.Forms.Label();
            this.dgvBestallning = new System.Windows.Forms.DataGridView();
            this.btnRadera = new System.Windows.Forms.Button();
            this.btnBekrafta = new System.Windows.Forms.Button();
            this.btnKvitto = new System.Windows.Forms.Button();
            this.ppdKvittto = new System.Windows.Forms.PrintPreviewDialog();
            this.prdKvittto = new System.Drawing.Printing.PrintDocument();
            this.btnAvsluta = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBestallning)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDinBestallning
            // 
            this.lblDinBestallning.AutoSize = true;
            this.lblDinBestallning.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDinBestallning.Location = new System.Drawing.Point(287, 24);
            this.lblDinBestallning.Name = "lblDinBestallning";
            this.lblDinBestallning.Size = new System.Drawing.Size(258, 37);
            this.lblDinBestallning.TabIndex = 0;
            this.lblDinBestallning.Text = "Din beställning:";
            // 
            // dgvBestallning
            // 
            this.dgvBestallning.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBestallning.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBestallning.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvBestallning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBestallning.Location = new System.Drawing.Point(46, 81);
            this.dgvBestallning.Name = "dgvBestallning";
            this.dgvBestallning.RowHeadersWidth = 82;
            this.dgvBestallning.RowTemplate.Height = 33;
            this.dgvBestallning.Size = new System.Drawing.Size(791, 210);
            this.dgvBestallning.TabIndex = 1;
            this.dgvBestallning.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBestallning_RowHeaderMouseClick);
            // 
            // btnRadera
            // 
            this.btnRadera.BackColor = System.Drawing.Color.Coral;
            this.btnRadera.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRadera.Location = new System.Drawing.Point(523, 342);
            this.btnRadera.Name = "btnRadera";
            this.btnRadera.Size = new System.Drawing.Size(170, 56);
            this.btnRadera.TabIndex = 3;
            this.btnRadera.Text = "Radera";
            this.btnRadera.UseVisualStyleBackColor = false;
            this.btnRadera.Click += new System.EventHandler(this.btnRadera_Click);
            // 
            // btnBekrafta
            // 
            this.btnBekrafta.BackColor = System.Drawing.Color.Coral;
            this.btnBekrafta.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBekrafta.Location = new System.Drawing.Point(312, 423);
            this.btnBekrafta.Name = "btnBekrafta";
            this.btnBekrafta.Size = new System.Drawing.Size(349, 66);
            this.btnBekrafta.TabIndex = 4;
            this.btnBekrafta.Text = "Bekräfta din beställning";
            this.btnBekrafta.UseVisualStyleBackColor = false;
            this.btnBekrafta.Click += new System.EventHandler(this.btnBekrafta_Click);
            // 
            // btnKvitto
            // 
            this.btnKvitto.BackColor = System.Drawing.Color.Coral;
            this.btnKvitto.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnKvitto.Location = new System.Drawing.Point(164, 531);
            this.btnKvitto.Name = "btnKvitto";
            this.btnKvitto.Size = new System.Drawing.Size(259, 57);
            this.btnKvitto.TabIndex = 5;
            this.btnKvitto.Text = "Skriv utt kvitto";
            this.btnKvitto.UseVisualStyleBackColor = false;
            this.btnKvitto.Click += new System.EventHandler(this.btnKvitto_Click);
            // 
            // ppdKvittto
            // 
            this.ppdKvittto.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppdKvittto.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppdKvittto.ClientSize = new System.Drawing.Size(400, 300);
            this.ppdKvittto.Enabled = true;
            this.ppdKvittto.Icon = ((System.Drawing.Icon)(resources.GetObject("ppdKvittto.Icon")));
            this.ppdKvittto.Name = "printPreviewDialog1";
            this.ppdKvittto.Visible = false;
            // 
            // prdKvittto
            // 
            this.prdKvittto.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prdKvittto_PrintPage);
            // 
            // btnAvsluta
            // 
            this.btnAvsluta.BackColor = System.Drawing.Color.Coral;
            this.btnAvsluta.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAvsluta.Location = new System.Drawing.Point(523, 531);
            this.btnAvsluta.Name = "btnAvsluta";
            this.btnAvsluta.Size = new System.Drawing.Size(212, 57);
            this.btnAvsluta.TabIndex = 6;
            this.btnAvsluta.Text = "Avsluta";
            this.btnAvsluta.UseVisualStyleBackColor = false;
            this.btnAvsluta.Click += new System.EventHandler(this.btnAvsluta_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(98, 345);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(190, 32);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total summa:";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(294, 342);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(129, 39);
            this.txtTotal.TabIndex = 8;
            // 
            // frmOrderCompletion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(880, 633);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnAvsluta);
            this.Controls.Add(this.btnKvitto);
            this.Controls.Add(this.btnBekrafta);
            this.Controls.Add(this.btnRadera);
            this.Controls.Add(this.dgvBestallning);
            this.Controls.Add(this.lblDinBestallning);
            this.Name = "frmOrderCompletion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Activated += new System.EventHandler(this.frmOrderCompletion_Activated);
            this.Load += new System.EventHandler(this.frmOrderCompletion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBestallning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDinBestallning;
        private System.Windows.Forms.DataGridView dgvBestallning;
        private System.Windows.Forms.Button btnRadera;
        private System.Windows.Forms.Button btnBekrafta;
        private System.Windows.Forms.PrintPreviewDialog ppdKvitto;
        private System.Drawing.Printing.PrintDocument prdKvitto;
        private System.Windows.Forms.Button btnKvitto;
        private System.Windows.Forms.PrintPreviewDialog ppdKvittto;
        private System.Drawing.Printing.PrintDocument prdKvittto;
        private System.Windows.Forms.Button btnAvsluta;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
    }
}
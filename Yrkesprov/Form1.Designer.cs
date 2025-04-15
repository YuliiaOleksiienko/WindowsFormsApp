namespace Yrkesprov
{
    partial class frmRestaurang
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
            this.btnBestalla = new System.Windows.Forms.Button();
            this.lblBurgerHuset = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBestalla
            // 
            this.btnBestalla.BackColor = System.Drawing.Color.White;
            this.btnBestalla.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBestalla.Location = new System.Drawing.Point(260, 477);
            this.btnBestalla.Name = "btnBestalla";
            this.btnBestalla.Size = new System.Drawing.Size(227, 68);
            this.btnBestalla.TabIndex = 1;
            this.btnBestalla.Text = "Beställa";
            this.btnBestalla.UseVisualStyleBackColor = false;
            this.btnBestalla.Click += new System.EventHandler(this.btnBestalla_Click);
            // 
            // lblBurgerHuset
            // 
            this.lblBurgerHuset.AutoSize = true;
            this.lblBurgerHuset.BackColor = System.Drawing.Color.Transparent;
            this.lblBurgerHuset.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBurgerHuset.Location = new System.Drawing.Point(210, 49);
            this.lblBurgerHuset.Name = "lblBurgerHuset";
            this.lblBurgerHuset.Size = new System.Drawing.Size(305, 67);
            this.lblBurgerHuset.TabIndex = 3;
            this.lblBurgerHuset.Text = "Snabb&&Gott";
            // 
            // frmRestaurang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Yrkesprov.Properties.Resources._360_F_232165262_F4LFqFpcpVTufzGvQWLsXa0U5MYNmPjs;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(745, 589);
            this.Controls.Add(this.lblBurgerHuset);
            this.Controls.Add(this.btnBestalla);
            this.Name = "frmRestaurang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBestalla;
        private System.Windows.Forms.Label lblBurgerHuset;
    }
}


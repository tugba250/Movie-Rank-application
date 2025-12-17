namespace FilmIzlemeUygulamasi
{
    partial class MovieCard
    {
        private System.ComponentModel.IContainer components = null;

        
        /// <param name="disposing">Yönetilen kaynaklar silinmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        

       
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // Bileşenler
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pbPoster = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.btnDetail = new Bunifu.UI.WinForms.BunifuButton.BunifuButton(); // NOT: btnDetails değil, btnDetail kullandık
            this.panelInfo = new System.Windows.Forms.Panel();

            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).BeginInit();
            this.SuspendLayout();

            
            // bunifuElipse1 
             
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
           
            // pbPoster 
            
            this.pbPoster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.pbPoster.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbPoster.Location = new System.Drawing.Point(0, 0);
            this.pbPoster.Name = "pbPoster";
            this.pbPoster.Size = new System.Drawing.Size(200, 240); // Standart Poster Boyutu
            this.pbPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPoster.TabIndex = 0;
            this.pbPoster.TabStop = false;
            
            // panelInfo
            
            this.panelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panelInfo.Controls.Add(this.btnDetail);
            this.panelInfo.Controls.Add(this.lblRating);
            this.panelInfo.Controls.Add(this.lblYear);
            this.panelInfo.Controls.Add(this.lblTitle);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfo.Location = new System.Drawing.Point(0, 240);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(200, 110);
            this.panelInfo.TabIndex = 1;
           
            // lblTitle 
            
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(5, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(190, 20);
            this.lblTitle.Text = "Movie Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            
            // lblYear 
             
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblYear.ForeColor = System.Drawing.Color.Silver;
            this.lblYear.Location = new System.Drawing.Point(5, 28);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(90, 15);
            this.lblYear.Text = "Year: 2024";
            
            // lblRating 
           
            this.lblRating.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblRating.ForeColor = System.Drawing.Color.Gold;
            this.lblRating.Location = new System.Drawing.Point(100, 28);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(95, 15);
            this.lblRating.Text = "Rating: 8.5/10";
            this.lblRating.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
          
            // btnDetail 
             
            this.btnDetail.ButtonText = "Details";
            this.btnDetail.Location = new System.Drawing.Point(10, 65);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(180, 35);
            this.btnDetail.TabIndex = 4;
            

          
            // MovieCard 
           
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.pbPoster);
            this.Name = "MovieCard";
            this.Size = new System.Drawing.Size(200, 350); // Kartın Toplam Boyutu
            this.panelInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).EndInit();
            this.ResumeLayout(false);

        }

        

        // Private bileşen tanımları
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pbPoster;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label lblTitle;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDetail;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblYear;
    }
}
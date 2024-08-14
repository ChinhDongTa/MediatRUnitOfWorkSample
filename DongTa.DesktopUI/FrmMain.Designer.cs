namespace DongTa.DesktopUI {
    partial class FrmMain {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Dgv = new DataGridView();
            LbTitle = new Label();
            BtnGetAllAlbum = new Button();
            BtnGetAllArtist = new Button();
            BtnGetAllGenre = new Button();
            BtnAllPlaylist = new Button();
            ((System.ComponentModel.ISupportInitialize)Dgv).BeginInit();
            SuspendLayout();
            // 
            // Dgv
            // 
            Dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv.Location = new Point(12, 37);
            Dgv.Name = "Dgv";
            Dgv.Size = new Size(793, 459);
            Dgv.TabIndex = 0;
            // 
            // LbTitle
            // 
            LbTitle.AutoSize = true;
            LbTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbTitle.ForeColor = SystemColors.HotTrack;
            LbTitle.Location = new Point(12, 9);
            LbTitle.Name = "LbTitle";
            LbTitle.Size = new Size(206, 25);
            LbTitle.TabIndex = 1;
            LbTitle.Text = "Chinook data samples";
            // 
            // BtnGetAllAlbum
            // 
            BtnGetAllAlbum.Location = new Point(844, 105);
            BtnGetAllAlbum.Name = "BtnGetAllAlbum";
            BtnGetAllAlbum.Size = new Size(143, 23);
            BtnGetAllAlbum.TabIndex = 2;
            BtnGetAllAlbum.Text = "Get all Album";
            BtnGetAllAlbum.UseVisualStyleBackColor = true;
            BtnGetAllAlbum.Click += BtnGetAllAlbum_Click;
            // 
            // BtnGetAllArtist
            // 
            BtnGetAllArtist.Location = new Point(844, 153);
            BtnGetAllArtist.Name = "BtnGetAllArtist";
            BtnGetAllArtist.Size = new Size(143, 23);
            BtnGetAllArtist.TabIndex = 3;
            BtnGetAllArtist.Text = "Get All Artist";
            BtnGetAllArtist.UseVisualStyleBackColor = true;
            BtnGetAllArtist.Click += BtnGetAllArtist_Click;
            // 
            // BtnGetAllGenre
            // 
            BtnGetAllGenre.Location = new Point(844, 208);
            BtnGetAllGenre.Name = "BtnGetAllGenre";
            BtnGetAllGenre.Size = new Size(143, 23);
            BtnGetAllGenre.TabIndex = 4;
            BtnGetAllGenre.Text = "Get All Genre";
            BtnGetAllGenre.UseVisualStyleBackColor = true;
            BtnGetAllGenre.Click += BtnGetAllGenre_Click;
            // 
            // BtnAllPlaylist
            // 
            BtnAllPlaylist.Location = new Point(844, 266);
            BtnAllPlaylist.Name = "BtnAllPlaylist";
            BtnAllPlaylist.Size = new Size(143, 23);
            BtnAllPlaylist.TabIndex = 5;
            BtnAllPlaylist.Text = "Get All Playlist";
            BtnAllPlaylist.UseVisualStyleBackColor = true;
            BtnAllPlaylist.Click += BtnAllPlaylist_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 508);
            Controls.Add(BtnAllPlaylist);
            Controls.Add(BtnGetAllGenre);
            Controls.Add(BtnGetAllArtist);
            Controls.Add(BtnGetAllAlbum);
            Controls.Add(LbTitle);
            Controls.Add(Dgv);
            Name = "FrmMain";
            Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)Dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Dgv;
        private Label LbTitle;
        private Button BtnGetAllAlbum;
        private Button BtnGetAllArtist;
        private Button BtnGetAllGenre;
        private Button BtnAllPlaylist;
    }
}

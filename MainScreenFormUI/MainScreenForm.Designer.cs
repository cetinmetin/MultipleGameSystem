namespace MainScreenFormUI
{
    partial class MainScreenForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreenForm));
            this.lblAppName = new System.Windows.Forms.Label();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.pbxSmartClassroom = new System.Windows.Forms.PictureBox();
            this.pbxMakeMeHappy = new System.Windows.Forms.PictureBox();
            this.pbxSnap = new System.Windows.Forms.PictureBox();
            this.pbxChameleon = new System.Windows.Forms.PictureBox();
            this.pbxShyPanda = new System.Windows.Forms.PictureBox();
            this.pbxFaceLock = new System.Windows.Forms.PictureBox();
            this.pbxCarorCup = new System.Windows.Forms.PictureBox();
            this.pbxTitanic = new System.Windows.Forms.PictureBox();
            this.pbxRockPaperScissors = new System.Windows.Forms.PictureBox();
            this.pbxSortingHat = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSmartClassroom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMakeMeHappy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSnap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChameleon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxShyPanda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFaceLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCarorCup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTitanic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRockPaperScissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSortingHat)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAppName
            // 
            this.lblAppName.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAppName.Location = new System.Drawing.Point(12, 9);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(895, 41);
            this.lblAppName.TabIndex = 0;
            this.lblAppName.Text = "Multiple Game Emulator System";
            this.lblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCloseForm.ForeColor = System.Drawing.Color.Red;
            this.btnCloseForm.Location = new System.Drawing.Point(874, 1);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(44, 36);
            this.btnCloseForm.TabIndex = 1;
            this.btnCloseForm.Text = "X";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.BtnCloseForm_Click);
            // 
            // pbxSmartClassroom
            // 
            this.pbxSmartClassroom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxSmartClassroom.Image = ((System.Drawing.Image)(resources.GetObject("pbxSmartClassroom.Image")));
            this.pbxSmartClassroom.Location = new System.Drawing.Point(12, 77);
            this.pbxSmartClassroom.Name = "pbxSmartClassroom";
            this.pbxSmartClassroom.Size = new System.Drawing.Size(433, 80);
            this.pbxSmartClassroom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSmartClassroom.TabIndex = 9;
            this.pbxSmartClassroom.TabStop = false;
            this.pbxSmartClassroom.Click += new System.EventHandler(this.PbxSmartClassroom_Click);
            // 
            // pbxMakeMeHappy
            // 
            this.pbxMakeMeHappy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxMakeMeHappy.Image = ((System.Drawing.Image)(resources.GetObject("pbxMakeMeHappy.Image")));
            this.pbxMakeMeHappy.Location = new System.Drawing.Point(474, 77);
            this.pbxMakeMeHappy.Name = "pbxMakeMeHappy";
            this.pbxMakeMeHappy.Size = new System.Drawing.Size(433, 80);
            this.pbxMakeMeHappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMakeMeHappy.TabIndex = 10;
            this.pbxMakeMeHappy.TabStop = false;
            this.pbxMakeMeHappy.Click += new System.EventHandler(this.PbxMakeMeHappy_Click);
            // 
            // pbxSnap
            // 
            this.pbxSnap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxSnap.Image = ((System.Drawing.Image)(resources.GetObject("pbxSnap.Image")));
            this.pbxSnap.Location = new System.Drawing.Point(12, 184);
            this.pbxSnap.Name = "pbxSnap";
            this.pbxSnap.Size = new System.Drawing.Size(433, 80);
            this.pbxSnap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSnap.TabIndex = 11;
            this.pbxSnap.TabStop = false;
            this.pbxSnap.Click += new System.EventHandler(this.PbxSnap_Click);
            // 
            // pbxChameleon
            // 
            this.pbxChameleon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxChameleon.Image = ((System.Drawing.Image)(resources.GetObject("pbxChameleon.Image")));
            this.pbxChameleon.Location = new System.Drawing.Point(474, 184);
            this.pbxChameleon.Name = "pbxChameleon";
            this.pbxChameleon.Size = new System.Drawing.Size(433, 80);
            this.pbxChameleon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxChameleon.TabIndex = 12;
            this.pbxChameleon.TabStop = false;
            this.pbxChameleon.Click += new System.EventHandler(this.PbxChameleon_Click);
            // 
            // pbxShyPanda
            // 
            this.pbxShyPanda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxShyPanda.Image = ((System.Drawing.Image)(resources.GetObject("pbxShyPanda.Image")));
            this.pbxShyPanda.Location = new System.Drawing.Point(474, 398);
            this.pbxShyPanda.Name = "pbxShyPanda";
            this.pbxShyPanda.Size = new System.Drawing.Size(433, 80);
            this.pbxShyPanda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxShyPanda.TabIndex = 16;
            this.pbxShyPanda.TabStop = false;
            this.pbxShyPanda.Click += new System.EventHandler(this.PbxShyPanda_Click);
            // 
            // pbxFaceLock
            // 
            this.pbxFaceLock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxFaceLock.Image = ((System.Drawing.Image)(resources.GetObject("pbxFaceLock.Image")));
            this.pbxFaceLock.Location = new System.Drawing.Point(12, 398);
            this.pbxFaceLock.Name = "pbxFaceLock";
            this.pbxFaceLock.Size = new System.Drawing.Size(433, 80);
            this.pbxFaceLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFaceLock.TabIndex = 15;
            this.pbxFaceLock.TabStop = false;
            this.pbxFaceLock.Click += new System.EventHandler(this.PbxFaceLock_Click);
            // 
            // pbxCarorCup
            // 
            this.pbxCarorCup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxCarorCup.Image = ((System.Drawing.Image)(resources.GetObject("pbxCarorCup.Image")));
            this.pbxCarorCup.Location = new System.Drawing.Point(474, 291);
            this.pbxCarorCup.Name = "pbxCarorCup";
            this.pbxCarorCup.Size = new System.Drawing.Size(433, 80);
            this.pbxCarorCup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCarorCup.TabIndex = 14;
            this.pbxCarorCup.TabStop = false;
            this.pbxCarorCup.Click += new System.EventHandler(this.PbxCarorCup_Click);
            // 
            // pbxTitanic
            // 
            this.pbxTitanic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxTitanic.Image = ((System.Drawing.Image)(resources.GetObject("pbxTitanic.Image")));
            this.pbxTitanic.Location = new System.Drawing.Point(12, 291);
            this.pbxTitanic.Name = "pbxTitanic";
            this.pbxTitanic.Size = new System.Drawing.Size(433, 80);
            this.pbxTitanic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxTitanic.TabIndex = 13;
            this.pbxTitanic.TabStop = false;
            this.pbxTitanic.Click += new System.EventHandler(this.PbxTitanic_Click);
            // 
            // pbxRockPaperScissors
            // 
            this.pbxRockPaperScissors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxRockPaperScissors.Image = ((System.Drawing.Image)(resources.GetObject("pbxRockPaperScissors.Image")));
            this.pbxRockPaperScissors.Location = new System.Drawing.Point(474, 505);
            this.pbxRockPaperScissors.Name = "pbxRockPaperScissors";
            this.pbxRockPaperScissors.Size = new System.Drawing.Size(433, 80);
            this.pbxRockPaperScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxRockPaperScissors.TabIndex = 18;
            this.pbxRockPaperScissors.TabStop = false;
            this.pbxRockPaperScissors.Click += new System.EventHandler(this.PbxRockPaperScissors_Click);
            // 
            // pbxSortingHat
            // 
            this.pbxSortingHat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxSortingHat.Image = ((System.Drawing.Image)(resources.GetObject("pbxSortingHat.Image")));
            this.pbxSortingHat.Location = new System.Drawing.Point(12, 505);
            this.pbxSortingHat.Name = "pbxSortingHat";
            this.pbxSortingHat.Size = new System.Drawing.Size(433, 80);
            this.pbxSortingHat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSortingHat.TabIndex = 17;
            this.pbxSortingHat.TabStop = false;
            this.pbxSortingHat.Click += new System.EventHandler(this.PbxSortingHat_Click);
            // 
            // MainScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(919, 627);
            this.Controls.Add(this.pbxRockPaperScissors);
            this.Controls.Add(this.pbxSortingHat);
            this.Controls.Add(this.pbxShyPanda);
            this.Controls.Add(this.pbxFaceLock);
            this.Controls.Add(this.pbxCarorCup);
            this.Controls.Add(this.pbxTitanic);
            this.Controls.Add(this.pbxChameleon);
            this.Controls.Add(this.pbxSnap);
            this.Controls.Add(this.pbxMakeMeHappy);
            this.Controls.Add(this.pbxSmartClassroom);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.lblAppName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multiple Game Emulator System";
            ((System.ComponentModel.ISupportInitialize)(this.pbxSmartClassroom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMakeMeHappy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSnap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChameleon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxShyPanda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFaceLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCarorCup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTitanic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRockPaperScissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSortingHat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.PictureBox pbxSmartClassroom;
        private System.Windows.Forms.PictureBox pbxMakeMeHappy;
        private System.Windows.Forms.PictureBox pbxSnap;
        private System.Windows.Forms.PictureBox pbxChameleon;
        private System.Windows.Forms.PictureBox pbxShyPanda;
        private System.Windows.Forms.PictureBox pbxFaceLock;
        private System.Windows.Forms.PictureBox pbxCarorCup;
        private System.Windows.Forms.PictureBox pbxTitanic;
        private System.Windows.Forms.PictureBox pbxRockPaperScissors;
        private System.Windows.Forms.PictureBox pbxSortingHat;
    }
}


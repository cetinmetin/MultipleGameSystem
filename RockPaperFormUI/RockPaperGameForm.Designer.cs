namespace RockPaperFormUI
{
    partial class RockPaperGameForm
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
            this.gbxControl = new System.Windows.Forms.GroupBox();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.gbxMain = new System.Windows.Forms.GroupBox();
            this.lblWinner = new System.Windows.Forms.Label();
            this.lblCompMove = new System.Windows.Forms.Label();
            this.lblUserMove = new System.Windows.Forms.Label();
            this.pbxCompMove = new System.Windows.Forms.PictureBox();
            this.pbxUserMove = new System.Windows.Forms.PictureBox();
            this.gbxMoves = new System.Windows.Forms.GroupBox();
            this.pbxPap = new System.Windows.Forms.PictureBox();
            this.pbxSciss = new System.Windows.Forms.PictureBox();
            this.pbxRoc = new System.Windows.Forms.PictureBox();
            this.gbxControl.SuspendLayout();
            this.gbxMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCompMove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUserMove)).BeginInit();
            this.gbxMoves.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSciss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRoc)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxControl
            // 
            this.gbxControl.BackColor = System.Drawing.Color.Lavender;
            this.gbxControl.Controls.Add(this.btnCloseForm);
            this.gbxControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxControl.Location = new System.Drawing.Point(-1, -7);
            this.gbxControl.Name = "gbxControl";
            this.gbxControl.Size = new System.Drawing.Size(902, 38);
            this.gbxControl.TabIndex = 6;
            this.gbxControl.TabStop = false;
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.BackColor = System.Drawing.Color.White;
            this.btnCloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCloseForm.ForeColor = System.Drawing.Color.Red;
            this.btnCloseForm.Location = new System.Drawing.Point(857, 7);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(44, 30);
            this.btnCloseForm.TabIndex = 11;
            this.btnCloseForm.Text = "X";
            this.btnCloseForm.UseVisualStyleBackColor = false;
            this.btnCloseForm.Click += new System.EventHandler(this.BtnCloseForm_Click);
            // 
            // gbxMain
            // 
            this.gbxMain.Controls.Add(this.lblWinner);
            this.gbxMain.Controls.Add(this.lblCompMove);
            this.gbxMain.Controls.Add(this.lblUserMove);
            this.gbxMain.Controls.Add(this.pbxCompMove);
            this.gbxMain.Controls.Add(this.pbxUserMove);
            this.gbxMain.Location = new System.Drawing.Point(47, 43);
            this.gbxMain.Name = "gbxMain";
            this.gbxMain.Size = new System.Drawing.Size(807, 279);
            this.gbxMain.TabIndex = 8;
            this.gbxMain.TabStop = false;
            // 
            // lblWinner
            // 
            this.lblWinner.ForeColor = System.Drawing.Color.Blue;
            this.lblWinner.Location = new System.Drawing.Point(6, 253);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(795, 13);
            this.lblWinner.TabIndex = 66;
            this.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCompMove
            // 
            this.lblCompMove.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompMove.ForeColor = System.Drawing.Color.Blue;
            this.lblCompMove.Location = new System.Drawing.Point(407, 22);
            this.lblCompMove.Name = "lblCompMove";
            this.lblCompMove.Size = new System.Drawing.Size(338, 22);
            this.lblCompMove.TabIndex = 65;
            this.lblCompMove.Text = "Computer\'s Move";
            this.lblCompMove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserMove
            // 
            this.lblUserMove.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserMove.ForeColor = System.Drawing.Color.Blue;
            this.lblUserMove.Location = new System.Drawing.Point(63, 22);
            this.lblUserMove.Name = "lblUserMove";
            this.lblUserMove.Size = new System.Drawing.Size(338, 22);
            this.lblUserMove.TabIndex = 64;
            this.lblUserMove.Text = "Your Move";
            this.lblUserMove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxCompMove
            // 
            this.pbxCompMove.BackColor = System.Drawing.Color.Transparent;
            this.pbxCompMove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxCompMove.Location = new System.Drawing.Point(407, 47);
            this.pbxCompMove.Name = "pbxCompMove";
            this.pbxCompMove.Size = new System.Drawing.Size(338, 193);
            this.pbxCompMove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCompMove.TabIndex = 63;
            this.pbxCompMove.TabStop = false;
            // 
            // pbxUserMove
            // 
            this.pbxUserMove.BackColor = System.Drawing.Color.Transparent;
            this.pbxUserMove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxUserMove.Location = new System.Drawing.Point(63, 47);
            this.pbxUserMove.Name = "pbxUserMove";
            this.pbxUserMove.Size = new System.Drawing.Size(338, 193);
            this.pbxUserMove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxUserMove.TabIndex = 62;
            this.pbxUserMove.TabStop = false;
            // 
            // gbxMoves
            // 
            this.gbxMoves.Controls.Add(this.pbxPap);
            this.gbxMoves.Controls.Add(this.pbxSciss);
            this.gbxMoves.Controls.Add(this.pbxRoc);
            this.gbxMoves.Location = new System.Drawing.Point(47, 333);
            this.gbxMoves.Name = "gbxMoves";
            this.gbxMoves.Size = new System.Drawing.Size(807, 155);
            this.gbxMoves.TabIndex = 9;
            this.gbxMoves.TabStop = false;
            // 
            // pbxPap
            // 
            this.pbxPap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxPap.Location = new System.Drawing.Point(74, 20);
            this.pbxPap.Name = "pbxPap";
            this.pbxPap.Size = new System.Drawing.Size(160, 130);
            this.pbxPap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPap.TabIndex = 61;
            this.pbxPap.TabStop = false;
            // 
            // pbxSciss
            // 
            this.pbxSciss.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxSciss.Location = new System.Drawing.Point(568, 20);
            this.pbxSciss.Name = "pbxSciss";
            this.pbxSciss.Size = new System.Drawing.Size(160, 130);
            this.pbxSciss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSciss.TabIndex = 53;
            this.pbxSciss.TabStop = false;
            // 
            // pbxRoc
            // 
            this.pbxRoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxRoc.Location = new System.Drawing.Point(321, 20);
            this.pbxRoc.Name = "pbxRoc";
            this.pbxRoc.Size = new System.Drawing.Size(160, 130);
            this.pbxRoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxRoc.TabIndex = 52;
            this.pbxRoc.TabStop = false;
            // 
            // RockPaperGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.gbxMoves);
            this.Controls.Add(this.gbxMain);
            this.Controls.Add(this.gbxControl);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RockPaperGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rock Paper Scissors";
            this.Load += new System.EventHandler(this.RockPaperGameForm_Load);
            this.gbxControl.ResumeLayout(false);
            this.gbxMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCompMove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUserMove)).EndInit();
            this.gbxMoves.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSciss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxControl;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.GroupBox gbxMain;
        private System.Windows.Forms.PictureBox pbxUserMove;
        private System.Windows.Forms.GroupBox gbxMoves;
        private System.Windows.Forms.PictureBox pbxPap;
        private System.Windows.Forms.PictureBox pbxSciss;
        private System.Windows.Forms.PictureBox pbxRoc;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Label lblCompMove;
        private System.Windows.Forms.Label lblUserMove;
        private System.Windows.Forms.PictureBox pbxCompMove;
    }
}


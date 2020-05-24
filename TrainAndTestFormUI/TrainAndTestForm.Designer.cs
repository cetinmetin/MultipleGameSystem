namespace TrainAndTestFormUI
{
    partial class TrainAndTestForm
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
            this.lblGameName = new System.Windows.Forms.Label();
            this.gbxTrain = new System.Windows.Forms.GroupBox();
            this.btnTrain = new System.Windows.Forms.Button();
            this.lblTrain2 = new System.Windows.Forms.Label();
            this.lblTrain = new System.Windows.Forms.Label();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.gbxTest = new System.Windows.Forms.GroupBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.lblTest2 = new System.Windows.Forms.Label();
            this.lblTest = new System.Windows.Forms.Label();
            this.gbxTrain.SuspendLayout();
            this.gbxTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGameName
            // 
            this.lblGameName.BackColor = System.Drawing.Color.Gainsboro;
            this.lblGameName.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGameName.Location = new System.Drawing.Point(2, 63);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(780, 69);
            this.lblGameName.TabIndex = 0;
            this.lblGameName.Text = "Game Name";
            this.lblGameName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbxTrain
            // 
            this.gbxTrain.BackColor = System.Drawing.Color.Gainsboro;
            this.gbxTrain.Controls.Add(this.btnTrain);
            this.gbxTrain.Controls.Add(this.lblTrain2);
            this.gbxTrain.Controls.Add(this.lblTrain);
            this.gbxTrain.Location = new System.Drawing.Point(111, 184);
            this.gbxTrain.Name = "gbxTrain";
            this.gbxTrain.Size = new System.Drawing.Size(257, 192);
            this.gbxTrain.TabIndex = 1;
            this.gbxTrain.TabStop = false;
            // 
            // btnTrain
            // 
            this.btnTrain.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnTrain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrain.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTrain.ForeColor = System.Drawing.Color.White;
            this.btnTrain.Location = new System.Drawing.Point(9, 146);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(242, 33);
            this.btnTrain.TabIndex = 2;
            this.btnTrain.Text = "Train";
            this.btnTrain.UseVisualStyleBackColor = false;
            this.btnTrain.Click += new System.EventHandler(this.BtnTrain_Click);
            // 
            // lblTrain2
            // 
            this.lblTrain2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTrain2.Location = new System.Drawing.Point(6, 78);
            this.lblTrain2.Name = "lblTrain2";
            this.lblTrain2.Size = new System.Drawing.Size(245, 54);
            this.lblTrain2.TabIndex = 1;
            this.lblTrain2.Text = "Collect examples of what you want the computer to recognise";
            this.lblTrain2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTrain
            // 
            this.lblTrain.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTrain.Location = new System.Drawing.Point(9, 24);
            this.lblTrain.Name = "lblTrain";
            this.lblTrain.Size = new System.Drawing.Size(242, 41);
            this.lblTrain.TabIndex = 0;
            this.lblTrain.Text = "Train";
            this.lblTrain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCloseForm.ForeColor = System.Drawing.Color.Red;
            this.btnCloseForm.Location = new System.Drawing.Point(740, 0);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(44, 36);
            this.btnCloseForm.TabIndex = 5;
            this.btnCloseForm.Text = "X";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.BtnCloseForm_Click);
            // 
            // gbxTest
            // 
            this.gbxTest.BackColor = System.Drawing.Color.Gainsboro;
            this.gbxTest.Controls.Add(this.btnTest);
            this.gbxTest.Controls.Add(this.lblTest2);
            this.gbxTest.Controls.Add(this.lblTest);
            this.gbxTest.Location = new System.Drawing.Point(422, 184);
            this.gbxTest.Name = "gbxTest";
            this.gbxTest.Size = new System.Drawing.Size(257, 192);
            this.gbxTest.TabIndex = 3;
            this.gbxTest.TabStop = false;
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTest.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTest.ForeColor = System.Drawing.Color.White;
            this.btnTest.Location = new System.Drawing.Point(9, 146);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(242, 33);
            this.btnTest.TabIndex = 2;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // lblTest2
            // 
            this.lblTest2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTest2.Location = new System.Drawing.Point(6, 78);
            this.lblTest2.Name = "lblTest2";
            this.lblTest2.Size = new System.Drawing.Size(245, 54);
            this.lblTest2.TabIndex = 1;
            this.lblTest2.Text = "Test the game with data recognised to the computer";
            this.lblTest2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTest
            // 
            this.lblTest.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTest.Location = new System.Drawing.Point(9, 24);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(242, 41);
            this.lblTest.TabIndex = 0;
            this.lblTest.Text = "Test";
            this.lblTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TrainAndTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.gbxTest);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.gbxTrain);
            this.Controls.Add(this.lblGameName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TrainAndTestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Train And Test";
            this.gbxTrain.ResumeLayout(false);
            this.gbxTest.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.GroupBox gbxTrain;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Label lblTrain2;
        private System.Windows.Forms.Label lblTrain;
        private System.Windows.Forms.GroupBox gbxTest;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label lblTest2;
        private System.Windows.Forms.Label lblTest;
    }
}


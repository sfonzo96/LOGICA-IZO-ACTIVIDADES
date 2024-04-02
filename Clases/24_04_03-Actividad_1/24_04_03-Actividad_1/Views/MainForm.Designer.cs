namespace _24_04_03_Actividad_1
{
    partial class MainForm
    {
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
            MainTitleLbl = new Label();
            ProfilePic = new PictureBox();
            UploadPicBtn = new Button();
            ProfilePicLoader = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)ProfilePic).BeginInit();
            SuspendLayout();
            // 
            // MainTitleLbl
            // 
            MainTitleLbl.AutoSize = true;
            MainTitleLbl.Font = new Font("Segoe UI", 16F);
            MainTitleLbl.Location = new Point(337, 43);
            MainTitleLbl.Name = "MainTitleLbl";
            MainTitleLbl.Size = new Size(127, 30);
            MainTitleLbl.TabIndex = 0;
            MainTitleLbl.Text = "Bienvenido!";
            // 
            // ProfilePic
            // 
            ProfilePic.Location = new Point(598, 12);
            ProfilePic.Name = "ProfilePic";
            ProfilePic.Size = new Size(90, 90);
            ProfilePic.SizeMode = PictureBoxSizeMode.StretchImage;
            ProfilePic.TabIndex = 1;
            ProfilePic.TabStop = false;
            // 
            // UploadPicBtn
            // 
            UploadPicBtn.Location = new Point(594, 108);
            UploadPicBtn.Name = "UploadPicBtn";
            UploadPicBtn.Size = new Size(98, 40);
            UploadPicBtn.TabIndex = 2;
            UploadPicBtn.Text = "Cargar imagen";
            UploadPicBtn.UseVisualStyleBackColor = true;
            UploadPicBtn.Click += UploadPicBtn_Click;
            // 
            // ProfilePicLoader
            // 
            ProfilePicLoader.Filter = "Image Files(*.JPEG;*.JPG)|*.JPEG;*.JPG";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(UploadPicBtn);
            Controls.Add(ProfilePic);
            Controls.Add(MainTitleLbl);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            ((System.ComponentModel.ISupportInitialize)ProfilePic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MainTitleLbl;
        private PictureBox ProfilePic;
        private Button UploadPicBtn;
        private OpenFileDialog ProfilePicLoader;
    }
}

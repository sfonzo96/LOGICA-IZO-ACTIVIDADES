namespace _24_04_03_Actividad_1.Views
{
    partial class SignupForm
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
            UserLbl = new Label();
            UserTxt = new TextBox();
            FNameTxt = new TextBox();
            FNameLbl = new Label();
            LNameTxt = new TextBox();
            LNameLbl = new Label();
            PassTxt = new TextBox();
            PassLbl = new Label();
            EmailTxt = new TextBox();
            EmailLbl = new Label();
            ConfirmBtn = new Button();
            AdminPassTxt = new TextBox();
            AdmPassLbl = new Label();
            SuspendLayout();
            // 
            // UserLbl
            // 
            UserLbl.AutoSize = true;
            UserLbl.Location = new Point(88, 47);
            UserLbl.Name = "UserLbl";
            UserLbl.Size = new Size(47, 15);
            UserLbl.TabIndex = 0;
            UserLbl.Text = "Usuario";
            // 
            // UserTxt
            // 
            UserTxt.Location = new Point(167, 44);
            UserTxt.Name = "UserTxt";
            UserTxt.Size = new Size(100, 23);
            UserTxt.TabIndex = 1;
            // 
            // FNameTxt
            // 
            FNameTxt.Location = new Point(167, 73);
            FNameTxt.Name = "FNameTxt";
            FNameTxt.Size = new Size(100, 23);
            FNameTxt.TabIndex = 3;
            // 
            // FNameLbl
            // 
            FNameLbl.AutoSize = true;
            FNameLbl.Location = new Point(88, 76);
            FNameLbl.Name = "FNameLbl";
            FNameLbl.Size = new Size(51, 15);
            FNameLbl.TabIndex = 2;
            FNameLbl.Text = "Nombre";
            // 
            // LNameTxt
            // 
            LNameTxt.Location = new Point(167, 102);
            LNameTxt.Name = "LNameTxt";
            LNameTxt.Size = new Size(100, 23);
            LNameTxt.TabIndex = 5;
            // 
            // LNameLbl
            // 
            LNameLbl.AutoSize = true;
            LNameLbl.Location = new Point(88, 105);
            LNameLbl.Name = "LNameLbl";
            LNameLbl.Size = new Size(51, 15);
            LNameLbl.TabIndex = 4;
            LNameLbl.Text = "Apellido";
            // 
            // PassTxt
            // 
            PassTxt.Location = new Point(167, 131);
            PassTxt.Name = "PassTxt";
            PassTxt.Size = new Size(100, 23);
            PassTxt.TabIndex = 7;
            // 
            // PassLbl
            // 
            PassLbl.AutoSize = true;
            PassLbl.Location = new Point(88, 134);
            PassLbl.Name = "PassLbl";
            PassLbl.Size = new Size(67, 15);
            PassLbl.TabIndex = 6;
            PassLbl.Text = "Contraseña";
            // 
            // EmailTxt
            // 
            EmailTxt.Location = new Point(167, 160);
            EmailTxt.Name = "EmailTxt";
            EmailTxt.Size = new Size(100, 23);
            EmailTxt.TabIndex = 9;
            // 
            // EmailLbl
            // 
            EmailLbl.AutoSize = true;
            EmailLbl.Location = new Point(88, 163);
            EmailLbl.Name = "EmailLbl";
            EmailLbl.Size = new Size(36, 15);
            EmailLbl.TabIndex = 8;
            EmailLbl.Text = "Email";
            // 
            // ConfirmBtn
            // 
            ConfirmBtn.Location = new Point(180, 189);
            ConfirmBtn.Name = "ConfirmBtn";
            ConfirmBtn.Size = new Size(75, 23);
            ConfirmBtn.TabIndex = 10;
            ConfirmBtn.Text = "Confirmar";
            ConfirmBtn.UseVisualStyleBackColor = true;
            ConfirmBtn.Click += ConfirmBtn_Click;
            // 
            // AdminPassTxt
            // 
            AdminPassTxt.Location = new Point(322, 105);
            AdminPassTxt.Name = "AdminPassTxt";
            AdminPassTxt.Size = new Size(100, 23);
            AdminPassTxt.TabIndex = 12;
            // 
            // AdmPassLbl
            // 
            AdmPassLbl.AutoSize = true;
            AdmPassLbl.Location = new Point(351, 81);
            AdmPassLbl.Name = "AdmPassLbl";
            AdmPassLbl.Size = new Size(43, 15);
            AdmPassLbl.TabIndex = 11;
            AdmPassLbl.Text = "Admin";
            // 
            // SignupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 261);
            Controls.Add(AdminPassTxt);
            Controls.Add(AdmPassLbl);
            Controls.Add(ConfirmBtn);
            Controls.Add(EmailTxt);
            Controls.Add(EmailLbl);
            Controls.Add(PassTxt);
            Controls.Add(PassLbl);
            Controls.Add(LNameTxt);
            Controls.Add(LNameLbl);
            Controls.Add(FNameTxt);
            Controls.Add(FNameLbl);
            Controls.Add(UserTxt);
            Controls.Add(UserLbl);
            Name = "SignupForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignupForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UserLbl;
        private TextBox UserTxt;
        private TextBox FNameTxt;
        private Label FNameLbl;
        private TextBox LNameTxt;
        private Label LNameLbl;
        private TextBox PassTxt;
        private Label PassLbl;
        private TextBox EmailTxt;
        private Label EmailLbl;
        private Button ConfirmBtn;
        private TextBox AdminPassTxt;
        private Label AdmPassLbl;
    }
}
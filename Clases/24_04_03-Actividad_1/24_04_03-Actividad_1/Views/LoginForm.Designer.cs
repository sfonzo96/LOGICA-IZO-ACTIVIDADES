namespace _24_04_03_Actividad_1.Views
{
    partial class LoginForm
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
            UserTxt = new TextBox();
            LoginBtn = new Button();
            UserLbl = new Label();
            PassLbl = new Label();
            PassTxt = new TextBox();
            SignupBtn = new Button();
            SuspendLayout();
            // 
            // UserTxt
            // 
            UserTxt.Location = new Point(167, 78);
            UserTxt.Name = "UserTxt";
            UserTxt.Size = new Size(100, 23);
            UserTxt.TabIndex = 0;
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(176, 158);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(75, 23);
            LoginBtn.TabIndex = 2;
            LoginBtn.Text = "Ingresar";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // UserLbl
            // 
            UserLbl.AutoSize = true;
            UserLbl.Location = new Point(94, 81);
            UserLbl.Name = "UserLbl";
            UserLbl.Size = new Size(47, 15);
            UserLbl.TabIndex = 2;
            UserLbl.Text = "Usuario";
            // 
            // PassLbl
            // 
            PassLbl.AutoSize = true;
            PassLbl.Location = new Point(94, 121);
            PassLbl.Name = "PassLbl";
            PassLbl.Size = new Size(67, 15);
            PassLbl.TabIndex = 3;
            PassLbl.Text = "Contraseña";
            // 
            // PassTxt
            // 
            PassTxt.Location = new Point(167, 118);
            PassTxt.Name = "PassTxt";
            PassTxt.Size = new Size(100, 23);
            PassTxt.TabIndex = 1;
            // 
            // SignupBtn
            // 
            SignupBtn.Location = new Point(176, 187);
            SignupBtn.Name = "SignupBtn";
            SignupBtn.Size = new Size(75, 39);
            SignupBtn.TabIndex = 3;
            SignupBtn.Text = "Nuevo Usuario";
            SignupBtn.UseVisualStyleBackColor = true;
            SignupBtn.Click += SignupBtn_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 261);
            Controls.Add(SignupBtn);
            Controls.Add(PassTxt);
            Controls.Add(PassLbl);
            Controls.Add(UserLbl);
            Controls.Add(LoginBtn);
            Controls.Add(UserTxt);
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UserTxt;
        private Button LoginBtn;
        private Label UserLbl;
        private Label PassLbl;
        private TextBox PassTxt;
        private Button SignupBtn;
    }
}
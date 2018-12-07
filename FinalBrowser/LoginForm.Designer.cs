namespace FinalBrowser
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
            this.TextFieldUser = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TextFieldPass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialCheckBox1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.FlatButtonSignIn = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // TextFieldUser
            // 
            this.TextFieldUser.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TextFieldUser.Depth = 0;
            this.TextFieldUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TextFieldUser.Hint = "Username";
            this.TextFieldUser.Location = new System.Drawing.Point(182, 129);
            this.TextFieldUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextFieldUser.Name = "TextFieldUser";
            this.TextFieldUser.PasswordChar = '\0';
            this.TextFieldUser.SelectedText = "";
            this.TextFieldUser.SelectionLength = 0;
            this.TextFieldUser.SelectionStart = 0;
            this.TextFieldUser.Size = new System.Drawing.Size(235, 23);
            this.TextFieldUser.TabIndex = 0;
            this.TextFieldUser.UseSystemPasswordChar = false;
            // 
            // TextFieldPass
            // 
            this.TextFieldPass.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TextFieldPass.Depth = 0;
            this.TextFieldPass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TextFieldPass.Hint = "Password";
            this.TextFieldPass.Location = new System.Drawing.Point(182, 175);
            this.TextFieldPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextFieldPass.Name = "TextFieldPass";
            this.TextFieldPass.PasswordChar = '*';
            this.TextFieldPass.SelectedText = "";
            this.TextFieldPass.SelectionLength = 0;
            this.TextFieldPass.SelectionStart = 0;
            this.TextFieldPass.Size = new System.Drawing.Size(235, 23);
            this.TextFieldPass.TabIndex = 1;
            this.TextFieldPass.UseSystemPasswordChar = false;
            this.TextFieldPass.Click += new System.EventHandler(this.TextFieldPass_Click);
            // 
            // materialCheckBox1
            // 
            this.materialCheckBox1.AutoSize = true;
            this.materialCheckBox1.Depth = 0;
            this.materialCheckBox1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox1.Location = new System.Drawing.Point(214, 211);
            this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox1.Name = "materialCheckBox1";
            this.materialCheckBox1.Ripple = true;
            this.materialCheckBox1.Size = new System.Drawing.Size(144, 30);
            this.materialCheckBox1.TabIndex = 2;
            this.materialCheckBox1.Text = "Keep Me logged In";
            this.materialCheckBox1.UseVisualStyleBackColor = true;
            // 
            // FlatButtonSignIn
            // 
            this.FlatButtonSignIn.AutoSize = true;
            this.FlatButtonSignIn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FlatButtonSignIn.Depth = 0;
            this.FlatButtonSignIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FlatButtonSignIn.Location = new System.Drawing.Point(253, 264);
            this.FlatButtonSignIn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.FlatButtonSignIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.FlatButtonSignIn.Name = "FlatButtonSignIn";
            this.FlatButtonSignIn.Primary = false;
            this.FlatButtonSignIn.Size = new System.Drawing.Size(60, 36);
            this.FlatButtonSignIn.TabIndex = 3;
            this.FlatButtonSignIn.Text = "Sign In";
            this.FlatButtonSignIn.UseVisualStyleBackColor = true;
            this.FlatButtonSignIn.Click += new System.EventHandler(this.FlatButtonSignIn_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(236, 84);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(107, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Authentication";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(590, 325);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.FlatButtonSignIn);
            this.Controls.Add(this.materialCheckBox1);
            this.Controls.Add(this.TextFieldPass);
            this.Controls.Add(this.TextFieldUser);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField TextFieldUser;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextFieldPass;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox1;
        private MaterialSkin.Controls.MaterialFlatButton FlatButtonSignIn;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}
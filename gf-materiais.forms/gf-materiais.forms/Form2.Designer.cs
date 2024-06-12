
namespace gf_materiais.forms
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.senhalogin_txt = new System.Windows.Forms.TextBox();
            this.usuariologin_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.senhalogin_txt);
            this.panel1.Controls.Add(this.usuariologin_txt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Showcard Gothic", 7F, System.Drawing.FontStyle.Italic);
            this.panel1.Location = new System.Drawing.Point(271, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 278);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(100, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 11);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cadastrar";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 11);
            this.label4.TabIndex = 6;
            this.label4.Text = "Esqueceu Sua Senha?";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconButton1.Font = new System.Drawing.Font("Showcard Gothic", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Snow;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(90, 177);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(75, 23);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.Text = "Entrar";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuario";
            // 
            // senhalogin_txt
            // 
            this.senhalogin_txt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhalogin_txt.Location = new System.Drawing.Point(63, 141);
            this.senhalogin_txt.Name = "senhalogin_txt";
            this.senhalogin_txt.Size = new System.Drawing.Size(133, 18);
            this.senhalogin_txt.TabIndex = 2;
            // 
            // usuariologin_txt
            // 
            this.usuariologin_txt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuariologin_txt.Location = new System.Drawing.Point(63, 96);
            this.usuariologin_txt.Name = "usuariologin_txt";
            this.usuariologin_txt.Size = new System.Drawing.Size(133, 18);
            this.usuariologin_txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 30.5F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(54, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox senhalogin_txt;
        private System.Windows.Forms.TextBox usuariologin_txt;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label5;
    }
}
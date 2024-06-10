
namespace gf_materiais.forms
{
    partial class Form3
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
            this.date_txt = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.criar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Senha_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Email_txt = new System.Windows.Forms.TextBox();
            this.Nome_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Usuario_txt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.date_txt);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Usuario_txt);
            this.panel1.Controls.Add(this.criar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Senha_txt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Email_txt);
            this.panel1.Controls.Add(this.Nome_txt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Showcard Gothic", 7F, System.Drawing.FontStyle.Italic);
            this.panel1.Location = new System.Drawing.Point(212, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 340);
            this.panel1.TabIndex = 1;
            // 
            // date_txt
            // 
            this.date_txt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 6.75F, System.Drawing.FontStyle.Italic);
            this.date_txt.Location = new System.Drawing.Point(233, 101);
            this.date_txt.Name = "date_txt";
            this.date_txt.Size = new System.Drawing.Size(133, 18);
            this.date_txt.TabIndex = 14;
            this.date_txt.ValueChanged += new System.EventHandler(this.date_txt_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(230, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 14);
            this.label7.TabIndex = 13;
            this.label7.Text = "Data De Nascimento";
            // 
            // criar
            // 
            this.criar.BackColor = System.Drawing.SystemColors.WindowText;
            this.criar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.criar.Location = new System.Drawing.Point(181, 214);
            this.criar.Name = "criar";
            this.criar.Size = new System.Drawing.Size(75, 23);
            this.criar.TabIndex = 7;
            this.criar.Text = "Criar";
            this.criar.UseVisualStyleBackColor = false;
            this.criar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Senha";
            // 
            // Senha_txt
            // 
            this.Senha_txt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Senha_txt.Location = new System.Drawing.Point(233, 148);
            this.Senha_txt.Name = "Senha_txt";
            this.Senha_txt.Size = new System.Drawing.Size(133, 18);
            this.Senha_txt.TabIndex = 5;
            this.Senha_txt.TextChanged += new System.EventHandler(this.Senha_txt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome Completo";
            // 
            // Email_txt
            // 
            this.Email_txt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_txt.Location = new System.Drawing.Point(150, 190);
            this.Email_txt.Name = "Email_txt";
            this.Email_txt.Size = new System.Drawing.Size(133, 18);
            this.Email_txt.TabIndex = 2;
            this.Email_txt.TextChanged += new System.EventHandler(this.Email_txt_TextChanged);
            // 
            // Nome_txt
            // 
            this.Nome_txt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome_txt.Location = new System.Drawing.Point(52, 101);
            this.Nome_txt.Name = "Nome_txt";
            this.Nome_txt.Size = new System.Drawing.Size(133, 18);
            this.Nome_txt.TabIndex = 1;
            this.Nome_txt.TextChanged += new System.EventHandler(this.Nome_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 30.5F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(87, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "Usuario";
            // 
            // Usuario_txt
            // 
            this.Usuario_txt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario_txt.Location = new System.Drawing.Point(52, 148);
            this.Usuario_txt.Name = "Usuario_txt";
            this.Usuario_txt.Size = new System.Drawing.Size(133, 18);
            this.Usuario_txt.TabIndex = 8;
            this.Usuario_txt.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button criar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Senha_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Email_txt;
        private System.Windows.Forms.TextBox Nome_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Usuario_txt;
    }
}
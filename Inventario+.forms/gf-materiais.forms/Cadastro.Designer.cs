
namespace gf_materiais.forms
{
    partial class Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panel1 = new System.Windows.Forms.Panel();
            this.date_txt = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Usuario_txt = new System.Windows.Forms.TextBox();
            this.criar_cadastro = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Senha_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Email_txt = new System.Windows.Forms.TextBox();
            this.Nome_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.voltarbotao = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.voltarbotao);
            this.panel1.Controls.Add(this.date_txt);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Usuario_txt);
            this.panel1.Controls.Add(this.criar_cadastro);
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
            // 
            // criar_cadastro
            // 
            this.criar_cadastro.BackColor = System.Drawing.SystemColors.WindowText;
            this.criar_cadastro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.criar_cadastro.Location = new System.Drawing.Point(181, 214);
            this.criar_cadastro.Name = "criar_cadastro";
            this.criar_cadastro.Size = new System.Drawing.Size(75, 23);
            this.criar_cadastro.TabIndex = 7;
            this.criar_cadastro.Text = "Criar";
            this.criar_cadastro.UseVisualStyleBackColor = false;
            this.criar_cadastro.Click += new System.EventHandler(this.button1_Click);
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
            // 
            // Nome_txt
            // 
            this.Nome_txt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome_txt.Location = new System.Drawing.Point(52, 101);
            this.Nome_txt.Name = "Nome_txt";
            this.Nome_txt.Size = new System.Drawing.Size(133, 18);
            this.Nome_txt.TabIndex = 1;
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
            // voltarbotao
            // 
            this.voltarbotao.AllowAnimations = true;
            this.voltarbotao.AllowMouseEffects = true;
            this.voltarbotao.AllowToggling = false;
            this.voltarbotao.AnimationSpeed = 200;
            this.voltarbotao.AutoGenerateColors = false;
            this.voltarbotao.AutoRoundBorders = false;
            this.voltarbotao.AutoSizeLeftIcon = true;
            this.voltarbotao.AutoSizeRightIcon = true;
            this.voltarbotao.BackColor = System.Drawing.Color.Transparent;
            this.voltarbotao.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.voltarbotao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("voltarbotao.BackgroundImage")));
            this.voltarbotao.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.voltarbotao.ButtonText = "Voltar";
            this.voltarbotao.ButtonTextMarginLeft = 0;
            this.voltarbotao.ColorContrastOnClick = 45;
            this.voltarbotao.ColorContrastOnHover = 45;
            this.voltarbotao.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.voltarbotao.CustomizableEdges = borderEdges1;
            this.voltarbotao.DialogResult = System.Windows.Forms.DialogResult.None;
            this.voltarbotao.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.voltarbotao.DisabledFillColor = System.Drawing.Color.Empty;
            this.voltarbotao.DisabledForecolor = System.Drawing.Color.Empty;
            this.voltarbotao.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.voltarbotao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.voltarbotao.ForeColor = System.Drawing.Color.White;
            this.voltarbotao.IconLeft = null;
            this.voltarbotao.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.voltarbotao.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.voltarbotao.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.voltarbotao.IconMarginLeft = 11;
            this.voltarbotao.IconPadding = 10;
            this.voltarbotao.IconRight = null;
            this.voltarbotao.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.voltarbotao.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.voltarbotao.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.voltarbotao.IconSize = 25;
            this.voltarbotao.IdleBorderColor = System.Drawing.Color.Empty;
            this.voltarbotao.IdleBorderRadius = 0;
            this.voltarbotao.IdleBorderThickness = 0;
            this.voltarbotao.IdleFillColor = System.Drawing.Color.Empty;
            this.voltarbotao.IdleIconLeftImage = null;
            this.voltarbotao.IdleIconRightImage = null;
            this.voltarbotao.IndicateFocus = false;
            this.voltarbotao.Location = new System.Drawing.Point(192, 243);
            this.voltarbotao.Name = "voltarbotao";
            this.voltarbotao.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.voltarbotao.OnDisabledState.BorderRadius = 17;
            this.voltarbotao.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.voltarbotao.OnDisabledState.BorderThickness = 1;
            this.voltarbotao.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.voltarbotao.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.voltarbotao.OnDisabledState.IconLeftImage = null;
            this.voltarbotao.OnDisabledState.IconRightImage = null;
            this.voltarbotao.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.voltarbotao.onHoverState.BorderRadius = 17;
            this.voltarbotao.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.voltarbotao.onHoverState.BorderThickness = 1;
            this.voltarbotao.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.voltarbotao.onHoverState.ForeColor = System.Drawing.Color.White;
            this.voltarbotao.onHoverState.IconLeftImage = null;
            this.voltarbotao.onHoverState.IconRightImage = null;
            this.voltarbotao.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.voltarbotao.OnIdleState.BorderRadius = 17;
            this.voltarbotao.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.voltarbotao.OnIdleState.BorderThickness = 1;
            this.voltarbotao.OnIdleState.FillColor = System.Drawing.Color.Red;
            this.voltarbotao.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.voltarbotao.OnIdleState.IconLeftImage = null;
            this.voltarbotao.OnIdleState.IconRightImage = null;
            this.voltarbotao.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.voltarbotao.OnPressedState.BorderRadius = 17;
            this.voltarbotao.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.voltarbotao.OnPressedState.BorderThickness = 1;
            this.voltarbotao.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.voltarbotao.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.voltarbotao.OnPressedState.IconLeftImage = null;
            this.voltarbotao.OnPressedState.IconRightImage = null;
            this.voltarbotao.Size = new System.Drawing.Size(54, 30);
            this.voltarbotao.TabIndex = 15;
            this.voltarbotao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.voltarbotao.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.voltarbotao.TextMarginLeft = 0;
            this.voltarbotao.TextPadding = new System.Windows.Forms.Padding(0);
            this.voltarbotao.UseDefaultRadiusAndThickness = true;
            this.voltarbotao.Click += new System.EventHandler(this.voltarbotao_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Cadastro";
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button criar_cadastro;
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
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton voltarbotao;
    }
}
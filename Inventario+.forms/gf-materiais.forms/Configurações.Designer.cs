
namespace gf_materiais.forms
{
    partial class Configurações
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configurações));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.usuariotxt = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.nomecompletotxt = new Bunifu.UI.WinForms.BunifuLabel();
            this.emailtxt = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.sair = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Voltar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.bunifuPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usuariotxt
            // 
            this.usuariotxt.AllowParentOverrides = false;
            this.usuariotxt.AutoEllipsis = false;
            this.usuariotxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.usuariotxt.CursorType = System.Windows.Forms.Cursors.Default;
            this.usuariotxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.usuariotxt.Location = new System.Drawing.Point(118, 96);
            this.usuariotxt.Name = "usuariotxt";
            this.usuariotxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.usuariotxt.Size = new System.Drawing.Size(40, 15);
            this.usuariotxt.TabIndex = 0;
            this.usuariotxt.Text = "Usuario";
            this.usuariotxt.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.usuariotxt.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.usuariotxt.Click += new System.EventHandler(this.bunifuLabel1_Click);
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 35;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(103, 20);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(70, 70);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 1;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // nomecompletotxt
            // 
            this.nomecompletotxt.AllowParentOverrides = false;
            this.nomecompletotxt.AutoEllipsis = false;
            this.nomecompletotxt.CursorType = null;
            this.nomecompletotxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nomecompletotxt.Location = new System.Drawing.Point(94, 117);
            this.nomecompletotxt.Name = "nomecompletotxt";
            this.nomecompletotxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nomecompletotxt.Size = new System.Drawing.Size(89, 15);
            this.nomecompletotxt.TabIndex = 2;
            this.nomecompletotxt.Text = "Nome Completo";
            this.nomecompletotxt.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.nomecompletotxt.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // emailtxt
            // 
            this.emailtxt.AllowParentOverrides = false;
            this.emailtxt.AutoEllipsis = false;
            this.emailtxt.CursorType = null;
            this.emailtxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emailtxt.Location = new System.Drawing.Point(124, 138);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.emailtxt.Size = new System.Drawing.Size(29, 15);
            this.emailtxt.TabIndex = 3;
            this.emailtxt.Text = "Email";
            this.emailtxt.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.emailtxt.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.DimGray;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Black;
            this.bunifuPanel1.BorderRadius = 22;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.Voltar);
            this.bunifuPanel1.Controls.Add(this.sair);
            this.bunifuPanel1.Controls.Add(this.bunifuPictureBox1);
            this.bunifuPanel1.Controls.Add(this.emailtxt);
            this.bunifuPanel1.Controls.Add(this.usuariotxt);
            this.bunifuPanel1.Controls.Add(this.nomecompletotxt);
            this.bunifuPanel1.Location = new System.Drawing.Point(280, 55);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(276, 320);
            this.bunifuPanel1.TabIndex = 4;
            // 
            // sair
            // 
            this.sair.AllowAnimations = true;
            this.sair.AllowMouseEffects = true;
            this.sair.AllowToggling = false;
            this.sair.AnimationSpeed = 200;
            this.sair.AutoGenerateColors = false;
            this.sair.AutoRoundBorders = false;
            this.sair.AutoSizeLeftIcon = true;
            this.sair.AutoSizeRightIcon = true;
            this.sair.BackColor = System.Drawing.Color.Transparent;
            this.sair.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.sair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sair.BackgroundImage")));
            this.sair.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.sair.ButtonText = "Sair";
            this.sair.ButtonTextMarginLeft = 0;
            this.sair.ColorContrastOnClick = 45;
            this.sair.ColorContrastOnHover = 45;
            this.sair.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.sair.CustomizableEdges = borderEdges2;
            this.sair.DialogResult = System.Windows.Forms.DialogResult.None;
            this.sair.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.sair.DisabledFillColor = System.Drawing.Color.Empty;
            this.sair.DisabledForecolor = System.Drawing.Color.Empty;
            this.sair.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.sair.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sair.ForeColor = System.Drawing.Color.Black;
            this.sair.IconLeft = null;
            this.sair.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sair.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.sair.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.sair.IconMarginLeft = 11;
            this.sair.IconPadding = 10;
            this.sair.IconRight = null;
            this.sair.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sair.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.sair.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.sair.IconSize = 25;
            this.sair.IdleBorderColor = System.Drawing.Color.Empty;
            this.sair.IdleBorderRadius = 0;
            this.sair.IdleBorderThickness = 0;
            this.sair.IdleFillColor = System.Drawing.Color.Empty;
            this.sair.IdleIconLeftImage = null;
            this.sair.IdleIconRightImage = null;
            this.sair.IndicateFocus = false;
            this.sair.Location = new System.Drawing.Point(80, 214);
            this.sair.Name = "sair";
            this.sair.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.sair.OnDisabledState.BorderRadius = 22;
            this.sair.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.sair.OnDisabledState.BorderThickness = 1;
            this.sair.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.sair.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.sair.OnDisabledState.IconLeftImage = null;
            this.sair.OnDisabledState.IconRightImage = null;
            this.sair.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.sair.onHoverState.BorderRadius = 22;
            this.sair.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.sair.onHoverState.BorderThickness = 1;
            this.sair.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.sair.onHoverState.ForeColor = System.Drawing.Color.White;
            this.sair.onHoverState.IconLeftImage = null;
            this.sair.onHoverState.IconRightImage = null;
            this.sair.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.sair.OnIdleState.BorderRadius = 22;
            this.sair.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.sair.OnIdleState.BorderThickness = 1;
            this.sair.OnIdleState.FillColor = System.Drawing.Color.Red;
            this.sair.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.sair.OnIdleState.IconLeftImage = null;
            this.sair.OnIdleState.IconRightImage = null;
            this.sair.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.sair.OnPressedState.BorderRadius = 22;
            this.sair.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.sair.OnPressedState.BorderThickness = 1;
            this.sair.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.sair.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.sair.OnPressedState.IconLeftImage = null;
            this.sair.OnPressedState.IconRightImage = null;
            this.sair.Size = new System.Drawing.Size(114, 32);
            this.sair.TabIndex = 4;
            this.sair.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sair.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.sair.TextMarginLeft = 0;
            this.sair.TextPadding = new System.Windows.Forms.Padding(0);
            this.sair.UseDefaultRadiusAndThickness = true;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // Voltar
            // 
            this.Voltar.AllowAnimations = true;
            this.Voltar.AllowMouseEffects = true;
            this.Voltar.AllowToggling = false;
            this.Voltar.AnimationSpeed = 200;
            this.Voltar.AutoGenerateColors = false;
            this.Voltar.AutoRoundBorders = false;
            this.Voltar.AutoSizeLeftIcon = true;
            this.Voltar.AutoSizeRightIcon = true;
            this.Voltar.BackColor = System.Drawing.Color.Transparent;
            this.Voltar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.Voltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Voltar.BackgroundImage")));
            this.Voltar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Voltar.ButtonText = "Voltar";
            this.Voltar.ButtonTextMarginLeft = 0;
            this.Voltar.ColorContrastOnClick = 45;
            this.Voltar.ColorContrastOnHover = 45;
            this.Voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.Voltar.CustomizableEdges = borderEdges1;
            this.Voltar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Voltar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Voltar.DisabledFillColor = System.Drawing.Color.Empty;
            this.Voltar.DisabledForecolor = System.Drawing.Color.Empty;
            this.Voltar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Voltar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Voltar.ForeColor = System.Drawing.Color.Black;
            this.Voltar.IconLeft = null;
            this.Voltar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Voltar.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.Voltar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Voltar.IconMarginLeft = 11;
            this.Voltar.IconPadding = 10;
            this.Voltar.IconRight = null;
            this.Voltar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Voltar.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.Voltar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Voltar.IconSize = 25;
            this.Voltar.IdleBorderColor = System.Drawing.Color.Empty;
            this.Voltar.IdleBorderRadius = 0;
            this.Voltar.IdleBorderThickness = 0;
            this.Voltar.IdleFillColor = System.Drawing.Color.Empty;
            this.Voltar.IdleIconLeftImage = null;
            this.Voltar.IdleIconRightImage = null;
            this.Voltar.IndicateFocus = false;
            this.Voltar.Location = new System.Drawing.Point(103, 252);
            this.Voltar.Name = "Voltar";
            this.Voltar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Voltar.OnDisabledState.BorderRadius = 22;
            this.Voltar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Voltar.OnDisabledState.BorderThickness = 1;
            this.Voltar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Voltar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Voltar.OnDisabledState.IconLeftImage = null;
            this.Voltar.OnDisabledState.IconRightImage = null;
            this.Voltar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.Voltar.onHoverState.BorderRadius = 22;
            this.Voltar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Voltar.onHoverState.BorderThickness = 1;
            this.Voltar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.Voltar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.Voltar.onHoverState.IconLeftImage = null;
            this.Voltar.onHoverState.IconRightImage = null;
            this.Voltar.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.Voltar.OnIdleState.BorderRadius = 22;
            this.Voltar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Voltar.OnIdleState.BorderThickness = 1;
            this.Voltar.OnIdleState.FillColor = System.Drawing.Color.Red;
            this.Voltar.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.Voltar.OnIdleState.IconLeftImage = null;
            this.Voltar.OnIdleState.IconRightImage = null;
            this.Voltar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Voltar.OnPressedState.BorderRadius = 22;
            this.Voltar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Voltar.OnPressedState.BorderThickness = 1;
            this.Voltar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Voltar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Voltar.OnPressedState.IconLeftImage = null;
            this.Voltar.OnPressedState.IconRightImage = null;
            this.Voltar.Size = new System.Drawing.Size(70, 32);
            this.Voltar.TabIndex = 5;
            this.Voltar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Voltar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Voltar.TextMarginLeft = 0;
            this.Voltar.TextPadding = new System.Windows.Forms.Padding(0);
            this.Voltar.UseDefaultRadiusAndThickness = true;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // Configurações
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bunifuPanel1);
            this.Name = "Configurações";
            this.Text = "Configurações";
            this.Load += new System.EventHandler(this.configuraçoes_load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel usuariotxt;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuLabel nomecompletotxt;
        private Bunifu.UI.WinForms.BunifuLabel emailtxt;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton sair;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Voltar;
    }
}
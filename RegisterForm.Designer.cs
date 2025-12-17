namespace FilmIzlemeUygulamasi
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtRegUsername = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtRegPassword = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnRegister = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnGoBack = new System.Windows.Forms.LinkLabel();
            this.btnClose = new Bunifu.UI.WinForms.BunifuImageButton();
            this.SuspendLayout();
            
            // bunifuElipse1
            
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            
            // lblTitle
             
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(67, 74);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 49);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "CREATE NEW ACCOUNT";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // txtRegUsername
           
            this.txtRegUsername.AcceptsReturn = false;
            this.txtRegUsername.AcceptsTab = false;
            this.txtRegUsername.AnimationSpeed = 200;
            this.txtRegUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtRegUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtRegUsername.AutoSizeHeight = true;
            this.txtRegUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtRegUsername.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtRegUsername.BackgroundImage")));
            this.txtRegUsername.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtRegUsername.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtRegUsername.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtRegUsername.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtRegUsername.BorderRadius = 1;
            this.txtRegUsername.BorderThickness = 1;
            this.txtRegUsername.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtRegUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRegUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegUsername.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtRegUsername.DefaultText = "";
            this.txtRegUsername.FillColor = System.Drawing.Color.White;
            this.txtRegUsername.HideSelection = true;
            this.txtRegUsername.IconLeft = null;
            this.txtRegUsername.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegUsername.IconPadding = 10;
            this.txtRegUsername.IconRight = null;
            this.txtRegUsername.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegUsername.Lines = new string[0];
            this.txtRegUsername.Location = new System.Drawing.Point(67, 172);
            this.txtRegUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtRegUsername.MaxLength = 32767;
            this.txtRegUsername.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtRegUsername.Modified = false;
            this.txtRegUsername.Multiline = false;
            this.txtRegUsername.Name = "txtRegUsername";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtRegUsername.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtRegUsername.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtRegUsername.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtRegUsername.OnIdleState = stateProperties8;
            this.txtRegUsername.Padding = new System.Windows.Forms.Padding(4);
            this.txtRegUsername.PasswordChar = '\0';
            this.txtRegUsername.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtRegUsername.PlaceholderText = "Username";
            this.txtRegUsername.ReadOnly = false;
            this.txtRegUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRegUsername.SelectedText = "";
            this.txtRegUsername.SelectionLength = 0;
            this.txtRegUsername.SelectionStart = 0;
            this.txtRegUsername.ShortcutsEnabled = true;
            this.txtRegUsername.Size = new System.Drawing.Size(400, 55);
            this.txtRegUsername.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtRegUsername.TabIndex = 1;
            this.txtRegUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRegUsername.TextMarginBottom = 0;
            this.txtRegUsername.TextMarginLeft = 3;
            this.txtRegUsername.TextMarginTop = 1;
            this.txtRegUsername.TextPlaceholder = "Username";
            this.txtRegUsername.UseSystemPasswordChar = false;
            this.txtRegUsername.WordWrap = true;
           
            // txtRegPassword
           
            this.txtRegPassword.AcceptsReturn = false;
            this.txtRegPassword.AcceptsTab = false;
            this.txtRegPassword.AnimationSpeed = 200;
            this.txtRegPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtRegPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtRegPassword.AutoSizeHeight = true;
            this.txtRegPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtRegPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtRegPassword.BackgroundImage")));
            this.txtRegPassword.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtRegPassword.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtRegPassword.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtRegPassword.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtRegPassword.BorderRadius = 1;
            this.txtRegPassword.BorderThickness = 1;
            this.txtRegPassword.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtRegPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRegPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegPassword.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtRegPassword.DefaultText = "";
            this.txtRegPassword.FillColor = System.Drawing.Color.White;
            this.txtRegPassword.HideSelection = true;
            this.txtRegPassword.IconLeft = null;
            this.txtRegPassword.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegPassword.IconPadding = 10;
            this.txtRegPassword.IconRight = null;
            this.txtRegPassword.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegPassword.Lines = new string[0];
            this.txtRegPassword.Location = new System.Drawing.Point(67, 258);
            this.txtRegPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtRegPassword.MaxLength = 32767;
            this.txtRegPassword.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtRegPassword.Modified = false;
            this.txtRegPassword.Multiline = false;
            this.txtRegPassword.Name = "txtRegPassword";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtRegPassword.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtRegPassword.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtRegPassword.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtRegPassword.OnIdleState = stateProperties4;
            this.txtRegPassword.Padding = new System.Windows.Forms.Padding(4);
            this.txtRegPassword.PasswordChar = '●';
            this.txtRegPassword.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtRegPassword.PlaceholderText = "Password";
            this.txtRegPassword.ReadOnly = false;
            this.txtRegPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRegPassword.SelectedText = "";
            this.txtRegPassword.SelectionLength = 0;
            this.txtRegPassword.SelectionStart = 0;
            this.txtRegPassword.ShortcutsEnabled = true;
            this.txtRegPassword.Size = new System.Drawing.Size(400, 55);
            this.txtRegPassword.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtRegPassword.TabIndex = 2;
            this.txtRegPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRegPassword.TextMarginBottom = 0;
            this.txtRegPassword.TextMarginLeft = 3;
            this.txtRegPassword.TextMarginTop = 1;
            this.txtRegPassword.TextPlaceholder = "Password";
            this.txtRegPassword.UseSystemPasswordChar = false;
            this.txtRegPassword.WordWrap = true;
            
            // btnRegister
            
            this.btnRegister.AllowAnimations = true;
            this.btnRegister.AllowMouseEffects = true;
            this.btnRegister.AllowToggling = false;
            this.btnRegister.AnimationSpeed = 200;
            this.btnRegister.AutoGenerateColors = false;
            this.btnRegister.AutoRoundBorders = false;
            this.btnRegister.AutoSizeLeftIcon = true;
            this.btnRegister.AutoSizeRightIcon = true;
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnRegister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegister.BackgroundImage")));
            this.btnRegister.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRegister.ButtonText = "REGISTER";
            this.btnRegister.ButtonTextMarginLeft = 0;
            this.btnRegister.ColorContrastOnClick = 45;
            this.btnRegister.ColorContrastOnHover = 45;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnRegister.CustomizableEdges = borderEdges1;
            this.btnRegister.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRegister.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnRegister.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnRegister.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnRegister.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.IconLeft = null;
            this.btnRegister.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegister.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnRegister.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnRegister.IconMarginLeft = 11;
            this.btnRegister.IconPadding = 10;
            this.btnRegister.IconRight = null;
            this.btnRegister.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegister.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnRegister.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnRegister.IconSize = 25;
            this.btnRegister.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnRegister.IdleBorderRadius = 0;
            this.btnRegister.IdleBorderThickness = 0;
            this.btnRegister.IdleFillColor = System.Drawing.Color.Empty;
            this.btnRegister.IdleIconLeftImage = null;
            this.btnRegister.IdleIconRightImage = null;
            this.btnRegister.IndicateFocus = false;
            this.btnRegister.Location = new System.Drawing.Point(67, 357);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnRegister.OnDisabledState.BorderRadius = 1;
            this.btnRegister.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRegister.OnDisabledState.BorderThickness = 1;
            this.btnRegister.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnRegister.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnRegister.OnDisabledState.IconLeftImage = null;
            this.btnRegister.OnDisabledState.IconRightImage = null;
            this.btnRegister.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnRegister.onHoverState.BorderRadius = 1;
            this.btnRegister.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRegister.onHoverState.BorderThickness = 1;
            this.btnRegister.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnRegister.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnRegister.onHoverState.IconLeftImage = null;
            this.btnRegister.onHoverState.IconRightImage = null;
            this.btnRegister.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnRegister.OnIdleState.BorderRadius = 1;
            this.btnRegister.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRegister.OnIdleState.BorderThickness = 1;
            this.btnRegister.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnRegister.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnRegister.OnIdleState.IconLeftImage = null;
            this.btnRegister.OnIdleState.IconRightImage = null;
            this.btnRegister.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnRegister.OnPressedState.BorderRadius = 1;
            this.btnRegister.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRegister.OnPressedState.BorderThickness = 1;
            this.btnRegister.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnRegister.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnRegister.OnPressedState.IconLeftImage = null;
            this.btnRegister.OnPressedState.IconRightImage = null;
            this.btnRegister.Size = new System.Drawing.Size(400, 62);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegister.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRegister.TextMarginLeft = 0;
            this.btnRegister.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnRegister.UseDefaultRadiusAndThickness = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
             
            // btnGoBack
           
            this.btnGoBack.AutoSize = true;
            this.btnGoBack.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnGoBack.LinkColor = System.Drawing.Color.White;
            this.btnGoBack.Location = new System.Drawing.Point(180, 443);
            this.btnGoBack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(140, 23);
            this.btnGoBack.TabIndex = 4;
            this.btnGoBack.TabStop = true;
            this.btnGoBack.Text = "Go back to Login";
            this.btnGoBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnGoBack_Click);
           
            // btnClose
           
            this.btnClose.ActiveImage = null;
            this.btnClose.AllowAnimations = true;
            this.btnClose.AllowBuffering = false;
            this.btnClose.AllowToggling = false;
            this.btnClose.AllowZooming = true;
            this.btnClose.AllowZoomingOnFocus = false;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnClose.ErrorImage")));
            this.btnClose.FadeWhenInactive = false;
            this.btnClose.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageLocation = null;
            this.btnClose.ImageMargin = 20;
            this.btnClose.ImageSize = new System.Drawing.Size(47, 42);
            this.btnClose.ImageZoomSize = new System.Drawing.Size(67, 62);
            this.btnClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnClose.InitialImage")));
            this.btnClose.Location = new System.Drawing.Point(453, 8);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Rotation = 0;
            this.btnClose.ShowActiveImage = true;
            this.btnClose.ShowCursorChanges = true;
            this.btnClose.ShowImageBorders = true;
            this.btnClose.ShowSizeMarkers = false;
            this.btnClose.Size = new System.Drawing.Size(67, 62);
            this.btnClose.TabIndex = 0;
            this.btnClose.ToolTipText = "";
            this.btnClose.WaitOnLoad = false;
            this.btnClose.ImageMargin = 20;
            this.btnClose.ZoomSpeed = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
           
            // RegisterForm
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(533, 517);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtRegPassword);
            this.Controls.Add(this.txtRegUsername);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label lblTitle;
        private Bunifu.UI.WinForms.BunifuTextBox txtRegUsername;
        private Bunifu.UI.WinForms.BunifuTextBox txtRegPassword;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnRegister;
        private System.Windows.Forms.LinkLabel btnGoBack;
        private Bunifu.UI.WinForms.BunifuImageButton btnClose;
    }
}
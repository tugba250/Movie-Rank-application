namespace FilmIzlemeUygulamasi
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.flowLayoutPanelMovies = new System.Windows.Forms.FlowLayoutPanel();
            this.lbCategories = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtSearch = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnStatistic = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnLogOut = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnAddMovie = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panelSidebar.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            
            // bunifuElipse1
            
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            
            // panelSidebar
            
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panelSidebar.Controls.Add(this.btnStatistic);
            this.panelSidebar.Controls.Add(this.btnLogOut);
            this.panelSidebar.Controls.Add(this.btnAddMovie);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(4);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(267, 862);
            this.panelSidebar.TabIndex = 2;
          
            // panelHeader
          
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panelHeader.Controls.Add(this.txtSearch);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(267, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1066, 74);
            this.panelHeader.TabIndex = 1;
         
            // panelContent
          
            this.panelContent.Controls.Add(this.flowLayoutPanelMovies);
            this.panelContent.Controls.Add(this.lbCategories);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(267, 74);
            this.panelContent.Margin = new System.Windows.Forms.Padding(4);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1066, 788);
            this.panelContent.TabIndex = 0;
          
            // flowLayoutPanelMovies
            
            this.flowLayoutPanelMovies.AutoScroll = true;
            this.flowLayoutPanelMovies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelMovies.Location = new System.Drawing.Point(239, 0);
            this.flowLayoutPanelMovies.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanelMovies.Name = "flowLayoutPanelMovies";
            this.flowLayoutPanelMovies.Size = new System.Drawing.Size(827, 788);
            this.flowLayoutPanelMovies.TabIndex = 0;
          
            // lbCategories
          
            this.lbCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lbCategories.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbCategories.ForeColor = System.Drawing.Color.White;
            this.lbCategories.ItemHeight = 25;
            this.lbCategories.Location = new System.Drawing.Point(0, 0);
            this.lbCategories.Margin = new System.Windows.Forms.Padding(4);
            this.lbCategories.Name = "lbCategories";
            this.lbCategories.Size = new System.Drawing.Size(239, 788);
            this.lbCategories.TabIndex = 1;
            this.lbCategories.SelectedIndexChanged += new System.EventHandler(this.lbCategories_SelectedIndexChanged);
         
            // txtSearch
           
            this.txtSearch.AcceptsReturn = false;
            this.txtSearch.AcceptsTab = false;
            this.txtSearch.AnimationSpeed = 200;
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSearch.AutoSizeHeight = true;
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.BackgroundImage")));
            this.txtSearch.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtSearch.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtSearch.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtSearch.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtSearch.BorderRadius = 1;
            this.txtSearch.BorderThickness = 1;
            this.txtSearch.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearch.DefaultText = "";
            this.txtSearch.FillColor = System.Drawing.Color.White;
            this.txtSearch.HideSelection = true;
            this.txtSearch.IconLeft = null;
            this.txtSearch.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.IconPadding = 10;
            this.txtSearch.IconRight = null;
            this.txtSearch.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(27, 12);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtSearch.Modified = false;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtSearch.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnIdleState = stateProperties4;
            this.txtSearch.Padding = new System.Windows.Forms.Padding(4);
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSearch.PlaceholderText = "Search movies by title...";
            this.txtSearch.ReadOnly = false;
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(667, 52);
            this.txtSearch.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.TextMarginBottom = 0;
            this.txtSearch.TextMarginLeft = 3;
            this.txtSearch.TextMarginTop = 1;
            this.txtSearch.TextPlaceholder = "Search movies by title...";
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.WordWrap = true;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
         
            // btnStatistic
            
            this.btnStatistic.AllowAnimations = true;
            this.btnStatistic.AllowMouseEffects = true;
            this.btnStatistic.AllowToggling = false;
            this.btnStatistic.AnimationSpeed = 200;
            this.btnStatistic.AutoGenerateColors = false;
            this.btnStatistic.AutoRoundBorders = false;
            this.btnStatistic.AutoSizeLeftIcon = true;
            this.btnStatistic.AutoSizeRightIcon = true;
            this.btnStatistic.BackColor = System.Drawing.Color.Transparent;
            this.btnStatistic.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnStatistic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStatistic.BackgroundImage")));
            this.btnStatistic.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnStatistic.ButtonText = "Statistic";
            this.btnStatistic.ButtonTextMarginLeft = 0;
            this.btnStatistic.ColorContrastOnClick = 45;
            this.btnStatistic.ColorContrastOnHover = 45;
            this.btnStatistic.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnStatistic.CustomizableEdges = borderEdges1;
            this.btnStatistic.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnStatistic.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnStatistic.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnStatistic.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnStatistic.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnStatistic.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStatistic.ForeColor = System.Drawing.Color.White;
            this.btnStatistic.IconLeft = null;
            this.btnStatistic.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistic.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnStatistic.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnStatistic.IconMarginLeft = 11;
            this.btnStatistic.IconPadding = 10;
            this.btnStatistic.IconRight = null;
            this.btnStatistic.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStatistic.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnStatistic.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnStatistic.IconSize = 25;
            this.btnStatistic.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnStatistic.IdleBorderRadius = 0;
            this.btnStatistic.IdleBorderThickness = 0;
            this.btnStatistic.IdleFillColor = System.Drawing.Color.Empty;
            this.btnStatistic.IdleIconLeftImage = null;
            this.btnStatistic.IdleIconRightImage = null;
            this.btnStatistic.IndicateFocus = false;
            this.btnStatistic.Location = new System.Drawing.Point(13, 146);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnStatistic.OnDisabledState.BorderRadius = 1;
            this.btnStatistic.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnStatistic.OnDisabledState.BorderThickness = 1;
            this.btnStatistic.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnStatistic.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnStatistic.OnDisabledState.IconLeftImage = null;
            this.btnStatistic.OnDisabledState.IconRightImage = null;
            this.btnStatistic.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnStatistic.onHoverState.BorderRadius = 1;
            this.btnStatistic.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnStatistic.onHoverState.BorderThickness = 1;
            this.btnStatistic.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnStatistic.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnStatistic.onHoverState.IconLeftImage = null;
            this.btnStatistic.onHoverState.IconRightImage = null;
            this.btnStatistic.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnStatistic.OnIdleState.BorderRadius = 1;
            this.btnStatistic.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnStatistic.OnIdleState.BorderThickness = 1;
            this.btnStatistic.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnStatistic.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnStatistic.OnIdleState.IconLeftImage = null;
            this.btnStatistic.OnIdleState.IconRightImage = null;
            this.btnStatistic.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnStatistic.OnPressedState.BorderRadius = 1;
            this.btnStatistic.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnStatistic.OnPressedState.BorderThickness = 1;
            this.btnStatistic.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnStatistic.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnStatistic.OnPressedState.IconLeftImage = null;
            this.btnStatistic.OnPressedState.IconRightImage = null;
            this.btnStatistic.Size = new System.Drawing.Size(240, 54);
            this.btnStatistic.TabIndex = 2;
            this.btnStatistic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStatistic.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnStatistic.TextMarginLeft = 0;
            this.btnStatistic.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnStatistic.UseDefaultRadiusAndThickness = true;
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistics_Click);
          
            // btnLogOut
            
            this.btnLogOut.AllowAnimations = true;
            this.btnLogOut.AllowMouseEffects = true;
            this.btnLogOut.AllowToggling = false;
            this.btnLogOut.AnimationSpeed = 200;
            this.btnLogOut.AutoGenerateColors = false;
            this.btnLogOut.AutoRoundBorders = false;
            this.btnLogOut.AutoSizeLeftIcon = true;
            this.btnLogOut.AutoSizeRightIcon = true;
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnLogOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.BackgroundImage")));
            this.btnLogOut.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogOut.ButtonText = "Log out";
            this.btnLogOut.ButtonTextMarginLeft = 0;
            this.btnLogOut.ColorContrastOnClick = 45;
            this.btnLogOut.ColorContrastOnHover = 45;
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnLogOut.CustomizableEdges = borderEdges2;
            this.btnLogOut.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogOut.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLogOut.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnLogOut.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnLogOut.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.IconLeft = null;
            this.btnLogOut.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnLogOut.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnLogOut.IconMarginLeft = 11;
            this.btnLogOut.IconPadding = 10;
            this.btnLogOut.IconRight = null;
            this.btnLogOut.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogOut.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnLogOut.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnLogOut.IconSize = 25;
            this.btnLogOut.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnLogOut.IdleBorderRadius = 0;
            this.btnLogOut.IdleBorderThickness = 0;
            this.btnLogOut.IdleFillColor = System.Drawing.Color.Empty;
            this.btnLogOut.IdleIconLeftImage = null;
            this.btnLogOut.IdleIconRightImage = null;
            this.btnLogOut.IndicateFocus = false;
            this.btnLogOut.Location = new System.Drawing.Point(13, 236);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLogOut.OnDisabledState.BorderRadius = 1;
            this.btnLogOut.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogOut.OnDisabledState.BorderThickness = 1;
            this.btnLogOut.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLogOut.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLogOut.OnDisabledState.IconLeftImage = null;
            this.btnLogOut.OnDisabledState.IconRightImage = null;
            this.btnLogOut.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnLogOut.onHoverState.BorderRadius = 1;
            this.btnLogOut.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogOut.onHoverState.BorderThickness = 1;
            this.btnLogOut.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnLogOut.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.onHoverState.IconLeftImage = null;
            this.btnLogOut.onHoverState.IconRightImage = null;
            this.btnLogOut.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnLogOut.OnIdleState.BorderRadius = 1;
            this.btnLogOut.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogOut.OnIdleState.BorderThickness = 1;
            this.btnLogOut.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnLogOut.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.OnIdleState.IconLeftImage = null;
            this.btnLogOut.OnIdleState.IconRightImage = null;
            this.btnLogOut.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnLogOut.OnPressedState.BorderRadius = 1;
            this.btnLogOut.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogOut.OnPressedState.BorderThickness = 1;
            this.btnLogOut.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnLogOut.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.OnPressedState.IconLeftImage = null;
            this.btnLogOut.OnPressedState.IconRightImage = null;
            this.btnLogOut.Size = new System.Drawing.Size(240, 55);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogOut.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogOut.TextMarginLeft = 0;
            this.btnLogOut.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnLogOut.UseDefaultRadiusAndThickness = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
          
            // btnAddMovie
           
            this.btnAddMovie.AllowAnimations = true;
            this.btnAddMovie.AllowMouseEffects = true;
            this.btnAddMovie.AllowToggling = false;
            this.btnAddMovie.AnimationSpeed = 200;
            this.btnAddMovie.AutoGenerateColors = false;
            this.btnAddMovie.AutoRoundBorders = false;
            this.btnAddMovie.AutoSizeLeftIcon = true;
            this.btnAddMovie.AutoSizeRightIcon = true;
            this.btnAddMovie.BackColor = System.Drawing.Color.Transparent;
            this.btnAddMovie.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnAddMovie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddMovie.BackgroundImage")));
            this.btnAddMovie.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddMovie.ButtonText = "ADD NEW MOVIE";
            this.btnAddMovie.ButtonTextMarginLeft = 0;
            this.btnAddMovie.ColorContrastOnClick = 45;
            this.btnAddMovie.ColorContrastOnHover = 45;
            this.btnAddMovie.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnAddMovie.CustomizableEdges = borderEdges3;
            this.btnAddMovie.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddMovie.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddMovie.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnAddMovie.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnAddMovie.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAddMovie.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddMovie.ForeColor = System.Drawing.Color.White;
            this.btnAddMovie.IconLeft = null;
            this.btnAddMovie.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMovie.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddMovie.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAddMovie.IconMarginLeft = 11;
            this.btnAddMovie.IconPadding = 10;
            this.btnAddMovie.IconRight = null;
            this.btnAddMovie.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddMovie.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddMovie.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAddMovie.IconSize = 25;
            this.btnAddMovie.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnAddMovie.IdleBorderRadius = 0;
            this.btnAddMovie.IdleBorderThickness = 0;
            this.btnAddMovie.IdleFillColor = System.Drawing.Color.Empty;
            this.btnAddMovie.IdleIconLeftImage = null;
            this.btnAddMovie.IdleIconRightImage = null;
            this.btnAddMovie.IndicateFocus = false;
            this.btnAddMovie.Location = new System.Drawing.Point(13, 62);
            this.btnAddMovie.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddMovie.OnDisabledState.BorderRadius = 1;
            this.btnAddMovie.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddMovie.OnDisabledState.BorderThickness = 1;
            this.btnAddMovie.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddMovie.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddMovie.OnDisabledState.IconLeftImage = null;
            this.btnAddMovie.OnDisabledState.IconRightImage = null;
            this.btnAddMovie.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnAddMovie.onHoverState.BorderRadius = 1;
            this.btnAddMovie.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddMovie.onHoverState.BorderThickness = 1;
            this.btnAddMovie.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnAddMovie.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddMovie.onHoverState.IconLeftImage = null;
            this.btnAddMovie.onHoverState.IconRightImage = null;
            this.btnAddMovie.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAddMovie.OnIdleState.BorderRadius = 1;
            this.btnAddMovie.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddMovie.OnIdleState.BorderThickness = 1;
            this.btnAddMovie.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnAddMovie.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAddMovie.OnIdleState.IconLeftImage = null;
            this.btnAddMovie.OnIdleState.IconRightImage = null;
            this.btnAddMovie.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAddMovie.OnPressedState.BorderRadius = 1;
            this.btnAddMovie.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddMovie.OnPressedState.BorderThickness = 1;
            this.btnAddMovie.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAddMovie.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAddMovie.OnPressedState.IconLeftImage = null;
            this.btnAddMovie.OnPressedState.IconRightImage = null;
            this.btnAddMovie.Size = new System.Drawing.Size(240, 49);
            this.btnAddMovie.TabIndex = 1;
            this.btnAddMovie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddMovie.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddMovie.TextMarginLeft = 0;
            this.btnAddMovie.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAddMovie.UseDefaultRadiusAndThickness = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
         
            // MainForm
           
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1333, 862);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Film Hub";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

       
        
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelContent;
        private Bunifu.UI.WinForms.BunifuTextBox txtSearch;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddMovie;
        private System.Windows.Forms.ListBox lbCategories;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMovies;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnLogOut;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnStatistics;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnStatistic;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
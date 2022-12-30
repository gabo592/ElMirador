namespace ElMirador.Presentacion.Principal
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.PbLogo = new System.Windows.Forms.PictureBox();
            this.TbPnlDatos = new System.Windows.Forms.TableLayoutPanel();
            this.TxtNombre = new Bunifu.UI.WinForms.BunifuTextBox();
            this.TxtClave = new Bunifu.UI.WinForms.BunifuTextBox();
            this.TblPnlBotones = new System.Windows.Forms.TableLayoutPanel();
            this.BtnIniciarSesion = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).BeginInit();
            this.TbPnlDatos.SuspendLayout();
            this.TblPnlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(0, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(466, 43);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "¡Bienvenido de vuelta!";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PbLogo
            // 
            this.PbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PbLogo.Image = global::ElMirador.Properties.Resources.Logo_El_Mirador;
            this.PbLogo.Location = new System.Drawing.Point(0, 43);
            this.PbLogo.Name = "PbLogo";
            this.PbLogo.Size = new System.Drawing.Size(466, 135);
            this.PbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbLogo.TabIndex = 1;
            this.PbLogo.TabStop = false;
            // 
            // TbPnlDatos
            // 
            this.TbPnlDatos.ColumnCount = 3;
            this.TbPnlDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.TbPnlDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94F));
            this.TbPnlDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.TbPnlDatos.Controls.Add(this.TxtNombre, 1, 0);
            this.TbPnlDatos.Controls.Add(this.TxtClave, 1, 1);
            this.TbPnlDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.TbPnlDatos.Location = new System.Drawing.Point(0, 178);
            this.TbPnlDatos.Name = "TbPnlDatos";
            this.TbPnlDatos.RowCount = 2;
            this.TbPnlDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TbPnlDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TbPnlDatos.Size = new System.Drawing.Size(466, 100);
            this.TbPnlDatos.TabIndex = 2;
            // 
            // TxtNombre
            // 
            this.TxtNombre.AcceptsReturn = false;
            this.TxtNombre.AcceptsTab = false;
            this.TxtNombre.AnimationSpeed = 200;
            this.TxtNombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtNombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtNombre.AutoSizeHeight = true;
            this.TxtNombre.BackColor = System.Drawing.Color.Transparent;
            this.TxtNombre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TxtNombre.BackgroundImage")));
            this.TxtNombre.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(191)))), ((int)(((byte)(63)))));
            this.TxtNombre.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.TxtNombre.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(191)))), ((int)(((byte)(63)))));
            this.TxtNombre.BorderColorIdle = System.Drawing.Color.Silver;
            this.TxtNombre.BorderRadius = 17;
            this.TxtNombre.BorderThickness = 1;
            this.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNombre.DefaultFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.DefaultText = "";
            this.TxtNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtNombre.FillColor = System.Drawing.Color.White;
            this.TxtNombre.ForeColor = System.Drawing.Color.Silver;
            this.TxtNombre.HideSelection = true;
            this.TxtNombre.IconLeft = global::ElMirador.Properties.Resources.user;
            this.TxtNombre.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNombre.IconPadding = 12;
            this.TxtNombre.IconRight = null;
            this.TxtNombre.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNombre.Lines = new string[0];
            this.TxtNombre.Location = new System.Drawing.Point(16, 3);
            this.TxtNombre.MaxLength = 32767;
            this.TxtNombre.MinimumSize = new System.Drawing.Size(1, 1);
            this.TxtNombre.Modified = false;
            this.TxtNombre.Multiline = false;
            this.TxtNombre.Name = "TxtNombre";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(191)))), ((int)(((byte)(63)))));
            stateProperties1.FillColor = System.Drawing.Color.White;
            stateProperties1.ForeColor = System.Drawing.Color.Black;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Black;
            this.TxtNombre.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TxtNombre.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(191)))), ((int)(((byte)(63)))));
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(191)))), ((int)(((byte)(63)))));
            stateProperties3.ForeColor = System.Drawing.Color.White;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.White;
            this.TxtNombre.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Silver;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.TxtNombre.OnIdleState = stateProperties4;
            this.TxtNombre.Padding = new System.Windows.Forms.Padding(3);
            this.TxtNombre.PasswordChar = '\0';
            this.TxtNombre.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.TxtNombre.PlaceholderText = "Nombre de Usuario";
            this.TxtNombre.ReadOnly = false;
            this.TxtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtNombre.SelectedText = "";
            this.TxtNombre.SelectionLength = 0;
            this.TxtNombre.SelectionStart = 0;
            this.TxtNombre.ShortcutsEnabled = true;
            this.TxtNombre.Size = new System.Drawing.Size(432, 44);
            this.TxtNombre.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.TxtNombre.TabIndex = 0;
            this.TxtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtNombre.TextMarginBottom = 0;
            this.TxtNombre.TextMarginLeft = 3;
            this.TxtNombre.TextMarginTop = 1;
            this.TxtNombre.TextPlaceholder = "Nombre de Usuario";
            this.TxtNombre.UseSystemPasswordChar = false;
            this.TxtNombre.WordWrap = true;
            // 
            // TxtClave
            // 
            this.TxtClave.AcceptsReturn = false;
            this.TxtClave.AcceptsTab = false;
            this.TxtClave.AnimationSpeed = 200;
            this.TxtClave.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtClave.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtClave.AutoSizeHeight = true;
            this.TxtClave.BackColor = System.Drawing.Color.Transparent;
            this.TxtClave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TxtClave.BackgroundImage")));
            this.TxtClave.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(191)))), ((int)(((byte)(63)))));
            this.TxtClave.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.TxtClave.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(191)))), ((int)(((byte)(63)))));
            this.TxtClave.BorderColorIdle = System.Drawing.Color.Silver;
            this.TxtClave.BorderRadius = 17;
            this.TxtClave.BorderThickness = 1;
            this.TxtClave.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtClave.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtClave.DefaultFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtClave.DefaultText = "";
            this.TxtClave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtClave.FillColor = System.Drawing.Color.White;
            this.TxtClave.ForeColor = System.Drawing.Color.Silver;
            this.TxtClave.HideSelection = true;
            this.TxtClave.IconLeft = global::ElMirador.Properties.Resources._lock;
            this.TxtClave.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtClave.IconPadding = 12;
            this.TxtClave.IconRight = null;
            this.TxtClave.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtClave.Lines = new string[0];
            this.TxtClave.Location = new System.Drawing.Point(16, 53);
            this.TxtClave.MaxLength = 32767;
            this.TxtClave.MinimumSize = new System.Drawing.Size(1, 1);
            this.TxtClave.Modified = false;
            this.TxtClave.Multiline = false;
            this.TxtClave.Name = "TxtClave";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(191)))), ((int)(((byte)(63)))));
            stateProperties5.FillColor = System.Drawing.Color.White;
            stateProperties5.ForeColor = System.Drawing.Color.Black;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Black;
            this.TxtClave.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TxtClave.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(191)))), ((int)(((byte)(63)))));
            stateProperties7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(191)))), ((int)(((byte)(63)))));
            stateProperties7.ForeColor = System.Drawing.Color.White;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.White;
            this.TxtClave.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Silver;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.TxtClave.OnIdleState = stateProperties8;
            this.TxtClave.Padding = new System.Windows.Forms.Padding(3);
            this.TxtClave.PasswordChar = '●';
            this.TxtClave.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.TxtClave.PlaceholderText = "Contraseña";
            this.TxtClave.ReadOnly = false;
            this.TxtClave.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtClave.SelectedText = "";
            this.TxtClave.SelectionLength = 0;
            this.TxtClave.SelectionStart = 0;
            this.TxtClave.ShortcutsEnabled = true;
            this.TxtClave.Size = new System.Drawing.Size(432, 44);
            this.TxtClave.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.TxtClave.TabIndex = 1;
            this.TxtClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtClave.TextMarginBottom = 0;
            this.TxtClave.TextMarginLeft = 3;
            this.TxtClave.TextMarginTop = 1;
            this.TxtClave.TextPlaceholder = "Contraseña";
            this.TxtClave.UseSystemPasswordChar = true;
            this.TxtClave.WordWrap = true;
            // 
            // TblPnlBotones
            // 
            this.TblPnlBotones.ColumnCount = 3;
            this.TblPnlBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.TblPnlBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94F));
            this.TblPnlBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.TblPnlBotones.Controls.Add(this.BtnIniciarSesion, 1, 0);
            this.TblPnlBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.TblPnlBotones.Location = new System.Drawing.Point(0, 278);
            this.TblPnlBotones.Name = "TblPnlBotones";
            this.TblPnlBotones.RowCount = 1;
            this.TblPnlBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblPnlBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblPnlBotones.Size = new System.Drawing.Size(466, 53);
            this.TblPnlBotones.TabIndex = 3;
            // 
            // BtnIniciarSesion
            // 
            this.BtnIniciarSesion.AllowAnimations = true;
            this.BtnIniciarSesion.AllowMouseEffects = true;
            this.BtnIniciarSesion.AllowToggling = false;
            this.BtnIniciarSesion.AnimationSpeed = 200;
            this.BtnIniciarSesion.AutoGenerateColors = false;
            this.BtnIniciarSesion.AutoRoundBorders = false;
            this.BtnIniciarSesion.AutoSizeLeftIcon = true;
            this.BtnIniciarSesion.AutoSizeRightIcon = true;
            this.BtnIniciarSesion.BackColor = System.Drawing.Color.Transparent;
            this.BtnIniciarSesion.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.BtnIniciarSesion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnIniciarSesion.BackgroundImage")));
            this.BtnIniciarSesion.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnIniciarSesion.ButtonText = "Iniciar Sesión";
            this.BtnIniciarSesion.ButtonTextMarginLeft = 0;
            this.BtnIniciarSesion.ColorContrastOnClick = 45;
            this.BtnIniciarSesion.ColorContrastOnHover = 45;
            this.BtnIniciarSesion.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.BtnIniciarSesion.CustomizableEdges = borderEdges1;
            this.BtnIniciarSesion.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnIniciarSesion.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnIniciarSesion.DisabledFillColor = System.Drawing.Color.Empty;
            this.BtnIniciarSesion.DisabledForecolor = System.Drawing.Color.Empty;
            this.BtnIniciarSesion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnIniciarSesion.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BtnIniciarSesion.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.BtnIniciarSesion.IconLeft = null;
            this.BtnIniciarSesion.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnIniciarSesion.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BtnIniciarSesion.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.BtnIniciarSesion.IconMarginLeft = 11;
            this.BtnIniciarSesion.IconPadding = 10;
            this.BtnIniciarSesion.IconRight = null;
            this.BtnIniciarSesion.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnIniciarSesion.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BtnIniciarSesion.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BtnIniciarSesion.IconSize = 25;
            this.BtnIniciarSesion.IdleBorderColor = System.Drawing.Color.Empty;
            this.BtnIniciarSesion.IdleBorderRadius = 0;
            this.BtnIniciarSesion.IdleBorderThickness = 0;
            this.BtnIniciarSesion.IdleFillColor = System.Drawing.Color.Empty;
            this.BtnIniciarSesion.IdleIconLeftImage = null;
            this.BtnIniciarSesion.IdleIconRightImage = null;
            this.BtnIniciarSesion.IndicateFocus = false;
            this.BtnIniciarSesion.Location = new System.Drawing.Point(16, 3);
            this.BtnIniciarSesion.Name = "BtnIniciarSesion";
            this.BtnIniciarSesion.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnIniciarSesion.OnDisabledState.BorderRadius = 17;
            this.BtnIniciarSesion.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnIniciarSesion.OnDisabledState.BorderThickness = 1;
            this.BtnIniciarSesion.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnIniciarSesion.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnIniciarSesion.OnDisabledState.IconLeftImage = null;
            this.BtnIniciarSesion.OnDisabledState.IconRightImage = null;
            this.BtnIniciarSesion.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(199)))), ((int)(((byte)(242)))));
            this.BtnIniciarSesion.onHoverState.BorderRadius = 17;
            this.BtnIniciarSesion.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnIniciarSesion.onHoverState.BorderThickness = 1;
            this.BtnIniciarSesion.onHoverState.FillColor = System.Drawing.Color.White;
            this.BtnIniciarSesion.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.BtnIniciarSesion.onHoverState.IconLeftImage = null;
            this.BtnIniciarSesion.onHoverState.IconRightImage = null;
            this.BtnIniciarSesion.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(199)))), ((int)(((byte)(242)))));
            this.BtnIniciarSesion.OnIdleState.BorderRadius = 17;
            this.BtnIniciarSesion.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnIniciarSesion.OnIdleState.BorderThickness = 1;
            this.BtnIniciarSesion.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(199)))), ((int)(((byte)(242)))));
            this.BtnIniciarSesion.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.BtnIniciarSesion.OnIdleState.IconLeftImage = null;
            this.BtnIniciarSesion.OnIdleState.IconRightImage = null;
            this.BtnIniciarSesion.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(199)))), ((int)(((byte)(242)))));
            this.BtnIniciarSesion.OnPressedState.BorderRadius = 17;
            this.BtnIniciarSesion.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnIniciarSesion.OnPressedState.BorderThickness = 1;
            this.BtnIniciarSesion.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(199)))), ((int)(((byte)(242)))));
            this.BtnIniciarSesion.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BtnIniciarSesion.OnPressedState.IconLeftImage = null;
            this.BtnIniciarSesion.OnPressedState.IconRightImage = null;
            this.BtnIniciarSesion.Size = new System.Drawing.Size(432, 47);
            this.BtnIniciarSesion.TabIndex = 0;
            this.BtnIniciarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnIniciarSesion.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnIniciarSesion.TextMarginLeft = 0;
            this.BtnIniciarSesion.TextPadding = new System.Windows.Forms.Padding(0);
            this.BtnIniciarSesion.UseDefaultRadiusAndThickness = true;
            this.BtnIniciarSesion.Click += new System.EventHandler(this.BtnIniciarSesion_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(466, 361);
            this.Controls.Add(this.TblPnlBotones);
            this.Controls.Add(this.TbPnlDatos);
            this.Controls.Add(this.PbLogo);
            this.Controls.Add(this.LblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).EndInit();
            this.TbPnlDatos.ResumeLayout(false);
            this.TblPnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.PictureBox PbLogo;
        private System.Windows.Forms.TableLayoutPanel TbPnlDatos;
        private Bunifu.UI.WinForms.BunifuTextBox TxtNombre;
        private Bunifu.UI.WinForms.BunifuTextBox TxtClave;
        private System.Windows.Forms.TableLayoutPanel TblPnlBotones;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtnIniciarSesion;
    }
}
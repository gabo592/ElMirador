namespace ElMirador.Presentacion.Inventario
{
    partial class FrmEditorProducto
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
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditorProducto));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.PnlPrincipal = new System.Windows.Forms.Panel();
            this.TblPnlIdentificacion = new System.Windows.Forms.TableLayoutPanel();
            this.LblFoto = new System.Windows.Forms.Label();
            this.PbFoto = new System.Windows.Forms.PictureBox();
            this.LblIdentificacion = new System.Windows.Forms.Label();
            this.TblPnlMedicion = new System.Windows.Forms.TableLayoutPanel();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.NumPrecio = new System.Windows.Forms.NumericUpDown();
            this.NumCantidad = new System.Windows.Forms.NumericUpDown();
            this.LblMedicion = new System.Windows.Forms.Label();
            this.TblPnlDatos = new System.Windows.Forms.TableLayoutPanel();
            this.TxtDescripcion = new Bunifu.UI.WinForms.BunifuTextBox();
            this.LblDatos = new System.Windows.Forms.Label();
            this.LblFinalizado = new System.Windows.Forms.Label();
            this.FlwPnlBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnGuardar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.BtnLimpiar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.BtnCancelar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.PnlPrincipal.SuspendLayout();
            this.TblPnlIdentificacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbFoto)).BeginInit();
            this.TblPnlMedicion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCantidad)).BeginInit();
            this.TblPnlDatos.SuspendLayout();
            this.FlwPnlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlPrincipal
            // 
            this.PnlPrincipal.AutoScroll = true;
            this.PnlPrincipal.Controls.Add(this.FlwPnlBotones);
            this.PnlPrincipal.Controls.Add(this.LblFinalizado);
            this.PnlPrincipal.Controls.Add(this.TblPnlIdentificacion);
            this.PnlPrincipal.Controls.Add(this.LblIdentificacion);
            this.PnlPrincipal.Controls.Add(this.TblPnlMedicion);
            this.PnlPrincipal.Controls.Add(this.LblMedicion);
            this.PnlPrincipal.Controls.Add(this.TblPnlDatos);
            this.PnlPrincipal.Controls.Add(this.LblDatos);
            this.PnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PnlPrincipal.Name = "PnlPrincipal";
            this.PnlPrincipal.Size = new System.Drawing.Size(800, 450);
            this.PnlPrincipal.TabIndex = 0;
            // 
            // TblPnlIdentificacion
            // 
            this.TblPnlIdentificacion.ColumnCount = 4;
            this.TblPnlIdentificacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.TblPnlIdentificacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47F));
            this.TblPnlIdentificacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47F));
            this.TblPnlIdentificacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.TblPnlIdentificacion.Controls.Add(this.LblFoto, 1, 0);
            this.TblPnlIdentificacion.Controls.Add(this.PbFoto, 2, 0);
            this.TblPnlIdentificacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.TblPnlIdentificacion.Location = new System.Drawing.Point(0, 282);
            this.TblPnlIdentificacion.Name = "TblPnlIdentificacion";
            this.TblPnlIdentificacion.RowCount = 1;
            this.TblPnlIdentificacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblPnlIdentificacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblPnlIdentificacion.Size = new System.Drawing.Size(783, 85);
            this.TblPnlIdentificacion.TabIndex = 5;
            // 
            // LblFoto
            // 
            this.LblFoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFoto.Location = new System.Drawing.Point(26, 0);
            this.LblFoto.Name = "LblFoto";
            this.LblFoto.Size = new System.Drawing.Size(362, 85);
            this.LblFoto.TabIndex = 0;
            this.LblFoto.Text = "Foto:";
            this.LblFoto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PbFoto
            // 
            this.PbFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbFoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbFoto.Image = global::ElMirador.Properties.Resources.burger;
            this.PbFoto.Location = new System.Drawing.Point(394, 3);
            this.PbFoto.Name = "PbFoto";
            this.PbFoto.Size = new System.Drawing.Size(362, 79);
            this.PbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbFoto.TabIndex = 1;
            this.PbFoto.TabStop = false;
            this.PbFoto.Click += new System.EventHandler(this.PbFoto_Click);
            // 
            // LblIdentificacion
            // 
            this.LblIdentificacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdentificacion.Location = new System.Drawing.Point(0, 239);
            this.LblIdentificacion.Name = "LblIdentificacion";
            this.LblIdentificacion.Size = new System.Drawing.Size(783, 43);
            this.LblIdentificacion.TabIndex = 4;
            this.LblIdentificacion.Text = "Ayúdanos a identificarlo";
            this.LblIdentificacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TblPnlMedicion
            // 
            this.TblPnlMedicion.ColumnCount = 4;
            this.TblPnlMedicion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.TblPnlMedicion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47F));
            this.TblPnlMedicion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47F));
            this.TblPnlMedicion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.TblPnlMedicion.Controls.Add(this.LblPrecio, 1, 0);
            this.TblPnlMedicion.Controls.Add(this.LblCantidad, 2, 0);
            this.TblPnlMedicion.Controls.Add(this.NumPrecio, 1, 1);
            this.TblPnlMedicion.Controls.Add(this.NumCantidad, 2, 1);
            this.TblPnlMedicion.Dock = System.Windows.Forms.DockStyle.Top;
            this.TblPnlMedicion.Location = new System.Drawing.Point(0, 160);
            this.TblPnlMedicion.Name = "TblPnlMedicion";
            this.TblPnlMedicion.RowCount = 2;
            this.TblPnlMedicion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.49367F));
            this.TblPnlMedicion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.50633F));
            this.TblPnlMedicion.Size = new System.Drawing.Size(783, 79);
            this.TblPnlMedicion.TabIndex = 3;
            // 
            // LblPrecio
            // 
            this.LblPrecio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecio.Location = new System.Drawing.Point(26, 0);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(362, 47);
            this.LblPrecio.TabIndex = 0;
            this.LblPrecio.Text = "Precio C$";
            this.LblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblCantidad
            // 
            this.LblCantidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidad.Location = new System.Drawing.Point(394, 0);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(362, 47);
            this.LblCantidad.TabIndex = 1;
            this.LblCantidad.Text = "Cantidad";
            this.LblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumPrecio
            // 
            this.NumPrecio.DecimalPlaces = 2;
            this.NumPrecio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumPrecio.Location = new System.Drawing.Point(26, 50);
            this.NumPrecio.Maximum = new decimal(new int[] {
            -1981284352,
            -1966660860,
            0,
            0});
            this.NumPrecio.Name = "NumPrecio";
            this.NumPrecio.Size = new System.Drawing.Size(362, 22);
            this.NumPrecio.TabIndex = 2;
            this.NumPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NumCantidad
            // 
            this.NumCantidad.DecimalPlaces = 2;
            this.NumCantidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumCantidad.Location = new System.Drawing.Point(394, 50);
            this.NumCantidad.Maximum = new decimal(new int[] {
            -1981284352,
            -1966660860,
            0,
            0});
            this.NumCantidad.Name = "NumCantidad";
            this.NumCantidad.Size = new System.Drawing.Size(362, 22);
            this.NumCantidad.TabIndex = 3;
            this.NumCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LblMedicion
            // 
            this.LblMedicion.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblMedicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMedicion.Location = new System.Drawing.Point(0, 117);
            this.LblMedicion.Name = "LblMedicion";
            this.LblMedicion.Size = new System.Drawing.Size(783, 43);
            this.LblMedicion.TabIndex = 2;
            this.LblMedicion.Text = "Sección cuantitativa";
            this.LblMedicion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TblPnlDatos
            // 
            this.TblPnlDatos.ColumnCount = 3;
            this.TblPnlDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.TblPnlDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94F));
            this.TblPnlDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.TblPnlDatos.Controls.Add(this.TxtDescripcion, 1, 0);
            this.TblPnlDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.TblPnlDatos.Location = new System.Drawing.Point(0, 43);
            this.TblPnlDatos.Name = "TblPnlDatos";
            this.TblPnlDatos.RowCount = 1;
            this.TblPnlDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblPnlDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblPnlDatos.Size = new System.Drawing.Size(783, 74);
            this.TblPnlDatos.TabIndex = 1;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.AcceptsReturn = false;
            this.TxtDescripcion.AcceptsTab = false;
            this.TxtDescripcion.AnimationSpeed = 200;
            this.TxtDescripcion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtDescripcion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtDescripcion.AutoSizeHeight = true;
            this.TxtDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.TxtDescripcion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TxtDescripcion.BackgroundImage")));
            this.TxtDescripcion.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(199)))), ((int)(((byte)(242)))));
            this.TxtDescripcion.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.TxtDescripcion.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(199)))), ((int)(((byte)(242)))));
            this.TxtDescripcion.BorderColorIdle = System.Drawing.Color.Silver;
            this.TxtDescripcion.BorderRadius = 10;
            this.TxtDescripcion.BorderThickness = 1;
            this.TxtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtDescripcion.DefaultFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescripcion.DefaultText = "";
            this.TxtDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtDescripcion.FillColor = System.Drawing.Color.White;
            this.TxtDescripcion.ForeColor = System.Drawing.Color.Black;
            this.TxtDescripcion.HideSelection = true;
            this.TxtDescripcion.IconLeft = null;
            this.TxtDescripcion.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtDescripcion.IconPadding = 10;
            this.TxtDescripcion.IconRight = null;
            this.TxtDescripcion.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtDescripcion.Lines = new string[0];
            this.TxtDescripcion.Location = new System.Drawing.Point(26, 3);
            this.TxtDescripcion.MaxLength = 32767;
            this.TxtDescripcion.MinimumSize = new System.Drawing.Size(1, 1);
            this.TxtDescripcion.Modified = false;
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(199)))), ((int)(((byte)(242)))));
            stateProperties1.FillColor = System.Drawing.Color.White;
            stateProperties1.ForeColor = System.Drawing.Color.Black;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Black;
            this.TxtDescripcion.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TxtDescripcion.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(199)))), ((int)(((byte)(242)))));
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(199)))), ((int)(((byte)(242)))));
            stateProperties3.ForeColor = System.Drawing.Color.Black;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Black;
            this.TxtDescripcion.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Black;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.TxtDescripcion.OnIdleState = stateProperties4;
            this.TxtDescripcion.Padding = new System.Windows.Forms.Padding(3);
            this.TxtDescripcion.PasswordChar = '\0';
            this.TxtDescripcion.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.TxtDescripcion.PlaceholderText = "Descripción";
            this.TxtDescripcion.ReadOnly = false;
            this.TxtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtDescripcion.SelectedText = "";
            this.TxtDescripcion.SelectionLength = 0;
            this.TxtDescripcion.SelectionStart = 0;
            this.TxtDescripcion.ShortcutsEnabled = true;
            this.TxtDescripcion.Size = new System.Drawing.Size(730, 68);
            this.TxtDescripcion.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.TxtDescripcion.TabIndex = 0;
            this.TxtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtDescripcion.TextMarginBottom = 0;
            this.TxtDescripcion.TextMarginLeft = 3;
            this.TxtDescripcion.TextMarginTop = 1;
            this.TxtDescripcion.TextPlaceholder = "Descripción";
            this.TxtDescripcion.UseSystemPasswordChar = false;
            this.TxtDescripcion.WordWrap = true;
            // 
            // LblDatos
            // 
            this.LblDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDatos.Location = new System.Drawing.Point(0, 0);
            this.LblDatos.Name = "LblDatos";
            this.LblDatos.Size = new System.Drawing.Size(783, 43);
            this.LblDatos.TabIndex = 0;
            this.LblDatos.Text = "Datos del Producto";
            this.LblDatos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblFinalizado
            // 
            this.LblFinalizado.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblFinalizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFinalizado.Location = new System.Drawing.Point(0, 367);
            this.LblFinalizado.Name = "LblFinalizado";
            this.LblFinalizado.Size = new System.Drawing.Size(783, 43);
            this.LblFinalizado.TabIndex = 6;
            this.LblFinalizado.Text = "¡Has finalizado!";
            this.LblFinalizado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FlwPnlBotones
            // 
            this.FlwPnlBotones.Controls.Add(this.BtnGuardar);
            this.FlwPnlBotones.Controls.Add(this.BtnLimpiar);
            this.FlwPnlBotones.Controls.Add(this.BtnCancelar);
            this.FlwPnlBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.FlwPnlBotones.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FlwPnlBotones.Location = new System.Drawing.Point(0, 410);
            this.FlwPnlBotones.Name = "FlwPnlBotones";
            this.FlwPnlBotones.Size = new System.Drawing.Size(783, 52);
            this.FlwPnlBotones.TabIndex = 7;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.AllowAnimations = true;
            this.BtnGuardar.AllowMouseEffects = true;
            this.BtnGuardar.AllowToggling = false;
            this.BtnGuardar.AnimationSpeed = 200;
            this.BtnGuardar.AutoGenerateColors = false;
            this.BtnGuardar.AutoRoundBorders = false;
            this.BtnGuardar.AutoSizeLeftIcon = true;
            this.BtnGuardar.AutoSizeRightIcon = true;
            this.BtnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.BtnGuardar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.BtnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.BackgroundImage")));
            this.BtnGuardar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnGuardar.ButtonText = "Guardar";
            this.BtnGuardar.ButtonTextMarginLeft = 0;
            this.BtnGuardar.ColorContrastOnClick = 45;
            this.BtnGuardar.ColorContrastOnHover = 45;
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.BtnGuardar.CustomizableEdges = borderEdges1;
            this.BtnGuardar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnGuardar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnGuardar.DisabledFillColor = System.Drawing.Color.Empty;
            this.BtnGuardar.DisabledForecolor = System.Drawing.Color.Empty;
            this.BtnGuardar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.IconLeft = null;
            this.BtnGuardar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BtnGuardar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.BtnGuardar.IconMarginLeft = 11;
            this.BtnGuardar.IconPadding = 10;
            this.BtnGuardar.IconRight = null;
            this.BtnGuardar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BtnGuardar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BtnGuardar.IconSize = 25;
            this.BtnGuardar.IdleBorderColor = System.Drawing.Color.Empty;
            this.BtnGuardar.IdleBorderRadius = 0;
            this.BtnGuardar.IdleBorderThickness = 0;
            this.BtnGuardar.IdleFillColor = System.Drawing.Color.Empty;
            this.BtnGuardar.IdleIconLeftImage = null;
            this.BtnGuardar.IdleIconRightImage = null;
            this.BtnGuardar.IndicateFocus = false;
            this.BtnGuardar.Location = new System.Drawing.Point(630, 3);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnGuardar.OnDisabledState.BorderRadius = 10;
            this.BtnGuardar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnGuardar.OnDisabledState.BorderThickness = 1;
            this.BtnGuardar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnGuardar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnGuardar.OnDisabledState.IconLeftImage = null;
            this.BtnGuardar.OnDisabledState.IconRightImage = null;
            this.BtnGuardar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(191)))), ((int)(((byte)(63)))));
            this.BtnGuardar.onHoverState.BorderRadius = 10;
            this.BtnGuardar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnGuardar.onHoverState.BorderThickness = 1;
            this.BtnGuardar.onHoverState.FillColor = System.Drawing.Color.White;
            this.BtnGuardar.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.BtnGuardar.onHoverState.IconLeftImage = null;
            this.BtnGuardar.onHoverState.IconRightImage = null;
            this.BtnGuardar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(191)))), ((int)(((byte)(63)))));
            this.BtnGuardar.OnIdleState.BorderRadius = 10;
            this.BtnGuardar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnGuardar.OnIdleState.BorderThickness = 1;
            this.BtnGuardar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(191)))), ((int)(((byte)(63)))));
            this.BtnGuardar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.OnIdleState.IconLeftImage = null;
            this.BtnGuardar.OnIdleState.IconRightImage = null;
            this.BtnGuardar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(191)))), ((int)(((byte)(63)))));
            this.BtnGuardar.OnPressedState.BorderRadius = 10;
            this.BtnGuardar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnGuardar.OnPressedState.BorderThickness = 1;
            this.BtnGuardar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(191)))), ((int)(((byte)(63)))));
            this.BtnGuardar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.OnPressedState.IconLeftImage = null;
            this.BtnGuardar.OnPressedState.IconRightImage = null;
            this.BtnGuardar.Size = new System.Drawing.Size(150, 39);
            this.BtnGuardar.TabIndex = 0;
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnGuardar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnGuardar.TextMarginLeft = 0;
            this.BtnGuardar.TextPadding = new System.Windows.Forms.Padding(0);
            this.BtnGuardar.UseDefaultRadiusAndThickness = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.AllowAnimations = true;
            this.BtnLimpiar.AllowMouseEffects = true;
            this.BtnLimpiar.AllowToggling = false;
            this.BtnLimpiar.AnimationSpeed = 200;
            this.BtnLimpiar.AutoGenerateColors = false;
            this.BtnLimpiar.AutoRoundBorders = false;
            this.BtnLimpiar.AutoSizeLeftIcon = true;
            this.BtnLimpiar.AutoSizeRightIcon = true;
            this.BtnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.BtnLimpiar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.BtnLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnLimpiar.BackgroundImage")));
            this.BtnLimpiar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnLimpiar.ButtonText = "Limpíar";
            this.BtnLimpiar.ButtonTextMarginLeft = 0;
            this.BtnLimpiar.ColorContrastOnClick = 45;
            this.BtnLimpiar.ColorContrastOnHover = 45;
            this.BtnLimpiar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.BtnLimpiar.CustomizableEdges = borderEdges2;
            this.BtnLimpiar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnLimpiar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnLimpiar.DisabledFillColor = System.Drawing.Color.Empty;
            this.BtnLimpiar.DisabledForecolor = System.Drawing.Color.Empty;
            this.BtnLimpiar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BtnLimpiar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.BtnLimpiar.IconLeft = null;
            this.BtnLimpiar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLimpiar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BtnLimpiar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.BtnLimpiar.IconMarginLeft = 11;
            this.BtnLimpiar.IconPadding = 10;
            this.BtnLimpiar.IconRight = null;
            this.BtnLimpiar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpiar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BtnLimpiar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BtnLimpiar.IconSize = 25;
            this.BtnLimpiar.IdleBorderColor = System.Drawing.Color.Empty;
            this.BtnLimpiar.IdleBorderRadius = 0;
            this.BtnLimpiar.IdleBorderThickness = 0;
            this.BtnLimpiar.IdleFillColor = System.Drawing.Color.Empty;
            this.BtnLimpiar.IdleIconLeftImage = null;
            this.BtnLimpiar.IdleIconRightImage = null;
            this.BtnLimpiar.IndicateFocus = false;
            this.BtnLimpiar.Location = new System.Drawing.Point(474, 3);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnLimpiar.OnDisabledState.BorderRadius = 10;
            this.BtnLimpiar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnLimpiar.OnDisabledState.BorderThickness = 1;
            this.BtnLimpiar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnLimpiar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnLimpiar.OnDisabledState.IconLeftImage = null;
            this.BtnLimpiar.OnDisabledState.IconRightImage = null;
            this.BtnLimpiar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(191)))), ((int)(((byte)(63)))));
            this.BtnLimpiar.onHoverState.BorderRadius = 10;
            this.BtnLimpiar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnLimpiar.onHoverState.BorderThickness = 1;
            this.BtnLimpiar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(191)))), ((int)(((byte)(63)))));
            this.BtnLimpiar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.onHoverState.IconLeftImage = null;
            this.BtnLimpiar.onHoverState.IconRightImage = null;
            this.BtnLimpiar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(191)))), ((int)(((byte)(63)))));
            this.BtnLimpiar.OnIdleState.BorderRadius = 10;
            this.BtnLimpiar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnLimpiar.OnIdleState.BorderThickness = 1;
            this.BtnLimpiar.OnIdleState.FillColor = System.Drawing.Color.White;
            this.BtnLimpiar.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.BtnLimpiar.OnIdleState.IconLeftImage = null;
            this.BtnLimpiar.OnIdleState.IconRightImage = null;
            this.BtnLimpiar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(191)))), ((int)(((byte)(63)))));
            this.BtnLimpiar.OnPressedState.BorderRadius = 10;
            this.BtnLimpiar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnLimpiar.OnPressedState.BorderThickness = 1;
            this.BtnLimpiar.OnPressedState.FillColor = System.Drawing.Color.White;
            this.BtnLimpiar.OnPressedState.ForeColor = System.Drawing.Color.Black;
            this.BtnLimpiar.OnPressedState.IconLeftImage = null;
            this.BtnLimpiar.OnPressedState.IconRightImage = null;
            this.BtnLimpiar.Size = new System.Drawing.Size(150, 39);
            this.BtnLimpiar.TabIndex = 1;
            this.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnLimpiar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnLimpiar.TextMarginLeft = 0;
            this.BtnLimpiar.TextPadding = new System.Windows.Forms.Padding(0);
            this.BtnLimpiar.UseDefaultRadiusAndThickness = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.AllowAnimations = true;
            this.BtnCancelar.AllowMouseEffects = true;
            this.BtnCancelar.AllowToggling = false;
            this.BtnCancelar.AnimationSpeed = 200;
            this.BtnCancelar.AutoGenerateColors = false;
            this.BtnCancelar.AutoRoundBorders = false;
            this.BtnCancelar.AutoSizeLeftIcon = true;
            this.BtnCancelar.AutoSizeRightIcon = true;
            this.BtnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.BtnCancelar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.BtnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.BackgroundImage")));
            this.BtnCancelar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnCancelar.ButtonText = "Cancelar";
            this.BtnCancelar.ButtonTextMarginLeft = 0;
            this.BtnCancelar.ColorContrastOnClick = 45;
            this.BtnCancelar.ColorContrastOnHover = 45;
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.BtnCancelar.CustomizableEdges = borderEdges3;
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnCancelar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnCancelar.DisabledFillColor = System.Drawing.Color.Empty;
            this.BtnCancelar.DisabledForecolor = System.Drawing.Color.Empty;
            this.BtnCancelar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.Black;
            this.BtnCancelar.IconLeft = null;
            this.BtnCancelar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BtnCancelar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.BtnCancelar.IconMarginLeft = 11;
            this.BtnCancelar.IconPadding = 10;
            this.BtnCancelar.IconRight = null;
            this.BtnCancelar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BtnCancelar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BtnCancelar.IconSize = 25;
            this.BtnCancelar.IdleBorderColor = System.Drawing.Color.Empty;
            this.BtnCancelar.IdleBorderRadius = 0;
            this.BtnCancelar.IdleBorderThickness = 0;
            this.BtnCancelar.IdleFillColor = System.Drawing.Color.Empty;
            this.BtnCancelar.IdleIconLeftImage = null;
            this.BtnCancelar.IdleIconRightImage = null;
            this.BtnCancelar.IndicateFocus = false;
            this.BtnCancelar.Location = new System.Drawing.Point(318, 3);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnCancelar.OnDisabledState.BorderRadius = 10;
            this.BtnCancelar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnCancelar.OnDisabledState.BorderThickness = 1;
            this.BtnCancelar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnCancelar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnCancelar.OnDisabledState.IconLeftImage = null;
            this.BtnCancelar.OnDisabledState.IconRightImage = null;
            this.BtnCancelar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(191)))), ((int)(((byte)(63)))));
            this.BtnCancelar.onHoverState.BorderRadius = 10;
            this.BtnCancelar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnCancelar.onHoverState.BorderThickness = 1;
            this.BtnCancelar.onHoverState.FillColor = System.Drawing.Color.White;
            this.BtnCancelar.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.BtnCancelar.onHoverState.IconLeftImage = null;
            this.BtnCancelar.onHoverState.IconRightImage = null;
            this.BtnCancelar.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.BtnCancelar.OnIdleState.BorderRadius = 10;
            this.BtnCancelar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnCancelar.OnIdleState.BorderThickness = 1;
            this.BtnCancelar.OnIdleState.FillColor = System.Drawing.Color.White;
            this.BtnCancelar.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.BtnCancelar.OnIdleState.IconLeftImage = null;
            this.BtnCancelar.OnIdleState.IconRightImage = null;
            this.BtnCancelar.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.BtnCancelar.OnPressedState.BorderRadius = 10;
            this.BtnCancelar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnCancelar.OnPressedState.BorderThickness = 1;
            this.BtnCancelar.OnPressedState.FillColor = System.Drawing.Color.White;
            this.BtnCancelar.OnPressedState.ForeColor = System.Drawing.Color.Black;
            this.BtnCancelar.OnPressedState.IconLeftImage = null;
            this.BtnCancelar.OnPressedState.IconRightImage = null;
            this.BtnCancelar.Size = new System.Drawing.Size(150, 39);
            this.BtnCancelar.TabIndex = 2;
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnCancelar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnCancelar.TextMarginLeft = 0;
            this.BtnCancelar.TextPadding = new System.Windows.Forms.Padding(0);
            this.BtnCancelar.UseDefaultRadiusAndThickness = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmEditorProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PnlPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEditorProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor Producto";
            this.PnlPrincipal.ResumeLayout(false);
            this.TblPnlIdentificacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbFoto)).EndInit();
            this.TblPnlMedicion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCantidad)).EndInit();
            this.TblPnlDatos.ResumeLayout(false);
            this.FlwPnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlPrincipal;
        private System.Windows.Forms.Label LblDatos;
        private System.Windows.Forms.TableLayoutPanel TblPnlDatos;
        private Bunifu.UI.WinForms.BunifuTextBox TxtDescripcion;
        private System.Windows.Forms.Label LblMedicion;
        private System.Windows.Forms.TableLayoutPanel TblPnlMedicion;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.NumericUpDown NumPrecio;
        private System.Windows.Forms.NumericUpDown NumCantidad;
        private System.Windows.Forms.Label LblIdentificacion;
        private System.Windows.Forms.TableLayoutPanel TblPnlIdentificacion;
        private System.Windows.Forms.Label LblFoto;
        private System.Windows.Forms.PictureBox PbFoto;
        private System.Windows.Forms.Label LblFinalizado;
        private System.Windows.Forms.FlowLayoutPanel FlwPnlBotones;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtnGuardar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtnLimpiar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtnCancelar;
    }
}
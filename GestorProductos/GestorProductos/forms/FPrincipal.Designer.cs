using System.Windows.Forms;

namespace GestorProductos
{
    partial class FPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPrincipal));
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cbComparacion = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.importarcsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exportarcsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarpdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mArchivoSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarAyudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCSVExportar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.ttNuevo = new System.Windows.Forms.ToolTip(this.components);
            this.ttEditar = new System.Windows.Forms.ToolTip(this.components);
            this.ttEliminar = new System.Windows.Forms.ToolTip(this.components);
            this.ttFiltros = new System.Windows.Forms.ToolTip(this.components);
            this.ttCampoBuscar = new System.Windows.Forms.ToolTip(this.components);
            this.ttRefrescar = new System.Windows.Forms.ToolTip(this.components);
            this.ttBuscar = new System.Windows.Forms.ToolTip(this.components);
            this.ttLimpiar = new System.Windows.Forms.ToolTip(this.components);
            this.ttImprimir = new System.Windows.Forms.ToolTip(this.components);
            this.ttCSV = new System.Windows.Forms.ToolTip(this.components);
            this.btnCSVImportar = new System.Windows.Forms.Button();
            this.ttSalir = new System.Windows.Forms.ToolTip(this.components);
            this.lblCSV = new System.Windows.Forms.Label();
            this.lblPDF = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProductos.Location = new System.Drawing.Point(12, 27);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.RowTemplate.Height = 32;
            this.dgvProductos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(822, 472);
            this.dgvProductos.TabIndex = 0;
            this.dgvProductos.TabStop = false;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(12, 505);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(44, 44);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "➕";
            this.ttBuscar.SetToolTip(this.btnNuevo, "Crear un nuevo producto.");
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(112, 505);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(44, 44);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.Text = "❌";
            this.ttEliminar.SetToolTip(this.btnBorrar, "Eliminar producto/productos seleccionados. Puedes seleccionar varios productos.");
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(333, 505);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(44, 44);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "🔍";
            this.ttBuscar.SetToolTip(this.btnBuscar, "Busca productos según los filtros seleccionados.");
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBuscar.Location = new System.Drawing.Point(162, 529);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(115, 20);
            this.txtBuscar.TabIndex = 4;
            this.ttCampoBuscar.SetToolTip(this.txtBuscar, "Introduce aquí lo que quieras buscar.");
            // 
            // cbComparacion
            // 
            this.cbComparacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbComparacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbComparacion.FormattingEnabled = true;
            this.cbComparacion.Items.AddRange(new object[] {
            "Nombre",
            "Descripción",
            "Tipo"});
            this.cbComparacion.Location = new System.Drawing.Point(162, 505);
            this.cbComparacion.Name = "cbComparacion";
            this.cbComparacion.Size = new System.Drawing.Size(115, 21);
            this.cbComparacion.TabIndex = 3;
            this.ttFiltros.SetToolTip(this.cbComparacion, "Filtrar la búsqueda por desripción, nombre o tipo.");
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(283, 505);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(44, 44);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "🔄";
            this.ttRefrescar.SetToolTip(this.btnReset, "Reinicia los filtros y el campo de búsqueda.");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(750, 505);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(84, 44);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.ttSalir.SetToolTip(this.btnSalir, "Salir del programa.");
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(418, 505);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(44, 44);
            this.btnImprimir.TabIndex = 7;
            this.btnImprimir.Text = "🖨️";
            this.ttImprimir.SetToolTip(this.btnImprimir, "Imprimir datos de la tabla a un documento PDF.");
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(62, 505);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(44, 44);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "🖊";
            this.ttEditar.SetToolTip(this.btnEditar, "Editar el producto seleccionado. Selecciona sólo uno.");
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mArchivo,
            this.productoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(846, 25);
            this.menuStrip.TabIndex = 21;
            this.menuStrip.Text = "menuStrip1";
            // 
            // mArchivo
            // 
            this.mArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importarcsvToolStripMenuItem,
            this.toolStripSeparator2,
            this.exportarcsvToolStripMenuItem,
            this.exportarpdfToolStripMenuItem,
            this.toolStripSeparator1,
            this.mArchivoSalir,
            this.toolStripSeparator3});
            this.mArchivo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mArchivo.Name = "mArchivo";
            this.mArchivo.Size = new System.Drawing.Size(63, 21);
            this.mArchivo.Text = "Archivo";
            // 
            // importarcsvToolStripMenuItem
            // 
            this.importarcsvToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.importarcsvToolStripMenuItem.Name = "importarcsvToolStripMenuItem";
            this.importarcsvToolStripMenuItem.ShortcutKeyDisplayString = "F4";
            this.importarcsvToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.importarcsvToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.importarcsvToolStripMenuItem.Text = "🔽 Importar .csv";
            this.importarcsvToolStripMenuItem.Click += new System.EventHandler(this.btnCSVImportar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(193, 6);
            // 
            // exportarcsvToolStripMenuItem
            // 
            this.exportarcsvToolStripMenuItem.Name = "exportarcsvToolStripMenuItem";
            this.exportarcsvToolStripMenuItem.ShortcutKeyDisplayString = "F5";
            this.exportarcsvToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.exportarcsvToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.exportarcsvToolStripMenuItem.Text = "🔼 Exportar .csv";
            this.exportarcsvToolStripMenuItem.Click += new System.EventHandler(this.btnCSVExportar_Click);
            // 
            // exportarpdfToolStripMenuItem
            // 
            this.exportarpdfToolStripMenuItem.Name = "exportarpdfToolStripMenuItem";
            this.exportarpdfToolStripMenuItem.ShortcutKeyDisplayString = "F6";
            this.exportarpdfToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.exportarpdfToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.exportarpdfToolStripMenuItem.Text = "🖨️ Exportar .pdf";
            this.exportarpdfToolStripMenuItem.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(193, 6);
            // 
            // mArchivoSalir
            // 
            this.mArchivoSalir.Name = "mArchivoSalir";
            this.mArchivoSalir.ShortcutKeyDisplayString = "Ctrl+Q";
            this.mArchivoSalir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mArchivoSalir.Size = new System.Drawing.Size(196, 22);
            this.mArchivoSalir.Text = "Salir";
            this.mArchivoSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(193, 6);
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.productoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(73, 21);
            this.productoToolStripMenuItem.Text = "Producto";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.nuevoToolStripMenuItem.DoubleClickEnabled = true;
            this.nuevoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+N";
            this.nuevoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.nuevoToolStripMenuItem.Text = "➕ Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+M";
            this.modificarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.modificarToolStripMenuItem.Text = "🖊️ Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+X";
            this.eliminarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.eliminarToolStripMenuItem.Text = "❌ Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarAyudaToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // mostrarAyudaToolStripMenuItem
            // 
            this.mostrarAyudaToolStripMenuItem.Name = "mostrarAyudaToolStripMenuItem";
            this.mostrarAyudaToolStripMenuItem.ShortcutKeyDisplayString = "F11";
            this.mostrarAyudaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.mostrarAyudaToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.mostrarAyudaToolStripMenuItem.Text = "Mostrar ayuda";
            this.mostrarAyudaToolStripMenuItem.Click += new System.EventHandler(this.mostrarAyudaToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.ShortcutKeyDisplayString = "F12";
            this.acercaDeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // btnCSVExportar
            // 
            this.btnCSVExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCSVExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCSVExportar.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCSVExportar.Location = new System.Drawing.Point(524, 505);
            this.btnCSVExportar.Name = "btnCSVExportar";
            this.btnCSVExportar.Size = new System.Drawing.Size(44, 44);
            this.btnCSVExportar.TabIndex = 8;
            this.btnCSVExportar.Text = "⏏️";
            this.ttCSV.SetToolTip(this.btnCSVExportar, "Exportar a fichero CSV.");
            this.btnCSVExportar.UseVisualStyleBackColor = true;
            this.btnCSVExportar.Click += new System.EventHandler(this.btnCSVExportar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(700, 505);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(44, 44);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "🧹";
            this.ttLimpiar.SetToolTip(this.btnLimpiar, "Limpiar todos los datos de la tabla.");
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCSVImportar
            // 
            this.btnCSVImportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCSVImportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCSVImportar.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCSVImportar.Location = new System.Drawing.Point(574, 505);
            this.btnCSVImportar.Name = "btnCSVImportar";
            this.btnCSVImportar.Size = new System.Drawing.Size(44, 44);
            this.btnCSVImportar.TabIndex = 9;
            this.btnCSVImportar.Text = "🔽";
            this.ttCSV.SetToolTip(this.btnCSVImportar, "Importar desde fichero CSV.");
            this.btnCSVImportar.UseVisualStyleBackColor = true;
            this.btnCSVImportar.Click += new System.EventHandler(this.btnCSVImportar_Click);
            // 
            // lblCSV
            // 
            this.lblCSV.AutoSize = true;
            this.lblCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCSV.Location = new System.Drawing.Point(624, 518);
            this.lblCSV.Name = "lblCSV";
            this.lblCSV.Size = new System.Drawing.Size(40, 20);
            this.lblCSV.TabIndex = 25;
            this.lblCSV.Text = ".csv";
            // 
            // lblPDF
            // 
            this.lblPDF.AutoSize = true;
            this.lblPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPDF.Location = new System.Drawing.Point(468, 518);
            this.lblPDF.Name = "lblPDF";
            this.lblPDF.Size = new System.Drawing.Size(40, 20);
            this.lblPDF.TabIndex = 26;
            this.lblPDF.Text = ".pdf";
            // 
            // FPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(846, 561);
            this.Controls.Add(this.lblPDF);
            this.Controls.Add(this.lblCSV);
            this.Controls.Add(this.btnCSVImportar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCSVExportar);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cbComparacion);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvProductos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(720, 600);
            this.Name = "FPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de productos";
            this.Load += new System.EventHandler(this.FPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cbComparacion;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnEditar;
        private MenuStrip menuStrip;
        private ToolStripMenuItem mArchivo;
        private ToolStripMenuItem mArchivoSalir;
        private Button btnCSVExportar;
        private ToolStripMenuItem importarcsvToolStripMenuItem;
        private ToolStripMenuItem exportarcsvToolStripMenuItem;
        private ToolStripMenuItem exportarpdfToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem productoToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem modificarToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private Button btnLimpiar;
        private ToolTip ttBuscar;
        private ToolTip ttEliminar;
        private ToolTip ttNuevo;
        private ToolTip ttEditar;
        private ToolTip ttFiltros;
        private ToolTip ttCampoBuscar;
        private ToolTip ttRefrescar;
        private ToolTip ttLimpiar;
        private ToolTip ttImprimir;
        private ToolTip ttCSV;
        private ToolTip ttSalir;
        private Button btnCSVImportar;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem mostrarAyudaToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private Label lblCSV;
        private Label lblPDF;
    }
}


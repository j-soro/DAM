using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GestorProductos
{
    /// <summary>
    /// Clase Form principal de la aplicación, el cual gestiona un DataGridView en donde se visualizan los productos,
    /// además de los distintos botones para gestionar los elementos de ese DGV. También contiene menús para acceder
    /// a las funciones presentes en los botones tanto a través del menú como de accesos rápidos de teclado.
    /// 
    /// Campos/variables:
    ///     - model: instancia de ModeloProduct que contiene tanto el origen de los datos como funciones para gestionar los mismos de forma desacoplada de la vista.
    ///     - productos: List de Producto que representa los productos presentes en la vista en el momento actual.
    ///     - table: DataTable que srrve para gestionar los datos de forma desacoplada del DataGridView.
    ///     - selected: Product que representa el producto seleccionado actualmente en el DataGridView.
    /// </summary>
    public partial class FPrincipal : Form
    {
        // Modelo que gestiona los datos de productos entre formularios
        ModeloProducto model = new ModeloProducto();
        List<Producto> productos = new List<Producto>();

        // Objeto DataTable en el que guardamos los datos.
        DataTable table = new DataTable("table");

        // Producto correspondiente a la fila seleccionada actualmente
        Producto selected;

        public FPrincipal()
        {
            InitializeComponent();

            // Inicializamos la tabla 
            table.Columns.Add("ID", Type.GetType("System.Int32"));
            table.Columns.Add("Imagen", Type.GetType("System.Byte[]"));
            table.Columns.Add("Nombre", Type.GetType("System.String"));
            table.Columns.Add("Stock", Type.GetType("System.Int32"));
            table.Columns.Add("Precio", Type.GetType("System.Double"));
            table.Columns.Add("Descripción", Type.GetType("System.String"));
            table.Columns.Add("Tipo", Type.GetType("System.String"));

            // Obtenemos los datos
            productos = model.GetProductos();
        }

        private void FPrincipal_Load(object sender, EventArgs e)
        {
            Recargar();
            FormatoDGV(dgvProductos);
        }

        /// <summary>
        /// Función que recarga la vista en la tabla con todos los productos gestionados (que existen como lista fuera del DGV).
        /// </summary>
        private void Recargar()
        {
            // Establecer origen de los datos del DGV en el objeto DataTable.
            dgvProductos.DataSource = table;
            table.Rows.Clear();

            productos = model.GetProductos();
            foreach (Producto p in productos)
            {
                byte[] img_bytes = CUtility.imageToByteArray(p.Imagen);
                table.Rows.Add(p.Id, img_bytes, p.Name, p.Stock, p.Price, p.Descripcion, p.Tipo);
            }

        }

        /// <summary>
        /// Función que establece un formato para las columnas del DataGridView inicialmente tras la carga del formulario.
        /// </summary>
        /// <param name="dgv"></param>
        private void FormatoDGV(DataGridView dgv)
        {
            // Establecer anchos fijos iniciales para cada columna. Se deja el resto de espacio libre para la descripción (col. 4).
            dgvProductos.Columns[0].Width = 16;
            dgvProductos.Columns[1].Width = 32;
            dgvProductos.Columns[2].Width = 48;
            dgvProductos.Columns[3].Width = 20;
            dgvProductos.Columns[4].Width = 48;
            dgvProductos.Columns[5].Width = 96;
            dgvProductos.Columns[6].Width = 72;

            // Establecer un formato para moneda (currency) española en la columna Precio
            dgvProductos.Columns["Precio"].DefaultCellStyle.Format = "c"; // formato para currency, con localización española
            dgvProductos.Columns["Precio"].DefaultCellStyle.FormatProvider = System.Globalization.CultureInfo.GetCultureInfo("es-ES");
        }

        /// <summary>
        /// Función que obtiene un objeto Producto a partir de la fila seleccionada en el DataGridView y asigna ese objeto a la variable selected.
        /// </summary>
        private void Seleccionar()
        {
            try
            {
                int index = dgvProductos.SelectedRows[0].Index;
                if (index >= 0)
                {
                    DataTable dt = this.dgvProductos.DataSource as DataTable;
                    DataRow row = dt.Rows[index];

                    int id = (int)row.ItemArray[0];
                    byte[] img_bytes = (byte[]) row.ItemArray[1];
                    string name = row.ItemArray[2].ToString();
                    int stock = (int)row.ItemArray[3];
                    double price = (Double)row.ItemArray[4];
                    string descripcion = row.ItemArray[5].ToString();
                    string tipo = row.ItemArray[6].ToString();

                    Bitmap img = (Bitmap) CUtility.byteArrayToImage(img_bytes);

                    Producto x = new Producto(id, img, name, stock, price, descripcion, tipo);
                    selected = x;
                }
            }
            catch
            {
                MessageBox.Show("Selecciona una fila para editar el producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // EVENTOS DEL FORMULARIO
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbComparacion.SelectedItem != null)
            {
                table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", cbComparacion.SelectedItem, txtBuscar.Text);
            }
            else
            {
                MessageBox.Show("Debe introducir un campo a filtrar", "Filtrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cbComparacion.SelectedItem = null;
            txtBuscar.ResetText();
            table.DefaultView.RowFilter = "";
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            CProductosPDF cProductosPDF = new CProductosPDF();
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                saveFileDialog.Filter = "Archivo PDF|*pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (Path.GetExtension(saveFileDialog.FileName) != ".pdf")
                        saveFileDialog.FileName += ".pdf";

                    cProductosPDF.fileName = saveFileDialog.FileName;

                    cProductosPDF.Imprimir(table);
                    MessageBox.Show("Archivo " + cProductosPDF.fileName + " se ha generado correctamente.",
                    "PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PDF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            // Instanciamos la clase FProductosModificar para introducir los datos.
            FProductosCrear fProductosCrear = new FProductosCrear(productos);

            // Mostramos el cuadro de diálogo.
            fProductosCrear.ShowDialog();

            // Si se ha pulsado el botón de aceptar.
            if (fProductosCrear.DialogResult == DialogResult.OK)
            {
                // Añadimos el nuevo producto
                Producto nuevo_producto = fProductosCrear.producto;
                model.addProducto(nuevo_producto);
                MessageBox.Show("Producto guardado correctamente");

                // Recargamos la tabla.
                Recargar();
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Seleccionar el producto resaltado en el DataGridView
            Seleccionar();

            // En caso de seleccionar más de uno, no permitimos editar
            if (dgvProductos.SelectedRows.Count != 1)
            {
                MessageBox.Show("Por favor, selecciona un único producto para editar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvProductos.ClearSelection();
                dgvProductos.Focus();
                return;
            }
            // Instanciamos la clase FProductosModificar pasando por referencia el empleado seleccionado
            FProductosModificar fProductosModificar = new FProductosModificar(selected);

            // Mostramos el cuadro de diálogo.
            fProductosModificar.ShowDialog();

            // Si se ha pulsado el botón de aceptar.
            if (fProductosModificar.DialogResult == DialogResult.OK)
            {
                // Añadimos el producto actualizado
                Producto actualizado = fProductosModificar.producto;
                model.updateProducto(actualizado);

                MessageBox.Show("Producto actualizado", "Producto modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Recargamos la tabla.
                Recargar();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtenemos una colección de filas seleccionadas del DataGridView
                DataGridViewSelectedRowCollection rows = dgvProductos.SelectedRows;

                // DataTable que contiene la información del DataGridView
                DataTable dt = this.dgvProductos.DataSource as DataTable;

                // Lista de productos a eliminar
                List<Producto> lista_eliminar = new List<Producto>();

                // Para cada fila de las seleccionadas antes de pulsar el botón de borrado, creamos un Producto y lo añadimos a lista_eliminar
                foreach (DataGridViewRow dgv_row in rows)
                {
                    int index = dgv_row.Index; // Posición de la fila en el DGV
                    DataRow row = dt.Rows[index]; // DataRow correspondiente a la posición de la fila

                    int id = (int)row.ItemArray[0]; // ID

                    byte[] img_bytes = (byte[]) row.ItemArray[1];
                    Bitmap img = (Bitmap)CUtility.byteArrayToImage(img_bytes); // Imagen

                    string name = row.ItemArray[2].ToString(); // Nombre
                    int stock = (int)row.ItemArray[3]; // Stock
                    double price = (Double)row.ItemArray[4]; // Precio
                    string descripcion = row.ItemArray[5].ToString(); // Descripción
                    string tipo = row.ItemArray[6].ToString(); // Tipo

                    Producto x = new Producto(id, img, name, stock, price, descripcion, tipo);
                    lista_eliminar.Add(x);
                }

                lista_eliminar.Sort();

                // Número de productos a eliminar
                int count_del = lista_eliminar.Count;

                // Diálogo que pide confirmación para eliminar los productos
                DialogResult confirmar = MessageBox.Show("¿Eliminar " + count_del + " productos?", "Confirmar eliminación de productos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmar == DialogResult.Yes)
                {
                    // Lista de productos que NO vamos a eliminar
                    List<Producto> lista_conservar = new List<Producto>();

                    // Añadimos a la lista de conservar todos los productos existentes que NO hayan sido añadidos a lista_eliminar
                    foreach (Producto x in productos)
                    {
                        lista_conservar.Add(x);

                        foreach (Producto y in lista_eliminar)
                        {
                            if (x.Id == y.Id)
                            {
                                lista_conservar.Remove(x);
                            }
                        }
                    }
                    // Reemplazamos los productos existentes por los de lista_conservar
                    model.productos = lista_conservar;

                    MessageBox.Show("Eliminados " + count_del + " productos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Recargar();
                } 
                else
                {
                    MessageBox.Show("Operación cancelada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Selecciona una o varias filas para eliminar productos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewCell cell = dgvProductos.CurrentCell;


            if (cell.ColumnIndex == 1)
            {
                Seleccionar();

                FImageExpander fimgexp = new FImageExpander(selected.Imagen);
                fimgexp.ShowDialog();
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Diálogo que pide confirmación para limpiar los productos de la lista
            int count = table.Rows.Count;
            DialogResult confirmar = MessageBox.Show("¿Limpiar todos los productos de la lista?\nSe perderán todos los datos de forma irreversible.", "Limpiar lista", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar == DialogResult.Yes)
            {

                table.Rows.Clear();
                model.productos.Clear();
                selected = null;

                MessageBox.Show("Eliminados " + count + " productos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Recargar();

            } else
            {
                MessageBox.Show("Operación cancelada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCSVExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog() { Filter = "Archivo CSV|*.csv" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // Listas de string para las filas y las cabeceras
                List<string> rows = new List<string>();
                List<string> headers = new List<string>();

                // Añadimos las cabeceras de cada columna a headers
                foreach (DataGridViewColumn col in dgvProductos.Columns)
                {
                    headers.Add(col.HeaderText);
                }

                // Añadimos a la primera fila la lista de cabeceras
                string sep = ",";
                rows.Add(string.Join(sep, headers));

                // Para cada fila añadimos el producto al fichero .csv (los valores de cada celda de esa fila)
                foreach (DataGridViewRow row in dgvProductos.Rows)
                {
                    try
                    {
                        List<string> cells = new List<string>();
                        foreach (DataGridViewCell c in row.Cells)

                            // Para inluir la imagen como base64
                            if (c.Value is byte[])
                            {
                                cells.Add(Convert.ToBase64String((byte[])c.Value));
                            }
                            else
                            {
                                cells.Add(c.Value.ToString());
                            }

                        rows.Add(string.Join(sep, cells));
                    }
                    catch (Exception)
                    {

                    }
                }
                File.WriteAllLines(sfd.FileName, rows);
                MessageBox.Show("Archivo " + sfd.FileName + " se ha generado correctamente.", "Exportación terminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCSVImportar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog() { Filter = "Archivo CSV|*.csv" };

            // Tras escoger un archivo, procedemos a importar datos
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Separador
                string sep = ",";
                // Filas
                string[] lines = File.ReadAllLines(ofd.FileName);
                // Cabeceras
                string[] headers = lines[0].Split(new[] { sep }, StringSplitOptions.None);

                // Productos a reemplazar en la lista actual
                List<Producto> prod_import = new List<Producto>();

                // Añadimos productos a la lista prod_import desde el fichero
                try
                {
                    for (int i = 1; i < lines.Length; i++)
                    {
                        string[] cells = lines[i].Split(new[] { sep }, StringSplitOptions.None);

                        int id = int.Parse(cells[0]);

                        byte[] img_bytes = Convert.FromBase64String(cells[1]);
                        Bitmap img = (Bitmap)CUtility.byteArrayToImage(img_bytes);

                        string nombre = cells[2];
                        int stock = int.Parse(cells[3]);
                        double precio = double.Parse(cells[4]);
                        string descripcion = cells[5];
                        string tipo = cells[6];

                        Producto x = new Producto(id, img, nombre, stock, precio, descripcion, tipo);

                        prod_import.Add(x);
                    }
                }
                catch
                {
                    MessageBox.Show("Error al importar: el archivo no tiene una estructura correcta", "Error de importación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Reemplazamos la lista de productos anterior por prod_import en el modelo 
                model.productos = prod_import;

                // Recargamos el DataGridView
                Recargar();

                // Mensaje de confirmación
                MessageBox.Show("Archivo " + ofd.FileName + " importado correctamente.", "Importación terminada", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void mostrarAyudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ToolTip CSVExport = new ToolTip();
            CSVExport.Active = true;
            CSVExport.Show("Exportar, Importar .csv", btnCSVExportar, 5000);

            ToolTip CampoBuscar = new ToolTip();
            CampoBuscar.Active = true;
            CampoBuscar.Show("Texto a buscar", txtBuscar, 5000);

            ToolTip Editar = new ToolTip();
            Editar.Active = true;
            Editar.Show("Editar", btnEditar, 5000);

            ToolTip Eliminar = new ToolTip();
            Eliminar.Active = true;
            Eliminar.Show("Eliminar", btnBorrar, 5000);

            ToolTip Filtros = new ToolTip();
            Filtros.Active = true;
            Filtros.Show("Filtrar", cbComparacion, 5000);

            ToolTip Imprimir = new ToolTip();
            Imprimir.Active = true;
            Imprimir.Show("Exportar .pdf", btnImprimir, 5000);

            ToolTip Limpiar = new ToolTip();
            Limpiar.Active = true;
            Limpiar.Show("Limpiar", btnLimpiar, 5000);

            ToolTip Nuevo = new ToolTip();
            Nuevo.Active = true;
            Nuevo.Show("Crear", btnNuevo, 5000);

            ToolTip Refrescar = new ToolTip();
            Refrescar.Active = true;
            Refrescar.Show("Restablecer, Buscar", btnReset, 5000);

            ToolTip Salir = new ToolTip();
            Salir.Active = true;
            Salir.Show("Salir", btnSalir, 5000);
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAboutBox fabout = new FAboutBox();
            fabout.ShowDialog();
        }
    }
}

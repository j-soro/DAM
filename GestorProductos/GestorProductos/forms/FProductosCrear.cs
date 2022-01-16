using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GestorProductos
{
    /// <summary>
    /// Clase Form para crear un producto nuevo en la lista. Permite modificar todos los campos.
    /// 
    /// Campos/variables:
    ///     - producto: Producto individual que representa al producto editado en una instancia del Form.
    ///     - productos: List de productos actuales que se obtiene como parámetro en el constructor.
    /// </summary>
    public partial class FProductosCrear : Form
    {
        public Producto producto { get; set; }
        public List<Producto> productos { get; set;}
        public FProductosCrear(List<Producto> productos)
        {
            InitializeComponent();
            this.productos = productos;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ValidarForm();

        }

        private void txtId_Validating(object sender, CancelEventArgs e)
        {
            ValidarID();
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            ValidarNombre();
        }

        private void cbTipos_Validating(object sender, CancelEventArgs e)
        {
            ValidarTipo();
        }

        private bool ValidarID()
        {
            bool bStatus = true;
            if (txtId.Text == "")
            {
                errorProviderID.SetError(txtId, "Introduce un ID de producto");
                bStatus = false;
            }
            else
            {
                errorProviderID.SetError(txtId, "");

                try
                {
                    int temp = int.Parse(txtId.Text);

                    // Comprobar que el id no existe en ningún otro producto
                    if (CheckProductoId(temp, productos) == true)
                    {
                        errorProviderID.SetError(txtId, "Introduce un ID no repetido");
                        bStatus = false;

                    }
                }
                catch
                {
                    errorProviderID.SetError(txtId, "Introduce números exclusivamente");
                    bStatus = false;
                }

            }
                
            return bStatus;
        }

        /// <summary>
        /// Función que comprueba si un Id existe en algún producto de una List de productos.
        /// </summary>
        /// <param name="id">Id del producto a comprobar.</param>
        /// <param name="productos">List de productos donde comprobar si existe el Id.</param>
        /// <returns>true si el Id existe en la lista, false si no existe.</returns>
        private bool CheckProductoId(int id, List<Producto> productos)
        {
            foreach (Producto p in productos)
            {
                if (p.Id == id)
                {
                    return true;
                }
            }
            return false;
        }

        private bool ValidarNombre()
        {
            bool bStatus = true;
            if (txtNombre.Text == "")
            {
                errorProviderNombre.SetError(txtNombre, "Introduce un nombre de producto");
                bStatus = false;
            }
            else
                errorProviderNombre.SetError(txtNombre, "");
            return bStatus;
        }

        private bool ValidarTipo()
        {
            bool bStatus = true;
            if (cbTipos.SelectedItem == null)
            {
                errorProviderTipo.SetError(cbTipos, "Selecciona un tipo de producto");
                bStatus = false;
            }
            else
                errorProviderTipo.SetError(cbTipos, "");
            return bStatus;
        }

        /// <summary>
        /// Función que representa un sistema de validación para asegurar que los campos son correctos y que los 
        /// campos obligatorios no están en blanco. Los campos obligatorios son: Id, Nombre, Tipo.
        /// </summary>
        private void ValidarForm()
        {
            bool bValidID = ValidarID();
            bool bValidNombre = ValidarNombre();
            bool bValidTipo = ValidarTipo();
            if (bValidID && bValidNombre && bValidTipo)
            {
                try
                {
                    producto = new Producto(Convert.ToInt32(txtId.Text), (Bitmap) picBoxCrear.Image, txtNombre.Text, Convert.ToInt32(txtStock.Value), Convert.ToDouble(txtPrecio.Value), txtDescripcion.Text, cbTipos.SelectedItem.ToString());
                    this.DialogResult = DialogResult.OK;
                }
                catch
                {
                    MessageBox.Show("Problema al guardar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, introduce datos válidos en los campos requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void picBoxCrear_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog() { Filter = "Imágenes de mapa de bits (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG" };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picBoxCrear.ImageLocation = ofd.FileName;

            }

        }
    }
}

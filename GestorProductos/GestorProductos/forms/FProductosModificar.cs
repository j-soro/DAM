using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GestorProductos
{
    /// <summary>
    /// Clase Form para modificar productos existentes en la lista. Permite modificar todos los campos exceptuando el Id, que se emplea
    /// para diferenciar un producto de otro.
    /// 
    /// Campos/variables:
    ///     - producto: Producto individual que representa al producto editado en una instancia del Form.
    /// </summary>
    public partial class FProductosModificar : Form
    {
        public Producto producto { get; set; }
        public FProductosModificar(Producto previo)
        {
            InitializeComponent();
            this.producto = previo;
        }

        private void FProductosModificar_Load(object sender, EventArgs e)
        {
            txtId.Text = producto.Id.ToString();
            txtId.Enabled = false;

            if (producto.Imagen != null)
            {
                picBoxModificar.Image = producto.Imagen;
            }

            txtNombre.Text = producto.Name.ToString();
            txtStock.Value = producto.Stock;
            txtPrecio.Value = (decimal) producto.Price;
            txtDescripcion.Text = producto.Descripcion;
            cbTipos.SelectedItem = producto.Tipo;

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

            errorProviderID.SetError(txtId, "");

            try
            {
                int temp = int.Parse(txtId.Text);
                errorProviderID.SetError(txtId, "");

            }
            catch
            {
                errorProviderID.SetError(txtId, "Introduce números exclusivamente");
                bStatus = false;
            }
            return bStatus;
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
                    producto = new Producto(Convert.ToInt32(txtId.Text), (Bitmap)picBoxModificar.Image, txtNombre.Text, Convert.ToInt32(txtStock.Value), Convert.ToDouble(txtPrecio.Value), txtDescripcion.Text, cbTipos.SelectedItem.ToString());
                    this.DialogResult = DialogResult.OK;
                }
                catch
                {
                    MessageBox.Show("Problema al actualizar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, introduce datos válidos en los campos requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void picBoxModificar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog() { Filter = "Imágenes de mapa de bits (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG" };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picBoxModificar.ImageLocation = ofd.FileName;

            }
        }
    }
}
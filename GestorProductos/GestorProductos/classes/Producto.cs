using System;
using System.Drawing;

namespace GestorProductos

{
    /// <summary>
    /// Clase que representa un producto que gestionamos en nuestra aplicación.
    /// </summary>
    public class Producto : IComparable<Producto>
    {
        public int Id { get; set; }

        public Bitmap Imagen { get; set; }

        public string Name { get; set; }

        public int Stock { get; set; }

        public double Price { get; set; }

        public string Descripcion { get; set; }

        public string Tipo { get; set; }

        // CONSTRUCTORES

        /// <summary>
        /// Constructor con un Image como parámetro para la imagen del producto.
        /// </summary>
        /// <param name="id">ID del producto.</param>
        /// <param name="image">Imagen del producto.</param>
        /// <param name="name">Nombre del producto.</param>
        /// <param name="stock">Stock existente del producto.</param>
        /// <param name="price">Precio del producto.</param>
        /// <param name="descripcion">Descripción del producto.</param>
        /// <param name="tipo">Tipo de producto.</param>
        public Producto(int id, Bitmap image, string name, int stock, double price, string descripcion, string tipo)
        {
            Id = id;
            Imagen = image;
            Imagen = (Bitmap) CUtility.resizeImage(Imagen, 512, 512);
            Name = name;
            Stock = stock;
            Price = price;
            Descripcion = descripcion;
            Tipo = tipo;
        }
        /// <summary>
        /// Constructor con una ruta de archivo como parámetro para la imagen del producto.
        /// </summary>
        /// <param name="id">ID del producto.</param>
        /// <param name="image">Ruta del archivo con la imagen del producto.</param>
        /// <param name="name">Nombre del producto.</param>
        /// <param name="stock">Stock existente del producto.</param>
        /// <param name="price">Precio del producto.</param>
        /// <param name="descripcion">Descripción del producto.</param>
        /// <param name="tipo">Tipo de producto.</param>
        public Producto(int id, string image, string name, int stock, double price, string descripcion, string tipo)
        {
            Id = id;
            Imagen = (Bitmap) Image.FromFile(image);
            Imagen = (Bitmap)CUtility.resizeImage(Imagen, 512, 512);
            Name = name;
            Stock = stock;
            Price = price;
            Descripcion = descripcion;
            Tipo = tipo;
        }
        /// <summary>
        /// Constructor sin imagen, que establece la imagen por defecto para el producto.
        /// </summary>
        /// <param name="id">ID del producto.</param>
        /// <param name="name">Nombre del producto.</param>
        /// <param name="stock">Stock existente del producto.</param>
        /// <param name="price">Precio del producto.</param>
        /// <param name="descripcion">Descripción del producto.</param>
        /// <param name="tipo">Tipo de producto.</param>
        public Producto(int id, string name, int stock, double price, string descripcion, string tipo)
        {
            Id = id;
            Imagen = (Bitmap) Image.FromFile(@"../../resources/placeholder.png");
            Imagen = (Bitmap) CUtility.resizeImage(Imagen, 512, 512);
            Name = name;
            Stock = stock;
            Price = price;
            Descripcion = descripcion;
            Tipo = tipo;
        }
        /// <summary>
        /// Implementación de la interfaz IComparable
        /// </summary>
        /// <param name="other">Producto con el cual comparar.</param>
        /// <returns></returns>
        public int CompareTo(Producto other) =>
            (Id).CompareTo((other.Id));
    }
}
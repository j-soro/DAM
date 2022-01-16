using System.Collections.Generic;

namespace GestorProductos
{
    internal class ModeloProducto
    {
        public List<Producto> productos  { get; set; }

        public List<Producto> GetProductos()
        {
            return productos;
        }
        
        /// <summary>
        /// Constructor que genera una lista de productos y la llena con datos generados por generarProductos().
        /// </summary>
        public ModeloProducto()
        {
            productos = new List<Producto>();
            generarProductos();
        }

        /// <summary>
        /// Función que añade un Product a la lista productos de la instancia ModeloProducto.
        /// </summary>
        /// <param name="p">Product a añadir a la lista.</param>
        public void addProducto(Producto p)
        {
            productos.Add(p);
        }

        /// <summary>
        /// Función que elimina un Product de la lista productos de la instancia ModeloProducto.
        /// </summary>
        /// <param name="p">Product a eliminar de la lista.</param>
        public void removeProducto(Producto p)
        {
            productos.Remove(p);
        }

        /// <summary>
        /// Función que reemplaza la información de un producto, existente en la lista de la instancia ModeloProducto, por la de otro producto x, que comparte su mismo Id.
        /// </summary>
        /// <param name="x">Product a actualizar en el ModeloProducto</param>
        public void updateProducto(Producto x)
        {

            foreach(Producto p in productos)
            {
                if (p.Id == x.Id)
                {
                    p.Imagen = x.Imagen;
                    p.Name = x.Name;
                    p.Stock = x.Stock;
                    p.Price = x.Price;
                    p.Descripcion = x.Descripcion;
                    p.Tipo = x.Tipo;
                }
            }
        }

        /// <summary>
        /// Función que genera los productos de prueba para hacer la demostración del funcionamiento del gestor de productos.
        /// Sería interesante incluir en esta función datos obtenidos de cualquier otra fuente, como una base de datos, aunque
        /// en este caso concreto no queremos utilizar una BD, así que se crean instancias de Producto.
        /// </summary>
        public void generarProductos()
        {
            Producto p1 = new Producto(1, @"../../resources/images/mesa.jpg", "Mesa", 23, 125, "Una mesa bastante buena", "Mobiliario"); productos.Add(p1);
            Producto p2 = new Producto(2, @"../../resources/images/placa_solar.jpg", "Placa solar", 5, 3500, "Placa solar termoeléctrica", "Exteriores"); productos.Add(p2);
            Producto p3 = new Producto(3, @"../../resources/images/silla_oficina.jpg", "Silla de oficina", 56, 89, "Silla de oficina negra", "Mobiliario"); productos.Add(p3);
            Producto p4 = new Producto(4, @"../../resources/images/mantel_rosas.jpg", "Mantel de rosas", 129, 3.5, "Mantel con estampado de rosas", "Hogar"); productos.Add(p4);
            Producto p5 = new Producto(5, @"../../resources/images/paquete_folios.jpg", "Paquete de folios", 800, 1.35, "250 folios DIN-A4", "Papelería"); productos.Add(p5);
            Producto p6 = new Producto(6, @"../../resources/images/caja_clavos.jpg", "Caja de clavos", 366, 1.70, "100 clavos en caja de cartón", "Bricolaje"); productos.Add(p6);
            Producto p7 = new Producto(7, @"../../resources/images/bandeja_horno.jpg", "Bandeja de horno", 23, 9, "150 x 80 cm, tamaño estándar", "Hogar"); productos.Add(p7);
            Producto p8 = new Producto(8, @"../../resources/images/pelota_animales.jpg", "Pelota para animales", 30, 2.30, "Pelota de goma suave para mascotas", "Mascotas"); productos.Add(p8);
            Producto p9 = new Producto(9, @"../../resources/images/caja_cerillas.jpg", "Caja de cerillas", 65, 0.40, "50 fósforos", "Hogar"); productos.Add(p9); 
            Producto p10 = new Producto(10, @"../../resources/images/bombona_camping.jpg", "Bombona para camping", 17, 12.50, "Pequeña bombona de gas para cocinar", "Exteriores"); productos.Add(p10);
            Producto p11 = new Producto(11, @"../../resources/images/butaca_burdeos.jpg", "Butaca burdeos", 6, 224.99, "Cómoda butaca clásica para relajarse", "Mobiliario"); productos.Add(p11);
            Producto p12 = new Producto(12, @"../../resources/images/3x_rollos_papel.jpg", "3X Rollo papel de cocina", 79, 1.35, "100 papeles para limpieza cotidiana", "Hogar"); productos.Add(p12);
            Producto p13 = new Producto(13, @"../../resources/images/pegamento_madera.jpg", "Pegamento para madera", 120, 3.50, "Pegamento para maderas de todo tipo", "Bricolaje"); productos.Add(p13);
            Producto p14 = new Producto(14, @"../../resources/images/collar_perro.jpg", "Collar para perro", 20, 6.45, "Bonito collar de piel sintética para mascotas", "Mascotas"); productos.Add(p14);
            Producto p15 = new Producto(15, @"../../resources/images/bolsas_perros.jpg", "Bolsas higiénicas para perros", 1758, 1.00, "100 bolsitas para recoger excrementos", "Mascotas"); productos.Add(p15);
            Producto p16 = new Producto(16, @"../../resources/images/caja_grapas.jpg", "Caja de grapas", 200, 1.35, "100 grapas de metal", "Papelería"); productos.Add(p16);
            Producto p17 = new Producto(17, @"../../resources/images/mesita_cafe.jpg", "Mesita de café", 4, 35.00, "Bonita mesa de café para tu salón", "Mobiliario"); productos.Add(p17);
            Producto p18 = new Producto(18, @"../../resources/images/boligrafo.jpg", "Bolígrafo", 950, 1.75, "Bolígrafo de tinta china", "Papelería"); productos.Add(p18);
            Producto p19 = new Producto(19, @"../../resources/images/manguera_20m.jpg", "Manguera 20m", 120, 3.65, "Manguera para jardines de 20 metros de longitud", "Exteriores"); productos.Add(p19);
            Producto p20 = new Producto(20, @"../../resources/images/servilletas.jpg", "Servilletas", 100, 1.00, "50 servilletas de cumpleaños", "Hogar"); productos.Add(p20);
        }
    }
}

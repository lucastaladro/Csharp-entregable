﻿namespace csharpEntregable
{
    public class ProductoVendido
    {
        public ProductoVendido()
        {

        }
        public int Id { get; set; }
        public int IdProducto { get; set; }
        public int Stock { get; set; }

        public int IdVenta { get; set; }
    }
}
namespace MiPrimeraAppMAUIBlazor.Class.Modelos
{
    public class Producto
    {
        public int IdProducto { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public decimal Precio { get; set; }

        public string Descripcion { get; set; } = string.Empty;

        public int Stock { get; set; }
    }
}

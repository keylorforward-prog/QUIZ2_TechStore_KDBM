using MiPrimeraAppMAUIBlazor.Class.Modelos;

namespace MiPrimeraAppMAUIBlazor.Services
{
    public class ProductoService
    {
        private List<Producto> lista;

        public ProductoService()
        {
            lista = new List<Producto>();

            lista.Add(new Producto
            {
                IdProducto = 1,
                Nombre = "Laptop Lenovo",
                Precio = 2500,
                Descripcion = "Laptop para trabajo y estudio",
                Stock = 10,
            }); //ES COMO UN TIPO 

            lista.Add(new Producto
            {
                IdProducto = 2,
                Nombre = "Mouse Logitech",
                Precio = 80,
                Descripcion = "Mouse inalámbrico",
                Stock = 25,
            });
        }

        public async Task<List<Producto>> listaProducto()
        {
            return lista;
        }

        public async Task<Producto?> obtenerProducto(int idProducto)
        {
            return lista.FirstOrDefault(x => x.IdProducto == idProducto);
        }

        public async Task guardarProducto(Producto producto)
        {
            producto.IdProducto = lista.Count == 0 ? 1 : lista.Max(x => x.IdProducto) + 1;
            lista.Add(producto);
        } //DEL CODIGO BASE DEL PROFESOR 
    }
}

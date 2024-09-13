using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Producto
    {
        public int Id { get; set; }

        public static int UltimoId { get; set; } = 1;

        public string Nombre { get; set; }

        public string Activo { get; set; }

        public int Cantidad { get; set; }
        public DateTime FechaDeFabricacion { get; set; }

        public Producto(string nombre, string activo, int cantidad, DateTime fechaDeFabricacion)
        {
            Id = UltimoId++;
            Nombre = nombre;
            Activo = activo;
            Cantidad = cantidad;
            FechaDeFabricacion = fechaDeFabricacion;
            EsValido();
        }

        public void EsValido()
        {
            ValidarNombre();
            ValidarCantidad();
            ValidarFechaDeFabricacion();
        }
        private void ValidarNombre()
        {
            if (string.IsNullOrEmpty(Nombre) ||
                string.IsNullOrEmpty(Activo)
                )
            {
                throw new Exception("El nombre ni el Activo no puede estar vacio");
            }
        }
        private void ValidarCantidad()
        {
           if (Cantidad <= 0)
            {
            throw new Exception("Cantidad debe ser un valor numerico positivo");
            } 
        }
        private void ValidarFechaDeFabricacion()
        {

            if (FechaDeFabricacion < new DateTime(2021, 1, 1))
            {
                throw new Exception("La fecha de fabricacion debe ser posterior al 1ero de enero de 2021");
            }
        }

        public override bool Equals(object? obj)
        {
            return obj is Producto producto &&
                   Nombre == producto.Nombre &&
                   Activo == producto.Activo &&
                   Cantidad == producto.Cantidad;
        }
    }


}


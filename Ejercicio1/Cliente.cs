using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{

    public class Cliente
    {
        public int Id { get; set; }

        public static int UltimoId { get; set; } = 1;

        public string NombreCompleto { get; set; }

        public DateTime FechaDeAlta { get; set; }

        public Cliente(string nombreCompleto)
        {
            Id = UltimoId++;
            NombreCompleto = nombreCompleto;
            FechaDeAlta = DateTime.Now;
            EsValido();
        }

        public void EsValido()
        {
            if (string.IsNullOrEmpty(NombreCompleto))
            {
                throw new Exception("Nombre no puede estar vacio");
            }
        }

        public override bool Equals(object? obj)
        {
            return obj is Cliente cliente &&
                   NombreCompleto == cliente.NombreCompleto;
        }
    }
}

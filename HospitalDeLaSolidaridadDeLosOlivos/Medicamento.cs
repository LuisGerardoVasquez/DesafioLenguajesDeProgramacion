using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDeLaSolidaridadDeLosOlivos
{
    public class Medicamento
    {
        // ATRIBUTOS
        private string idMedicamento;
        private string nombreComercial;
        private int stockDisponible;

        // CONSTRUCTOR
        public Medicamento(string id, string nombre, int stock)
        {
            IdMedicamento = id;
            NombreComercial = nombre;
            if (stock < 0)
            {
                throw new ArgumentException("El stock no puede ser negativo.");
            }
            stockDisponible = stock;
        }

        // PROPIEDADES
        public string IdMedicamento
        {
            get { return idMedicamento; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El id del medicamento es obligatorio.");
                }
                idMedicamento = value.Trim();
            }
        }

        public string NombreComercial
        {
            get { return nombreComercial; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El nombre del medicamento es obligatorio.");
                }
                nombreComercial = value.Trim();
            }
        }

        public int StockDisponible
        {
            get { return stockDisponible; }
        }

        // METODOS
        public void ActualizarStock(int cantidad)
        {
            if (stockDisponible + cantidad < 0)
            {
                throw new ArgumentException("Stock insuficiente. Disponible: " + stockDisponible);
            }
            stockDisponible += cantidad;
        }

        public bool VerificarDisponibilidad()
        {
            return stockDisponible > 0;
        }
    }
}

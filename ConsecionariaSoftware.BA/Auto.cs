using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsecionariaSoftware.BA
{
    public class Auto
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Traccion { get; set; }
        public string Cilindrada { get; set; }
        public string Usado0km { get; set; }
        public string FullEstandar { get; set; }
        public decimal Precio { get; set; }
        public int Id {  get; set; }

      public Auto(int Id,
                  string marca,
                  string modelo,
                  string traccion,
                  string cilindrada,
                  string usado0km,
                  string fullestandar,
                  string precio)
      {
          this.Id = Id;
          Marca = marca;
          Modelo = modelo;
          Traccion = traccion;
          Cilindrada = cilindrada;
          Usado0km = usado0km;
          FullEstandar = fullestandar;
          Precio = Convert.ToInt32(precio);
      }

        public override string ToString()
        {
            return $"{Marca} - {Modelo} {Traccion} {Cilindrada} {Usado0km} {FullEstandar} {Precio}";
        }
    }
}

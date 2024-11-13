using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsecionariaSoftware.BA
{
    public class Vehículos
    {
        public DataTable Tabla { get; set; }
        public DataTable TablaCamion {  get; set; }
        public static int ultimoid { get; set; } = 0;
        public static int ultimoidcamion { get; set; } = 0;

        public Vehículos()
        {
            Tabla = new DataTable();
            Tabla.TableName = "Vehículos";
            Tabla.Columns.Add("Num");
            Tabla.Columns.Add("Marca");
            Tabla.Columns.Add("Modelo");
            Tabla.Columns.Add("Tracción");
            Tabla.Columns.Add("Cilindrada");
            Tabla.Columns.Add("Usado - 0km");
            Tabla.Columns.Add("Full - Standar");
            Tabla.Columns.Add("Precio", typeof(int));

            LeerArchivo();
            for (int i = 0; i < Tabla.Rows.Count; i++)
            {
                if (Convert.ToInt32(Tabla.Rows[i][0]) > ultimoid)
                {
                    ultimoid = Convert.ToInt32(Tabla.Rows[i][0]);
                }
            }

            TablaCamion = new DataTable();
            TablaCamion.TableName = "Vehículos2";
            TablaCamion.Columns.Add("Num");
            TablaCamion.Columns.Add("Marca");
            TablaCamion.Columns.Add("Modelo");
            TablaCamion.Columns.Add("Tracción");
            TablaCamion.Columns.Add("Cilindrada");
            TablaCamion.Columns.Add("Usado - 0km");
            TablaCamion.Columns.Add("Full - Standar");
            TablaCamion.Columns.Add("Precio", typeof(int));

            LeerArchivoCamion();
            for (int i = 0; i < TablaCamion.Rows.Count; i++)
            {
                if (Convert.ToInt32(TablaCamion.Rows[i][0]) > ultimoidcamion)
                {
                    ultimoidcamion = Convert.ToInt32(TablaCamion.Rows[i][0]);
                }
            }
        }

        public void LeerArchivo()
        {
            if (System.IO.File.Exists("Vehículos.xml"))
            {
                Tabla.ReadXml("Vehículos.xml");
            }
        }
        public void LeerArchivoCamion()
        {
            if (System.IO.File.Exists("Vehículos2.xml"))
            {
                TablaCamion.ReadXml("Vehículos2.xml");
            }
        }
        public void Insert(Auto aAuto)
        {
            Tabla.Rows.Add();

            int NuevoRenglon = Tabla.Rows.Count - 1;
            Tabla.Rows[NuevoRenglon][0] = aAuto.Id;
            Tabla.Rows[NuevoRenglon]["Marca"] = aAuto.Marca;
            Tabla.Rows[NuevoRenglon]["Modelo"] = aAuto.Modelo;
            Tabla.Rows[NuevoRenglon]["Tracción"] = aAuto.Traccion;
            Tabla.Rows[NuevoRenglon]["Cilindrada"] = aAuto.Cilindrada;
            Tabla.Rows[NuevoRenglon]["Usado - 0km"] = aAuto.Usado0km;
            Tabla.Rows[NuevoRenglon]["Full - Standar"] = aAuto.FullEstandar;
            Tabla.Rows[NuevoRenglon]["Precio"] = aAuto.Precio;

            Tabla.WriteXml("Vehículos.xml");
        }
        public void Insert(Camioneta cCamioneta)
        {
            TablaCamion.Rows.Add();

            int NuevoRenglon = TablaCamion.Rows.Count - 1;
            TablaCamion.Rows[NuevoRenglon][0] = cCamioneta.Id;
            TablaCamion.Rows[NuevoRenglon]["Marca"] = cCamioneta.Marca;
            TablaCamion.Rows[NuevoRenglon]["Modelo"] = cCamioneta.Modelo;
            TablaCamion.Rows[NuevoRenglon]["Tracción"] = cCamioneta.Traccion;
            TablaCamion.Rows[NuevoRenglon]["Cilindrada"] = cCamioneta.Cilindrada;
            TablaCamion.Rows[NuevoRenglon]["Usado - 0km"] = cCamioneta.Usado0km;
            TablaCamion.Rows[NuevoRenglon]["Full - Standar"] = cCamioneta.FullEstandar;
            TablaCamion.Rows[NuevoRenglon]["Precio"] = cCamioneta.Precio;

            TablaCamion.WriteXml("Vehículos2.xml");
        }

        public void Delete(int idaeliminar)
        {

            DataRow[] filas = Tabla.Select($"Num = {idaeliminar}");
            foreach (DataRow fila in filas)
            {
                Tabla.Rows.Remove(fila);
            }
            Tabla.WriteXml("Vehículos.xml");
        }

        public void Deletecamion(int idaeliminar)
        {

            DataRow[] filas = TablaCamion.Select($"Num = {idaeliminar}");
            foreach (DataRow fila in filas)
            {
                TablaCamion.Rows.Remove(fila);
            }
            TablaCamion.WriteXml("Vehículos2.xml");
        }
        public void Update(int idaeliminar) { }
    }
}

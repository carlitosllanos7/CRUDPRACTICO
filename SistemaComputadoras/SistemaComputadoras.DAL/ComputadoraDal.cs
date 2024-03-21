using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using SistemaComputadora.Modelos;
namespace SistemaComputadoras.DAL
{
    public class ComputadoraDal
    {
        public DataTable ListarComputadoraDal()
        { 
        string consulta = "select * from computadora";
        DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
        return lista;
        }
        public void AgregarComputadoraDal(Computadora computadora)
        {
            string consulta = "INSERT INTO computadora  VALUES ('" + computadora.Nombre+ "', '" + computadora.Descricion+ "', " + computadora.Precio+ ", '" + computadora.FechaFabricacion+ "')";

            conexion.Ejecutar(consulta);        }
        public Computadora ObtenerComputadoraId(int id)
        {
            string consulta = "select * from computadora where idcomputadora=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "ya");
            Computadora c = new Computadora();
            if (tabla.Rows.Count > 0)
            {
                c.IdComputadora = Convert.ToInt32(tabla.Rows[0]["idcomputadora"]);
                c.Nombre = tabla.Rows[0]["nombre"].ToString();
                c.Descricion = tabla.Rows[0]["descripcion"].ToString();
                c.Precio = Convert.ToDecimal(tabla.Rows[0]["precio"]);
                c.FechaFabricacion = Convert.ToDateTime(tabla.Rows[0]["fechafabricacion"]);
            }
            return c;
        }
        public void EditarComputadoraDal(Computadora computadora)
        {
            string consulta = "UPDATE computadora SET NOMBRE = '" + computadora.Nombre + "', DESCRIPCION = '" +
                computadora.Descricion + "', PRECIO = " + computadora.Precio + ", FECHAFABRICACION = '" + computadora.FechaFabricacion + "' WHERE IDComputadora = " + computadora.IdComputadora;
            conexion.Ejecutar(consulta);
        }
        public void EliminarComputadoraDal(int id)
        {
            string consulta = "DELETE FROM computadora WHERE IdComputadora = " + id;
            conexion.Ejecutar(consulta);
        }



    }
}

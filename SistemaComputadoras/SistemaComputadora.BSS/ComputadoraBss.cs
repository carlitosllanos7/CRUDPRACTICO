using SistemaComputadoras.DAL;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaComputadora.Modelos;
using System.Text.RegularExpressions;

namespace SistemaComputadora.BSS
{
    public class ComputadoraBss
    {
        ComputadoraDal dal = new ComputadoraDal();
        public DataTable ListarComputadoraBss()
        {
            return dal.ListarComputadoraDal();
        }
        public void InsertarComputadora(Computadora c)
        {
            dal.AgregarComputadoraDal(c);
        }
        public Computadora ObtenerIdComputadora(int id)
        {
            return dal.ObtenerComputadoraId(id);
        }
        public void EditarComputadoraBss(Computadora c)
        {
            dal.EditarComputadoraDal(c);
        }
        public void EliminarComputadora(int id)
        {
            dal.EliminarComputadoraDal(id);
        }
    }
}

using SistemaComputadora.BSS;
using SistemaComputadora.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaComputadora.VISTA.ComputadoraVista
{
    public partial class AgregarComputadoraVista : Form
    {
        public AgregarComputadoraVista()
        {
            InitializeComponent();
        }
        ComputadoraBss bss= new ComputadoraBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Computadora c = new Computadora();
            c.Nombre = textBox1.Text;
            c.Descricion = textBox2.Text;
            c.Precio = Convert.ToDecimal(textBox3.Text);
            c.FechaFabricacion = dateTimePicker1.Value;
            bss.InsertarComputadora(c);
            MessageBox.Show("La computadora se agrego correctamente");
        }
    }
}

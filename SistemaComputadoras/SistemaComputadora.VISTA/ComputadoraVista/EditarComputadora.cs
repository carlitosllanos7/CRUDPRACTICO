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
    public partial class EditarComputadora : Form
    {
        int idx = 0;
        Computadora c = new Computadora();
        ComputadoraBss bss = new ComputadoraBss();
        public EditarComputadora(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void EditarComputadora_Load(object sender, EventArgs e)
        {
            c = bss.ObtenerIdComputadora(idx);
            textBox1.Text = c.Nombre;
            textBox2.Text = c.Descricion;
            textBox3.Text = Convert.ToString(c.Precio);
            dateTimePicker1.Value = c.FechaFabricacion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.Nombre = textBox1.Text;
            c.Descricion = textBox2.Text;
            c.Precio=Convert.ToDecimal(textBox3.Text);
            c.FechaFabricacion = dateTimePicker1.Value;
            bss.EditarComputadoraBss(c);
            MessageBox.Show("Se edito correctamente");
        }
    }
}

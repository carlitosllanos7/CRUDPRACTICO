using SistemaComputadora.BSS;
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
    public partial class ListarComputadoraVista : Form
    {
        public ListarComputadoraVista()
        {
            InitializeComponent();
        }
        ComputadoraBss bss = new ComputadoraBss();
        private void ListarComputadoraVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarComputadoraBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarComputadoraVista fr = new AgregarComputadoraVista();
            fr.ShowDialog();
            {
                dataGridView1.DataSource = bss.ListarComputadoraBss();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int IdComputadoraSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            EditarComputadora fr = new EditarComputadora(IdComputadoraSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarComputadoraBss();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idComputadoraSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("esta seguro de eliminar esta computadora", "eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarComputadora(idComputadoraSeleccionada);
                dataGridView1.DataSource = bss.ListarComputadoraBss();
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3Repaso
{
    public partial class Form1 : Form
    {
        List<Propietarios> propietarioslista = new List<Propietarios>();
        List<Propiedades> propiedadeslista = new List<Propiedades>();
        List<Reporte> reporteslista = new List<Reporte>();


        public Form1()
        {
            InitializeComponent();
        }
        public void GuardarPropietarios()
        {
            using (FileStream stream = new FileStream("Propietarios.txt", FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    foreach (Propietarios propietarios in propietarioslista)
                    {
                        writer.WriteLine(propietarios.Dpi);
                        writer.WriteLine(propietarios.Nombre);
                        writer.WriteLine(propietarios.Apellido);
                    }
                    writer.Close();
                }
            }
        }
        public void MostrarPropietarios()
        {
            dataGridViewPropietarios.DataSource = null;
            dataGridViewPropietarios.DataSource = propietarioslista;
            dataGridViewPropietarios.Refresh();
        }
        private void btnPropietario_Click(object sender, EventArgs e)
        {
            Propietarios propietarios = new Propietarios();         
            propietarios.Dpi = int.Parse(txtDpi.Text);
            propietarios.Nombre = txtNombre.Text;
            propietarios.Apellido = txtApellido.Text;          
            propietarioslista.Add(propietarios);
            GuardarPropietarios();
            MostrarPropietarios();   



        }

        public void GuardarPropiedades()
        {
            using (FileStream stream = new FileStream("Propiedades.txt", FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    foreach (Propiedades propiedades in propiedadeslista)
                    {
                        writer.WriteLine(propiedades.Nodecasa);
                        writer.WriteLine(propiedades.Dpi);
                        writer.WriteLine(propiedades.Cuotamantenimiento);
                    }
                    writer.Close();
                }

            }
        }
        public void MostrarPropiedades()
        {
            dataGridViewPropiedades.DataSource = null;
            dataGridViewPropiedades.DataSource = propiedadeslista;
            dataGridViewPropiedades.Refresh();

        }

        private void BtnPropiedades_Click_1(object sender, EventArgs e)
        {
            Propiedades propiedades = new Propiedades();
            propiedades.Dpi = int.Parse(txtDpi.Text);
            propiedades.Nodecasa = int.Parse(txtNumeroCasa.Text);
            propiedades.Cuotamantenimiento = decimal.Parse(txtMantenimiento.Text);
            propiedadeslista.Add(propiedades);
            GuardarPropiedades();
            MostrarPropiedades();
        }




        public void MostrarReporte()
        {
            foreach (Propiedades propiedades in propiedadeslista)
            {
                Propietarios propietarios = propietarioslista.FirstOrDefault(p => p.Dpi == propiedades.Dpi);
                if (propietarios != null)
                {
                    Reporte reporte = new Reporte
                    {
                        Nombre = propietarios.Nombre,
                        Apellido = propietarios.Apellido,
                        Nodecasa = propiedades.Nodecasa,
                        Cuotamantenimiento = propiedades.Cuotamantenimiento,

                    };
                    reporteslista.Add(reporte);
                }
            }

            dataGridViewdatos.DataSource = null;
            dataGridViewdatos.DataSource = reporteslista;
            dataGridViewdatos.Refresh();


        }


        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            MostrarReporte();
        }

        private void btnOrdenarCuota_Click(object sender, EventArgs e)
        {
            dataGridViewdatos.DataSource = null;
            propiedadeslista = propiedadeslista.OrderBy(p => p.Cuotamantenimiento).ToList();
            MostrarReporte();
        }

        private void btnCuotaAlta_Click(object sender, EventArgs e)
        {
            dataGridViewdatos.DataSource = null;
            propiedadeslista = propiedadeslista.OrderByDescending(p => p.Cuotamantenimiento).ToList();
            MostrarReporte();
        }

        private void btnCuotaBaja_Click(object sender, EventArgs e)
        {
            dataGridViewdatos.DataSource = null;
            propiedadeslista = propiedadeslista.OrderBy(p => p.Cuotamantenimiento).ToList();
            MostrarReporte();
        }
    }
}

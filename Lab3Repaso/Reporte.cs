using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Repaso
{
    internal class Reporte
    {
        string nombre;
        string apellido;
        int nodecasa;
        decimal cuotamantenimiento;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Nodecasa { get => nodecasa; set => nodecasa = value; }
        public decimal Cuotamantenimiento { get => cuotamantenimiento; set => cuotamantenimiento = value; }
    }
}

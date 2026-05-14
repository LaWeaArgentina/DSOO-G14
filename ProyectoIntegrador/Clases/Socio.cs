using System;

namespace ProyectoIntegrador
{
    internal class Socio : Alumno
    {
        private DateTime vencimiento;

        public Socio(int identificador, string nombre, string apellido, DateTime vencimiento)
            : base(identificador, nombre, apellido, true) // esSocio = true
        {
            this.vencimiento = vencimiento;
        }

        public Socio(string nombre, string apellido)
            : base(0, nombre, apellido, true) // esSocio = true
        { }

        public DateTime Vencimiento { get => vencimiento; set => vencimiento = value; }

        public override void pagar()
        {
            base.pagar();
        }

        public override bool obtenerEstadoPago()
        {
            return this.vencimiento < DateTime.Today;
        }
    }
}
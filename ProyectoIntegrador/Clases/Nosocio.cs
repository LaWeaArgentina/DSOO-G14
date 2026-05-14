namespace ProyectoIntegrador
{
    internal class Nosocio : Alumno
    {
        public Nosocio(int identificador, string nombre, string apellido)
            : base(identificador, nombre, apellido, false) // esSocio = false
        { }

        public Nosocio(string nombre, string apellido)
            : base(0, nombre, apellido, false) // esSocio = false
        { }

        public override void pagar()
        {
            base.pagar();
        }

        public override bool obtenerEstadoPago() {  return false; }
    }
}
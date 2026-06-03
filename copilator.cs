namespace practice
{
    public class program
    {
        public static void Main(string[] args)
        {
            Camiones auto1 = new Camiones();
            auto1.Tamano = "Grande";
            auto1.Carga = "10 toneladas";
            auto1.Nombre = "Camion de carga";
            auto1.tipocombustible = "Diesel";
            auto1.Trabajo_Personal = "Transporte de mercancías";
            auto1.kilometraje = 50000;

            auto1.mostrarInformacion();
        }
    }
}

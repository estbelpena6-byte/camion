using System;

namespace practice
{
    public class Vehiculos
    {
        public string marca;
        public string modelo;
        public string anioFabricacion;
        public string color;
        public string matricula;
        public bool tieneLuces;
        public string tipo;
        public string maxVelocity;
        public bool esElectrico;
        public string placa;

        protected bool estado;

        public Vehiculos() { }

        public bool encender()
        {
            return this.estado = true;
        }

        public bool apagar()
        {
            return this.estado = false;
        }

        public string getEstado()
        {
            if (this.estado == true)
            {
                return "Encendido";
            }

            return "Apagado";
        }
    }

    public class Automovil : Vehiculos
    {
        private int cantRuedas;
        public int cantPuertas;
        public string uso;
        public string segmento;
        public string motor;
        public string tipoCombustible;
        public bool tieneEspejos;
        public int pasajeros;
        private int kilometraje;
        public string nombre;

        public Automovil(string name)
        {
            this.nombre = name;
        }

        public void Acelerar(int velocidad, int tiempo)
        {
            if (this.getEstado() == "Encendido")
            {
                this.kilometraje += velocidad * tiempo / 1000;
            }
            else if (this.getEstado() == "Apagado")
            {
                this.kilometraje = 0;
            }
        }

        public double getKilometroRecorridos()
        {
            return this.kilometraje;
        }

        public void mostrarInformacion()
        {
            Console.WriteLine("Nombre: " + this.nombre);
            Console.WriteLine("Marca: " + this.marca);
            Console.WriteLine("Modelo: " + this.modelo);
            Console.WriteLine("Estado: " + this.getEstado());
            Console.WriteLine("Kilometraje: " + this.kilometraje);
        }
    }

    public class Camiones : Vehiculos
    {
        public string Tamano;
        public string Carga;
        private string Matricula;
        public string Nombre;
        private string Motor;
        private string costo;
        public string tipocombustible;
        public string Trabajo_Personal;
        private string CantRuedas;

        public int kilometraje;

        string name;

        public Camiones() { }

        public bool Encender()
        {
            return this.estado = true;
        }

        public bool Apagar()
        {
            return this.estado = false;
        }

        public string GetEstado()
        {
            if (this.estado == true)
            {
                return "Encendido";
            }

            return "Apagado";
        }

        public void acelerar(int velocidad, int tiempo)
        {
            if (this.GetEstado() == "Encendido")
            {
                this.kilometraje += velocidad * tiempo / 1000;
            }
        }

      

        public void mostrarInformacion()
        {
            Console.WriteLine("Nombre: " + this.Nombre);
            Console.WriteLine("Tipo de combustible: " + this.tipocombustible);
            Console.WriteLine("Carga: " + this.Carga);
            Console.WriteLine("Estado: " + this.GetEstado());
            Console.WriteLine("Kilometraje: " + this.kilometraje);
        }
    }
}

    
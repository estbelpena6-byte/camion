using System;

namespace CAMIONIU
{

    public class Camiones
    {
        public string Nombre = "";
        public int kilometraje;

        protected bool estado;

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

        public void Acelerar(int velocidad, int tiempo)
        {
            if (this.GetEstado() == "Encendido")
            {
                this.kilometraje += velocidad * tiempo / 1000;
            }
        }
        

    }
}
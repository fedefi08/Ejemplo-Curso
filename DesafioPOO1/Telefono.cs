using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO1
{
    internal class Telefono
    {
        //Modelo string.
        //Marca string.
        //NumeroTelefonico string.
        //CodigoOperador int (1, 2 o 3).

        private string Modelo;
        private string Marca;
        private string NumeroTelefonico;
        private int CodigoOperador;
        private string Contacto;


        public string modelo
        {
            get { return Modelo; }
        }

        public string Telmarca
        {
            get { return Marca; }
        }

        public int codOpe
        {
            get { return CodigoOperador; }

            set {
                if(CodigoOperador == 1 || CodigoOperador == 2 || CodigoOperador == 3)
                {
                    CodigoOperador = value;
                }else{
                    CodigoOperador = 0;   
                }

            
            
            }
        }

        public string NumTelefono
        {
            get { return Marca; }
            set{ Marca = value; }
        }

        public string TelContacto
        {
            get { return Contacto; }
            set { Contacto = value;}
        }

        //Constructor: Agregar Constructor que reciba Modelo y Marca

        public Telefono(string Modelo, string Marca)
        {
            this.Modelo = Modelo;
            this.Marca = Marca;
        }

        // Metodo
        //Agregar método Llamar() sin parámetros que devuelva un string con la leyenda "Realizando llamada...".
        public string Llamar()
        {
            return "Llamando a ..." + NumTelefono;
        }

        //Sobrecarga de Metodo
        //Sobrecargar el método Llamar(string contacto) para que reciba un contacto y
        //devuelva un string con la leyenda "Llamando a " + contacto

        public string Llamar(string Contacto)
        {
            return "Llamando a... " + TelContacto;
        }


    }
}

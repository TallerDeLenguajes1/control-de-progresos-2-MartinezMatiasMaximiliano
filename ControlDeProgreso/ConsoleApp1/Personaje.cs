using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Personaje
    {
        enum Maximos
        {
            velocidad = 10,
            destreza = 5,
            fuerza = 10,
            nivel = 10,
            armadura = 10
        };

        public class Caracteristicas
        {
            private int velocidad;
            private int destreza;
            private int fuerza;
            private int nivel;
            private int armadura;

            public int Velocidad { get => velocidad; set => velocidad = value; }
            public int Destreza { get => destreza; set => destreza = value; }
            public int Fuerza { get => fuerza; set => fuerza = value; }
            public int Nivel { get => nivel; set => nivel = value; }
            public int Armadura { get => armadura; set => armadura = value; }
        }

        public class Datos
        {
            private string tipo;
            private string nombre;
            private string apodo;
            private DateTime fechaNac;
            private int salud;

            public string Tipo { get => tipo; set => tipo = value; }
            public string Nombre { get => nombre; set => nombre = value; }
            public string Apodo { get => apodo; set => apodo = value; }
            public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
            public int Salud { get => salud; set => salud = value; }
        }


    }
}

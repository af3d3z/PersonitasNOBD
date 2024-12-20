﻿using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Listados
    {
        private static List<Persona> _listaPersonas = ObtenerPersonas();
        private static List<Departamento> _listaDepartamentos = ObtenerDepartamentos();

        public static List<Persona> ListaPersonas
        {
            get { return _listaPersonas; }
            set { _listaPersonas = value; }
        }

        public static List<Departamento> ListaDepartamentos
        {
            get { return _listaDepartamentos; }
            set { _listaDepartamentos = value; }
        }

        /// <summary>
        /// Devuelve un listado de Personas
        /// </summary>
        /// <returns>List<Persona> Listado de personas inicial</returns>
        public static List<Persona> ObtenerPersonas() { 
            List<Persona> listadoPersonas = new List<Persona>();
            listadoPersonas.Add(new Persona(1, "Antonio", "Morilla", "https://thispersondoesnotexist.com/", new DateTime(2000, 06, 03), 3));
            listadoPersonas.Add(new Persona(2, "María", "González", "https://thispersondoesnotexist.com/", new DateTime(1995, 02, 14), 4));
            listadoPersonas.Add(new Persona(3, "Luis", "Pérez", "https://thispersondoesnotexist.com/", new DateTime(1990, 11, 21), 2));
            listadoPersonas.Add(new Persona(4, "Laura", "Sánchez", "https://thispersondoesnotexist.com/", new DateTime(1985, 07, 10), 5));
            listadoPersonas.Add(new Persona(5, "Carlos", "Rodríguez", "https://thispersondoesnotexist.com/", new DateTime(2001, 03, 30), 1));
            listadoPersonas.Add(new Persona(6, "Ana", "Martínez", "https://thispersondoesnotexist.com/", new DateTime(1998, 09, 18), 3));
            listadoPersonas.Add(new Persona(7, "David", "Hernández", "https://thispersondoesnotexist.com/", new DateTime(1992, 12, 25), 2));
            listadoPersonas.Add(new Persona(8, "Carmen", "López", "https://thispersondoesnotexist.com/", new DateTime(1987, 04, 16), 4));
            listadoPersonas.Add(new Persona(9, "José", "García", "https://thispersondoesnotexist.com/", new DateTime(2000, 01, 07), 1));
            listadoPersonas.Add(new Persona(10, "Raquel", "Martín", "https://thispersondoesnotexist.com/", new DateTime(1993, 10, 22), 5));
            listadoPersonas.Add(new Persona(11, "Pedro", "Ferrer", "https://thispersondoesnotexist.com/", new DateTime(1980, 06, 15), 3));
            listadoPersonas.Add(new Persona(12, "Isabel", "Córdoba", "https://thispersondoesnotexist.com/", new DateTime(1996, 08, 04), 4));
            listadoPersonas.Add(new Persona(13, "Francisco", "Jiménez", "https://thispersondoesnotexist.com/", new DateTime(2002, 12, 30), 2));
            listadoPersonas.Add(new Persona(14, "Elena", "Álvarez", "https://thispersondoesnotexist.com/", new DateTime(1988, 05, 02), 5));
            listadoPersonas.Add(new Persona(15, "Javier", "Ramírez", "https://thispersondoesnotexist.com/", new DateTime(1997, 11, 19), 1));
            listadoPersonas.Add(new Persona(16, "Sara", "Vázquez", "https://thispersondoesnotexist.com/", new DateTime(1994, 09, 05), 3));
            listadoPersonas.Add(new Persona(17, "Manuel", "Moreno", "https://thispersondoesnotexist.com/", new DateTime(1991, 03, 12), 2));
            listadoPersonas.Add(new Persona(18, "Marta", "Ruiz", "https://thispersondoesnotexist.com/", new DateTime(1986, 01, 20), 4));
            listadoPersonas.Add(new Persona(19, "Antonio", "Torres", "https://thispersondoesnotexist.com/", new DateTime(2003, 10, 15), 5));
            listadoPersonas.Add(new Persona(20, "José", "Fernández", "https://thispersondoesnotexist.com/", new DateTime(1999, 04, 28), 1));
            listadoPersonas.Add(new Persona(21, "Patricia", "Gutiérrez", "https://thispersondoesnotexist.com/", new DateTime(1990, 07, 11), 3));
            listadoPersonas.Add(new Persona(22, "Ricardo", "Gómez", "https://thispersondoesnotexist.com/", new DateTime(1995, 01, 17), 2));

            return listadoPersonas;
        }

        /// <summary>
        /// Devuelve un listado de departamentos
        /// </summary>
        /// <returns>List<Departamento> Listado de departamentos</returns>
        public static List<Departamento> ObtenerDepartamentos() { 
            List<Departamento> listadoDepartamentos = new List<Departamento>();
            listadoDepartamentos.Add(new Departamento(1, "Contabilidad"));
            listadoDepartamentos.Add(new Departamento(2, "Marketing"));
            listadoDepartamentos.Add(new Departamento(3, "Finanzas"));
            listadoDepartamentos.Add(new Departamento(4, "Combate cuerpo-a-cuerpo"));
            listadoDepartamentos.Add(new Departamento(5, "Informática"));
            listadoDepartamentos.Add(new Departamento(6, "Recursos Humanos"));
            return listadoDepartamentos;
        }
    }
}

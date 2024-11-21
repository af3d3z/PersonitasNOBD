﻿using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ManejadoraPersona
    {
        /// <summary>
        /// Devuelve una persona del listado suministrado en base a su id
        /// PRE: el id debe ser mayor a 0
        /// </summary>
        /// <param name="id"></param>
        /// <param name="listado"></param>
        /// <returns></returns>
        public static Persona GetPersona(int id) {
            int contador = 0;
            bool encontrado = false;
            Persona persona = new Persona();
            List<Persona> listaPersonas = Listados.ObtenerPersonas();
            while (contador < listaPersonas.Count && !encontrado) {
                persona = listaPersonas[contador];
                if (persona.Id == id) {
                    encontrado = true;
                }
                contador++;
            }

            return persona;
        }

        /// <summary>
        /// Agrega una persona a la lista de personas de la clase listado
        /// PRE: Que la persona esté rellena y sin nulos
        /// </summary>
        /// <param name="persona"></param>
        public static void AgregarPersona(Persona persona) {
            List<Persona> listadoPersonas = Listados.ListaPersonas;
            listadoPersonas.Add(persona);
            Listados.ListaPersonas = listadoPersonas;
        }

        /// <summary>
        /// Edita una persona en el listado de la capa DAL
        /// </summary>
        /// <param name="persona"></param>
        public static bool EditarPersona(Persona persona) {
            List<Persona> listadoPersonas = Listados.ListaPersonas;
            int contador = 0;
            bool encontrado = false;
            while (contador < listadoPersonas.Count && !encontrado) {
                if (listadoPersonas[contador].Id == persona.Id)
                {
                    encontrado = true;
                    listadoPersonas[contador] = persona;
                }
                contador++;
            }

            return encontrado;
        }
    }
}
﻿using ENT;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            Persona persona = new Persona();
            persona = Listados.ListaPersonas.Where(p => p.Id == id).FirstOrDefault();

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
            bool encontrado = false;
            int index = listadoPersonas.FindIndex(per => per.Id == persona.Id);
            if (index != -1) { 
                listadoPersonas[index] = persona;
                encontrado = true;
            }

            return encontrado;
        }

        /// <summary>
        /// Elimina una persona del listado de la capa DAL
        /// PRE: debe tener al menos el ID
        /// </summary>
        /// <param name="persona"></param>
        /// <returns></returns>
        public static bool EliminarPersona(Persona persona) {
            Persona personaBusqueda = Listados.ListaPersonas.Where(p => p.Id == persona.Id).FirstOrDefault();
            return Listados.ListaPersonas.Remove(personaBusqueda);
        }
    }
}

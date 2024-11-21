﻿using BL;
using ENT;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Personitas.Models.ViewModels;

namespace Personitas.Controllers
{
    public class PersonaController : Controller
    {
        // GET: PersonaController
        public ActionResult Index()
        {
            List<PersonaDepartamentoVM> listaPersonasDpto = new List<PersonaDepartamentoVM>();
            List<Persona> listadoPersonas = ListadosBL.GetListaPersonasBL();
            try
            {
                foreach (Persona per in listadoPersonas) {
                    PersonaDepartamentoVM personaDpto = new PersonaDepartamentoVM(per);
                    listaPersonasDpto.Add(personaDpto);
                } 
            }
            catch (Exception e) {
                //todo implementar excepcion
                throw e;
            }
            return View(listaPersonasDpto);
        }

        // GET: PersonaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PersonaController/Create
        public ActionResult Create()
        {
            List <Departamento> listadoDepartamentos = ListadosBL.GetListaDepartamentosBL();
            return View(listadoDepartamentos);
        }

        // POST: PersonaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Persona persona)
        {
            try
            {
                persona.Id = ListadosBL.GetNumeroPersonas() + 1;
                ManejadoraPersonaBL.AgregarPersonaBL(persona);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonaController/Edit/5
        public ActionResult Edit(int id)
        {
            PersonaListaDepartamentos personaDepartamentos = new PersonaListaDepartamentos(ManejadoraPersonaBL.GetPersonaBL(id));
            return View(personaDepartamentos);
        }

        // POST: PersonaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Persona persona)
        {
            try
            {
                if (ManejadoraPersonaBL.EditarPersona(persona))
                {
                    return RedirectToAction(nameof(Index));
                }
                else {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PersonaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

using BL;
using DAL;
using ENT;
using PersonitasMAUI.Models.Utilidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PersonitasMAUI.Models.ViewModels
{
    public class ListaPersonasConNombreDpto: PersonitasMAUI.Models.Utilidades.clsVMBase
    {
        #region atributos
        private DelegateCommand? _btnEliminarCommand;
        private DelegateCommand? _btnAgregarCommand;
        private PersonaConNombreDepartamento _personaSeleccionada = new PersonaConNombreDepartamento();
        private List<PersonaConNombreDepartamento> _listadoPersonasNombreDepartamento = new List<PersonaConNombreDepartamento>();
        #endregion


        #region properties
        public List<PersonaConNombreDepartamento> ListadoPersonasNombreDepartamento {
            get {
                return _listadoPersonasNombreDepartamento;
            }
        }

        public DelegateCommand BtnEliminarCommand { get { return _btnEliminarCommand; } }
        
        public DelegateCommand BtnAgregarCommand { get { return _btnAgregarCommand; } }

        public PersonaConNombreDepartamento PersonaSeleccionada
        {
            get { return _personaSeleccionada; }
            set {
                _personaSeleccionada = value;
                _btnEliminarCommand?.RaiseCanExecuteChanged();
                Console.WriteLine("Potato");
                NotifyPropertyChanged("PersonaSeleccionada");
               
            }
        }
        #endregion

        public ListaPersonasConNombreDpto() { 
            List<Departamento> departamentos = BL.ListadosBL.GetListaDepartamentosBL();
            List<Persona> personas = BL.ListadosBL.GetListaPersonasBL();

            foreach (Persona persona in personas){
                this._listadoPersonasNombreDepartamento.Add(new PersonaConNombreDepartamento(persona, departamentos));
            }

            this.PersonaSeleccionada = _listadoPersonasNombreDepartamento.FirstOrDefault();

            this._btnEliminarCommand = new DelegateCommand(btnEliminarCommand_Execute, btnEliminarCommand_CanExecute);
            this._btnAgregarCommand = new DelegateCommand(btnAgregarCommand_Execute);
        }

        public void ActualizarLista() {
            List<Departamento> departamentos = BL.ListadosBL.GetListaDepartamentosBL();
            List<Persona> personas = BL.ListadosBL.GetListaPersonasBL();

            foreach (Persona persona in personas)
            {
                this._listadoPersonasNombreDepartamento.Add(new PersonaConNombreDepartamento(persona, departamentos));
            }
        }

        public ListaPersonasConNombreDpto(int idPersonaSeleccionada) {
            this._btnEliminarCommand = new DelegateCommand(btnEliminarCommand_Execute, btnEliminarCommand_CanExecute);
            this.PersonaSeleccionada = this._listadoPersonasNombreDepartamento.Where(per => per.Id == idPersonaSeleccionada).FirstOrDefault();
        }

        #region commands
        /// <summary>
        /// Verifica si se puede ejecutar o no el btn
        /// </summary>
        /// <returns></returns>
        private bool btnEliminarCommand_CanExecute() {
            bool canExecute = false;
            if (_personaSeleccionada != null) {
                canExecute = true;
            }

            return canExecute;
        }

        /// <summary>
        /// Elimina del listado la persona seleccionada
        /// </summary>
        private void btnEliminarCommand_Execute() {
            this._listadoPersonasNombreDepartamento.Remove(this._personaSeleccionada);
        }

        /// <summary>
        /// Redirige al usuario a la vista de agregado
        /// </summary>
        private async void btnAgregarCommand_Execute() {
            await Shell.Current.GoToAsync("//Agregar");
        }
        #endregion
    }
}

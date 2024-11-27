﻿using ENT;
using PersonitasMAUI.Models.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonitasMAUI.Models.ViewModels
{
    public class EditarVM : Persona
    {
        #region atributos
        private List<Departamento> _departamentos;
        private Departamento _departamentoSeleccionado;
        private DelegateCommand? _btnGuardar;
        private DelegateCommand? _btnVolver;
        #endregion

        #region propiedades
        public List<Departamento> Departamentos {
            get { return _departamentos; }
        }

        public Departamento DepartamentoSeleccionado {
            get { return _departamentoSeleccionado; }
            set { _departamentoSeleccionado = value; }
        }

        public DelegateCommand BtnGuardar { get { return _btnGuardar; } }
        public DelegateCommand BtnVolver { get { return _btnVolver; } }
        #endregion


        #region constructores
        public EditarVM(Persona persona): base(persona) {
            this._departamentos = BL.ListadosBL.GetListaDepartamentosBL();
            this._departamentoSeleccionado = _departamentos.FirstOrDefault();
            this._btnGuardar = new DelegateCommand(BtnGuardar_Execute, BtnGuardar_CanExecute);
            this._btnVolver = new DelegateCommand(BtnVolver_Execute);
        }
        #endregion

        #region commands
        private bool BtnGuardar_CanExecute() {
            bool canExecute = false;
            if (this.Nombre != string.Empty && this.Apellidos != string.Empty && this.Foto != string.Empty) {
                canExecute = true;
            }
            return canExecute;
        }

        private void BtnGuardar_Execute() {
            BL.ManejadoraPersonaBL.EditarPersonaBL(new Persona(this.Id, this.Nombre, this.Apellidos, this.Foto, this.FechaNacimiento, this._departamentoSeleccionado.ID));
            BtnVolver_Execute();
        }

        private void BtnVolver_Execute() {
            Shell.Current.GoToAsync("//MainPage");
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;

namespace Examen1ParcialPrograNegocios
{
    public class Empleado : INotifyPropertyChanged
    {
        // Variables 
        private string SueldoSinDeducciones;
        private string SueldoHorasExtra;
        private string SueldoTotal;

        // Propiedades

        
        public string sueldoSinDeducciones
        {
            get { return SueldoSinDeducciones; }
            set
            {
                decimal sueldo;
                //sueldo = 

                OnPropertyChanged("horasTrabajadas");
                OnPropertyChanged("sueldo");
            }
        }
        
    /* public string GetSueldoSinDeducciones()
        { return GetSueldoSinDeducciones(); }

        // Propiedades
        public void SetSueldoSinDeducciones(string value)
        {
            int horas;
            decimal sueldo;

            sueldo = horas * int.Parse();

            OnPropertyChanged("horasTrabajadas");
            OnPropertyChanged("s");
        }


        public string GetSueldoHorasExtra()
        { return GetSueldoHorasExtra(); }

        // Propiedades
        public void SetSueldoHOrasExtras(string value)
        {
            int horas;
            decimal sueldo;

            //sueldo = horas * int.Parse(PagoPorHoraNormal);

            OnPropertyChanged("Horas trabajadas");
            OnPropertyChanged("Pago de las horas trabajadas");
        }*/


        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
}

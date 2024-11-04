using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrpoLabs.WpfApp.ViewModel
{
    public class CalculateAreaViewModel : INotifyPropertyChanged
    {
        private double _radio;
        private double _altura;
        private double _resultado;

        public double Radio
        {
            get { return _radio; }
            set
            {
                if (_radio != value)
                {
                    _radio = value;
                    OnPropertyChanged(nameof(Radio));
                    CalcularArea(); 
                }
            }
        }

        public double Altura
        {
            get { return _altura; }
            set
            {
                if (_altura != value)
                {
                    _altura = value;
                    OnPropertyChanged(nameof(Altura));
                    CalcularArea(); 
                }
            }
        }

        public double Resultado
        {
            get { return _resultado; }
            private set
            {
                if (_resultado != value)
                {
                    _resultado = value;
                    OnPropertyChanged(nameof(Resultado));
                }
            }
        }

        private void CalcularArea()
        {
            Resultado = Math.PI * Radio * (Radio + Math.Sqrt((Altura * Altura) + (Radio * Radio)));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
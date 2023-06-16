using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_MVVM_ColorViever;

namespace WPF_MVVM_ColorViever
{
    internal class Colore : INotifyPropertyChanged
    {
        private byte alpha;
        private byte red;
        private byte green;
        private byte blue;

        public byte Alpha
        {
            get { return alpha; }
            set
            {
                alpha = value;
                OnPropertyChanged("Alpha"); 
            }
        }
        public byte Red
        {
            get { return red; }
            set
            {
                red = value;
                OnPropertyChanged("Red");
            }
        }
        public byte Green
        {
            get { return green; }
            set
            {
                green = value;
                OnPropertyChanged("Green");
            }
        }
        public byte Blue
        {
            get { return blue; }
            set
            {
                blue = value;
                OnPropertyChanged("Blue");
            }
        }
        public string ColorCode
        {
            get
            {
                return ColoreViewModel.GetColorSum(Alpha, Red, Green, Blue);
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
       
        protected virtual void OnPropertyChanged(string propColor)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propColor));
        }   
    }
}

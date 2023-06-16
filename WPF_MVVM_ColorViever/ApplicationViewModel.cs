using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WPF_MVVM_ColorViever
{
    class ApplicationViewModel : INotifyPropertyChanged
    {
        private byte alfaSld = 0;
        private byte blueSld = 0;
        private byte greenSld = 0;
        private byte redSld = 0;
        private Colore? selectColor;
        private SolidColorBrush colorBorder;
        public ObservableCollection<Colore> Colors { get; set; }
        public ApplicationViewModel()
        {
            Colors = new ObservableCollection<Colore>();
        }

        public SolidColorBrush ColorBorder
        {
            get { return colorBorder; }
            set
            {
                colorBorder = value;
                OnPropertyChanged("ColorBorder");
            }
        }
        public byte AlfaSld
        {
            get { return alfaSld; }
            set
            {
                alfaSld = value;
                OnPropertyChanged("AlfaSld");
                BuildingCode();
            }
        }
        public byte BlueSld
        {
            get { return blueSld; }
            set
            {
                blueSld = value;
                OnPropertyChanged("BlueSld");
                BuildingCode();
            }
        }
        public byte GreenSld
        {
            get { return greenSld; }
            set
            {
                greenSld = value;
                OnPropertyChanged("GreenSld");
                BuildingCode();


            }
        }
        public byte RedSld
        {
            get { return redSld; }
            set
            {
                redSld = value;
                OnPropertyChanged("RedSld");
                BuildingCode();


            }
        }

        public void BuildingCode()
        {
            ColorBorder = new SolidColorBrush(Color.FromArgb(AlfaSld, RedSld, GreenSld, BlueSld));
        }

        public Colore SelectColor
        {
            get { return selectColor; }
            set
            {
                selectColor = value;
                OnPropertyChanged("SelectColor");
            }
        }
        // команда добавления нового объекта
        RelayCommand? addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                  (addCommand = new RelayCommand(obj =>
                  {
                      Colore clr = new Colore {Alpha= alfaSld, Red =redSld,Green=GreenSld,Blue=BlueSld};
                      Colors.Insert(0, clr);
                      
                  }));
            }
        }

        // команда удаления
        RelayCommand? removeCommand;
        public RelayCommand RemoveCommand
        {
            get
            {
                return removeCommand ??
                  (removeCommand = new RelayCommand(obj =>
                  {
                      Colore? clr = obj as Colore;
                      if (clr != null)
                      {
                          Colors.Remove(clr);
                      }
                  },
                 (obj) => Colors.Count > 0));
            }
        }

        

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}

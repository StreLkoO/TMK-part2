using System.ComponentModel;

namespace WindowsFormsApp1.Models
{
    class FilterDgv : INotifyPropertyChanged
    {

        private int _Number;
        public int Number
        {
            get => _Number;
            set
            {
                _Number = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Number)));
            }
        }


        private string _IsOk;
        public string IsOk
        {
            get => _IsOk;
            set
            {
                _IsOk = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsOk)));
            }
        }


        private string _SteelGrade;
        public string SteelGrade
        {
            get => _SteelGrade;
            set
            {
                _SteelGrade = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SteelGrade)));
            }
        }

        private int _Lenght;
        public int Lenght
        {
            get => _Lenght;
            set
            {
                _Lenght = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Lenght)));
            }
        }

        private int _Radius;
        public int Radius
        {
            get => _Radius;
            set
            {
                _Radius = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Radius)));
            }
        }

        private int _Weight;
        public int Weight
        {
            get => _Weight;
            set
            {
                _Weight = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Weight)));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
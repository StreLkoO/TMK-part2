using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TMK_plus_plus.Classes
{
    [Serializable]
    public class Pipe : IDataErrorInfo
    {
        public int Number { get; set; }
        public bool IsOk { get; set; }
        public string SteelGrade { get; set; } = "";
        public int Lenght { get; set; }
        public int Radius { get; set; }
        public int Weight { get; set; }

        public string Error => string.Empty;
        public string this[string columnName]
        {
            get
            {
                if (columnName.Equals(nameof(SteelGrade)) && !Program.SteelGrades.Exists(x => x == SteelGrade))
                {
                    return "Выберите марку стали";
                }
                if (columnName.Equals(nameof(Lenght)) && Lenght <= 0)
                {
                    return "Введите длинну в см";
                }
                if (columnName.Equals(nameof(Radius)) && Radius <= 0)
                {
                    return "Введите радиус в см";
                }
                if (columnName.Equals(nameof(Weight)) && Weight <= 0)
                {
                    return "Введите вес в килограммах";
                }
                return string.Empty;
            }
        }

        public Object Clone() => MemberwiseClone();

        public Pipe(object[] objects)
        {
            Number = (int)objects[0];
            IsOk = (bool)objects[1];
            SteelGrade = (string)objects[2];
            Lenght = (int)objects[3];
            Radius = (int)objects[4];
            Weight = (int)objects[5];
        }

        public Pipe()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMK_plus_plus.Classes
{
    [Serializable]
    public class PipePackage : IDataErrorInfo, ICloneable
    {
        public int Number { get; set; }
        public DateTime DateCreate { get; set; }
        public string Error => String.Empty;
        public string this[string columnName]
        {
            get
            {
                if (columnName.Equals(nameof(DateCreate)) &&
                    (DateCreate <= DateTime.Now.AddYears(-5) || DateCreate > DateTime.Now))
                {
                    return "Введите дату создания правильно";
                }
                return String.Empty;
            }
        }

        public object Clone()
        {
            return MemberwiseClone();
        }


        override public bool Equals(object? o)
        {
            if (o == null) { return false; }
            if (o == this) { return true; }
            if (o == DBNull.Value) { return false; }
            if (o.GetType() != typeof(PipePackage)) { return false; }
            PipePackage p = (PipePackage)o;
            return p.Number == Number;
        }

    }
}

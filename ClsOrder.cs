using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class ClsOrder
    {
        private string plat;
        private string sum;
        private string pol;
        public string PLAT
        {
            get { return plat; }
            set { plat = value; }
        }
        public string POL
        {
            get { return pol; }
            set { pol = value; }
        }
        public string SUM
        {
            get { return sum; }
            set { sum = value; }
        }
        public ClsOrder()
        {
            plat = "";
            sum = "";
            pol = "";
        }
        public ClsOrder(string f, string g, string p)
        {
            plat = f;
            sum = g;
            pol = p;
        }
        public string PrintToScreen()
        {
            string line = $"Расчетный счет плательщика {plat}" + "\n";
            line += $"Расчетный счет получателя {pol}" + "\n";
            line += $"Перечисляемая сумма {sum}" + "\n";
            return line;
        }
        public void SaveToFile(string filename)
        {
            StreamWriter streamWriter = new StreamWriter(filename, true, Encoding.Default);
            streamWriter.WriteLine("Данные перевода");
            streamWriter.WriteLine($"Расчетный счет плательщика: {plat}");
            streamWriter.WriteLine($"Расчетный счет получателя: {pol}");
            streamWriter.WriteLine($"Перечисляемая сумма: {sum}");
            streamWriter.Close();
        }
    }
}

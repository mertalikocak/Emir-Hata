using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emir_Hata
{
    internal class Fault//Duruş sınıfı
    {
        private string faultName;//değişkenler
        private DateTime start;
        private double faultLong;
        private DateTime end;

        public Fault(string faultName, DateTime start, double faultLong)// değişkenlerin süreleri değişkenlik gösterdiği için uzunluklarıda parametre olarak alınır.
        {
            this.faultName = faultName;
            this.start = start;
            this.faultLong = faultLong;
            end = start.AddMinutes(faultLong);//uzunluk starta eklenir bitiş bulunur.
        }

        public string FaultName { get => faultName; set => faultName = value; }//get set metodları.
        public DateTime Start { get => start; set => start = value; }
        public double FaultLong { get => faultLong; set => faultLong = value; }
        public DateTime End { get => end; set => end = value; }

        
    }
}

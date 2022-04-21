using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emir_Hata
{
    internal class Work : ICloneable //İş sınıfı tanımlanır. Klonlamak için implement edilir.
    {
        private string jobNo;//Değişkenler tanımlanır.
        private DateTime start;
        const double jobLong = 8;// Tüm işlerin  süreleri sabit olduğu için bu süreyi parametre olarak almadım. Farklı olması durumunda constructor güncellenerek parametre alınabilir.
        private DateTime end;

        public Work(string jobNo, DateTime start)//iş numarası ve başlangıç alınır. Başlangıca joblong eklenir bitiş bulunur.
        {
            this.jobNo = jobNo;
            this.start = start;
           
            end= start.AddHours(jobLong);
        }


        public string JobNo { get => jobNo; set => jobNo = value; }//Get set metodları
        public DateTime Start { get => start; set => start = value; }
        public DateTime End { get => end; set => end = value; }

        public object Clone()//klon metodu
        {
            return new Work(this.jobNo,this.Start);
        }
    }
}

namespace Emir_Hata
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         static class Global
        {

            //İş Emirleri tanımlanır
            public static Work job1 = new Work("J000101", new DateTime(2020, 01, 01, 08, 00, 00));
            public static Work job2 = new Work("J000102", job1.End);
            public static Work job3 = new Work("J000103", job2.End);
            public static Work job4 = new Work("J000104", job3.End);
            public static Work job5 = new Work("J000105", job4.End);
            public static Work job6 = new Work("J000106", job5.End);
            public static Work job7 = new Work("J000107", job6.End);
            public static Work job8 = new Work("J000108", job7.End);
            public static Work job9 = new Work("J000109", job8.End);

            //emirler listede tutulur
            public static Work[] jobs = new Work[] { job1, job2, job3, job4, job5, job6, job7, job8, job9 };

            //duruşlar tanımlanır
            public static Fault fault1 = new Fault("Araba Yok", new DateTime(2020, 01, 01, 10, 00, 00), 10);
            public static Fault fault2 = new Fault("Arıza", new DateTime(2020, 01, 01, 10, 30, 00), 30);
            public static Fault fault3 = new Fault("Araba Yok", new DateTime(2020, 01, 01, 12, 00, 00), 30);
            public static Fault fault4 = new Fault("Araba Yok", new DateTime(2020, 01, 01, 14, 00, 00), 10);
            public static Fault fault5 = new Fault("Mal Yok", new DateTime(2020, 01, 01, 15, 00, 00), 90);
            public static Fault fault6 = new Fault("Araba Yok", new DateTime(2020, 01, 01, 18, 00, 00), 10);
            public static Fault fault7 = new Fault("Araba Yok", new DateTime(2020, 01, 01, 20, 00, 00), 30);
            public static Fault fault8 = new Fault("Araba Yok", new DateTime(2020, 01, 01, 22, 00, 00), 10);
            public static Fault fault9 = new Fault("Enerji Kesildi", new DateTime(2020, 01, 01, 23, 00, 00), 570);
            public static Fault fault10 = new Fault("Araba Yok", new DateTime(2020, 01, 02, 10, 00, 00), 10);
            public static Fault fault11 = new Fault("Araba Yok", new DateTime(2020, 01, 02, 12, 00, 00), 30);
            public static Fault fault12 = new Fault("Arıza", new DateTime(2020, 01, 02, 13, 00, 00), 45);
            public static Fault fault13 = new Fault("Araba Yok", new DateTime(2020, 01, 02, 14, 00, 00), 10);
            public static Fault fault14 = new Fault("Araba Yok", new DateTime(2020, 01, 02, 18, 00, 00), 10);
            public static Fault fault15 = new Fault("Enerji Kesildi", new DateTime(2020, 01, 02, 20, 00, 00), 370);
            public static Fault fault16 = new Fault("Araba Yok", new DateTime(2020, 01, 03, 04, 00, 00), 30);
            public static Fault fault17 = new Fault("Mal Yok", new DateTime(2020, 01, 03, 06, 00, 00), 210);
            public static Fault fault18 = new Fault("Araba Yok", new DateTime(2020, 01, 03, 10, 00, 00), 10);
            public static Fault fault19 = new Fault("Araba Yok", new DateTime(2020, 01, 03, 12, 00, 00), 30);
            public static Fault fault20 = new Fault("Araba Yok", new DateTime(2020, 01, 03, 14, 00, 00), 10);
            public static Fault fault21 = new Fault("Arıza", new DateTime(2020, 01, 03, 15, 00, 00), 225);
            public static Fault fault22 = new Fault("Araba Yok", new DateTime(2020, 01, 03, 20, 00, 00), 30);
            public static Fault fault23 = new Fault("Araba Yok", new DateTime(2020, 01, 03, 22, 00, 00), 10);


            //duruşlar listede tutulur
            public static Fault[] faults = {fault1, fault2, fault3, fault4, fault5, fault6, fault7, fault8, fault9, fault10, fault11, fault12, fault13, fault14
            , fault15, fault16, fault17, fault18, fault19, fault20, fault21, fault22, fault23 };


        }

        private void LoadListView(int buttonNo)
        {
            if (buttonNo == 1) { //İş emir listesi butonu
                listView1.Items.Clear();
                this.columnHeader1.Text = "İş Emir Numarası";//sütunlar butona göre düzenleniyor
                this.columnHeader2.Text = "Başlangıç";
                this.columnHeader3.Text = "Bitiş";
                this.columnHeader4.Text = "";
                this.columnHeader5.Text = "";
                this.columnHeader6.Text = "";
                this.columnHeader7.Text = "";
                foreach (var job in Global.jobs)//işler ve zamanları tabloya eklenip gösterilyor.
                {
                    string[] rowa = { job.JobNo, job.Start.ToString("g"), job.End.ToString("g") };
                    var listItema = new ListViewItem(rowa);
                    listView1.Items.Add(listItema);
                }
            }
            else if (buttonNo == 2)//Duruş listesi butonu
            {
                listView1.Items.Clear();
                this.columnHeader1.Text = "Duruş Nedeni";//sütunlar butona göre düzenleniyor
                this.columnHeader2.Text = "Başlangıç";
                this.columnHeader3.Text = "Bitiş";
                this.columnHeader4.Text = "";
                this.columnHeader5.Text = "";
                this.columnHeader6.Text = "";
                this.columnHeader7.Text = "";
                foreach (var fault in Global.faults)//Duruşlar ve zamanları tabloya eklenip gösteriliyor.
                {
                    string[] rowa = { fault.FaultName, fault.Start.ToString("g"), fault.End.ToString("g") };
                    var listItema = new ListViewItem(rowa);
                    listView1.Items.Add(listItema);
                }
            }
            else if (buttonNo == 3)//Hangi İş Emrinin ne kadar süre durduğunu ve geciktiğini hesaplayan buton
            {
               
                listView1.Items.Clear();
                this.columnHeader1.Text = "İş Emri Numarası";//sütunlar butona göre düzenleniyor
                this.columnHeader2.Text = "Araba Yok";
                this.columnHeader3.Text = "Arıza";
                this.columnHeader4.Text = "Mal Yok";
                this.columnHeader5.Text = "Enerji Kesildi";
                this.columnHeader6.Text = "Toplam";
                this.columnHeader7.Text = "Gecikme Süresi";
                double durustoplam = 0;//Sadece duraksamaları tutacak değişken.
                double gecikmeSuresi = 0;//İşin ne kadar geç başladığını tutan değişken
                foreach (var job in Global.jobs)//İşleri tek tek geziyoruz.
                {
                    Work jobCopy = job.Clone() as Work;//Orjinal nesnelerde değişiklik olmaması için klonladık.
                    jobCopy.Start = jobCopy.Start.AddMinutes(gecikmeSuresi + durustoplam);//İşlerin başlama süresini dursama ve gecikme süresine göre ileriye çekiyoruz.
                    jobCopy.End = jobCopy.End.AddMinutes(durustoplam + gecikmeSuresi);//işlerin bitiş süreleride aynı oranda ileriye kayıyor.
                    gecikmeSuresi += durustoplam;//Gecikme süresi bir önceki işin ne kadar durduğuna bağlı olarak hesaplanıyor.
                    double arabayok = 0;//duruşların countları.
                    double ariza = 0;
                    double malyok = 0;
                    double elektrik = 0;
                    durustoplam = 0;
                    int startIndex = 0;//Her duruş tek bir işi etkilediği için tüm listeyi sürekli gezmemek adına index tutuyoruz.
                    for (int i = startIndex; i < Global.faults.Length; i++)//duruşları tek tek geziyoruz.
                    {
                        var fault = Global.faults[i];
                        if (jobCopy.Start < fault.Start && jobCopy.End > fault.Start)//Eğer duruşun başlangıç saati işin başlangıç ve bitiş saati içindeyse tüm duruş süresi o işin süresine eklenir.
                        {
                            jobCopy.End = jobCopy.End.AddMinutes(fault.FaultLong);//bitiş saati kayıyor.

                            if (fault.FaultName == "Araba Yok")//countlar duruşun uzunluğu kadar artar.
                                arabayok += fault.FaultLong;
                            else if (fault.FaultName == "Arıza")
                                ariza += fault.FaultLong;
                            else if (fault.FaultName == "Mal Yok")
                                malyok += fault.FaultLong;
                            else if (fault.FaultName == "Enerji Kesildi")
                                elektrik += fault.FaultLong;
                        }
                        else if ((jobCopy.Start < fault.End && jobCopy.End > fault.End) || (jobCopy.Start > fault.Start && jobCopy.End < fault.End))
                            // eğer duruşun bitiş süresi işin başlangıç bitiş süreci içine denk geliyorsa veya duruş süresi bütün iş süresini kapsıyorsa
                            // işin başlangıcından itibaren duruşun bitiş süresine kadar geçen süre hesaplanır ve işe eklenir.
                        {
                            TimeSpan gecikme = fault.End - jobCopy.Start;//gecikme duruşun sonu - işin başlangıcıdır.
                            jobCopy.Start = fault.End;//iş duruşun bittiği süreden itibaren başlar.
                            jobCopy.End = jobCopy.End.AddMinutes(gecikme.TotalMinutes);//fark iş sonuna eklenir.

                            if (fault.FaultName == "Araba Yok")//countlar gecikme kadar artar.
                                arabayok += gecikme.TotalMinutes;
                            else if (fault.FaultName == "Arıza")
                                ariza += gecikme.TotalMinutes;
                            else if (fault.FaultName == "Mal Yok")
                                malyok += gecikme.TotalMinutes;
                            else if (fault.FaultName == "Enerji Kesildi")
                                elektrik += gecikme.TotalMinutes;
                        }
                        startIndex++;//verimlilik için index arttırılır.

                    }

                    durustoplam = arabayok + malyok + ariza + elektrik;//toplam duruş süreleri hesaplanır. Bu süreye işin başlama gecikmesi dahil değildir.

                    string[] rowa = { jobCopy.JobNo, arabayok.ToString(), ariza.ToString(), malyok.ToString(), elektrik.ToString(), durustoplam.ToString(), gecikmeSuresi.ToString() };//listelenir.
                    var listItema = new ListViewItem(rowa);
                    listView1.Items.Add(listItema);

                }
                
            }

        listView1.Visible= true;//tablo görünür hale getirilir.
    }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadListView(1);//butonlara basıldığında gerçekleşicek eylem.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadListView(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadListView(3);
        }
    }
}

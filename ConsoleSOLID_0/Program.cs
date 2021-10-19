using ConsoleSOLID_0.DIP.GOOD.Concrete;
using ConsoleSOLID_0.DIP.GOOD.Interfaces;
using ConsoleSOLID_0.LSP.BAD;
using ConsoleSOLID_0.LSP.GOOD.Concrete;
using ConsoleSOLID_0.LSP.GOOD.Interfaces;
using ConsoleSOLID_0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSOLID_0
{
    class Program
    {
        /*
         
         S => Single Responsibility => Bir yapının tekil bir sorumluluga sahip olmasıdır(DantexCrypt , ImageUploader, MailService class'larımızın hepsinin görevi tektir...Baska bir sorumluluk almamıslardır...N-Tier paterninin katmanlarına bakabilirsiniz...Kullandıgımız metotlar hep tekil sorumluluktadır...)

         O => Open Closed => Bir projenin gelişmeye açık değişime kapalı olmasıdır...Değişimden kastımız projenin normalde hicbir hata cıkarmayın ve güzel bir şekilde calısan kaynak kodlarının kökten modifiye edilmesidir...BU sekilde proje degişiyorsa proje Open Closed prensibine aykırıdır...Proje eger gercekten gelişecek ise güzel bir şekilde calısan kodlar bozulmadan üzerine zarif eklemeler yapılarak gelişmesi gerekir...

        L => Liskov's Substitution =>  Bir yapılar kümesinin tek bir çatı altında toplanması halinde bu çatı icerisinde bulunan her nesnenin Base'teki tipinden kullanıldıgı zaman Base'teki her türlü davranısa sadık kalmasıdır...Yani BaseClass tipimizde bir koleksiyon yaratıyorsak ve bu koleksiyon icerisine farklı nesneler alıyorsak BaseClass tipinin her davranışı bu nesnelerin herbiri için anlamlı eylemler olmak zorundadır...

        I=> Interface Segregation => Yarattıgımız Interface'ler icerisinde implement edilmeyecek veye kullanılmayacak metotların yazılmaması gerektigini savunan bir prensiptir...Cünkü böyle yapmak Interface'in gereksiz kodlarla bogulmasına neden olacaktır...


        D=> Dependency Inversion => Yüksek seviyeli bir modülün/yapının / class'ın alt seviyeki bir modeüle tightly coupled bir şekilde baglanmaması gerektigini savunan bir prensiptir...Bu prensibe göre Interface destegi ile modülü loosely coupled bir hale getirmiş oluruz...Böylece bu modül baska yerlere gittiginde de rahatca adapte olabilecektir...
         
         
         
         
         
         
         
         
         
         
         
         
         */












        static void Main(string[] args)
        {

            //List<ITusluCalgi> calgilar = new List<ITusluCalgi>
            //{
            //    new Gitar(), new Piyano()
            //};

            //foreach (ITusluCalgi item in calgilar)
            //{
            //    item.TelliCalgiYontemi();
            //}

            #region LSPIhlali

            //List<Araba> arabalar = new List<Araba>() { new Tofas(), new Ferrari() };
            //foreach (Araba item in arabalar)
            //{
            //    if (item is Tofas)
            //    {
            //        item.Calistir();
            //        continue;
            //    }


            //    item.KlimaCalistir();
            //}

            #endregion


            #region LSPUygun
            //List<IKlima> klimaliArabalar = new List<IKlima> { new GoodFerrari() };

            //foreach (IKlima item in klimaliArabalar)
            //{
            //    item.KlimaCalistir();
            //} 
            #endregion

            List<IProduct> urunler = new List<IProduct>
            {
                new GoodChicken(),new GoodFastFood(),new GoodFish(),new GoodMeze()
            };


            GoodRestaurant gr = new GoodRestaurant(urunler);

            Console.WriteLine(gr.GenerateInstructions());

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phoneDirectory
{
    public class directoryManage
    {
        Person person = new Person();

        List<List<object>> disListe = new List<List<object>>();

        public void personSave()
        {
            Console.Write("İsim Giriniz:");
            person.name = Console.ReadLine();

            Console.Write("Soyisim Giriniz:");
            person.surName = Console.ReadLine();

            Console.Write("Telefon Numarası girin");
            person.phoneNumber = Convert.ToInt32(Console.ReadLine());

            List<object> icListe1 = new List<object>();
            icListe1.Add(person.phoneNumber);
            icListe1.Add(person.name);
            icListe1.Add(person.surName);

            disListe.Add(icListe1);
        }

        public void personDelete()
        {

        }

        public void personUpdate()
        {

        }

        public void personList()
        {
            Console.WriteLine("Dış Liste:");
            foreach (var icListe in disListe)
            {
                Console.Write("[ ");
                foreach (var eleman in icListe)
                {
                    Console.Write(eleman + " ");
                }
                Console.WriteLine("]");
            }
        }

        public void personSearch()
        {

        }

    }
}

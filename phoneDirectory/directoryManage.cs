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

        List<List<string>> disListe = new List<List<string>>();

        public void personSave()
        {
            Console.Write("İsim Giriniz: ");
            person.name = Console.ReadLine();

            Console.Write("Soyisim Giriniz: ");
            person.surName = Console.ReadLine();

            Console.Write("Telefon Numarası girin: ");
            person.phoneNumber = Console.ReadLine();

            List<string> icListe1 = new List<string>();
            icListe1.Add(person.phoneNumber);
            icListe1.Add(person.name);
            icListe1.Add(person.surName);

            disListe.Add(icListe1);

            Console.WriteLine("! " + icListe1[1] + " Kişisi Listeye eklendi.");
            personList();
        }

        public void personDelete()
        {
            personList();
            Console.Write("Silmek istediğiniz kişinin adını giriniz: ");
            string deleteName = Console.ReadLine();


            for (int i = 0; i < disListe.Count; i++)
            {
                int index = disListe[i][1].IndexOf(deleteName);

                if (index != -1) // Aranan isim bulunduysa
                {
                    Console.WriteLine($"İsim: {disListe[i][1]}");
                    Console.WriteLine($"Soyisim: {disListe[i][2]}");
                    Console.WriteLine($"Telefon Numarası: {disListe[i][0]}");
                    Console.WriteLine(); 
                    Console.WriteLine("Silmek istediğiniz emin olmak için kişinin tam ismini giriniz");
                    string fullName = Console.ReadLine();

                    if(disListe[i][1] == fullName)
                    {
                        disListe.RemoveAt(i);
                        Console.WriteLine(fullName + "Adlı kişi listenizden silindi.");
                        Console.WriteLine();

                    }else
                    {
                        Console.WriteLine("İsim doğru girilmedi lütfen yeni bir işlem seçin.");
                        Console.WriteLine();
                        break;
                    }
                

                    
                }
                
            }


        }

        public void personUpdate()
        {

        }

        public void personList()
        {
            Console.WriteLine();
            Console.WriteLine("**********************Rehber**********************");
            for (int i = 0; i < disListe.Count; i++)
            {
                Console.WriteLine($"Kişi {i + 1}:");
                Console.WriteLine($"İsim: {disListe[i][1]}");
                Console.WriteLine($"Soyisim: {disListe[i][2]}");
                Console.WriteLine($"Telefon Numarası: {disListe[i][0]}");
                Console.WriteLine();
            }
        }

        public void personSearch()
        {
            Console.Write("Aramak istediğiniz kişinin adını giriniz: ");
            string searchPerson = Console.ReadLine();

            for (int i = 0; i < disListe.Count; i++)
            {
                int index = disListe[i][1].IndexOf(searchPerson);

                if (index != -1)
                {
                    Console.WriteLine($"İsim: {disListe[i][1]}");
                    Console.WriteLine($"Soyisim: {disListe[i][2]}");
                    Console.WriteLine($"Telefon Numarası: {disListe[i][0]}");
                    Console.WriteLine();
                }
                Console.WriteLine("Aradığın isimdeki tüm kişiler listelendi.");

            }

        }

    }
}

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

        List<List<string>> indexList = new List<List<string>>();

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

            indexList.Add(icListe1);

            Console.WriteLine("! " + icListe1[1] + " Kişisi Listeye eklendi.");
            personList();
        }

        public void personDelete()
        {
            if(IsListEmpty(indexList))
            {
                Console.WriteLine("Rehberde kişi yok. ");
                Console.WriteLine();
            }
            else
            {
                personList();
                Console.Write("Silmek istediğiniz kişinin adını giriniz: ");
                string deleteName = Console.ReadLine();


                for (int i = 0; i < indexList.Count; i++)
                {
                    int index = indexList[i][1].IndexOf(deleteName);

                    if (index != -1) // Aranan isim bulunduysa
                    {
                        Console.WriteLine($"İsim: {indexList[i][1]}");
                        Console.WriteLine($"Soyisim: {indexList[i][2]}");
                        Console.WriteLine($"Telefon Numarası: {indexList[i][0]}");
                        Console.WriteLine();
                        Console.WriteLine("Silmek istediğiniz kişiden emin olmak için kişinin tam ismini giriniz");
                        Console.Write("---->");
                        string fullName = Console.ReadLine();

                        if (indexList[i][1] == fullName)
                        {
                            indexList.RemoveAt(i);
                            Console.WriteLine(fullName + " Adlı kişi listenizden silindi.");
                            Console.WriteLine();

                        }
                        else
                        {
                            Console.WriteLine("İsim doğru girilmedi lütfen yeni bir işlem seçin.");
                            Console.WriteLine();
                            break;
                        }
                    }

                }
                personList();
            }
            
        }

        public void personUpdate()
        {
            if (IsListEmpty(indexList))
            {
                Console.WriteLine("Rehberde kişi yok. ");
                Console.WriteLine();
            }
            else
            {
                personList();
                Console.Write("Düzenlemek istediğiniz kişinin adını giriniz: ");
                string deleteName = Console.ReadLine();


                for (int i = 0; i < indexList.Count; i++)
                {
                    int index = indexList[i][1].IndexOf(deleteName);

                    if (index != -1) // Aranan isim bulunduysa
                    {
                        Console.WriteLine($"İsim: {indexList[i][1]}");
                        Console.WriteLine($"Soyisim: {indexList[i][2]}");
                        Console.WriteLine($"Telefon Numarası: {indexList[i][0]}");
                        Console.WriteLine();

                        Console.WriteLine("Düzenlemek istediğiniz kişiden emin olmak için kişinin tam ismini giriniz");
                        Console.Write("---->");
                        string fullName = Console.ReadLine();

                        if (indexList[i][1] == fullName)
                        {
                            Console.WriteLine($"İsim: {indexList[i][1]}");
                            Console.WriteLine($"Soyisim: {indexList[i][2]}");
                            Console.WriteLine($"Telefon Numarası: {indexList[i][0]}");
                            Console.WriteLine();

                            Console.WriteLine("İsim düzenle");
                            Console.Write("---->");
                            indexList[i][1] = Console.ReadLine();
                            Console.WriteLine("Soyisim düzenle");
                            Console.Write("---->");
                            indexList[i][2] = Console.ReadLine();
                            Console.WriteLine("Numarayı Düzenle");
                            Console.Write("---->");
                            indexList[i][0] = Console.ReadLine();

                            Console.WriteLine("Kişi bilgileri düzenlendi.");
                            Console.WriteLine();

                            Console.WriteLine($"İsim: {indexList[i][1]}");
                            Console.WriteLine($"Soyisim: {indexList[i][2]}");
                            Console.WriteLine($"Telefon Numarası: {indexList[i][0]}");
                            Console.WriteLine();

                        }
                        else
                        {
                            Console.WriteLine("İsim doğru girilmedi lütfen yeni bir işlem seçin.");
                            Console.WriteLine();
                            break;
                        }
                        break;

                    }
                }
            }
            
        }

        public void personList()
        {
            if(IsListEmpty(indexList))
            {
                Console.WriteLine("Rehberde kişi yok. ");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("**********************Rehber**********************");
                for (int i = 0; i < indexList.Count; i++)
                {
                    Console.WriteLine($"Kişi {i + 1}:");
                    Console.WriteLine($"İsim: {indexList[i][1]}");
                    Console.WriteLine($"Soyisim: {indexList[i][2]}");
                    Console.WriteLine($"Telefon Numarası: {indexList[i][0]}");
                    Console.WriteLine();
                }
            }
        }

        public void personSearch()
        {
            if(IsListEmpty(indexList))
            {
                Console.WriteLine("Rehberde kişi yok. ");
                Console.WriteLine();
            }
            else
            {
                Console.Write("Aramak istediğiniz kişinin adını giriniz: ");
                string searchPerson = Console.ReadLine();

                for (int i = 0; i < indexList.Count; i++)
                {
                    int index = indexList[i][1].IndexOf(searchPerson);

                    if (index != -1)
                    {
                        Console.WriteLine($"İsim: {indexList[i][1]}");
                        Console.WriteLine($"Soyisim: {indexList[i][2]}");
                        Console.WriteLine($"Telefon Numarası: {indexList[i][0]}");
                        Console.WriteLine();
                    }
                }
                Console.WriteLine("Aradığın isimdeki tüm kişiler listelendi.");
                Console.WriteLine();
            } 
        }

        static bool IsListEmpty<T>(List<T> list)
        {
            // Listenin null olup olmadığı kontrol ediliyor
            if (list == null)
            {
                throw new ArgumentNullException(nameof(list), "Liste null referansıyla gönderilemez.");
            }

            // Listenin eleman sayısı 0 mı kontrol ediliyor
            return list.Count == 0;
        }

    }
}

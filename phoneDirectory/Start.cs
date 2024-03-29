using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phoneDirectory
{
    public class Start
    {
        directoryManage directoryManage = new directoryManage();
        public Start()
        {
            while (true)
            {
                Console.WriteLine("Yapmak İstediğiniz işlemi seçin");
                Console.WriteLine("1- Yeni Numara Kaydetmek");
                Console.WriteLine("2- Varolan Numarayı Silmek");
                Console.WriteLine("3- Varolan Numarayı Güncelleme");
                Console.WriteLine("4- Rehberi Listelemek");
                Console.WriteLine("5- Rehberde Arama Yapmak﻿");
                Console.WriteLine("Çıkış için herhangi bir tuşa basın.");
                Console.Write("-------> ");

                int selectChoose = Convert.ToInt32(Console.ReadLine());
                select(selectChoose);
            }
        }

        public void select(int select)
        {
            switch (select)
            {
                case 1:
                    directoryManage.personSave();
                    break;
                case 2:
                    directoryManage.personDelete();
                    break;
                case 3:
                    directoryManage.personUpdate();
                    break;
                case 4:
                    directoryManage.personList();
                    break;
                case 5:
                    directoryManage.personSearch();
                    break;
                default:
                    break;
            }
        }
    }
}

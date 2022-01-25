using DBFirstApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ekzamen_cSharp
{
    class Menu
    {
        public void men1()
        {
            Model m1 = new Model();
            Modification mod1 = new Modification();
            Colour col1 = new Colour();
            Xml_serialization xml = new Xml_serialization();
            int select = 0;
            while (select != 3)
            {
                Console.WriteLine("1.Добавление новых машин, характеристик\n2.Выбор машины\n3.Выход");
                select = Convert.ToInt32(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        using (ApplicationContext db = new ApplicationContext())
                        {
                            int sel = 0;
                            while (sel != 4)
                            {
                                Console.WriteLine("1.Добавить машину\n2.Добавить модификацию\n3.Добавить цвет\n4.Выход");
                                sel = Convert.ToInt32(Console.ReadLine());
                                switch (sel)
                                {
                                    case 1:
                                        m1.create();
                                        db.Model.Add(m1);  //добавление машини
                                        db.SaveChanges();
                                        xml.Serializaton_Model();
                                        Console.WriteLine("Объекты успешно сохранены");
                                        break;
                                    case 2:
                                        mod1.create();
                                        db.Modification.Add(mod1); //добавление модификации
                                        db.SaveChanges();
                                        xml.Serializaton_Modification();
                                        Console.WriteLine("Объекты успешно сохранены");
                                        break;
                                    case 3:
                                        col1.create();
                                        db.Colour.Add(col1);
                                        db.SaveChanges();
                                        xml.Serializaton_Colour(); //добавление цвета
                                        Console.WriteLine("Объекты успешно сохранены");
                                        break;

                                }
                            }
                        }
                        break;
                    case 2:
                        using (helloappContext db = new helloappContext())
                        {
                            string sel;
                            var models = db.Model.ToList();
                            Console.WriteLine("Список моделей:");                            
                            foreach (Model m2 in models)
                            {
                                Console.WriteLine($"name - {m2.name} vendorcode - {m2.vendorcode}");
                            }
                            Console.WriteLine("Введите номер машини");
                            sel = Console.ReadLine();
                            foreach (Model m in models)
                            {                                                           
                                if (sel == m.vendorcode)
                                {
                                    StreamWriter sw1 = new StreamWriter(@"C:\\Users\\Пользователь\\source\\repos\\ekzamen-cSharp\\ekzamen-cSharp\\car.txt", true, System.Text.Encoding.Default);
                                    sw1.WriteLine($"name - {m.name} vendorcode - {m.vendorcode}"); // сохранение в файл
                                    sw1.Close();                                   
                                    var mod = db.Modification.ToList();
                                    Console.WriteLine("Список модификаций:");
                                    foreach (Modification mo1 in mod)
                                    {
                                        if (sel == mo1.vendorcode)
                                        {
                                            Console.WriteLine($"name - {mo1.name} vendorcode - {mo1.vendorcode}");
                                        }
                                    }
                                    Console.WriteLine("Выберите модификацию(введите её имя,если не хотите выбирать введите любой символ)");
                                    string sel_mod;
                                    sel_mod = Console.ReadLine();
                                    foreach (Modification mo in mod)
                                    {
                                        if (sel == mo.vendorcode)
                                        {                                                                                      
                                            if (sel_mod == mo.name)
                                            {
                                                Console.WriteLine("++++++++++++++++");
                                                StreamWriter sw = new StreamWriter(@"C:\\Users\\Пользователь\\source\\repos\\ekzamen-cSharp\\ekzamen-cSharp\\car.txt", true, System.Text.Encoding.Default);
                                                sw.WriteLine($"name - {mo.name} vendorcode - {mo.vendorcode}");
                                                sw.Close();
                                                // сохранение в файл
                                            }

                                            var col = db.Colour.ToList();
                                            Console.WriteLine("Список цветов:");
                                            foreach (Colour co in col)
                                            {
                                                if (sel == co.vendorcode)
                                                {
                                                    Console.WriteLine($"name - {co.name} vendorcode - {co.vendorcode}");
                                                }
                                            }
                                            string sel_col;
                                            Console.WriteLine("Выберите цвет(введите её имя,если не хотите выбирать введите любой символ)");
                                            sel_col = Console.ReadLine();
                                            foreach (Colour co in col)
                                            {
                                                if (sel == co.vendorcode)
                                                {
                                                    
                                                    if (sel_col == co.name)
                                                    {
                                                        Console.WriteLine("++++++++++++++++");
                                                        StreamWriter sw2 = new StreamWriter(@"C:\\Users\\Пользователь\\source\\repos\\ekzamen-cSharp\\ekzamen-cSharp\\car.txt", true, System.Text.Encoding.Default);
                                                        sw2.WriteLine($"name - {co.name} vendorcode - {co.vendorcode}");
                                                        sw2.Close();
                                                        // сохранение в файл
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        break;
                }

            }
        }
    }
}

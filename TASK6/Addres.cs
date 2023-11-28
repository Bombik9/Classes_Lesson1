using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
namespace TASK6
{
    internal class Address
    {

        //    Используя Visual Studio, создайте проект по шаблону Console Application.Требуется: 
        //        Создать класс с именем Address.
        //        В теле класса требуется создать поля: index, country, city, street, house, apartment
        //        .Для каждого поля, создать свойство с двумя методами доступа. 
        //        Создать экземпляр класса Address. 
        //        В поля экземпляра записать информацию о почтовом адресе.
        //        Выведите на экран значения полей, описывающих адрес.
        //}

        int index, house, apartament;
        string country, city, street;

        public int Index
        {
            get
            {
                { 
                    return index; 

                }
            }



            set
            {
                index = value;
            }

        }

        
        public int House
        {
            get
            {
                return house; 
            }

            set 
            { 
                house = value; 
            }

        }

        public int Apartament
        {

            get
            {
                return apartament;
            }

            set
            { 
                apartament = value; 
            }
        }
        public string Country
        {
            get 
            {
                return country;
            }

            set
            {
                country = value;
            }
        }
        public string City
        {
            get 
            {
                return city; 
            }

            set 
            {
                city = value;
            }


        }
        public string Street
        {
            get
            {
                return street;
            }

            set { street = value; }

        }

        public void Show()
        {
            Console.WriteLine(City);
            Console.WriteLine(Country);
            Console.WriteLine(Street);

            Console.WriteLine(Index);
            Console.WriteLine(House);
            Console.WriteLine(Apartament);
           
            
          
        }

    }
}

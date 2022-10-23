using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Создать класс с именем Address. 
//В теле класса требуется создать поля: index, country, city, street, house, apartment.Для каждого поля, создать свойство с двумя методами доступа.  
//Создать экземпляр класса Address.  
//В поля экземпляра записать информацию о почтовом адресе.  
//Выведите на экран значения полей, описывающих адрес. 

namespace additional_ex
{
    /// <summary>
    /// Main class
    /// program have to fill address from user
    /// Additional class: Address
    /// Fields: index, country, city, street, house, apartment
    /// </summary>
    internal class Program
    {
        static Address address = new Address(); // creating exemplar
        static void Main(string[] args)
        {
            MainMenu();
            Console.ReadKey(); //delay
        }
        /// <summary>
        /// Menu       
        /// </summary>
        /// ПОСОСИ

        public static void MainMenu()
        {
            Console.WriteLine("Choose a variant for filling:");
            Console.WriteLine("1) Index");
            Console.WriteLine("2) Country");
            Console.WriteLine("3) City");
            Console.WriteLine("4) Street");
            Console.WriteLine("5) House");
            Console.WriteLine("6) Apartment");
            Console.WriteLine("7) Exit programm");
            Console.Write("Select a variant: ");
            string MenuValue = Console.ReadLine();
            Console.Clear();
            if (MenuValue == "1")
            {
                Console.Write("Type index: ");
                string index = Console.ReadLine();
            }
            else if (MenuValue == "2")
            {
                Console.Write("Type country: ");
                string country = Console.ReadLine();
            }
            else if (MenuValue == "3")
            {
                Console.WriteLine("Type city: ");
                string city = Console.ReadLine();
            }
            else if (MenuValue == "4")
            {
                Console.WriteLine("Type street");
                string street = Console.ReadLine();    
            }
            else if (MenuValue == "5")
            {
                Console.WriteLine("Type house: ");
                string house = Console.ReadLine();
            }
            else if (MenuValue == "6")
            {
                Console.WriteLine("Type apartment: ");
                string apartment = Console.ReadLine();
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static void ParsingValue(string value) // checks string or int
        {
            Console.Clear();
            int x;
            if (Int32.TryParse(value, out x))
            {

            }
            else
            {

            }
        }
    }
}

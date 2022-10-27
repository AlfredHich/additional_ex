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
        enum MenuOptions
        {
            exit = 0,
            index = 1,
            country = 2,
            city = 3,
            street = 4,
            house = 5,
            apartment = 6
        }
        public static void MainMenu()
        {
            Console.WriteLine("Choose a variant for filling:");
            Console.WriteLine("1) Index");
            Console.WriteLine("2) Country");
            Console.WriteLine("3) City");
            Console.WriteLine("4) Street");
            Console.WriteLine("5) House");
            Console.WriteLine("6) Apartment");
            Console.WriteLine("0) Exit programm");
            Console.Write("Select a variant: ");
            string inputValue;
            int menuValue;
            inputValue = Console.ReadLine();
            while (!Int32.TryParse(inputValue, out menuValue))
            {
                Console.Write("Incorrect value, pls try again...");
                inputValue = Console.ReadLine();
            }
            switch (menuValue)
            {
                case (int)MenuOptions.exit:
                    Environment.Exit(0);
                    break;
                case (int)MenuOptions.index:
                    Console.Write("Type index: ");
                    string index = Console.ReadLine();
                    break;
            }
                

            Console.Clear();
            if (menuValue == "1")
            {
                Console.Write("Type index: ");
                string index = Console.ReadLine();
            }
            else if (menuValue == "2")
            {
                Console.Write("Type country: ");
                string country = Console.ReadLine();
            }
            else if (menuValue == "3")
            {
                Console.WriteLine("Type city: ");
                string city = Console.ReadLine();
            }
            else if (menuValue == "4")
            {
                Console.WriteLine("Type street");
                string street = Console.ReadLine();    
            }
            else if (menuValue == "5")
            {
                Console.WriteLine("Type house: ");
                string house = Console.ReadLine();
            }
            else if (menuValue == "6")
            {
                Console.WriteLine("Type apartment: ");
                string apartment = Console.ReadLine();
            }

        }

        public int ValidateIntInput(string input, string fieldName) //checks string or int
        {
            int result;
            while (!Int32.TryParse(input, out result))
            {
                Console.Write("Incorrect value, pls try again...");
                input = Console.ReadLine();
            }
            return result;
        }
    }
}

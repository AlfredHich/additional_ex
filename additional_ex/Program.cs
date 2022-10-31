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
            string inputValue;
            int menuValue;
            inputValue = Console.ReadLine();
            while (!Int32.TryParse(inputValue, out menuValue)) //validate value from MainMenu
            {
                Console.WriteLine("Incorrect value, pls try again...");
                Console.ReadKey(); //delay                
                inputValue = Console.ReadLine();
            }
            switch (menuValue)
            {
                case (int)MenuOptions.exit:
                    Environment.Exit(0);
                    break;
                case (int)MenuOptions.index: //int value
                    Console.Write("Type index: ");
                    string index = Console.ReadLine();
                    ValidateIntInput(index,"index");
                    break;
                case (int)MenuOptions.country: //string value
                    Console.WriteLine("Type country: ");
                    string country = Console.ReadLine();
                    ValidateStringInput(country, "country");
                    break;
                case (int)MenuOptions.city: //string value
                    Console.WriteLine("Type city: ");
                    string city = Console.ReadLine();
                    break;
                case (int)MenuOptions.street: //string value
                    Console.WriteLine("Type street: ");
                    string street = Console.ReadLine(); 
                    break;
                case (int)MenuOptions.house:  //int value
                    Console.WriteLine("Type house: ");
                    string house = Console.ReadLine();
                    break;
                case (int)MenuOptions.apartment: //int value
                    Console.WriteLine("Type apartment: ");
                    string apartment = Console.ReadLine();
                    break;
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

        public static int ValidateIntInput(string input, string fieldName) //checks INT value
        {
            int result;
            while (!Int32.TryParse(input, out result))
            {

            }
        }
        public static string ValidateStringInput(string input, string fieldName)
        {
            int result;
            while (int.TryParse(input, out result))
            {
                Console.Write("Incorrect value, pls try again...");
                input = Console.ReadLine();
            }
            return input;
        }
        public void ClosingConsole()
        {
            Environment.Exit(0);
        }
    }
}

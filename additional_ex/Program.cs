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
            ValuesFromKeyBoard(); //call method for Address class
            Console.ReadKey(); //delay
        }

        public static void ValuesFromKeyBoard() //get values from keyboard
        {
            Console.Write("Введите номер индекса: ");
            string index = Console.ReadLine(); //filling index value
            ParsingValue(index); //method for parsing value
            Console.Write("Введите название страны: ");
            string country = Console.ReadLine(); //filling country value
            ParsingValue(country); //method for parsing value
            Console.Write("Введите название города: ");
            string city = Console.ReadLine(); //filling city value
            Console.Write("Введите название улицы: ");
            string street = Console.ReadLine(); //filling steet value
            Console.Write("Введите номер дома: ");
            string house = Console.ReadLine(); //filling house value
            Console.Write("Введите номер квартиры: ");
            string apartment = Console.ReadLine(); //filling house value
            address.Show(); //shows all address values
        }
        public static void ParsingValue(string value)
        {
            int x;
            if (Int32.TryParse(value, out x))
            {
                
            }
            else
            {

            }

        }
        public static void ClearLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }
    }
}

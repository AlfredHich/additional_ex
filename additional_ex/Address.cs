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
    /// Class Address
    /// have contains fields: index, country, city, street, house, apartment
    /// each field must have properities with two permission methods
    /// </summary>
    internal class Address
    {
        private int index, house, apartment;
        private string country, city, street;
        //properities for fields
        public int Index
        {
            
             get
            { return index; }   //mutator
            set
            {              
                index = value; //accessor
            }  
        }
        public string Country
        {
            private get { return country; }//mutator
            set { country = value; }    //accessor
        }
        public string City
        {
            private get { return city; }//mutator
            set { city = value; }   //accessor
        }
        public string Street
        {
            private get { return street; } //mutator
            set { street = value; } //accessor


        }
        public int House
        {
            private get { return house; }//mutator
            set { house = value; }//accessor
        }
        public int Apartment
        {
            
            private get //mutator
            {                
                return apartment;
            }
            set { apartment = value; }//accessor
        }

        public void Show() //shows values
        {
            Console.WriteLine("Index: {0}", this.Index);
            Console.WriteLine("Country: {0} ", this.Country);
            Console.WriteLine("City: {0}", this.Index);
            Console.WriteLine("Street: {0}", this.Street);
            Console.WriteLine("House: {0}", this.House);
            Console.WriteLine("Apartments: {0}", this.Apartment);
        }

        public Address() //constructor
        {
            this.Index = index;
            this.Country = country;
            this.City = city;
            this.Street = street;
            this.House = house;
            this.Apartment = apartment;
        }

    }
}

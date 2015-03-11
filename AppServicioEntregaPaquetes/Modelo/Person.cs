using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppServicioEntregaPaquetes.Modelo
{
    class Person
    {
        #region "Atributes"
        private string name;
        private string numberIdentification;
        private string addres;
        private string city;
        private string state;
        private string postalCode;
        private string phone; // Telefono fijo
        private string mobilePhone; // Telefono Móvil 
        private List<Person> data = new List<Person>();

        public List<Person> Data
        {
            get { return data; }
            set { data = value; }
        }
        #endregion

        #region "Properties"

        /// <summary>
        /// Devuelve o asiga el nombre del destinatario
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Devuelve o asiga el numero de identificacion
        /// </summary>
        public string NumberIdentification
        {
            get { return numberIdentification; }
            set { numberIdentification = value; }
        }

        /// <summary>
        /// Devuelve o asiga la dirección del destinatario
        /// </summary>
        public string Addres
        {
            get { return addres; }
            set { addres = value; }
        }

        /// <summary>
        /// Devuelve o asiga la ciudad de residencia del destinatario
        /// </summary>
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        /// <summary>
        /// Devuelve o asiga el estado o departamento del destanatario
        /// </summary>
        public string State
        {
            get { return state; }
            set { state = value; }
        }

        /// <summary>
        /// Devuelve o asiga el codigo postal 
        /// </summary>
        public string PostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }
        }

        /// <summary>
        /// Devuelve o asiga el número de telefono
        /// </summary>
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        /// <summary>
        /// Devuelve o asiga el número de telefono móvil
        /// </summary>
        public string MobilePhone
        {
            get { return mobilePhone; }
            set { mobilePhone = value; }
        }
        #endregion

        #region "Builders"
        /// <summary>
        /// Constructor por defecto de la Clase Package
        /// </summary>
        public Person()
        {
            this.name = "Package";
            this.numberIdentification = "00000000";
            this.addres = "Addres";
            this.city = "City";
            this.state = "State";
            this.postalCode = "000000";
            this.phone = "00000";
            this.mobilePhone = "000000";
        }

        /// <summary>
        /// Constructor que inicializa la Clase Person 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="numberIdentification"></param>
        /// <param name="addres"></param>
        /// <param name="city"></param>
        /// <param name="state"></param>
        /// <param name="postalCode"></param>
        /// <param name="phone"></param>
        /// <param name="mobilePhone"></param>
        public Person(string name, string numberIdentification, string addres, string city,
            string state, string postalCode, string phone, string mobilePhone)
        {
            this.name = name;
            this.numberIdentification = numberIdentification;
            this.addres = addres;
            this.city = city;
            this.state = state;
            this.postalCode = postalCode;
            this.phone = phone;
            this.mobilePhone = mobilePhone;
        }

        #endregion

        #region "Override methods of Object"

        /// <summary>
        /// Retorna la descripición del Paquete
        /// </summary>
        /// <returns>Retorna la descripición del Paquete</returns>
        public override string ToString()
        {
            return "Name: " + this.name + "\n" +
                    "Number of identification: " + this.numberIdentification + "\n" +
                    "Addres: " + this.addres + "\n" +
                    "city: " + this.city + "\n" +
                    "state: " + this.state + "\n" +
                    "Postal Code:" + this.postalCode + "\n" +
                    "Phone: " + this.phone + "\n" +
                    "Mobile Phone: " + this.mobilePhone + "\n";

        }


        ///<summary>
        ///Retorna verdadero si los objetos comparados son iguales, falso para contario
        ///</summary>
        ///<return> Retorna verdadero o falso </return>
        public override bool Equals(object obj)
        {
            Person p = (Person)obj;
            bool result = false;

            if ((this.name == p.name) && (this.numberIdentification == p.numberIdentification) && (this.addres == p.addres) && (this.city == p.city)
                && (this.state == p.state) && (this.postalCode == p.postalCode) && (this.phone == p.phone) && (this.mobilePhone == p.mobilePhone))
                result = true;

            return result;
        }


        ///<summary>
        ///Retorna Codigo Has del objeto
        ///</summary>
        ///<return> Retorna hasCode del objeto</return>
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        #endregion

        #region "Abstracts Methods"

        public IEnumerable<Person> getPersonas()
        {
            Person sender = new Person("Alfredo Rodelo", "97052317727", "Edificio Los ejecutivos",
            "Cartagena", "Bolívar", "130014", "6612366", "3124600156");

            data.Add(sender);

            return data;
        }

        #endregion
    }
}
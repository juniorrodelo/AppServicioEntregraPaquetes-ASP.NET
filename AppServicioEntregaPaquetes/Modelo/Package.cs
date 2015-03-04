using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppServicioEntregaPaquetes.Modelo
{
    public abstract class Package
    {
        #region "Atributes"
        private string code;
        private string name;
        private string addres;
        private string city;
        private string state;
        private string postalCodeSender;
        private string postalCodeAddressee;
        private double weight;
        private double costXGrams;
        #endregion

        #region "Properties"
        /// <summary>
        /// Devuelve o asiga el codigo al paquete
        /// </summary>
        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        /// <summary>
        /// Devuelve o asiga el nombre del destinatario
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
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
        /// Devuelve o asiga el codigo postal del remitente
        /// </summary>
        public string PostalCodeSender
        {
            get { return postalCodeSender; }
            set { postalCodeSender = value; }
        }

        /// <summary>
        /// Devuelve o asiga el codigo postal del destanatario 
        /// </summary>
        public string PostalCodeAddressee
        {
            get { return postalCodeAddressee; }
            set { postalCodeAddressee = value; }
        }

        /// <summary>
        /// Devuelve o asiga el peso del paquete
        /// </summary>
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        /// <summary>
        /// Devuelve o asiga el costo por gramos del paquete
        /// </summary>
        public double CostXGrams
        {
            get { return costXGrams; }
            set { costXGrams = value; }
        }
        #endregion

        #region "Builders"
        /// <summary>
        /// Constructor por defecto de la Clase Package
        /// </summary>
        public Package()
        {
            this.code = "0";
            this.name = "Package";
            this.addres = "Addres";
            this.city = "City";
            this.state = "State";
            this.postalCodeSender = "000000";
            this.postalCodeAddressee = "000000";
            this.weight = 0.0;
            this.costXGrams = 1000.00;
        }

        /// <summary>
        /// Constructor que inicializa la Clase Package 
        /// </summary>
        /// <param name="code"></param>
        /// <param name="name"></param>
        /// <param name="addres"></param>
        /// <param name="city"></param>
        /// <param name="state"></param>
        /// <param name="postalCodeSender"></param>
        /// <param name="postalCodeAddressee"></param>
        /// <param name="weight"></param>
        /// <param name="CostXGrams"></param>
        public Package(string code, string name, string addres, string city, string state,
            string postalCodeSender, string postalCodeAddressee, double weight, double CostXGrams)
        {
            this.code = code;
            this.name = name;
            this.addres = addres;
            this.city = city;
            this.state = state;
            this.postalCodeSender = postalCodeSender;
            this.postalCodeAddressee = postalCodeAddressee;
            this.weight = weight;
            this.CostXGrams = CostXGrams;
        }

        #endregion

        #region "Override methods of Object" 

        /// <summary>
        /// Retorna la descripición del Paquete
        /// </summary>
        /// <returns>Retorna la descripición del Paquete</returns>
        public override string ToString()
        {
            return  "Code: " + this.code + "\n" +
                    "Name: " + this.name + "\n" +
                    "Addres: " + this.addres + "\n" +
                    "city: " + this.city + "\n" +
                    "state: " + this.state + "\n" +
                    "Postal Code Sender: " + this.postalCodeSender + "\n" +
                    "Postal Code Addressee: " + this.postalCodeAddressee + "\n" +
                    "Weight: " + this.weight + "\n" +
                    "Cost per gram: " + this.CostXGrams + "\n";

        }


        ///<summary>
        ///Retorna verdadero si los objetos comparados son iguales, falso para contario
        ///</summary>
        ///<return> Retorna verdadero o falso </return>
        public override bool Equals(object obj)
        {
            Package p = (Package)obj;
            bool result = false;

            if ((this.code == p.code) && (this.name == p.name) && (this.addres == p.addres) && (this.city == p.city)
                && (this.state == p.state) && (this.postalCodeSender == p.postalCodeSender) && (this.postalCodeAddressee == p.postalCodeAddressee)
                && (this.weight == p.weight) && (this.CostXGrams == p.CostXGrams))
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
              
        public abstract double calculateCost();

        #endregion
    }
}
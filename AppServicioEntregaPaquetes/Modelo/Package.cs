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
        private Person sender;
        private Person addresse;
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

        internal Person Addresse
        {
            get { return addresse; }
            set { addresse = value; }
        }




        #endregion

        #region "Builders"
        /// <summary>
        /// Constructor por defecto de la Clase Package
        /// </summary>
        public Package()
        {
            this.code = "0";
            this.sender = new Person();
            this.addresse = new Person();
            this.weight = 0.0;
            this.costXGrams = 1000.00;
        }

        public Package(string code, Person sender, Person addresse, double weight, double costXGrams)
        {
            this.code = code;
            this.sender = sender;
            this.addresse = addresse;
            this.weight = weight;
            this.costXGrams = costXGrams;
        }


        #endregion

        #region "Override methods of Object"

        /// <summary>
        /// Retorna la descripición del Paquete
        /// </summary>
        /// <returns>Retorna la descripición del Paquete</returns>
        public override string ToString()
        {
            return "=================== Sender Information ============= \n" +
                    this.sender.ToString() + "\n" +
                    "=================== Adderesse Information ============= \n" +
                    this.addresse.ToString() + "\n" +
                    "=================== Package Information ============= \n" +
                    "Code: " + this.code + "\n" +
                    "Weight: " + this.weight + " Gramos \n" +
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

            if ((this.sender.Equals(0)) && (this.addresse.Equals(0)) && (this.code == p.code) && (this.weight == p.weight) && (this.CostXGrams == p.CostXGrams))
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
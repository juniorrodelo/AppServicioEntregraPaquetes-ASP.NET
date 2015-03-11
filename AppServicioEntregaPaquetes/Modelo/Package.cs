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
        // Remitente
        Person sender = new Person("Alfredo Rodelo", "97052317727", "Edificio Los ejecutivos",
            "Cartagena", "Bolívar", "130014", "6612366", "3124600156");
        // Destinatario
        Person addresse = new Person("Edwin Puertas", "103940943", "san Fernando Calle 45 #12-03",
            "Barranquilla", "Atlantico", "130011", "6634456", "3203434342");
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
        #endregion

        #region "Builders"
        /// <summary>
        /// Constructor por defecto de la Clase Package
        /// </summary>
        public Package()
        {
            sender.getPersonas();
            addresse.getPersonas();
            this.code = "0";
            this.weight = 5.0;
            this.costXGrams = 1000.00;
        }

        public Package(string code, double weight, double CostXGrams)
        {
            sender.getPersonas();
            addresse.getPersonas();
            this.code = code;
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
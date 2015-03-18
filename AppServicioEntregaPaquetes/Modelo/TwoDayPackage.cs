using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppServicioEntregaPaquetes.Modelo
{
    class TwoDayPackage : Package
    {
        #region "Atributes"
        private double fixedFee; // Cuota Fija
        private double shippingCost; // Costo de Envio
        #endregion

        #region "Properties"
        public double FixedFee
        {
            get { return fixedFee; }
            set { fixedFee = value; }
        }

        public double ShippingCost
        {
            get { return shippingCost; }
            set { shippingCost = value; }
        }
        #endregion

        #region "Builders"
        public TwoDayPackage()
            : base()
        {
            this.fixedFee = 5200.00;
        }

        public TwoDayPackage(string code, Person sender, Person addresse, double weight, double costXGrams)
            : base(code, sender, addresse, weight, costXGrams)
        {
            this.fixedFee = fixedFee;
        }
        #endregion

        #region "Abstracts Methods"

        public override double calculateCost()
        {
            // Asegurando que es positivo el peso y el valor por gramos
            if (this.CostXGrams < 0 && this.Weight < 0)
            {
                this.CostXGrams = this.CostXGrams * -1;
                this.Weight = this.Weight * -1;
            }

            double cost = (this.Weight) * (this.CostXGrams);

            // Sumando Cuota fija para el envio de 2 días
            this.ShippingCost = (this.FixedFee) + (cost);
            return this.ShippingCost;
        }

        #endregion

        #region "Override methods of Object"

        public override string ToString()
        {
            return base.ToString() +
                   "Fixed Fee: " + fixedFee + "\n" +
                   "Total Cost: " + this.calculateCost() + "\n";
        }

        public override bool Equals(object obj)
        {
            TwoDayPackage p = (TwoDayPackage)obj;
            bool result = false;

            if (base.Equals(0) && (fixedFee == p.FixedFee))
                result = true;

            return result;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }



        #endregion


    }
}
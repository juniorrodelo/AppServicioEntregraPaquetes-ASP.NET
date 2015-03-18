using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppServicioEntregaPaquetes.Modelo
{
    public class OvernightPackage : Package
    {
        #region "Atributes"
        private double additionalChargeXGrams; // Cargo adicional por gramos
        private double shippingCost; // Costo de Envio
        #endregion

        #region "Properties"
        public double AdditionalChargeXGrams
        {
            get { return additionalChargeXGrams; }
            set { additionalChargeXGrams = value; }
        }

        public double ShippingCost
        {
            get { return shippingCost; }
            set { shippingCost = value; }
        }
        #endregion

        #region "Builders"
        public OvernightPackage()
            : base()
        {
            this.additionalChargeXGrams = 200.00;
        }

        public OvernightPackage(string code, Person sender, Person addresse, double weight, double costXGrams)
            : base(code, sender, addresse, weight, costXGrams)
        {
            this.additionalChargeXGrams = additionalChargeXGrams;
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

            // Agregando Costo Adicional por Gramos
            this.CostXGrams += additionalChargeXGrams;

            double cost = (this.Weight) * (this.CostXGrams);
            this.ShippingCost = cost;

            return this.ShippingCost;
        }

        #endregion

        #region "Override methods of Object"

        public override string ToString()
        {
            return base.ToString() +
                   "Additional Charge But Grams: " + additionalChargeXGrams + "\n" +
                   "Total Cost: " + this.calculateCost() + "\n";
        }

        public override bool Equals(object obj)
        {
            OvernightPackage p = (OvernightPackage)obj;
            bool result = false;

            if (base.Equals(0) && (additionalChargeXGrams == p.AdditionalChargeXGrams))
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
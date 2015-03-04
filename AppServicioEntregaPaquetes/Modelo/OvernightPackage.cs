﻿using System;
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
        #endregion

        #region "Override methods of Object"

        public override string ToString()
        {
            return base.ToString() +
                   "Additional Charge But Grams: " + this.additionalChargeXGrams + "\n";
        }

        public override bool Equals(object obj)
        {
            OvernightPackage p = (OvernightPackage)obj;
            bool result = false;

            if (base.Equals(0) && (this.additionalChargeXGrams == p.additionalChargeXGrams))
                result = true;

            return result;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }



        #endregion

        #region "Abstracts Methods"
              
        public override double calculateCost()
        {   
            // Agregando Costo Adicional por Gramos
            this.CostXGrams += this.additionalChargeXGrams;
 
            double cost = (this.Weight) * (this.CostXGrams);
            this.ShippingCost = cost;

            return this.ShippingCost;
        }

        #endregion
    }
}
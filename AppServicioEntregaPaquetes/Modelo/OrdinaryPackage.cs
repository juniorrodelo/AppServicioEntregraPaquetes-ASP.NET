﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppServicioEntregaPaquetes.Modelo
{
    class OrdinaryPackage : Package
    {
        #region "Atributes"
        private double shippingCost; // Costo de Envio
        #endregion

        #region "Properties"

        public double ShippingCost
        {
            get { return shippingCost; }
            set { shippingCost = value; }
        }
        #endregion

        #region "Builders"

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

            // Calculando el costo total

            double cost = (this.Weight) * (this.CostXGrams);
            this.ShippingCost = cost;

            return this.ShippingCost;
        }

        #endregion

        #region "Override methods of Object"

        public override string ToString()
        {
            return base.ToString() +
                   "Total Cost: " + this.calculateCost() + "\n";
        }

        public override bool Equals(object obj)
        {
            OvernightPackage p = (OvernightPackage)obj;
            bool result = false;

            if (base.Equals(0))
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
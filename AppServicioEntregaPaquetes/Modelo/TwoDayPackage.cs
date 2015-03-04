﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppServicioEntregaPaquetes.Modelo
{
    public class TwoDayPackage : Package
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
        public TwoDayPackage(): base()
        {
            this.fixedFee = 5200.00;
        }
        #endregion

        #region "Override methods of Object"

        public override string ToString()
        {
            return base.ToString() +
                   "Fixed Fee: " + this.fixedFee + "\n";
        }

        public override bool Equals(object obj)
        {
            TwoDayPackage p = (TwoDayPackage)obj;
            bool result = false;

            if (base.Equals(0) && (this.fixedFee == p.fixedFee))
                result = true;

            return result;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }



        #endregion


        public override double calculateCost()
        {
            double cost = (this.Weight) * (this.CostXGrams);
            this.ShippingCost = (this.FixedFee) + (cost);

            return this.ShippingCost;
        }


    }
}
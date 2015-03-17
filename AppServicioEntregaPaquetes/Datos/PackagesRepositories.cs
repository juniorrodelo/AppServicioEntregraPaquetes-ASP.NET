using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppServicioEntregaPaquetes.Modelo;

namespace AppServicioEntregaPaquetes.Datos
{
    public class PackagesRepositories
    {
        private List<Package> data = new List<Package>();
        public IEnumerable<Package> getPackages()
        {
            OrdinaryPackage package1 = new OrdinaryPackage();
            OvernightPackage package2 = new OvernightPackage();
            TwoDayPackage package3 = new TwoDayPackage();

            data.Add(package1);
            data.Add(package2);
            data.Add(package3);

            return data;
        }
    }
}
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

            Person sender = new Person("Alfredo Rodelo", "97052317727", "Barrio Buenos Aires Dig 46",
                "Cartagena", "Bolívar", "005600", "6614366", "3124600156" );

            Person addresse = new Person("Edwin Puertas", "736772323", "Barrio Campestre C:",
                "Cartagena", "Bolívar", "005600", "6653339", "3003422233");



            OrdinaryPackage package1 = new OrdinaryPackage("001", sender, addresse, 12.0, 1000.00, 5);
            OvernightPackage package2 = new OvernightPackage("002", sender, addresse, 12.0, 1000.00);
            TwoDayPackage package3 = new TwoDayPackage("003", sender, addresse, 12.0, 1000.00);

            data.Add(package1);
            data.Add(package2);
            data.Add(package3);

            return data;
        }
    }
}
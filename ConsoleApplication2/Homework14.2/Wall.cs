using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Homework14._2
{
    public class Wall
    {
        public string buildingMaterial;
        public int wallThickness;
       

        public Wall(string buildingMaterial, int wallThickness)
        {
            this.buildingMaterial = buildingMaterial;
            this.wallThickness = wallThickness;
           
        }

    }
}

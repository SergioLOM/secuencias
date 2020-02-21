using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appComplejidad.Models
{
    public class Secuencia
    {

        public Secuencia()
        {
            this.Elemento = new List<double>();
            this.ElementoReverse = new List<double>();
            this.Elemento.Add(2);
            this.Elemento.Add(4);
            this.Elemento.Add(5);
            this.Elemento.Add(6);

            int n = Elemento.Count;
            int a = n-1;
            for (int i=0; i<n; i++){
                this.ElementoReverse.Add(this.Elemento[a]);
                a--;
            }
            
        }

        public int Id { get; set; }
        public List<double> Elemento { get; set; }
        public List<double> ElementoReverse { get; set; }
    }
}
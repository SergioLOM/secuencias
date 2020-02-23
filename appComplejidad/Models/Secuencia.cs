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
            this.Elemento.Add(7);
            this.Elemento.Add(4);
            this.Elemento.Add(8);
            this.Elemento.Add(7);
            int n = Elemento.Count;
            double t;
            for (int c = 1; c < n; c++)
                for (int b = n - 1; b >= c; b--)
                {
                    if (Elemento[b - 1] > Elemento[b])
                    {
                        t = Elemento[b - 1];
                        Elemento[b - 1] = Elemento[b];
                        Elemento[b] = t;
                    }
                }

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
using System;

namespace Classes_and_Objects_Tasks
{
    class Program
    {

        static void Main(string[] args)
        {
            ///this code instantiates a cookie
            var c1 = new Cookie(51, "round");
            var c2 = new Cookie(32, "square"); 
            var c3 = new Cookie(44, "rectangle");
            var c4 = new Cookie(66, "oblong"); 
            System.Console.WriteLine(c1.Shape);
            System.Console.WriteLine(c1.Weight);
        } 
    }

    /////this is my basic cookie class
    public class Cookie
    {
        //attributees
        public int Weight;
        public string Shape;
        public Colour cl;

        /////=====================
        //constructor

        public Cookie(){
            this.Weight = 0;
            this.Shape = "";
            this.cl = null;
        }

        public Cookie(int w, string s, Colour c)
        {
            this.Weight = w;
            this.Shape = s;
            this.cl = c;
        }
        //////////////////////////
         
    }
    

        public class Colour{
            //////attributes////
            public int Red = 0;
            public int Green = 0;
            public int Blue = 0;
            ////////////////////////

            /////=====================
            //constructor

            public Colour(int rd, int gr, int bl){
                this.Red = rd;
                this.Green = gr;
                this.Blue = bl;
            }
            //=========================
        
        }

    

} 

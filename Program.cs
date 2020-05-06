using System;

namespace Classes_and_Objects_Tasks
{
    class Program
    {

        static void Main(string[] args)
        {
            ///this code instantiates a cookie and colours
            
            var Yellow = new Colour(255, 255, 0, "Yellow");
            var Red = new Colour(245, 66, 66, "Red");
            //-------------------------------------------
            var c1 = new Cookie(51, "round", Yellow);
            var c2 = new Cookie(32, "square"); 
            var c3 = new Cookie(44, "rectangle", Red);
            var c4 = new Cookie(66, "oblong"); 
            System.Console.WriteLine(c1.cl.Name);
            System.Console.WriteLine(c3.cl.Name);
            
            
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

        public Cookie(int w, string s){
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

            public string Name = "";
            ////////////////////////

            /////=====================
            //constructor

            public Colour(int rd, int gr, int bl, string name){
                this.Red = rd;
                this.Green = gr;
                this.Blue = bl;
                this.Name = name; 
            }
            //=========================
        
        }

    

} 

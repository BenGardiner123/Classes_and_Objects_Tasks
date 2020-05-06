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
            // can hard code colours into the cookies - btter to create above and pass in.
            var c1 = new Cookie(51, "round", Yellow);
            var c2 = new Cookie(32, "square"); 
            var c3 = new Cookie(44, "rectangle", Red);
            var c4 = new Cookie(66, "oblong"); 
        
            
            
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
        // overloading the constructor to allow me to create 2 types of cookies 1 with a colour and 1 without//
        public Cookie(int w, string s){
            this.Weight = 0;
            this.Shape = "";
            this.cl = null;
        }

        public Cookie(int w, string s, Colour c)
        {
            this.Weight = w;
            this.Shape = s;
            /////when printing to the console need to ref this not name of the new colour 
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

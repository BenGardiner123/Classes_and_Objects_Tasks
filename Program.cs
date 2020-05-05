using System;

namespace Classes_and_Objects_Tasks
{
    class Program
    {

        static void Main(string[] args)
        {
            ///this code instantiates a cookie
            Cookie c1 = new Cookie();
            Cookie.Colour c2 = new Cookie(); 
        } 
    }

    /////this is my basic cookie class
    public class Cookie
    {
        //attributees
        public int Weight;
        public string Shape;

        

        /////=====================
        //constructor

        public Cookie(){
            this.Weight = 0;
            this.Shape = "";
            

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

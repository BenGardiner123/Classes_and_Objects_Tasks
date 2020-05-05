using System;

namespace Classes_and_Objects_Tasks
{
    class Program
    {

        static void Main(string[] args)
        {
            ///this code instantiates a cookie
            Cookie c1 = new Cookie();
        } 
    }

    /////this is my basic cookie class
    class Cookie
    {
        //attributees
        public int Weight;
        public string Shape;

        //operations

        /////=====================
        //constructor

        public Cookie(){
            this.Weight = 0;
            this.Shape = "";

        }

         //operations

    }

     /*    class Colour{

            int cookieColour

            /////=====================
            //constructor

            public Colour(){
                cookieColour = 255 204 0;
            }
 */
    

} 

using System;
using System.Collections.Generic;  
using System.Linq;
using System.Text;   

namespace Classes_and_Objects_Tasks
{
 /*    class Program
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
 */
    
//////////// TASK 2 ....--------....-----....------ TASK 2//////////////////
 class Program
    {

        static void Main(string[] args)
        {

            Subject s1 = new Subject("English", 1988);
            Subject s2 = new Subject("French", 1988);
            Subject s3 = new Subject("Post-Modern Art", 1988);


            var p1 = new Person("Ben", "Gardiner", 182, new DateTime(1981,01,09));
            var p2 = new Person("Dave", "Matthews", 167, new DateTime(1966,06,08));
            var p3 = new Person("Peter", "Pan", 199, new DateTime(1996,05,19));

          

    
            Console.WriteLine(p1.getFullName() + " has " + p1.GetHeightDifference(p2) + " cm difference to " + p2.getFullName() + " and has " + p1.GetHeightDifference(p3) + " cm difference to " + p2.getFullName());

            Console.WriteLine(p2.getFullName() + " has " + p2.GetHeightDifference(p1) + " cm difference to " + p1.getFullName() + " and has " + p2.GetHeightDifference(p3) + " cm difference to " + p3.getFullName());

            Console.WriteLine(p3.getFullName() + " has " + p3.GetHeightDifference(p2) + " cm difference to " + p2.getFullName() + " and has " + p3.GetHeightDifference(p1) + " cm difference to " + p1.getFullName());

            
            
        
        } 

        

    }
     public class Person
    {
        //attributees
        public string FirstName;
        public string Surname;
        public int Height;
        public DateTime DOB;
        public List<Subject> perSub;

        

        /////=====================
        //constructor
        // overloading the constructor to allow differernt tyes of date///
        public Person()
        {
            
        }
        
        public Person(string f, string s, int h, DateTime d, List<Subject> l)
        {
            this.FirstName = f;
            this.Surname = s;
            this.Height = h;
            this.DOB = d;
            this.perSub = new List<Subject>();
        }
        

       
            public string getFullName()
            {
                return this.FirstName + " " + this.Surname;
            }

            public int GetHeightDifference(Person p)
            {
                
                return this.Height - p.Height;
                
            }
            
           


    

    }

    public class Subject {
        string name;
        int YearofDelivery;

        /// constructor 

        public Subject(string name, int yearofDelivery)
        {
            this.name = name;
            YearofDelivery = yearofDelivery;

        }



    }



    
    
}


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
            ///here im instantiating 3 new people
            var p1 = new Person("Ben", "Gardiner", 182, new DateTime(1981,01,09));
            var p2 = new Person("Dave", "Matthews", 167, new DateTime(1966,06,08));
            var p3 = new Person("Peter", "Pan", 199, new DateTime(1996,05,19));
        
            ///using my 2 functions inside of the Person class i get thefullnames and height differenes b/w them
            Console.WriteLine(p1.getFullName() + " has " + p1.GetHeightDifference(p2) + " cm difference to " + p2.getFullName() + " and has " + p1.GetHeightDifference(p3) + " cm difference to " + p2.getFullName());

            Console.WriteLine(p2.getFullName() + " has " + p2.GetHeightDifference(p1) + " cm difference to " + p1.getFullName() + " and has " + p2.GetHeightDifference(p3) + " cm difference to " + p3.getFullName());

            Console.WriteLine(p3.getFullName() + " has " + p3.GetHeightDifference(p2) + " cm difference to " + p2.getFullName() + " and has " + p3.GetHeightDifference(p1) + " cm difference to " + p1.getFullName());
            //// here i can add new subjects an allocate them to a person using the method 
            p1.addlistSubjects("Maths", 1888);
            p3.addlistSubjects("English", 1988);
            p2.addlistSubjects("French", 1988);
            p1.addlistSubjects("Post-Modern Art", 1988);

            Console.WriteLine("===============================================");
            Console.WriteLine("Here is a list of their subjects");
            Console.WriteLine(p1.getFullName() + " studies ");
            Console.WriteLine(p1.prinSubjectList());
            Console.WriteLine(p2.getFullName() + " studies "); 
            Console.WriteLine(p2.prinSubjectList());
            Console.WriteLine(p3.getFullName() + " studies ");
            Console.WriteLine(p3.prinSubjectList());

            Console.WriteLine("===============================================");
            Console.WriteLine("Here are their ID's");
            Console.WriteLine(p1.getFullName() + "'s " + " ID is " + p1.ID);
            Console.WriteLine(p2.getFullName() + "'s " + " ID is " + p2.ID);
            Console.WriteLine(p3.getFullName() + "'s " + " ID is " + p3.ID);


        
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
            public int ID;

        

            
            //constructor///////////////
            
            public Person(string f, string s, int h, DateTime d)
            {
                this.FirstName = f;
                this.Surname = s;
                this.Height = h;
                this.DOB = d;
                ////now when i do this there will be a list created without anything in it.
                this.perSub = new List<Subject>();

               // here we create an instance of a random object
               var rand = new Random();
               // then i need to store the random number in somewhere object.Next(n, n)
               int randID = rand.Next(1000, 10000);
               //now make the output = to this persons ID.
               this.ID = randID;
               // because this is inside the constructor, everytime an instance of a person is created a random Id will be created in this.ID


            }

            //=-------------methods for Person ----------=//
            ///string builder method--- comes with the convert to string method at the end////
            ///ideally made for building a string from a loop ////
            public string prinSubjectList(){
                StringBuilder builder = new StringBuilder();

                //string someString = "";
                foreach (Subject subjects in this.perSub)
                {
                    builder.Append(subjects.name + " ");
                    builder.Append(subjects.YearofDelivery + "\n" );

                  ////  someString += subjects.name + " ";
                  ////  someString += subjects.YearofDelivery + " ";
                        //or///
                    //////string interpolation///
                  ///someString += $"{subjects.name} {subjects.YearofDelivery}\n";
                }
                return builder.ToString();
                // returns builder.ToString();
            }

       
            public string getFullName()
            {
                return this.FirstName + " " + this.Surname;
            }

            public int GetHeightDifference(Person p)
            {
                return this.Height - p.Height;
            }

            ///this function creates a new instance of a Subject and adds it to the list of subjects associated with the person it's called on.
              public void addlistSubjects(string subname, int subyear)
            {
                ///create the new instance of a subject using the constructor from Subject (arguments from the function above)
                var addlistSubjects = new Subject(subname, subyear);
                //theperson it's called on. the list name in attributes.the add method(the variable where th info is stored)
                this.perSub.Add(addlistSubjects);
            }
              
           


    

    }

    public class Subject {
        public string name;
        public int YearofDelivery;

        /// constructor 

        public Subject(string name, int yearofDelivery)
        {
            this.name = name;
            this.YearofDelivery = yearofDelivery;

        }




    }



    
    
}


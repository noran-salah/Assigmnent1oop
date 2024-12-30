using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigmnent1oop
{
    internal class Demo
    {
        /* What Is Object Oriented Programming (OOP) ?
             * 
             *   OOP is programming model paradigm that revolves around object or data instead of logic or function
             *   
             *   focus on what we want to manipulate instead how to manipulate
             * 
             * 
             *  simulation of reality => simulate the real world object (Types)  in our program (Car, Person , Employee, ...)
             *  
             *   suitable for large, complex and actively update or maintained
             */


        /* What is Class ?
         *  
         *  class is a layout or blueprint of an object  that describe  how specific object can be used and look like
         * 
         *   class consists of 2 main things
         *   1. Attributes , Fields or member variables
         *   2. Implementatuin of the behaviors or member methods 
         * 
         */

        /* What is Object ?
         * 
         *    single instance of class  which contains data and methods working on that data
         * 
         *     Object consists of 3 main things :
         *     1.Name              => variable name repersent that object
         *     2.member Data       => the data that describe that object   
         *     3.member methods    => behviors that describes that object 
         * 
         * 
         * 
         * 
         *  
         */

        int x = 10;

        /*employee => id, name , age*/
        //employee => 1, ahmed, 25

        //do
        //{
        //    //logic
        //}
        //while (false);






        /* Object Oriented Programming Pillars:
         * 
         *  1.Encapsulation =>   is way of restricting the direct access to member object
         *  2.Inheritance   => creating new class by extending existing one
         *  3.Polymarphism  =>  is process in which object or function take many shapes(overloading, overriding)
         *  4.abstraction   => define external behavior and hide the internal working of an object (Logic)
         * 
         * 
         * 
         * 
         */

        #region Encapsulation

        //Employee employee = new Employee();
        ////Console.WriteLine("Please enter Employee age");
        ////employee.SetName(Console.ReadLine());

        //employee.Email = "10";

        //Console.WriteLine(employee.Email); 
        #endregion


        // PhoneBook phoneBook = new PhoneBook();
        // //phoneBook.Names[0] = "ahmed";
        // //phoneBook.Numbers[0] = "21346384613486130";


        // phoneBook.AddPhoneNumber(1,"ahmed", "012454648614863488");


        // phoneBook["ahmed"] = "01594684961";

        //// Console.WriteLine($"Name = {phoneBook.Names[1]}, his phone number = {phoneBook.Numbers[1]}");

        // Console.WriteLine(phoneBook["ahmed"]);


        #region Class vs Struct

        // 1. Type => class : Reference Type ; Struct : Value Type
        //2.  Memory => class : Heap ; struct : Stack
        //3. Performance => class : slow considering Struct : very fast
        // 4. inheritance => class : allow inheritance ; struct : don't allow inheritance

        // Usage => Class : Complex Object  ; Struct : Small, lightweight Object 


        #endregion


        //TypeB type = new TypeB(10, 40, 50, 120);
        //TypeC type = new TypeC(10, 40, 50, 120, 10);


        //type.Print();

            //TypeA typeA = new TypeA(10,120,213);

            //typeA.Print();
    }
}

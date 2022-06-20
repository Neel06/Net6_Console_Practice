using AdaptersServiceTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptersServiceTest
{
    public class LinqExample    //Language Integrated Query;
    {
        //string[] Users = { "Anoz", "Neel", "Prince", "Ronak", "Dhaval", "Deep" };

        //List<Student> StudentList = new (){
        //    new Student (){ Id= 3,Name= "Neel", Age=24,Department = "IT" },
        //    new Student (){ Id= 2,Name= "Ronak", Age=22,Department = "CSE" },
        //    new Student (){ Id= 1,Name= "Anoz", Age=25,Department = "MECH" },
        //    new Student (){ Id= 12,Name= "Dhaval", Age=23,Department = "ELECTRICAL" },
        //    new Student (){ Id= 4,Name= "Prince", Age=24,Department = "CIVIL" },
        //    new Student (){ Id= 15,Name= "Deep", Age=21,Department = "PLASTIC" },
        //    new Student (){ Id= 22,Name= "Raj", Age=22,Department = "TEXTILE" },
        //    new Student (){ Id= 6,Name= "Miral", Age=24,Department = "ICE" },
        //};

        /// <summary>
        /// This method demonstrates simple Linq Query
        /// </summary>
        /// <param name="itemList">The list of Items</param> 
        /// <returns>IEnumerable Result Object</returns>

        public void LinqInQueryForm(String[] itemList)
        {
            var result = from user in itemList where user.Contains('e') orderby user ascending select user;
            Console.WriteLine(result.GetType());

            foreach (var user in result)
            {
                Console.WriteLine(user);
            }
        }

        /// <summary>
        /// This method demonstrates simple Linq Query
        /// </summary>
        /// <param name="StudentList">The list of Students</param> 
        /// <returns>IEnumerable Result Object</returns>
        /// 

        public void LinqInLambdaForm(List<Student> StudentList)
        {
            //var result = StudentList.Where(x => x.Id == 2).Select(y => y.Name) ;
            var result = StudentList.Where(y => y.Age == 22).Select(x => new { x.Id, x.Name });

            var resultWithSelectMany = StudentList.SelectMany(a => a.Name);

            foreach (var item in result)
            {
                Console.WriteLine("ID: " + item.Id+"\n\t"+"Name: " +item.Name);
            }
            Console.WriteLine("\nSelect many Starts form Here");
            foreach (var item in resultWithSelectMany)
            {
                Console.WriteLine(item);
            }
            
            
        }

    }


}

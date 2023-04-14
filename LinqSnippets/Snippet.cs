using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqSnippets
{



    public class Snippet
    {
        static public void BasicLinq()
        {
            string[] cars =
            {
                "VM Golf",
                "VM California",
                "Audi A3",
                "Audi A4",
                "Audi A5",
                "Fiat punto",
                "Seat Ibiza",
                "Seat Leon",
            };

            //1. select * de todos los carros
            var carList = from car in cars select car;

            foreach (var car in carList)
            {
                Console.WriteLine(car);
            };

            //2. Select * from tal cosa Where
            var carListAudi = from car in cars where car.Contains("Audi") select car;
            foreach (var audi in carListAudi)
            {
                Console.WriteLine(audi);
            };


        }

        //Number Examples
        static public void LinqNumbers()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //Each number multiplied by 3
            //Take all numbers, but 9
            //Order numbers by asc value

            var processedNumberList =
                numbers
                .Select(num => num * 3)
                .Where(num => num != 9)//{All but 9 }
                .OrderBy(num => num);//{at the end, we order. ascending}

        }

        static public void SearchExamples()
        {
            List<string> textList = new List<string>
            {
                "a",
                "b",
                "bc",
                "d",
                "e",
                "cj",
                "F",
                "g",
            };

            //1. First of all elements
            var first = textList.First();

            //2. First element that has "c"
            var cText = textList.First(text => text.Equals("c"));

            //3. First element that contain "j"
            var jText = textList.First(text => text.Contains("j"));

            //4.First element that contain "z" or default
            var firstOrDefaultText = textList.FirstOrDefault(text => text.Contains('z')); //"" or first elemente with"z"

            //5.Last element that contain "z" or default
            var lastOrDefaultText = textList.LastOrDefault(text => text.Contains('z')); //"" or last elemente with"z"

            //6. Single values
            var uniqueText = textList.Single(text=>text.Contains('c'));
            var uniqueOrDefaultText = textList.Single();


            int[] evenNumbers = { 0, 2, 4, 6, 8 };
            int[] otherNumbers = { 0, 2, 6 };

            //obtain {4,8} 
            var myEvenNumbers = evenNumbers.Except(otherNumbers); //{4,8}

        }



        static public void MultipleSelects()
        {
            //Select many
            string[] myOpinions =
            {
                "opinion1, text1",
                "opinion2, text2",
                "opinion3, text3"
            };

            var myOpinionSelect = myOpinions.SelectMany(opinion => opinion.Split(","));

            var enterprises = new[]
            {
                new Enterprise()
                {
                    Id=1,
                    Name = "Enterprise 1 ",
                    Employees = new[]
                    {
                        new Employee
                        {
                            Id=1,
                            Name= "juan",
                            Email = "ajklsd@gmail.ocm",
                            Salary = 50001
                        }, new Employee
                        {
                            Id=2,
                            Name= "juan2",
                            Email = "ajklsd2@gmail.ocm",
                            Salary = 50002
                        }, new Employee
                        {
                            Id=3,
                            Name= "juan3",
                            Email = "ajklsd3@gmail.ocm",
                            Salary = 50003
                        },
                    }
                }, new Enterprise()
                {
                    Id=2,
                    Name = "Enterprise 2  ",
                    Employees = new[]
                    {
                        new Employee
                        {
                            Id=4,
                            Name= "juan4",
                            Email = "ajklsd4@gmail.ocm",
                            Salary = 50004
                        }, new Employee
                        {
                            Id=5,
                            Name= "juan5",
                            Email = "ajklsd5@gmail.ocm",
                            Salary = 50005
                        }, new Employee
                        {
                            Id=6,
                            Name= "juan6",
                            Email = "ajklsd6@gmail.ocm",
                            Salary = 50006
                        },
                    }
                },

            };
        }


    }
}
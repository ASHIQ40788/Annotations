using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Annotation058
{
    class Program
    {
        static void Main(string[] args)
        {
            Author author = new Author();
            author.FirstName = "Xyz";
            author.LastName = "abcd";
            author.PhoneNumber = "8074334664";
            author.Email = "ashiqshaiksvali8@gmail.com";

            //use it for author
            TestAuthorModel(author);

            //use it for Employee
            //Type type = Type.GetType("MoodAnalyser05Batch.Employee");
            //CustomAttribute.AttributeDisplay(typeof(Employee));
            Console.ReadLine();
        }
        public static void TestAuthorModel(Author author)
        {
            ValidationContext context = new ValidationContext(author, null, null);
            List<ValidationResult> validationResults = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(author, context, validationResults, true);
            if (!valid)
            {
                foreach (ValidationResult validationResult in validationResults)
                {
                    Console.WriteLine("{0}", validationResult.ErrorMessage);
                }
            }
            else
            {
                Console.WriteLine("Satisfied all the validations");
            }
        }

    }
}
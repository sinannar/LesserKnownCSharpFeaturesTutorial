using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    In this tutorial, I am following this tutorials
    ->    https://ankitvijay.net/2018/01/08/lesser-known-c-features-part-1/

     */

namespace LesserKnownCSharpFeaturesTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee()
            {
                FirstName = "John",
                Surname = "Doe",
                Department ="Finance"
            };
        }
    }
}

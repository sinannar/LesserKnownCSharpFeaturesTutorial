using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CallerInfoExample;
/*
    In this tutorial, I am following this tutorials
    ->      https://ankitvijay.net/2018/01/08/lesser-known-c-features-part-1/
    ->      https://ankitvijay.net/2018/01/11/lesser-known-c-features-part-2/
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
                Department = "Finance"
            };


            Logger.Log("Testing logging inside Main() method");

#pragma warning disable CS0618 // Type or member is obsolete
            Logger.Log("Testing logging inside Main() method","Main");
#pragma warning restore CS0618 // Type or member is obsolete

        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyntaxAndSyntaxSugarExercise
{
    internal class methods
    {
        public static void main(string[] args) 
        {
            int answer = 4;
            string response;
            if (answer < 9)
            {
                response = answer + " is less than nine";
            }
            else
            {
                response = answer + " is greater than or equal to nine";
            }
            var answer1 = 4;
            var response2 = (answer < 9) ? $"{answer} is less then 9" : $"{answer} is greater than or equal to nine";
        }
    }
}

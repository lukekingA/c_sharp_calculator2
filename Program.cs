using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace calculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me an expression to evaluate.");
            string expression = Console.ReadLine();
            var expressionRemoveWhiteSpace = String.Join("",(Regex.Split(expression," ")));
            var expressionArr = Regex.Split(expressionRemoveWhiteSpace, "");

            var primaryExpressions = new List<ParenDetails>();


            for (int i = 0; i < expressionArr.Length; i++)
            {
                var currentChar = expressionArr[i];
                if (currentChar == "(")
                {
                    //Console.WriteLine($"Index of paren: {i}");
                    primaryExpressions.Add(new ParenDetails("o",i));
                } else if (currentChar == ")")
                {
                    //Console.WriteLine($"Index of paren: {i}");
                    primaryExpressions.Add(new ParenDetails("c", i));
                }
            }

            foreach(ParenDetails x in primaryExpressions)
            {
                Console.WriteLine($"x: {x.Index}: {x.Type}");
            }

            Console.WriteLine($"Count of parens: {primaryExpressions.Count}");

            if (primaryExpressions.Count > 0 && !(primaryExpressions.Count % 2 == 0))
            {
                throw new Exception("Invalid expression.");
            }

            //int centerOfPrimaryExpList = (primaryExpressions.Count / 2);
            //int opCenterOfPrimaryExpList = (primaryExpressions.Count / 2);
            //for (int j = primaryExpressions[centerOfPrimaryExpList]; j <= primaryExpressions[centerOfPrimaryExpList + 1]; j++)
            //{
            //    Console.WriteLine(j);
            //    Console.WriteLine(expressionArr[j]);
                
            //}

        }
    }
}

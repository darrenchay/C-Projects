using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator{
    class Program{
        static void Main(string[] args){
            string buffer;
            double currVal = 0;
            string[] elements = new string[20];
            double[] values = new double[15];
            char[] symbols = new char[15];
            int numElements = 0;
            int valuesCount = 0;
            int symbolCount = 0;
            bool isNumeric = true;

            Console.WriteLine("Enter what you want to do as such: 5 + 10 OR 2 ^ 4 etc (put spaces between each element). Press enter to calculate the equation written.\nWrite 'exit' to stop");

            //Keeps doing operations until user enters exit
            do{
                symbolCount = 0;
                valuesCount = 0;
                //reads and trims input line
                buffer = Console.ReadLine();
                buffer = buffer.Trim();

                //breaks down string into each element(both operations and numbers) and finds number of elements
                elements = buffer.Split(' ');
                numElements = elements.Length;

                //puts each element in its respective array
                foreach (string str in elements){
                    int i;
                    isNumeric = int.TryParse(str, out i);
                    if (!isNumeric){
                        symbols[symbolCount] = str[0];
                        symbolCount++;
                    }
                    else{
                        values[valuesCount] = Convert.ToDouble(str);
                        valuesCount++;
                    }
                }

                //Console.WriteLine("Num operations: {0} and num Values: {1}\n", symbolCount, valuesCount);

                //checks to see if first 
                int n;
                isNumeric = int.TryParse(elements[0], out n);
                if (!isNumeric){
                    for (int i = valuesCount; i > 0; i--){
                        values[i] = values[i-1];
                    }
                    values[0] = currVal;
                }
                else{

                }
            } while (string.Compare(buffer.ToLower(), "exit") != 0);


            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        static double calculate(double[] values, char[] symbols, int valCount, int symbolCount)
        {
            double answer = 0;
            //calculate answer but BODMAS rule respected
            return answer;
        }
    }
}

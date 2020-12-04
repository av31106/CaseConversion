using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UnitTestingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "this_is_avaiable";
            List<Task<string>> taskList = new List<Task<string>>();
            taskList.Add(Task<string>.Run(() => { return CamelCase(input); }));
            taskList.Add(Task<string>.Run(() => { return PascalCase(input); }));
            var result = Task.WhenAll(taskList);
            Console.WriteLine(result.Result[0]);
            Console.WriteLine(result.Result[1]);
            Console.ReadKey();
        }

        private static string CamelCase(string inputString)
        {
            //Checking null and empty string.
            if (string.IsNullOrEmpty(inputString))
                return inputString;

            var _charArray = inputString.ToCharArray();
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < _charArray.Length; i++)
            {
                if (_charArray[i] == '_')
                    output.Append(_charArray[++i].ToString().ToUpper());
                else
                    output.Append(_charArray[i]);
            }
            return output.ToString();
        }

        private static string PascalCase(string inputString)
        {
            //Checking null and empty string.
            if (string.IsNullOrEmpty(inputString))
                return inputString;

            var _charArray = inputString.ToCharArray();
            StringBuilder output = new StringBuilder();
            if (_charArray.Length > 0)
            {
                _charArray[0] = _charArray[0].ToString().ToUpper().ToCharArray()[0];
                for (int i = 0; i < _charArray.Length; i++)
                {
                    if (_charArray[i] == '_')
                        output.Append(_charArray[++i].ToString().ToUpper());
                    else
                        output.Append(_charArray[i]);
                }
            }
            return output.ToString();
        }
    }
}

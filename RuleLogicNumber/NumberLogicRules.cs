using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleLogicNumber
{
    class NumberLogicRules
    {
        private Dictionary<int, string> rules = new Dictionary<int, string>();
        private List<int> ruleOrder = new List<int>();

        public void AddRule(int input, string output)
        {
            rules[input] = output;
            if (!ruleOrder.Contains(input))
            {
                ruleOrder.Add(input);
                ruleOrder.Sort();
            }
        }

        public void EditRule(int input, string newOutput)
        {
            if (rules.ContainsKey(input))
            {
                rules[input] = newOutput;
            }
            else
            {
                Console.WriteLine($"Rule with input {input} does not exist.");
            }
        }

        public void DeleteRule(int input)
        {
            if (rules.ContainsKey(input))
            {
                rules.Remove(input);
                ruleOrder.Remove(input);
            }
            else
            {
                Console.WriteLine($"Rule with input {input} does not exist.");
            }
        }

        public void ShowRules()
        {
            foreach (var input in ruleOrder)
            {
                Console.WriteLine($"Input: {input}, Output: {rules[input]}");
            }
        }

        public void Generate(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                string result = "";

                foreach (var input in ruleOrder)
                {
                    if (i % input == 0)
                    {
                        result += rules[input];
                    }
                }

                if (string.IsNullOrEmpty(result))
                {
                    Console.Write(i);
                }
                else
                {
                    Console.Write(result);
                }

                if (i != n)
                {
                    Console.Write(", ");
                }
            }
        }
    }
}

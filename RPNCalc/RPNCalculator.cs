using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPNCalc
{
    public class RPNCalculator
    {
        public int find(int [] arr)
        {
            return 8;
        }

        public int PerformCalc(int a, int b, string calcOperator)
        {
            if (calcOperator == "+")
            {
                return a + b;
            }
            else if (calcOperator == "-")
            {
                return a - b;
            }
            else if (calcOperator == "*")
            {
                return a * b;
            }

            else 
            {
                return a / b;
            }
            
        }

        private bool IsOperator(string a)
        {
            if ((a == "+") || (a == "-") || (a == "*") || (a == "/"))
            {
                return true;
            }
            return false;
        }




        public int MyCalc(string input)
        {
            int result = Int32.MinValue;

            try
            {
                string[] data = input.Split(',');
                int a;
                int b;
                int n;

                Stack<int> st = new Stack<int>();

                for (int i = 0; i < data.Length; i++)
                {
                    if (!IsOperator(data[i]))
                    {
                        st.Push(Convert.ToInt32(data[i]));
                    }
                    else
                    {
                        n = OperateStack(st,data[i]);
                    }

                }
                
            }
            catch { }
            return result;
        }

        public int OperateStack(Stack<int> st,string operators)
        {
            int lr = int.MinValue;

            foreach (var item in st)
            {
                lr = PerformCalc(st.Pop(), st.Pop(),operators);
            }

            
            return lr;

        }
            
               
                        
        

        //private string findOperator(string input)
        //{
        
        //}
    }
}

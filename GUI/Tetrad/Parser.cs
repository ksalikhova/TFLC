using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Tetrad
{
    class Parser
    {
        private string input;
        private int pos;
        private List<Tetrad> tetradList;

        public Parser(string input)
        {
            this.input = input;
            pos = 0;
            tetradList = new List<Tetrad>();
        }

        public List<Tetrad> Parse()
        {
            E();
            return tetradList;
        }

        private void E()
        {
            T();
            A();
        }

        private void A()
        {
            if (pos < input.Length)
            {
                if (input[pos] == '+')
                {
                    pos++;
                    T();
                    Tetrad tetrad = new Tetrad();
                    tetrad.op = "+";
                    tetrad.arg1 = tetradList[tetradList.Count - 2].result;
                    tetrad.arg2 = tetradList[tetradList.Count - 1].result;
                    tetrad.result = "t" + tetradList.Count;
                    tetradList.Add(tetrad);
                }
                else if (input[pos] == '-')
                {
                    pos++;
                    T();
                    Tetrad tetrad = new Tetrad();
                    tetrad.op = "-";
                    tetrad.arg1 = tetradList[tetradList.Count - 2].result;
                    tetrad.arg2 = tetradList[tetradList.Count - 1].result;
                    tetrad.result = "t" + tetradList.Count;
                    tetradList.Add(tetrad);
                }
            }
        }

        private void T()
        {
            O();
            B();
        }

        private void B()
        {
            if (pos < input.Length)
            {
                if (input[pos] == '*')
                {
                    pos++;
                    O();
                    Tetrad tetrad = new Tetrad();
                    tetrad.op = "*";
                    tetrad.arg1 = tetradList[tetradList.Count - 2].result;
                    tetrad.arg2 = tetradList[tetradList.Count - 1].result;
                    tetrad.result = "t" + tetradList.Count;
                    tetradList.Add(tetrad);
                    B();
                }
                else if (input[pos] == '/')
                {
                    pos++;
                    O();
                    Tetrad tetrad = new Tetrad();
                    tetrad.op = "/";
                    tetrad.arg1 = tetradList[tetradList.Count - 2].result;
                    tetrad.arg2 = tetradList[tetradList.Count - 1].result;
                    tetrad.result = "t" + tetradList.Count;
                    tetradList.Add(tetrad);
                    B();
                }
            }
        }

        private void O()
        {
            if (pos < input.Length && Char.IsLetter(input[pos]))
            {
                Tetrad tetrad = new Tetrad();
                tetrad.op = "id";
                tetrad.arg1 = input[pos].ToString();
                tetrad.result = tetrad.arg1;
                tetradList.Add(tetrad);
                pos++;
            }
            else if (input[pos] == '(')
            {
                pos++;
                E();
                if (input[pos] == ')')
                {
                    pos++;
                }
            }
        }

        public List<Tetrad> ParseTetrad(string input)
        {
            Parser parser = new Parser(input);
            List<Tetrad> tetradList = parser.Parse();

            return tetradList;
        }
    }

    public class Tetrad
    {
        public string op;
        public string arg1;
        public string arg2;
        public string result;
    }

}

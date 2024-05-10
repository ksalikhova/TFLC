using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Classes
{
    public class LexemeAnalyzer
    {
        List<Lexemes> Lexemes = new List<Lexemes>();
   
        public List<Lexemes> Analyze(string input)
        {
            int index;
            string value = string.Empty;
            
            Lexemes.Clear();

            for (index = 0; index < input.Length; index++)
            {
                value = string.Empty + input[index];

                if (char.IsLetter(input[index]))
                {
                    int startIndex = index;

                    while ((index + 1) < input.Length && (char.IsLetterOrDigit(input[index + 1]) || input[index + 1] == '_'))
                    {
                        index++;
                        value += input[index];
                    }

                    switch (value)
                    {
                        case "Complex"://Const
                            Lexemes.Add(new Lexemes(TypeOfLexeme.Complex, value, startIndex + 1, index + 1));
                            break;
                        case "new"://удалить
                            Lexemes.Add(new Lexemes(TypeOfLexeme.NewInstanceOperator, value, startIndex + 1, index + 1));
                            break;
                        default://оставвить
                            Lexemes.Add(new Lexemes(TypeOfLexeme.Identifier, value, startIndex + 1, index + 1));
                            break;
                    }
                }
                else
                {
                    if (char.IsDigit(input[index]))
                    {
                        int startIndex = index;
                        string temp = String.Empty;
                        int count = 0;

                        while((index) < input.Length)
                        {
                            if(count > 0)
                            {
                                if (char.IsDigit(input[index]))
                                {
                                    temp += (input[index]).ToString();
                                    index++;
                                }
                                else                              
                                    break;
                            }
                            else
                            {
                                if (char.IsDigit(input[index]))
                                {
                                    temp += (input[index]).ToString();
                                    index++;
                                }
                                else if(input[index] == '.')
                                {
                                    temp += (input[index]).ToString();
                                    index++;
                                    count++;
                                }
                               
                            }
                            


                            //else if (input[index + 1] == '.')
                            //{
                            //    temp += (input[index]).ToString();
                            //    index++;
                            //}
                            //else
                            //    break;
                        }
                        Lexemes.Add(new Lexemes(TypeOfLexeme.UnsignedInteger, temp, startIndex + 1, index + 1));
                        //while ((index + 1) < input.Length && char.IsDigit(input[index]))
                        //{
                        //    //while ((index + 1) < input.Length && char.IsDigit(input[index + 1]) || (index + 1) < input.Length && char.IsDigit(input[index + 1]) && input[index + 2] == '.')
                        //    while ((index + 1) < input.Length && (char.IsDigit(input[index + 1]) || input[index + 1] == '.'))
                        //    {
                        //        if (input[index + 1] == '.')
                        //        {
                        //            //value += input[index];
                        //            value += input[index + 1];
                        //            index += 2;
                        //        }
                        //        else
                        //        {
                        //            break;
                        //        }
                               
                        //    }
                        //    value += input[index];//доработать
                        //    index++;                            
                        //}
                        //Lexemes.Add(new Lexemes(TypeOfLexeme.UnsignedInteger, value, startIndex + 1, index + 1));
                        //index--;
                    }
                    else
                    {
                        switch (input[index])
                        {
                            case '\t':
                            case ' ':
                                Lexemes.Add(new Lexemes(TypeOfLexeme.WhiteSpace, value, index + 1, index + 1));
                                break;
                            case '\n':
                                if ((index + 1) < input.Length)
                                {
                                    //index++;
                                    value = "\\n";//вот здесь посмотреть
                                    //Lexemes.Add(new Lexemes(TypeOfLexeme.NewLine, value, index, index + 1));
                                    Lexemes.Add(new Lexemes(TypeOfLexeme.NewLine, value, index+1, index + 2));
                                }
                                else
                                {
                                    Lexemes.Add(new Lexemes(TypeOfLexeme.InvalidCharacter, value, index + 1, index + 1)); //глянуть этот момент
                                }
                                break;                           
                            case '=':
                                Lexemes.Add(new Lexemes(TypeOfLexeme.AssignmentOperator, value, index + 1, index + 1));
                                break;
                            case '-':
                                Lexemes.Add(new Lexemes(TypeOfLexeme.Sign, value, index + 1, index + 1));
                                break;
                            case ';':
                                Lexemes.Add(new Lexemes(TypeOfLexeme.EndOfOperator, value, index + 1, index + 1));
                                break;
                            case '(':
                            case ')':
                                Lexemes.Add(new Lexemes(TypeOfLexeme.ArgumentPassingOperator, value, index + 1, index + 1));
                                break;
                            case ',':
                                Lexemes.Add(new Lexemes(TypeOfLexeme.ParameterSeparator, value, index + 1, index + 1));
                                break;
                            default:
                                Lexemes.Add(new Lexemes(TypeOfLexeme.InvalidCharacter, value, index + 1, index + 1));
                                break;
                        }
                    }
                }
                
            }

            return Lexemes;
        }

    }

    
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Classes
{
    public enum TypeOfLexeme
    {
        Complex = 1,        //const =1,
        //Identifier = 2,
        //AssignmentOperator =3,
        //WhiteSpace = 4,
        //NewLine = 5,
        //integer =6,
        // EndOfOperator =7
        Identifier = 2,
        NewInstanceOperator = 3,
        WhiteSpace = 4,
        NewLine = 5,
        AssignmentOperator = 6,
        ArgumentPassingOperator = 7,
        ParameterSeparator = 8,
        UnsignedInteger = 9,
        Sign = 10,
        EndOfOperator = 11,
        InvalidCharacter = 12
    }

    public class Lexemes
    {
        private string[] lexemeNames =
            {
                    "Структура", 
                    "Идентификатор", 
                    "Оператор создания нового экземпляра",
                    "Пробел", 
                    "Переход на новую строку", 
                    "Оператор присваивания", 
                    "Оператор передачи аргументов", 
                    "Разделение параметров", 
                    "Целое число без знака", 
                    "Знак", 
                    "Конец оператора", 
                    "Недопустимый символ" 
                };

        public int IdLexeme { get => (int)Type; }
        public string LexemeName { get => lexemeNames[IdLexeme - 1]; }
        public TypeOfLexeme Type { get; set; }
        public string Value { get; set; }
        public int StartPosition { get; set; }
        public int EndPosition { get; set; }
        public string Position { get => $"с {StartPosition} по {EndPosition} символы"; }

        public Lexemes(TypeOfLexeme type, string value, int startPosition, int endPosition)
        {
            Type = type;
            Value = value;
            StartPosition = startPosition;
            EndPosition = endPosition;
             
        }
    }
}

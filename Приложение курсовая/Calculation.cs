using System;
using System.Collections.Generic;

namespace Приложение_курсовая
{
    class Calculation
    {
        // Вычисление значения выражения в форме обратной польской записи
        public static string CalculateExpression( string Expression)
        {
            // Стек для хранения операндов на время вычислений
            Stack<double> CalculationStack = new Stack<double>();

            // Пока не закончится исходное выражение
            while (Expression != "")
            {
                // Считать токен
                string Token = Expression.Substring(0, Expression.IndexOf(' '));
                // Переменная для записи чисел в стек
                double Number;
                // Удалить считанный токен
                Expression = Expression.Remove(0, Expression.IndexOf(' ') + 1);

                // Если токен - число
                if (Double.TryParse(Token, out Number))
                    // Поместить токен в стек
                    CalculationStack.Push(Number);
                // Если токен - знак операции
                else
                {
                    // Переменная для записи последнего элемента стэка
                    double SecondOperand = CalculationStack.Pop();
                    // Выполнить соответствующую операцию и поместить результат в стек
                    switch (Token)
                    {
                        case "+":
                            CalculationStack.Push(CalculationStack.Pop() + SecondOperand);
                            break;
                        case "-":
                            CalculationStack.Push(CalculationStack.Pop() - SecondOperand);
                            break;
                        case "*":
                            CalculationStack.Push(CalculationStack.Pop() * SecondOperand);
                            break;
                        case "/":
                            if (SecondOperand == 0)
                                return "Попытка деления на ноль.";
                            CalculationStack.Push(CalculationStack.Pop() / SecondOperand);
                            break;
                        case "Mod":
                            if (SecondOperand == 0)
                                return "Попытка деления на ноль.";
                            CalculationStack.Push(CalculationStack.Pop() % SecondOperand);
                            break;
                        case "^":
                            if ((CalculationStack.Peek() == 0) && (SecondOperand < 0))
                                    return "Попытка деления на ноль.";
                            if (Double.IsNaN((Math.Pow(CalculationStack.Peek(), SecondOperand))))
                                return "Невозможно вычислить.";

                            CalculationStack.Push(Math.Pow(CalculationStack.Pop(), SecondOperand));
                            break;
                        case "Root":
                            if ((CalculationStack.Peek() == 0) && (SecondOperand < 0))
                                return "Попытка деления на ноль.";
                            if (Double.IsNaN((Math.Pow(CalculationStack.Peek(), SecondOperand))))
                                return "Невозможно вычислить.";

                            CalculationStack.Push(Math.Sign(CalculationStack.Peek()) *
                                Math.Pow(Math.Abs(CalculationStack.Pop()), 1 / SecondOperand));
                            break;
                    }
                }
            }

            // Вернуть единственный оставшийся элемент стека
            return CalculationStack.Pop().ToString();
        }
    }
}
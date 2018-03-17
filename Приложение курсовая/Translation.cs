using System.Collections.Generic;
using System.Linq;

namespace Приложение_курсовая
{
    class Translation
    {
        // Преобразование выражения к виду обратной польской записи
        public static string TranslateExpression(string Expression)
        {
            // Стек для хранения операторов на время преобразования выражения
            Stack<string> TranslationStack = new Stack<string>();
            // Строка, содержащая преобразованное выражение
            string RPNExpression = "";

            // Пока не закончится исходное выражение
            while (Expression != "")
            {
                // Берем первый токен выражения
                string Token = GetFirstToken(Expression);
                Expression = Expression.Remove(0, Token.Length).TrimStart(' ');

                // Токен - знак операции
                if (OperationSigns.Contains(Token))

                {
                    // Элемент на вершине стека - знак операции большего или равного приоритета
                    if ((TranslationStack.Count > 0) && (OperationSigns.Contains(TranslationStack.Peek())) &&
                    (CheckPriority(Token, TranslationStack.Peek())))
                        // Выталкиваем токен с вершины в выходную строку
                        RPNExpression += TranslationStack.Pop() + " ";

                    // Помещаем токен в стек
                    TranslationStack.Push(Token);
                }

                else
            // Токен - число
            if (FigureSigns.Contains(Token[0]))
                    // Добавляем токен в выходную строку
                    RPNExpression += Token + " ";

                else
                    // Токен - (
                    if (Token == "(")
                    // Помещаем токен в стек
                    TranslationStack.Push(Token);
                // Токен - )
                else if (Token == ")")
                {
                    // Пока не дойдем до токена (
                    while (TranslationStack.Peek() != "(")
                    {
                        // Выталкиваем токен с вершины в выходную строку
                        RPNExpression += TranslationStack.Pop() + " ";
                    }
                    // Удаялем токен (
                    TranslationStack.Pop();
                }
            }

            // Выталкиваем из стека в выходную все оставшиеся элементы
            while (TranslationStack.Count > 0)
                RPNExpression += TranslationStack.Pop() + " ";

            return RPNExpression;
        }

        // Получение первого токена выражения
        static string GetFirstToken(string Expression)
        {
            // Выражение начинается со знака "("
            if (Expression[0] == '(')
                return "(";
            // Выражение начинается со знака ")"
            if (Expression[0] == ')')
                return ")";
            // Если выражение состоит из одного токена
            if (!Expression.Contains(' '))
                return Expression.TrimEnd(')');

            // Во всех остальных случаях
            // Возвращаем фрагмент выражения до первого пробела с удалением закрывающих скобок в конце
            return Expression.Substring(0, Expression.IndexOf(' ')).TrimEnd(')');
        }

        // Проверка операции в стеке на больший или раный приоритет
        static bool CheckPriority(string NewOperation, string OperationInStack)
        {
            // Если добавляем операцию сложения или вычитания
            if (OperationSigns3.Contains(NewOperation))
                return true;
            // Если добавляем операцию умножения или деления
            if ((OperationSigns2.Contains(NewOperation)) && (!OperationSigns3.Contains(OperationInStack)))
                return true;
            // Если добавляем операцию возведения в степень или извлечения корня
            if ((OperationSigns1.Contains(NewOperation)) && (OperationSigns1.Contains(OperationInStack)))
                return true;
            return false;
        }

        // Массив цифр и разделяющей точки
        static char[] FigureSigns = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', ',', '-' };

        // Массив обозначений знаков операций
        static string[] OperationSigns = new string[] { "+", "-", "*", "/", "^", "Mod", "Root" };

        // Массив обозначений знаков операций с высшим приоритетом
        static string[] OperationSigns1 = new string[] { "^", "Root" };

        // Массив обозначений знаков операций с вторичным приоритетом
        static string[] OperationSigns2 = new string[] { "*", "/", "Mod" };

        // Массив обозначений знаков операций с наименьшим приоритетом
        static string[] OperationSigns3 = new string[] { "+", "-" };
    }
}
using System.Linq;
using System.Windows.Forms;

namespace Приложение_курсовая
{
    static class InputExpression
    {
        // Получаем выражение, записанное в tb_InOutPut
        static string Expression = (Application.OpenForms[0] as MainForm).Expression;

        // Количество открытых скобок в выражении
        static ushort CountOfOpenedParenthesises = 0;

        // Взять последний токен из выражения
        public static string GetLastToken()
        {
            // Получаем выражение, записанное в tb_InOutPut
            Expression = (Application.OpenForms[0] as MainForm).Expression;

            // Если выражение заканчивается на скобку )
            if (Expression.EndsWith(")"))
                return ")";
            // Если выражение заканчивается на скобку (
            if (Expression.EndsWith("("))
                return "(";
            // Если выражение состоит из одного токена
            if (!Expression.Contains(' '))
                return Expression.TrimStart('(').TrimEnd(')');

            // Во всех остальных случаях
            // Возвращаем фрагмент выражения после последнего пробела с удалением открывающих скобок в начале
            return Expression.Substring(Expression.LastIndexOf(' ') + 1).TrimStart('(');
        }

        //Проверка, является ли введенный токен знаком операции
        static bool IsOperation(string TokenToCheck)
        {
            return OperationSigns.Contains(TokenToCheck);
        }

        // Проверка, является ли введенный символ цифрой
        static bool IsFigure(char SymbolToCheck)
        {
            return FigureSigns.Contains(SymbolToCheck);
        }

        #region Добавление символов

        // Добавить цифру в выражение
        public static void AddFigure(char Figure)
        {
            // Проверяем последний токен
            // Последний токен 0
            if (GetLastToken() == "0")
            {
                // Удаляем из выражения последнее вхождение 0 и добавляем на это место новую цифру
                Expression = (Application.OpenForms[0] as MainForm).Expression =
                Expression.Remove(Expression.LastIndexOf('0')) + Figure;
            }
            else
            {
                // Последний токен - знак операции
                if (IsOperation(GetLastToken()))
                    // Начинаем новое число через пробел
                    Expression = (Application.OpenForms[0] as MainForm).Expression += " " + Figure;
                else

                // Последний токен - число или скобка (
                if (GetLastToken() != ")")
                    // Продолжаем текущее число или начинаем новое без пробела
                    Expression = (Application.OpenForms[0] as MainForm).Expression += Figure;
            }
        }

        // Добавить знак бинарной операции в выражение
        public static void AddBinaryOperation(string Sign)
        {
            // Если последний токен - не (
            if (GetLastToken() != "(")
            {
                // Последний токен - знак операции
                if (IsOperation(GetLastToken()))
                    // Удаляем из выражения последнее вхождение знака операции и добавляем на это место новый знак операции
                    Expression = (Application.OpenForms[0] as MainForm).Expression = Expression.Remove(Expression.LastIndexOf(' '));

                // Последний токен - число или скобка )
                else

                // Если предыдущее число заканчивается на ,
                if (Expression[Expression.Length - 1] == ',')
                    // Удаляем ,
                    Expression = (Application.OpenForms[0] as MainForm).Expression = Expression.Remove(Expression.Length - 1);

                // Добавляем знак операции
                Expression = (Application.OpenForms[0] as MainForm).Expression += " " + Sign;
            }
        }

        // Добавить знак унарной операции
        public static void AddUnaryOperation(string Sign)
        {
            // Последний токен - число
            if (IsFigure(Expression[Expression.Length - 1]))
                Expression = (Application.OpenForms[0] as MainForm).Expression =
                    Expression.Insert(Expression.Length - GetLastToken().Length, Sign);
            else

            // Последний токен - знак операции или скобка (
            if (IsOperation(GetLastToken()) || Expression[Expression.Length - 1] == '(')
            {
                // Удаляем все скобки ( и знак операции после последнего числа или скобки )
                Expression = (Application.OpenForms[0] as MainForm).Expression = Expression.Remove(Expression.LastIndexOf(' '));
                // Проверяем измененную строку
                AddUnaryOperation(Sign);
            }
            else

            // Последний токен - )
            if (Expression[Expression.Length - 1] == ')')
            {
                // Количество закрывающих скобок
                ushort ClosedParenthesises = 1;
                // Вспомогательная переменная для прохода по выражению
                int i = Expression.Length - 2;

                // Идем по выражению, пока не найдем соответствующую (
                while (ClosedParenthesises > 0)
                {
                    if (Expression[i] == ')')
                        ClosedParenthesises++;
                    else if (Expression[i] == '(')
                        ClosedParenthesises--;
                    i--;
                }

                // Вставляем в выражение знак операции
                Expression = (Application.OpenForms[0] as MainForm).Expression = Expression.Insert(i + 1, Sign);
            }
        }

        // Добавить отрицание в выражение
        public static void Negate()
        {
            // Последний токен - число, не 0
            if ((IsFigure(Expression[Expression.Length - 1])) && (GetLastToken() != "0"))
                // Число отрицательное
                if (GetLastToken().Contains('-'))
                    // Удаляем знак "-"
                    Expression = (Application.OpenForms[0] as MainForm).Expression = Expression.Remove(Expression.LastIndexOf('-'), 1);
                else
                    // Добавляем знак "-" перед числом
                    Expression = (Application.OpenForms[0] as MainForm).Expression = Expression.Insert(Expression.LastIndexOf(' ') + 1, "-");

            else

            // Последний токен - знак операции, или скобка
            {
                AddUnaryOperation("-1 * ");
            }
        }

        // Добавить знак (
        public static void AddOpeningParenthesis()
        {
            // Проверяем последний токен
            if (GetLastToken() == "(")
            {
                // Добавляем ( через пробел в конец выражения
                Expression = (Application.OpenForms[0] as MainForm).Expression += '(';
                CountOfOpenedParenthesises++;
            }
            else

            // Последний токен - знак операции
            if (IsOperation(GetLastToken()))
            {
                // Добавляем ( в конец выражения
                Expression = (Application.OpenForms[0] as MainForm).Expression += " (";
                CountOfOpenedParenthesises++;
            }
            else

            // Последний токен - число или скобка
            // Вставляем ( перед последним в выражении числом
            {
                Expression = (Application.OpenForms[0] as MainForm).Expression =
                      Expression.Insert(Expression.LastIndexOf(' ') + 1, "(");
                CountOfOpenedParenthesises++;
            }
        }

        // Добавить знак )
        public static void AddClosingParenthesis()
        {
            // Если количество открытых скобок больше 0
            if (CountOfOpenedParenthesises > 0)

                // Проверяем последний токен
                switch (GetLastToken())
                {
                    // Последний токен - (
                    case "(":
                        Expression = (Application.OpenForms[0] as MainForm).Expression =
                            Expression.Remove(Expression.Length - 1);
                        CountOfOpenedParenthesises--;

                        if (Expression == "")
                            Expression = (Application.OpenForms[0] as MainForm).Expression = "0";
                        break;
                    // Последний токен - )
                    case ")":
                        Expression = (Application.OpenForms[0] as MainForm).Expression += ")";
                        CountOfOpenedParenthesises--;
                        break;
                    default:
                        // Последний токен - знак операции
                        if (IsOperation(GetLastToken()))
                        // Удаляем из выражения последнее вхождение знака операции и добавляем на это место 
                        {
                            Expression = (Application.OpenForms[0] as MainForm).Expression =
                                  Expression.Remove(Expression.LastIndexOf(' ')) + ")";
                            CountOfOpenedParenthesises--;
                        }
                        else

                        // Последний токен - число
                        {
                            // Если число заканчивается на ,
                            if (Expression[Expression.Length - 1] == ',')
                                // Удаляем ,
                                Expression = (Application.OpenForms[0] as MainForm).Expression = Expression.Remove(Expression.Length - 1);
                            Expression = (Application.OpenForms[0] as MainForm).Expression += ")";
                            CountOfOpenedParenthesises--;
                        }
                        break;
                }
        }

        // Добавить знак ,
        public static void AddPoint()
        {
            // Если в текущем числе еще не было знака .
            if (!Expression.Substring(Expression.LastIndexOf(' ') + 1).Contains(','))

                // Проверяем последний токен
                // Последний токен - (
                if (GetLastToken() == "(")
                {
                    // Добавляем на это место 0,
                    Expression = (Application.OpenForms[0] as MainForm).Expression += "0,";
                }
                else
                // Последний токен - знак операции
                if (IsOperation(GetLastToken()))
                    Expression = (Application.OpenForms[0] as MainForm).Expression += " 0,";
                else

                    // Последний токен - число
                    if (GetLastToken() != ")")
                    Expression = (Application.OpenForms[0] as MainForm).Expression += ",";
        }
        #endregion Добавление символов

        // Удалить последний символ в строке
        public static void DeleteSymbol()
        {
            Expression = (Application.OpenForms[0] as MainForm).Expression;

            // Если в текст-боксе записано сообщение об ошибке
            if ((!OperationSigns.Contains(GetLastToken())) && (!FigureSigns.Contains(Expression[Expression.Length - 1])) &&
                (Expression[Expression.Length - 1] != ')') && (Expression[Expression.Length - 1] != '('))
                Clear();
            else

            // Если удаляемый символ - )
            if (GetLastToken() == ")")
            {
                CountOfOpenedParenthesises++;
                Expression = (Application.OpenForms[0] as MainForm).Expression = Expression.Remove(Expression.Length - 1);
            }
            else

            // Если удаляемый символ - (
            if (GetLastToken() == "(")
            {
                CountOfOpenedParenthesises--;
                Expression = (Application.OpenForms[0] as MainForm).Expression = Expression.Remove(Expression.Length - 1);
            }
            else

            // Если удаляемый элемент - цифра
            if (IsFigure(Expression[Expression.Length - 1]))
            {
                Expression = (Application.OpenForms[0] as MainForm).Expression = Expression.Remove(Expression.Length - 1);
                if (Expression.Length > 0 && Expression[Expression.Length - 1] == '-')
                    Expression = (Application.OpenForms[0] as MainForm).Expression = Expression.Remove(Expression.Length - 1);
                if (Expression.Length > 0 && Expression[Expression.Length - 1] == ' ')
                    Expression = (Application.OpenForms[0] as MainForm).Expression = Expression.Remove(Expression.Length - 1);
            }
            else

                // Если удаляемый элемент - знак операции
                Expression = (Application.OpenForms[0] as MainForm).Expression = Expression.Remove(Expression.LastIndexOf(' '));

            if (Expression == "")
                    Expression = (Application.OpenForms[0] as MainForm).Expression = "0";
        }

        // Очистить строку
        public static void Clear()
        {
            Expression = (Application.OpenForms[0] as MainForm).Expression = "0";
            CountOfOpenedParenthesises = 0;
        }

        // Закончить выражение
        public static void FinishInput()
        {
            Expression = (Application.OpenForms[0] as MainForm).Expression = Expression.Insert(0, "(");
            CountOfOpenedParenthesises++;

            while (CountOfOpenedParenthesises > 0)
                AddClosingParenthesis();

            Expression = Expression.Remove(0, 1);
            Expression = Expression.Remove(Expression.Length - 1);
            (Application.OpenForms[0] as MainForm).Expression = Expression;
        }

        static string[] OperationSigns = new string[] { "+", "-", "*", "/", "^", "Mod", "Root" };

        static char[] FigureSigns = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', ',', '-' };
    }
}
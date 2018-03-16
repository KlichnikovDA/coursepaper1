using System;
using System.Windows.Forms;

namespace Приложение_курсовая
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        // Свойство доступа к выражению, записанному в tb_InOutPut
        public string Expression
        {
            get { return tb_Input.Text; }
            set { tb_Input.Text = value; }
        }

        // Кнопки с цифрами и десятичным разделителем
        #region figures

        private void bt_0_Click(object sender, EventArgs e)
        {
            InputExpression.AddFigure('0');
        }

        private void bt_1_Click(object sender, EventArgs e)
        {
            InputExpression.AddFigure('1');
        }

        private void bt_2_Click(object sender, EventArgs e)
        {
            InputExpression.AddFigure('2');
        }

        private void bt_3_Click(object sender, EventArgs e)
        {
            InputExpression.AddFigure('3');
        }

        private void bt_4_Click(object sender, EventArgs e)
        {
            InputExpression.AddFigure('4');
        }

        private void bt_5_Click(object sender, EventArgs e)
        {
            InputExpression.AddFigure('5');
        }

        private void bt_6_Click(object sender, EventArgs e)
        {
            InputExpression.AddFigure('6');
        }

        private void bt_7_Click(object sender, EventArgs e)
        {
            InputExpression.AddFigure('7');
        }

        private void bt_8_Click(object sender, EventArgs e)
        {
            InputExpression.AddFigure('8');
        }

        private void bt_9_Click(object sender, EventArgs e)
        {
            InputExpression.AddFigure('9');
        }

        private void bt_Point_Click(object sender, EventArgs e)
        {
            InputExpression.AddPoint();
        }

        #endregion figures

        // Кнопки со знаками операций
        #region Arithmetics

        // Отрицание
        private void bt_Negote_Click(object sender, EventArgs e)
        {
            InputExpression.Negate();
        }

        // Сложение
        private void bt_Add_Click(object sender, EventArgs e)
        {
            InputExpression.AddBinaryOperation("+");
        }

        // Вычитание
        private void bt_Sub_Click(object sender, EventArgs e)
        {
            InputExpression.AddBinaryOperation("-");
        }

        // Умножение
        private void bt_Multiple_Click(object sender, EventArgs e)
        {
            InputExpression.AddBinaryOperation("*");
        }

        // Деление
        private void bt_Divide_Click(object sender, EventArgs e)
        {
            InputExpression.AddBinaryOperation("/");
        }

        // 1/x
        private void bt_DivideRevers_Click(object sender, EventArgs e)
        {
            InputExpression.AddUnaryOperation("1 / ");
        }

        // Получить остаток от деления
        private void bt_Mod_Click(object sender, EventArgs e)
        {
            InputExpression.AddBinaryOperation("Mod");
        }

        // Возведение в степень
        private void bt_Pow_Click(object sender, EventArgs e)
        {
            InputExpression.AddBinaryOperation("^");
        }

        // Извлечение корня
        private void bt_Root_Click(object sender, EventArgs e)
        {
            InputExpression.AddBinaryOperation("Root");
        }

        // Вычисление значения выражения
        private void bt_Equal_Click(object sender, EventArgs e)
        {
            InputExpression.FinishInput();
            tb_RPNExpression.Text = Translation.TranslateExpression(tb_Input.Text);
            tb_Output.Text = Calculation.CalculateExpression(tb_RPNExpression.Text);
        }

        #endregion Arithmetics

        // Редактирование выражения
        #region Edit

        // Удалить последний символ выражения
        private void bt_Backspace_Click(object sender, EventArgs e)
        {
            InputExpression.DeleteSymbol();
        }

        // Очистить выражение
        private void bt_ClearAll_Click(object sender, EventArgs e)
        {
            InputExpression.Clear();
        }

        #endregion Edit

        // Обработка нажатия клавиши
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                // Числовые клавиши
                #region Figures
                case Keys.D1:
                case Keys.NumPad1:
                    InputExpression.AddFigure('1');
                    break;
                case Keys.D2:
                case Keys.NumPad2:
                    InputExpression.AddFigure('2');
                    break;
                case Keys.D3:
                case Keys.NumPad3:
                    InputExpression.AddFigure('3');
                    break;
                case Keys.D4:
                case Keys.NumPad4:
                    InputExpression.AddFigure('4');
                    break;
                case Keys.D5:
                case Keys.NumPad5:
                    InputExpression.AddFigure('5');
                    break;
                case Keys.D6:
                    if (Control.ModifierKeys == Keys.Shift)
                        InputExpression.AddBinaryOperation("^");
                    else InputExpression.AddFigure('6');
                    break;
                case Keys.NumPad6:
                    InputExpression.AddFigure('6');
                    break;
                case Keys.D7:
                case Keys.NumPad7:
                    InputExpression.AddFigure('7');
                    break;
                case Keys.D8:
                    if (Control.ModifierKeys == Keys.Shift)
                        InputExpression.AddBinaryOperation("*");
                    else InputExpression.AddFigure('8');
                    break;
                case Keys.NumPad8:
                    InputExpression.AddFigure('8');
                    break;
                case Keys.D9:
                    if (Control.ModifierKeys == Keys.Shift)
                        InputExpression.AddOpeningParenthesis();
                    else InputExpression.AddFigure('9');
                    break;
                case Keys.NumPad9:
                    InputExpression.AddFigure('9');
                    break;
                case Keys.D0:
                    if (Control.ModifierKeys == Keys.Shift)
                        InputExpression.AddClosingParenthesis();
                    else InputExpression.AddFigure('0');
                    break;
                case Keys.NumPad0:
                    InputExpression.AddFigure('0');
                    break;
                #endregion Figures

                // Клавиши с десятичным разделителем и знаками операций
                case Keys.Divide:
                    InputExpression.AddBinaryOperation("/");
                    break;
                case Keys.Multiply:
                    InputExpression.AddBinaryOperation("*");
                    break;
                case Keys.Subtract:
                    InputExpression.AddBinaryOperation("-");
                    break;
                case Keys.Decimal:
                    InputExpression.AddPoint();
                    break;
                case Keys.Add:
                    InputExpression.AddBinaryOperation("+");
                    break;
                case Keys.OemMinus:
                    InputExpression.AddBinaryOperation("-");
                    break;
                case Keys.Oemplus:
                    if (Control.ModifierKeys == Keys.Shift)
                        InputExpression.AddBinaryOperation("+");
                    else
                    {
                        InputExpression.FinishInput();
                        tb_RPNExpression.Text = Translation.TranslateExpression(tb_Input.Text);
                        tb_Output.Text = Calculation.CalculateExpression(tb_RPNExpression.Text);
                    }
                    break;
                case Keys.Back:
                    InputExpression.DeleteSymbol();
                    break;
                case Keys.Escape:
                    InputExpression.Clear();
                    break;
            }
        }

        private void tb_InOutPut_TextChanged(object sender, EventArgs e)
        {
            if ((tb_Input.Text != "Попытка деления на ноль.") && 
                    (tb_Input.Text.StartsWith("Попытка деления на ноль.")))
                tb_Input.Text = tb_Input.Text.Remove(0, 24);

            if ((tb_Input.Text != "Невозможно вычислить.") && 
                (tb_Input.Text.StartsWith("Невозможно вычислить.")))
                tb_Input.Text = tb_Input.Text.Remove(0, 18);
        }
    }
}
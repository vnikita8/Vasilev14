using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Vasilev14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DrawFirstEx();
            DrawSecondEx();
            DrawThirdEx();
        }

        void DrawFirstEx() //Bank
        {
            CustomBank.BankAccount bank1 = new CustomBank.BankAccount(CustomBank.AccountType.текущий ,1000 );
            CustomBank.BankAccount bank2 = new CustomBank.BankAccount(CustomBank.AccountType.текущий, 2000);
            DrawBank(Bank1rich, bank1);
            DrawBank(Bank2rich, bank2);
            BankResult.Text = $"bank1 == bank2: {bank1 == bank2}\nbank1 != bank2: {bank1 != bank2}\nПервый ToString(): {bank1.ToString()}\nВторой ToString(): {bank2.ToString()}";

        }

        void DrawBank(RichTextBox richTextBox, CustomBank.BankAccount bankAccount)
        {
            richTextBox.Text = $"Номер: {bankAccount.GetNumber()}, баланс: {bankAccount.GetBalance()}, тип: {bankAccount.GetType()}";
        }

        void DrawSecondEx() //
        {
            RacNumbers racNumbers1= new RacNumbers(10, 5);
            RacNumbers racNumbers2 = new RacNumbers(20, 30);

            DrawRac(richTextBox5, racNumbers1);
            DrawRac(richTextBox6, racNumbers2);

            richTextBox4.Text = "";
            richTextBox4.Text += $"Действия:\n" +
                $"1 < 2 = {racNumbers1 < racNumbers2}\n" +
                $"1 > 2 = {racNumbers1 > racNumbers2}\n" +
                $"1 <= 2 = {racNumbers1 <= racNumbers2}\n" +
                $"1 >= 2 = {racNumbers1 >= racNumbers2}\n" +
                $"1 + 2 = {racNumbers1 + racNumbers2}\n" +
                $"1 - 2 = {racNumbers1 - racNumbers2}\n" +
                $"1++ = {racNumbers1++} | 2++ = {racNumbers2++}\n" +
                $"1-- = {racNumbers1--} | 2-- = {racNumbers2--}\n" +
                $"1 * 2 = {racNumbers1 * racNumbers2}\n" +
                $"1 / 2 = {racNumbers1 / racNumbers2}\n" +
                $"1 % 2 = {racNumbers1 % racNumbers2}\n" +
                $"1.Float() = {racNumbers1.getFloat()} | 2.Float() = {racNumbers2.getFloat()}";

        }

        void DrawRac(RichTextBox rich, RacNumbers number)
        {
            rich.Text += $"{number.numerator} / {number.denominator}";
        }

        void DrawThirdEx()
        {
            ComplexNum num1 = new ComplexNum(2, 4);
            ComplexNum num2 = new ComplexNum(5, 2);
            richTextBox8.Text = num1.ToString();
            richTextBox9.Text = num2.ToString();
            richTextBox7.Text = "";
            richTextBox7.Text = $"Операции:\n" +
                $"Сложение: {num1 + num2}\n" +
                $"Вычитание: {num1 - num2}\n" +
                $"Равенство: {num1 == num2}\n" +
                $"ToString(): {num1} | {num2}";
        }

        void DrawFourEx()
        {

        }
    }
}

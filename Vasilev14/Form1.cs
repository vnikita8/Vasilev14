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

        }

        void DrawThirdEx()
        {

        }

        void DrawFourEx()
        {

        }
    }
}

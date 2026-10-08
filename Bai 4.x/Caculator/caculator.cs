using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace dangkyhocvien
{
    public partial class caculator : Form
    {
        public caculator()
        {
            InitializeComponent();
        }
        double result = 0;
        string operation = "";
        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtDisplay.Text += button.Text;
        }
        private void OperationButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }
        private void btn_ketqua_Click(object sender, EventArgs e)
        {
            double secondNumber = double.Parse(txtDisplay.Text);
            switch (operation)
            {
                case "+":
                    result += secondNumber;
                    break;
                case "-":
                    result -= secondNumber;
                    break;
                case "*":
                    result *= secondNumber;
                    break;
                case "/":
                    if (secondNumber != 0)
                        result /= secondNumber;
                    else
                        MessageBox.Show("Cannot divide by zero");
                    break;
            }
            txtDisplay.Text = result.ToString();
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            result = 0;
            operation = "";
        }
    }
}

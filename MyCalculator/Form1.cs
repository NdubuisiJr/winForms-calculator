using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator {
    public partial class Form1 : Form {
        private Calculator _calculator;
        public Form1() {
            InitializeComponent();
            screen.Text = "0";
            _calculator = new Calculator();
        }
       
        private void button19_Click(object sender, EventArgs e) {
            Button button = (Button)sender;
            screen.Text = _calculator.PressNumber(screen.Text, button.Text);
        }

        private void button18_Click(object sender, EventArgs e) {
            screen.Text = _calculator.PressDotButton(screen.Text);
        }

        private void button6_Click(object sender, EventArgs e) {
            screen.Text = _calculator.Backspace(screen.Text);
        }

        private void button7_Click(object sender, EventArgs e) {
            screen.Text = _calculator.PressClear();
        }

        private void button20_Click(object sender, EventArgs e) {
            screen.Text = _calculator.PressSignButton(screen.Text);
        }

        private void button1_Click(object sender, EventArgs e) {
            screen.Text = _calculator.PressSin(screen.Text);
        }

        private void button2_Click(object sender, EventArgs e) {
            screen.Text = _calculator.PressCos(screen.Text);
        }

        private void button4_Click(object sender, EventArgs e) {
            screen.Text = _calculator.PressTan(screen.Text);
        }

        private void button21_Click(object sender, EventArgs e) {
            screen.Text = _calculator.PressPlus(screen.Text);
        }

        private void button17_Click(object sender, EventArgs e) {
            screen.Text = _calculator.PressEqualButton(screen.Text);
        }
    }
}

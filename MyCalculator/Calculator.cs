using System;

namespace MyCalculator {
    public class Calculator {
        public string PressNumber(string textOnScreen, string textOnButton) {
            string result = textOnScreen;
            int lengthOfScreen = textOnScreen.Length;
            if (lengthOfScreen >= 50) {
                return result;
            }
            else if (textOnScreen[0] == '0' && !textOnScreen.Contains(".")) {
                result = textOnScreen.Remove(0);
            }
            result += textOnButton;
            return result;
        }
        public string PressDotButton(string textOnScreen) {
            var result = textOnScreen;
            if (!textOnScreen.Contains(".")) {
                result += ".";
            }
            return result;
        }
        public string Backspace(string textOnScreen) {
            var result = textOnScreen;
            if (textOnScreen.Length > 0) {
                result = textOnScreen.Remove(textOnScreen.Length - 1);
                if (result.Length == 0) {
                    result = "0";
                }
            }
            return result;
        }
        public string PressClear() {
            return "0";
        }
        public string PressSignButton(string textOnScreen) {
            var result = textOnScreen;
            if (textOnScreen[0] == '-') {
                result = textOnScreen.Replace("-", "");
            }
            else if (textOnScreen.Length < 50 && textOnScreen!="0") {
                if (textOnScreen=="0.") {
                    return result;
                }
                result = "-"+textOnScreen;
            }
            return result;
        }
        public string PressSin(string textOnScreen) {
            double numToSin = double.Parse(textOnScreen);
            double sin = Math.Sin(numToSin*(Math.PI/180));
            return sin.ToString();
        }
        public string PressCos(string textOnScreen) {
            double numToSin = double.Parse(textOnScreen);
            double cos = Math.Cos(numToSin * (Math.PI / 180));
            return cos.ToString();
        }
        public string PressTan(string textOnScreen) {
            double numToSin = double.Parse(textOnScreen);
            double tan = Math.Tan(numToSin * (Math.PI / 180));
            return tan.ToString();
        }
        public string PressPlus(string textOnScreen) {
            _firstDigit = double.Parse(textOnScreen);
            _currentOperation = "plus";
            return "0";
        }
        public string PressEqualButton(string textOnScreen) {
            double secondDigit = double.Parse(textOnScreen);
            switch (_currentOperation) {
                case "plus":
                    _result = _firstDigit + secondDigit;
                    break;
                case "minus":
                    _result = _firstDigit - secondDigit;
                    break;
                case "multiplication":
                    _result = _firstDigit * secondDigit;
                    break;
                case "division":
                    _result = _firstDigit / secondDigit;
                    break;
                default:
                    break;
            }
            _currentOperation ="";
            return _result.ToString();
        }
        private double _firstDigit;
        private string _currentOperation;
        private double _result;
    }
}

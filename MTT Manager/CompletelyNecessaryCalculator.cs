using System;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace MTT_Manager
{
    public partial class CompletelyNecessaryCalculator : Form
    {
        private double currentValue = 0; // Para almacenar el número actual en la pantalla
        private double LastValue = 0;
        private string currentOperation = ""; // Para almacenar la operación actual
        private bool isNewNumber = true; // Bandera para saber si se ingresa un nuevo número
        private bool dotUsed = false; // Bandera para saber si ya se ha utilizado el punto decimal
        private bool TrigUsed = false;
        public bool isNewCalc = true;
        private bool MinusVal = false;
        string lastAdded = "";
        public CompletelyNecessaryCalculator()
        {
            InitializeComponent();
        }

        // Evento para números del 0 al 9
        private void Number_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string buttonText = button.Text;

            if (isNewNumber)
            {
                Label_Screen.Text = buttonText;
                isNewNumber = false;

            }
            else
            {
                Label_Screen.Text += buttonText;
            }
            if(isNewCalc)
            {
                Label_History.Text = "";
                isNewCalc = false;
            }

        }

        // Evento para el botón de punto decimal
        private void BT_Dot_Click(object sender, EventArgs e)
        {
            if (!dotUsed)
            {
                Label_Screen.Text += ",";
                dotUsed = true;
            }
        }

        // Evento para los botones de operadores (+, -, *, /)
        private void Operator_Click(object sender, EventArgs e)
        {
            if (!isNewNumber || isNewCalc)
            {
                LastValue = double.Parse(Label_Screen.Text);
                PerformPreviousOperation();
                Button button = (Button)sender;
                currentOperation = button.Text;
                isNewNumber = true;
                dotUsed = false;
                if (isNewCalc)
                {
                    Label_History.Text = "";
                    isNewCalc = false;
                }
                if (!TrigUsed && !MinusVal)
                    Label_History.Text += $"{LastValue} {currentOperation} ";
                else if (TrigUsed)
                {
                    Label_History.Text += $" {currentOperation} ";
                    TrigUsed = false;
                }
                else if (MinusVal)
                {
                    Label_History.Text += $"({LastValue}) {currentOperation} ";
                    MinusVal = false;
                }
                LastValue = currentValue;
            }
            else if (currentOperation != "")
            {
                Button button = (Button)sender;
                currentOperation = button.Text;
                isNewNumber = true;
                dotUsed = false;
                Label_History.Text = Label_History.Text.Remove(Label_History.Text.Length - 2, 2);
                Label_History.Text += $"{currentOperation} ";
                LastValue = currentValue;
            }

        }

        // Método para realizar la operación previa
        private void PerformPreviousOperation()
        {
            bool cero_error = false;
            double newNumber = double.Parse(Label_Screen.Text);
            switch (currentOperation)
            {
                case "+":
                    currentValue += newNumber;
                    break;
                case "-":
                    currentValue -= newNumber;
                    break;
                case "x":
                    currentValue *= newNumber;
                    break;
                case "÷":
                    if (newNumber != 0)
                    {
                        currentValue /= newNumber;
                    }
                    else
                    {
                        MessageBox.Show("Error: No se puede dividir por cero.");
                        currentValue = 0;
                        cero_error = true;
                    }
                    break;
                default:
                    currentValue = newNumber; break;
            }
            if (!cero_error)
            {
                if (currentOperation != "")
                    Label_Screen.Text = currentValue.ToString();
            }
            else
            {
                Label_Screen.Text = "Error";
                isNewNumber = true;
            }
        }

        // Evento para el botón de igual (=)
        private void BT_Equals_Click(object sender, EventArgs e)
        {
            LastValue = double.Parse(Label_Screen.Text);
            PerformPreviousOperation();
            currentOperation = "";
            dotUsed = false;
            if (!TrigUsed && !MinusVal && !isNewNumber)
                Label_History.Text += $"{LastValue} {currentOperation} =";
            else if (TrigUsed)
            {
                Label_History.Text += $" {currentOperation} =";
                TrigUsed = false;
            }
            else if (MinusVal)
            {
                Label_History.Text += $"({LastValue}) {currentOperation} =";
                MinusVal = false;
            }
            isNewNumber = true;
            isNewCalc = true;
            MinusVal = false;
            lastAdded = "";
        }

        // Evento para el botón de borrar (CE)
        private void BT_ClearEverything_Click(object sender, EventArgs e)
        {
            clearEverything();
        }
        void clearEverything()
        {
            Label_Screen.Text = "0";
            currentValue = 0;
            currentOperation = "";
            isNewNumber = true;
            Label_History.Text = "";
            LastValue = 0;
            dotUsed = false;
            isNewCalc = true;
            lastAdded = "";
            TrigUsed = false;
            MinusVal = false;
        }

        // Evento para el botón de borrar (C)
        private void BT_Clear_Click(object sender, EventArgs e)
        {
            
            Label_Screen.Text = "0";
            isNewNumber = true;
            dotUsed = false;
            if (isNewCalc)
                clearEverything();
        }

        // Evento para el botón de cambiar signo (+/-)
        private void BT_Plus_minus_Click(object sender, EventArgs e)
        {
            if (!isNewNumber)
            {
                double currentNumber = double.Parse(Label_Screen.Text);
                currentNumber *= -1;
                Label_Screen.Text = currentNumber.ToString();
                if(currentNumber < 0)
                    MinusVal = true;
            }
        }

        // Evento para el botón de porcentaje (%)
        private void BT_Percent_Click(object sender, EventArgs e)
        {

        }

        // Evento para las funciones trigonométricas (sin, cos, tan)
        private void Trig_Function_Click(object sender, EventArgs e)
        {
            LastValue = double.Parse(Label_Screen.Text);
            Button button = (Button)sender;
            string trigFunction = button.Text.ToLower();
            double angle = ConvertToRadians(double.Parse(Label_Screen.Text));

            switch (trigFunction)
            {
                case "sin":
                    Label_Screen.Text = Math.Sin(angle).ToString();
                    break;
                case "cos":
                    Label_Screen.Text = Math.Cos(angle).ToString();
                    break;
                case "tan":
                    Label_Screen.Text = Math.Tan(angle).ToString();
                    break;
            }

            if (TrigUsed || isNewNumber)
            {
                Label_History.Text = $"{trigFunction}({LastValue})";
            }
            else
            {

                lastAdded = $"{trigFunction}({LastValue}) ";
                Label_History.Text += $"{trigFunction}({LastValue}) ";
            }


            if (MinusVal) MinusVal = false;
            LastValue = currentValue;
            TrigUsed = true;
            PerformPreviousOperation();
            currentOperation = "";
        }

        // Método para convertir grados a radianes
        private double ConvertToRadians(double degrees)
        {
            return degrees * Math.PI / 180.0;
        }

        // Método para convertir radianes a grados
        private double ConvertToDegrees(double radians)
        {
            return radians * 180.0 / Math.PI;
        }



        private void BT_Root_Click(object sender, EventArgs e)
        {
            LastValue = double.Parse(Label_Screen.Text);
            double value = double.Parse(Label_Screen.Text);


            if (TrigUsed || isNewNumber)
            {
                Label_History.Text = $" {LastValue}² ";
            }
            else
            {

                lastAdded = $" {LastValue}² ";
                Label_History.Text += $" {LastValue}² ";
            }

            
            LastValue = currentValue;
            TrigUsed = true;
            var result = value * value;
            Label_Screen.Text = result.ToString();

            PerformPreviousOperation();
            currentOperation = "";
        }
    }
}

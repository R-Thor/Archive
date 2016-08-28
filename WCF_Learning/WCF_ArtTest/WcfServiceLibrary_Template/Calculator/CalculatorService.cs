using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary_Template
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class CalculatorService : ICalculatorService
    {
        delegate double CalculateDelegate(double x ,double y);
        CalculateDelegate calcDelegate;
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        private double Add(double x, double y)
        {
            return (x + y);
        }
        private double Subtract(double x, double y)
        {
            return (x - y);
        }
        private double Divide(double x, double y)
        {
            return (x / y);
        }
        private double Multiply(double x, double y)
        {
            return (x * y);
        }
        private double Modulus(double x, double y)
        {
            return (x % y);
        }

        public double Calculate(double number1, double number2, char Operator)
        {
            switch (Operator)
            {
                case '+':
                    calcDelegate = Add;
                    break;
                case '-':
                    calcDelegate = Subtract;
                    break;
                case '*':
                    calcDelegate = Multiply;
                    break;
                case '%':
                    calcDelegate = Modulus;
                    break;
                default:
                    throw new ApplicationException("Operator is Undefined");

            }
            return (calcDelegate(number1, number2));
        }
    }
}

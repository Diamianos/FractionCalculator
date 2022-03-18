using System;
using System.Windows.Forms;

namespace Fraction_Calculator
{
    public partial class frmFractionCalculator : Form
    {
        public frmFractionCalculator()
        {
            InitializeComponent();
        }

        private void txtNumerator1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Logic to handle only integers being inserted into text box
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtDenominator1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Logic to handle only integers being inserted into text box
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtNumerator2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Logic to handle only integers being inserted into text box
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtDenominator2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Logic to handle only integers being inserted into text box
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int f1Numerator = Int32.Parse(txtNumerator1.Text.ToString());
            int f1Denominator = Int32.Parse(txtDenominator1.Text.ToString());
            int f2Numerator = Int32.Parse(txtNumerator2.Text.ToString());
            int f2Denominator = Int32.Parse(txtDenominator2.Text.ToString());

            Fraction f1 = new Fraction(f1Numerator,f1Denominator);
            Fraction f2 = new Fraction(f2Numerator, f2Denominator);
            Fraction resultFraction = new Fraction();

            int selection = cmbOperators.SelectedIndex;
            try
            {
                switch (selection)
                {
                    case 0:
                        resultFraction = f1 + f2;
                        lblResults.Text = resultFraction.ToString();
                        tslMainOutput.Text = "Decimal equivalent: " + resultFraction.ToDecimal().ToString();
                        break;
                    case 1:
                        resultFraction = f1 - f2;
                        lblResults.Text = resultFraction.ToString();
                        tslMainOutput.Text = "Decimal equivalent: " + resultFraction.ToDecimal().ToString();
                        break;
                    case 2:
                        resultFraction = f1 * f2;
                        lblResults.Text = resultFraction.ToString();
                        tslMainOutput.Text = "Decimal equivalent: " + resultFraction.ToDecimal().ToString();
                        break;
                    case 3:
                        if (f2.Numerator == 0) {
                            throw new ArithmeticException();
                        }
                        resultFraction = f1 / f2;
                        lblResults.Text = resultFraction.ToString();
                        tslMainOutput.Text = "Decimal equivalent: " + resultFraction.ToDecimal().ToString();
                        break;
                }
            }
            catch (DivideByZeroException ex)
            {
                tslMainOutput.Text = "Denominators must be a positive whole number.";

                if (f1.Denominator == 0)
                {
                    txtDenominator1.Focus();
                    txtDenominator1.SelectAll();
                }
                else {
                    txtDenominator2.Focus();
                    txtDenominator2.SelectAll();
                }

                return;
            }
            catch (ArithmeticException ex)
            {
                tslMainOutput.Text = "Invalid numerator. Calculation requires division by zero.";
                txtNumerator2.Focus();
                txtNumerator2.SelectAll();
                return;
            }
            
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumerator1.Clear();
            txtDenominator1.Clear();
            txtNumerator2.Clear();
            txtDenominator2.Clear();
            tslMainOutput.Text = "";
            lblResults.Text = "";
            cmbOperators.SelectedIndex = 0;
            txtNumerator1.Focus();
        }

        private void frmFractionCalculator_Load(object sender, EventArgs e)
        {
            tslMainOutput.Text = "";
            cmbOperators.SelectedIndex = 0;
        }
    }
}

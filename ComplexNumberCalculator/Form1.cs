using System;
using System.Windows.Forms;

namespace ComplexNumberCalculator
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            ComplexNumber cn1 = new ComplexNumber();
            ComplexNumber cn2 = new ComplexNumber();

            try
            {
                cn1.a = Convert.ToInt32(complexNum1Box1.Text);
                cn1.b = Convert.ToInt32(complexNum1Box2.Text);
                cn2.a = Convert.ToInt32(complexNum2Box1.Text);
                cn2.b = Convert.ToInt32(complexNum2Box2.Text);

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

            ComplexNumber cnResult;
            switch (signBox.Text)
            {
                case "+":
                    cnResult = cn1 + cn2;
                    break;
                case "-":
                    cnResult = cn1 - cn2;
                    break;
                case "*":
                    cnResult = cn1 * cn2;
                    break;
                default:
                    MessageBox.Show(
                        "В поле 'Знак' должен быть один из следующих знаков арифметических операций: + - *",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1
                    );
                    return;
            }

            expLabel.Text = cn1.Output() + signBox.Text + cn2.Output();
            resultBox.Text = cnResult.Output();
        }
    }
}

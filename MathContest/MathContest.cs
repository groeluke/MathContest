/*Luke Groesbeck
Spring 2026
RCET 2265
Project MathContest
Computer Fundamentals and Introduction to Programming
https://github.com/groeluke/MathContest.git
*/

namespace MathContest
{
    public partial class MathContest : Form
    {
        public MathContest()
        {
            InitializeComponent();
            SetDefaults();
            ValidateFields();
        }

        //Custom Methods ------------------------------------------------------
        void SetDefaults()
        {
            NameTextBox.Text = "";
            GradeTextBox.Text = "";
            AgeTextBox.Text = "";
            FirstNumberTextBox.Text = "";
            SecondNumberTextBox.Text = "";
            StudentAnswerTextBox.Text = "";
            AddRadioButton.Checked = true;
            SubmitButton.Enabled = false;
            SummeryButton.Enabled = false;
        }


        void ValidateFields()
        {
            bool valid = true;
            if (string.IsNullOrEmpty(NameTextBox.Text))
                // Check if the name field is empty
            {
                valid = false;
            }
            else
            {
                valid = true;
            }
            if (string.IsNullOrEmpty(GradeTextBox.Text))
                // Check if the grade field is empty
            {
                valid = false;
            }
            else
            {
                valid = true;
            }
            if (string.IsNullOrEmpty(AgeTextBox.Text))
                // Check if the age field is empty
            {
                valid = false;
            }
            else
            {
                valid = true;
            }
        }
        void GenerateProblem()
        {
            Random random = new Random();
            int firstNumber = random.Next(1, 25);
            int secondNumber = random.Next(1, 25);
            FirstNumberTextBox.Text = firstNumber.ToString();
            SecondNumberTextBox.Text = secondNumber.ToString();
        }
        
        bool MathProblemSolved()
        {
            GenerateProblem();
            bool valid = false;
            int firstNumber = int.Parse(FirstNumberTextBox.Text);
            int secondNumber = int.Parse(SecondNumberTextBox.Text);

            switch(true)
                { 
                    case bool when AddRadioButton.Checked:
                        int sum = firstNumber + secondNumber;
                    if (StudentAnswerTextBox.Text == sum.ToString())
                    {
                        valid = true;
                    }
                    else
                    {
                        valid = false;
                    }
                        // Generate addition problem
                        break;
                    case bool when SubtractRadioButton.Checked:
                        int difference = firstNumber - secondNumber;
                    if (StudentAnswerTextBox.Text == difference.ToString())
                    {
                        valid = true;
                    }
                    else
                    {
                        valid = false;
                    }
                    // Generate subtraction problem
                    break;
                    case bool when MultiplyRadioButton.Checked:
                        int product = firstNumber * secondNumber;
                    if (StudentAnswerTextBox.Text == product.ToString())
                    {
                        valid = true;
                    }
                    else
                    {
                        valid = false;
                    }
                    // Generate multiplication problem
                    break;
                    case bool when DivideRadioButton.Checked:
                        int quotient = firstNumber / secondNumber;
                    if (StudentAnswerTextBox.Text == quotient.ToString())
                    {
                        valid = true;
                    }
                    else
                    {
                        valid = false;
                    }
                    // Generate division problem
                    break;
                }
            return true;
        }
        // Event Handlers -----------------------------------------------------

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            MathProblemSolved();

        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

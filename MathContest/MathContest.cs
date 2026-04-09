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
            ProblemTypeGroupBox.Enabled = false;
            StudentAnswerLabel.Enabled = false;
        }


        void ValidateFields()
        {
            bool valid = true;
            if (string.IsNullOrEmpty(NameTextBox.Text))
                // Check if the name field is empty
            {
                valid = false;
                NameTextBox.BackColor = Color.LightYellow;
            }
            else
            {
                valid = true;
                NameTextBox.BackColor = Color.White;
            }
            if (string.IsNullOrEmpty(GradeTextBox.Text))
                // Check if the grade field is empty
            {
                valid = false;
                GradeTextBox.BackColor = Color.LightYellow;
            }
            else
            {
                valid = true;
                GradeTextBox.BackColor = Color.White;
            }
            if (string.IsNullOrEmpty(AgeTextBox.Text))
                // Check if the age field is empty
            {
                valid = false;
                AgeTextBox.BackColor = Color.LightYellow;
            }
            else
            {
                valid = true;
                AgeTextBox.BackColor = Color.White;
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
        
        bool MathProblemSolved(decimal studentAnswer)
        {
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
            return valid;
        }
        // Event Handlers -----------------------------------------------------

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            decimal studentAnswer;
            if (decimal.TryParse(StudentAnswerTextBox.Text, out studentAnswer))
            {
                MathProblemSolved(studentAnswer);
            }
            else
            {
                // Handle invalid input
            }
        }
        private void SummeryButton_Click(object sender, EventArgs e)
        {
            int totalProblems = 0; // Track total problems attempted
            SubmitButton.Click += (s, args) => totalProblems++;
            SummeryButton.Click += (s, args) =>
            {
                MessageBox.Show($"Total Problems Attempted: {totalProblems}");
            };
            // Display summary of results
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateFields();
        }

        private void GradeTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateFields();
        }

        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateFields();
        }

    }
}

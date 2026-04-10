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
            FirstNumberTextBox.ReadOnly = true;
            SecondNumberTextBox.ReadOnly = true;
            StudentAnswerTextBox.Enabled = false;
            // Set default values for all controls and reset any state variables as needed
        }

        void ValidateFields()
        {
            bool valid = true;

            // Name - cannot be empty
            if (string.IsNullOrEmpty(NameTextBox.Text.Trim()))
            {
                valid = false;
                NameTextBox.BackColor = Color.LightYellow;
            }
            else
            {
                NameTextBox.BackColor = Color.White;
            }

            // Grade - must be integer 1-4
            int grade;
            if (!int.TryParse(GradeTextBox.Text.Trim(), out grade) || grade < 1 || grade > 4)
            {
                valid = false;
                GradeTextBox.BackColor = Color.LightYellow;
            }
            else
            {
                GradeTextBox.BackColor = Color.White;
            }

            // Age - must be integer 7-11
            int age;
            if (!int.TryParse(AgeTextBox.Text.Trim(), out age) || age < 7 || age > 11)
            {
                valid = false;
                AgeTextBox.BackColor = Color.LightYellow;
            }
            else
            {
                AgeTextBox.BackColor = Color.White;
            }

            // Enable the contest area ONLY when all student info is valid
            if (valid)
            {
                // Only generate a new problem the first time the contest becomes enabled
                // (prevents regenerating on every keystroke after the student info is valid)
                if (!ProblemTypeGroupBox.Enabled)
                {
                    ProblemTypeGroupBox.Enabled = true;
                    StudentAnswerTextBox.Enabled = true;
                    StudentAnswerLabel.Enabled = true;
                    SubmitButton.Enabled = true;
                    GenerateProblem();   // First problem for this student
                }
                else
                {
                    SubmitButton.Enabled = true;
                }
            }
            else
            {
                SubmitButton.Enabled = false;
                ProblemTypeGroupBox.Enabled = false;
                StudentAnswerTextBox.Enabled = false;
                StudentAnswerLabel.Enabled = false;
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
            int totalAttempts = 0;
            int correctCount = 0;
            int incorrectCount = 0;

            decimal studentAnswer;
            if (decimal.TryParse(StudentAnswerTextBox.Text.Trim(), out studentAnswer))
            {
                bool isCorrect = MathProblemSolved(studentAnswer);

                totalAttempts++;

                if (isCorrect)
                {
                    correctCount++;
                    MessageBox.Show("Congratulations! You got it right!", "Math Contest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    incorrectCount++;

                    // Calculate the correct answer to display (duplicated logic is minimal and keeps your original method unchanged)
                    int firstNumber = int.Parse(FirstNumberTextBox.Text);
                    int secondNumber = int.Parse(SecondNumberTextBox.Text);
                    int correctAnswer = 0;

                    if (AddRadioButton.Checked) correctAnswer = firstNumber + secondNumber;
                    else if (SubtractRadioButton.Checked) correctAnswer = firstNumber - secondNumber;
                    else if (MultiplyRadioButton.Checked) correctAnswer = firstNumber * secondNumber;
                    else if (DivideRadioButton.Checked) correctAnswer = (secondNumber != 0) ? firstNumber / secondNumber : 0;

                    MessageBox.Show($"Sorry, the correct answer is {correctAnswer}.", "Math Contest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Clear the student's answer and generate the next problem
                StudentAnswerTextBox.Text = "";
                GenerateProblem();

                // Summary button is now available (at least one problem has been submitted)
                SummeryButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please enter a valid number for your answer.", "Invalid Answer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            ValidateFields();
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

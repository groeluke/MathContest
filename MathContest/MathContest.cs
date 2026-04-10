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
        private int correctCount = 0;
        private int incorrectCount = 0;
        private int totalAttempts = 0;

        public MathContest()
        {
            InitializeComponent();
            SetDefaults();
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
            ResetSummary();
        }

        void ResetSummary()
        {
            correctCount = 0;
            incorrectCount = 0;
            totalAttempts = 0;
            SummeryButton.Enabled = false;
            // Reset any of the summary tracking variables and disable -
            // the summary button until at least one problem has been attempted
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

            // Grade must be integer 1-4
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

            // Age must be integer 7-11
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

            // Enable the contest area only when all student info is valid
            if (valid)
            {
                // Only generate a new problem the first time the contest becomes enabled
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

            switch (true)
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
            if (!decimal.TryParse(StudentAnswerTextBox.Text.Trim(), out decimal studentAnswer))
            {
                MessageBox.Show("Please enter a valid number.", "Invalid Answer");
                return;
            }

            bool isCorrect = MathProblemSolved(studentAnswer);
            totalAttempts++;

            if (isCorrect)
            {
                correctCount++;
                MessageBox.Show("Correct nice work!", correctCount + " correct");
            }
            else
            {
                incorrectCount++;
                int correctAnswer = AddRadioButton.Checked ? int.Parse(FirstNumberTextBox.Text) + int.Parse(SecondNumberTextBox.Text) :
                                  SubtractRadioButton.Checked ? int.Parse(FirstNumberTextBox.Text) - int.Parse(SecondNumberTextBox.Text) :
                                  MultiplyRadioButton.Checked ? int.Parse(FirstNumberTextBox.Text) * int.Parse(SecondNumberTextBox.Text) :
                                  (int.Parse(SecondNumberTextBox.Text) != 0 ? int.Parse(FirstNumberTextBox.Text) / int.Parse(SecondNumberTextBox.Text) : 0);

                MessageBox.Show($"Sorry, the correct answer is {correctAnswer}.", "Math Contest");
            }
            StudentAnswerTextBox.Clear();
            GenerateProblem();
            SummeryButton.Enabled = true;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SetDefaults();
            ValidateFields();
        }

        private void SummeryButton_Click(object sender, EventArgs e)
        {
            int totalProblems = 0; // Track total problems attempted
            SubmitButton.Click += (s, args) => totalProblems++;
            SummeryButton.Click += (s, args) =>
            {
                MessageBox.Show($"{NameTextBox.Text} got {correctCount++} out of possible {totalAttempts++} problems.");
            };
            // Display summary of results
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (AddRadioButton.Checked)
                GenerateProblem();
        }

        private void SubtractRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SubtractRadioButton.Checked)
                GenerateProblem();
        }

        private void MultiplyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MultiplyRadioButton.Checked)
                GenerateProblem();
        }

        private void DivideRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (DivideRadioButton.Checked)
                GenerateProblem();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            ResetSummary();
            ValidateFields();
        }

        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            ResetSummary();
            ValidateFields();
        }

        private void GradeTextBox_TextChanged(object sender, EventArgs e)
        {
            ResetSummary();
            ValidateFields();
        }
    }
}

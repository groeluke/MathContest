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
        private int totalProblems = 0;

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
            // set default values for all controls and reset any state variables as needed
            ResetSummary();
        }

        void ResetSummary()
        {
            correctCount = 0;
            incorrectCount = 0;
            totalAttempts = 0;
            totalProblems = 0;
            SummeryButton.Enabled = false;
            // reset any of the summary tracking variables and disable the
            // summary button until at least one problem has been attempted
        }


        void ValidateFields()
        {
            bool valid = true;

            // name text box cannot be empty
            if (string.IsNullOrEmpty(NameTextBox.Text.Trim()))
            {
                valid = false;
                NameTextBox.BackColor = Color.LightYellow;
            }
            else
            {
                NameTextBox.BackColor = Color.White;
            }

            // grade text box must be in the range of 1-4
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

            // age text box must be in the range 7-11
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

            // enable the contest area only when all student info is valid
            if (valid)
            {
                // only generate a new problem the first time the contest becomes enabled
                if (!ProblemTypeGroupBox.Enabled)
                {
                    ProblemTypeGroupBox.Enabled = true;
                    StudentAnswerTextBox.Enabled = true;
                    StudentAnswerLabel.Enabled = true;
                    SubmitButton.Enabled = true;
                    GenerateProblem();   // First problem for this student
                }
            }
            else // don't allow the user to interact with the form until all fields are valid
            {
                SubmitButton.Enabled = false;
                ProblemTypeGroupBox.Enabled = false;
                StudentAnswerTextBox.Enabled = false;
                StudentAnswerLabel.Enabled = false;
            }
            // validate the user input for the name, grade, and age fields
        }

        void GenerateProblem()
        {
            Random random = new Random();
            int firstNumber = random.Next(1, 15);
            int secondNumber = random.Next(1, 15);
            FirstNumberTextBox.Text = firstNumber.ToString();
            SecondNumberTextBox.Text = secondNumber.ToString();
            // Generate new random numbers for the problem
        }

        bool MathProblemSolved(decimal studentAnswer)
        {
            bool valid = false;
            int firstNumber = int.Parse(FirstNumberTextBox.Text);
            int secondNumber = int.Parse(SecondNumberTextBox.Text);
            // determine which operation is selected and calculate the correct answer

            switch (true)
            {
                case bool when AddRadioButton.Checked:
                    int sum = firstNumber + secondNumber;
                    if (StudentAnswerTextBox.Text == sum.ToString())
                        // compare the student's answer to the correct answer
                    {
                        valid = true;
                    }
                    else
                    {
                        valid = false;
                    }
                    break;
                case bool when SubtractRadioButton.Checked:
                    int difference = firstNumber - secondNumber;
                    if (StudentAnswerTextBox.Text == difference.ToString())
                        // compare the student's answer to the correct answer
                    {
                        valid = true;
                    }
                    else
                    {
                        valid = false;
                    }
                    break;
                case bool when MultiplyRadioButton.Checked:
                    int product = firstNumber * secondNumber;
                    if (StudentAnswerTextBox.Text == product.ToString())
                        // compare the student's answer to the correct answer
                    {
                        valid = true;
                    }
                    else
                    {
                        valid = false;
                    }
                    break;
                case bool when DivideRadioButton.Checked:
                    int quotient = firstNumber / secondNumber;
                    if (StudentAnswerTextBox.Text == quotient.ToString())
                        // compare the student's answer to the correct answer
                    {
                        valid = true;
                    }
                    else
                    {
                        valid = false;
                    }
                    break;
            }
            return valid;
            // figure out which operation is selected and check if the users answer is correct
        }

        // Event Handlers -----------------------------------------------------
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            int studentAnswer = 0;
            try
            {
                studentAnswer = int.Parse(StudentAnswerTextBox.Text);
                totalAttempts++;
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid number for your answer.", "Input Error");
            }

            bool isCorrect = MathProblemSolved(studentAnswer);

            if (isCorrect) // if correct increment the count and show that to the user
            {
                correctCount++;
                MessageBox.Show("Correct, nice work!", " Correct");
            }
            else // if incorrect increment the count and show that to the user
            {
                incorrectCount++;
                MessageBox.Show($"Sorry, that is incorrect.", "Math Contest");
            }
            StudentAnswerTextBox.Clear();
            GenerateProblem();
            SummeryButton.Enabled = true;
            // check the user's answer, update the counts of correct and
            // incorrect answers, and provide feedback to the user.
            // then generate a new problem for the user to solve.
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SetDefaults();
            ValidateFields();
            // clear all fields and reset the form to its default state
        }

        private void SummeryButton_Click(object sender, EventArgs e)
        {
            totalProblems = 0; // track total problems attempted
            {
                MessageBox.Show($"" +
                    $"     {NameTextBox.Text} got {correctCount} out\n" +
                    $"of possible {totalAttempts} problems.");
            };
            // display summary of results
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            // close the form
        }

        private void AddRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (AddRadioButton.Checked)
                GenerateProblem();
            //generate a new problem when the user changes the operation type
        }

        private void SubtractRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SubtractRadioButton.Checked)
                GenerateProblem();
            //generate a new problem when the user changes the operation type
        }

        private void MultiplyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MultiplyRadioButton.Checked)
                GenerateProblem();
            //generate a new problem when the user changes the operation type
        }

        private void DivideRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (DivideRadioButton.Checked)
                GenerateProblem();
            //generate a new problem when the user changes the operation type
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            ResetSummary();
            ValidateFields();
            // reset the summary and validate fields if the users name changes
        }

        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            ResetSummary();
            ValidateFields();
            // reset the summary and validate fields if the users age changes
        }

        private void GradeTextBox_TextChanged(object sender, EventArgs e)
        {
            ResetSummary();
            ValidateFields();
            // reset the summary and validate fields if the users grade changes
        }
    }
}

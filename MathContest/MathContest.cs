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
                valid = false;
        }

        // Event Handlers -----------------------------------------------------
    }
}

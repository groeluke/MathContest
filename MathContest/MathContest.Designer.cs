namespace MathContest
{
    partial class MathContest
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            SubmitButton = new Button();
            ClearButton = new Button();
            SummeryButton = new Button();
            ExitButton = new Button();
            ButtonsGroupBox = new GroupBox();
            MainToolTip = new ToolTip(components);
            StudentInformationGroupBox = new GroupBox();
            GradeLabel = new Label();
            AgeLabel = new Label();
            GradeTextBox = new TextBox();
            AgeTextBox = new TextBox();
            NameTextBox = new TextBox();
            NameLabel = new Label();
            MathProblemGroupBox = new GroupBox();
            StudentAnswerLabel = new Label();
            StudentAnswerTextBox = new TextBox();
            SecondNumberLabel = new Label();
            SecondNumberTextBox = new TextBox();
            FirstNumberLabel = new Label();
            FirstNumberTextBox = new TextBox();
            ProblemTypeGroupBox = new GroupBox();
            DivideRadioButton = new RadioButton();
            MultiplyRadioButton = new RadioButton();
            SubtractRadioButton = new RadioButton();
            AddRadioButton = new RadioButton();
            ButtonsGroupBox.SuspendLayout();
            StudentInformationGroupBox.SuspendLayout();
            MathProblemGroupBox.SuspendLayout();
            ProblemTypeGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(6, 30);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(200, 77);
            SubmitButton.TabIndex = 0;
            SubmitButton.Text = "&Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(8, 113);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(200, 77);
            ClearButton.TabIndex = 1;
            ClearButton.Text = "&Clear";
            ClearButton.UseVisualStyleBackColor = true;
            // 
            // SummeryButton
            // 
            SummeryButton.Location = new Point(8, 196);
            SummeryButton.Name = "SummeryButton";
            SummeryButton.Size = new Size(200, 77);
            SummeryButton.TabIndex = 2;
            SummeryButton.Text = "S&ummery";
            SummeryButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(8, 279);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(200, 77);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            // 
            // ButtonsGroupBox
            // 
            ButtonsGroupBox.Controls.Add(SubmitButton);
            ButtonsGroupBox.Controls.Add(ExitButton);
            ButtonsGroupBox.Controls.Add(ClearButton);
            ButtonsGroupBox.Controls.Add(SummeryButton);
            ButtonsGroupBox.Font = new Font("Source Code Pro", 10F);
            ButtonsGroupBox.Location = new Point(576, 2);
            ButtonsGroupBox.Name = "ButtonsGroupBox";
            ButtonsGroupBox.Size = new Size(212, 436);
            ButtonsGroupBox.TabIndex = 4;
            ButtonsGroupBox.TabStop = false;
            MainToolTip.SetToolTip(ButtonsGroupBox, "The buttons to control the sumbit answer, clear, summery, and exit the form.");
            // 
            // StudentInformationGroupBox
            // 
            StudentInformationGroupBox.Controls.Add(GradeLabel);
            StudentInformationGroupBox.Controls.Add(AgeLabel);
            StudentInformationGroupBox.Controls.Add(GradeTextBox);
            StudentInformationGroupBox.Controls.Add(AgeTextBox);
            StudentInformationGroupBox.Controls.Add(NameTextBox);
            StudentInformationGroupBox.Controls.Add(NameLabel);
            StudentInformationGroupBox.Font = new Font("Source Code Pro", 10F);
            StudentInformationGroupBox.Location = new Point(12, 2);
            StudentInformationGroupBox.Name = "StudentInformationGroupBox";
            StudentInformationGroupBox.Size = new Size(558, 120);
            StudentInformationGroupBox.TabIndex = 5;
            StudentInformationGroupBox.TabStop = false;
            StudentInformationGroupBox.Text = "Student Information";
            MainToolTip.SetToolTip(StudentInformationGroupBox, "Please enter all the  students information before being able to submit.");
            // 
            // GradeLabel
            // 
            GradeLabel.AutoSize = true;
            GradeLabel.Location = new Point(418, 45);
            GradeLabel.Name = "GradeLabel";
            GradeLabel.Size = new Size(73, 30);
            GradeLabel.TabIndex = 5;
            GradeLabel.Text = "Grade";
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(325, 45);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(49, 30);
            AgeLabel.TabIndex = 4;
            AgeLabel.Text = "Age";
            // 
            // GradeTextBox
            // 
            GradeTextBox.Location = new Point(418, 73);
            GradeTextBox.Name = "GradeTextBox";
            GradeTextBox.Size = new Size(46, 33);
            GradeTextBox.TabIndex = 3;
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(325, 73);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.Size = new Size(46, 33);
            AgeTextBox.TabIndex = 2;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(6, 76);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(206, 33);
            NameTextBox.TabIndex = 1;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(6, 48);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(61, 30);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Name";
            // 
            // MathProblemGroupBox
            // 
            MathProblemGroupBox.Controls.Add(StudentAnswerLabel);
            MathProblemGroupBox.Controls.Add(StudentAnswerTextBox);
            MathProblemGroupBox.Controls.Add(SecondNumberLabel);
            MathProblemGroupBox.Controls.Add(SecondNumberTextBox);
            MathProblemGroupBox.Controls.Add(FirstNumberLabel);
            MathProblemGroupBox.Controls.Add(FirstNumberTextBox);
            MathProblemGroupBox.Font = new Font("Source Code Pro", 10F);
            MathProblemGroupBox.Location = new Point(12, 128);
            MathProblemGroupBox.Name = "MathProblemGroupBox";
            MathProblemGroupBox.Size = new Size(300, 310);
            MathProblemGroupBox.TabIndex = 6;
            MathProblemGroupBox.TabStop = false;
            MathProblemGroupBox.Text = "Current Math Problem";
            MainToolTip.SetToolTip(MathProblemGroupBox, "Solve with these numbers using the problem type.");
            // 
            // StudentAnswerLabel
            // 
            StudentAnswerLabel.AutoSize = true;
            StudentAnswerLabel.Location = new Point(6, 207);
            StudentAnswerLabel.Name = "StudentAnswerLabel";
            StudentAnswerLabel.Size = new Size(181, 30);
            StudentAnswerLabel.TabIndex = 5;
            StudentAnswerLabel.Text = "Student Answer";
            // 
            // StudentAnswerTextBox
            // 
            StudentAnswerTextBox.Location = new Point(6, 235);
            StudentAnswerTextBox.Name = "StudentAnswerTextBox";
            StudentAnswerTextBox.Size = new Size(288, 33);
            StudentAnswerTextBox.TabIndex = 4;
            // 
            // SecondNumberLabel
            // 
            SecondNumberLabel.AutoSize = true;
            SecondNumberLabel.Location = new Point(6, 125);
            SecondNumberLabel.Name = "SecondNumberLabel";
            SecondNumberLabel.Size = new Size(133, 30);
            SecondNumberLabel.TabIndex = 3;
            SecondNumberLabel.Text = "2nd Number";
            // 
            // SecondNumberTextBox
            // 
            SecondNumberTextBox.Location = new Point(6, 153);
            SecondNumberTextBox.Name = "SecondNumberTextBox";
            SecondNumberTextBox.Size = new Size(288, 33);
            SecondNumberTextBox.TabIndex = 2;
            // 
            // FirstNumberLabel
            // 
            FirstNumberLabel.AutoSize = true;
            FirstNumberLabel.Location = new Point(6, 42);
            FirstNumberLabel.Name = "FirstNumberLabel";
            FirstNumberLabel.Size = new Size(133, 30);
            FirstNumberLabel.TabIndex = 1;
            FirstNumberLabel.Text = "1st Number";
            // 
            // FirstNumberTextBox
            // 
            FirstNumberTextBox.Location = new Point(6, 70);
            FirstNumberTextBox.Name = "FirstNumberTextBox";
            FirstNumberTextBox.Size = new Size(288, 33);
            FirstNumberTextBox.TabIndex = 0;
            // 
            // ProblemTypeGroupBox
            // 
            ProblemTypeGroupBox.Controls.Add(DivideRadioButton);
            ProblemTypeGroupBox.Controls.Add(MultiplyRadioButton);
            ProblemTypeGroupBox.Controls.Add(SubtractRadioButton);
            ProblemTypeGroupBox.Controls.Add(AddRadioButton);
            ProblemTypeGroupBox.Font = new Font("Source Code Pro", 10F);
            ProblemTypeGroupBox.Location = new Point(318, 128);
            ProblemTypeGroupBox.Name = "ProblemTypeGroupBox";
            ProblemTypeGroupBox.Size = new Size(252, 310);
            ProblemTypeGroupBox.TabIndex = 7;
            ProblemTypeGroupBox.TabStop = false;
            ProblemTypeGroupBox.Text = "Math Problem Type";
            MainToolTip.SetToolTip(ProblemTypeGroupBox, "Select a type of problem to solve.");
            // 
            // DivideRadioButton
            // 
            DivideRadioButton.AutoSize = true;
            DivideRadioButton.Location = new Point(17, 163);
            DivideRadioButton.Name = "DivideRadioButton";
            DivideRadioButton.Size = new Size(110, 34);
            DivideRadioButton.TabIndex = 3;
            DivideRadioButton.TabStop = true;
            DivideRadioButton.Text = "Divide";
            DivideRadioButton.UseVisualStyleBackColor = true;
            // 
            // MultiplyRadioButton
            // 
            MultiplyRadioButton.AutoSize = true;
            MultiplyRadioButton.Location = new Point(17, 128);
            MultiplyRadioButton.Name = "MultiplyRadioButton";
            MultiplyRadioButton.Size = new Size(134, 34);
            MultiplyRadioButton.TabIndex = 2;
            MultiplyRadioButton.TabStop = true;
            MultiplyRadioButton.Text = "Multiply";
            MultiplyRadioButton.UseVisualStyleBackColor = true;
            // 
            // SubtractRadioButton
            // 
            SubtractRadioButton.AutoSize = true;
            SubtractRadioButton.Location = new Point(17, 93);
            SubtractRadioButton.Name = "SubtractRadioButton";
            SubtractRadioButton.Size = new Size(134, 34);
            SubtractRadioButton.TabIndex = 1;
            SubtractRadioButton.TabStop = true;
            SubtractRadioButton.Text = "Subtract";
            SubtractRadioButton.UseVisualStyleBackColor = true;
            // 
            // AddRadioButton
            // 
            AddRadioButton.AutoSize = true;
            AddRadioButton.Location = new Point(17, 54);
            AddRadioButton.Name = "AddRadioButton";
            AddRadioButton.Size = new Size(74, 34);
            AddRadioButton.TabIndex = 0;
            AddRadioButton.TabStop = true;
            AddRadioButton.Text = "Add";
            AddRadioButton.UseVisualStyleBackColor = true;
            // 
            // MathContest
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ProblemTypeGroupBox);
            Controls.Add(MathProblemGroupBox);
            Controls.Add(StudentInformationGroupBox);
            Controls.Add(ButtonsGroupBox);
            Name = "MathContest";
            Text = "Math Contest";
            ButtonsGroupBox.ResumeLayout(false);
            StudentInformationGroupBox.ResumeLayout(false);
            StudentInformationGroupBox.PerformLayout();
            MathProblemGroupBox.ResumeLayout(false);
            MathProblemGroupBox.PerformLayout();
            ProblemTypeGroupBox.ResumeLayout(false);
            ProblemTypeGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button SubmitButton;
        private Button ClearButton;
        private Button SummeryButton;
        private Button ExitButton;
        private GroupBox ButtonsGroupBox;
        private ToolTip MainToolTip;
        private GroupBox StudentInformationGroupBox;
        private GroupBox MathProblemGroupBox;
        private GroupBox ProblemTypeGroupBox;
        private Label NameLabel;
        private Label GradeLabel;
        private Label AgeLabel;
        private TextBox GradeTextBox;
        private TextBox AgeTextBox;
        private TextBox NameTextBox;
        private RadioButton DivideRadioButton;
        private RadioButton MultiplyRadioButton;
        private RadioButton SubtractRadioButton;
        private RadioButton AddRadioButton;
        private Label SecondNumberLabel;
        private TextBox SecondNumberTextBox;
        private Label FirstNumberLabel;
        private TextBox FirstNumberTextBox;
        private Label StudentAnswerLabel;
        private TextBox StudentAnswerTextBox;
    }
}

class Question
{

    public string questionText;
    public string optionA;
    public string optionB;
    public string optionC;
    public string optionD;
    public char correctAnswerLetter;
    private static char defaultCorrectAnswer = 'X';

    public Question()
    {
        questionText = null;
        optionA = null;
        optionB = null;
        optionC = null;
        optionD = null;
        correctAnswerLetter = Question.defaultCorrectAnswer;
    }

    public Question(string questionText)
    {
        this.questionText = questionText;
        optionA = null;
        optionB = null;
        optionC = null;
        optionD = null;
        correctAnswerLetter = Question.defaultCorrectAnswer;
    }

    public Question(string questionText, string optionA, string optionB, string optionC, string optionD, char correctAnswerLetter)
    {
        this.questionText = questionText;
        this.optionA = optionA;
        this.optionB = optionB;
        this.optionC = optionC;
        this.optionD = optionD;
        if (validAnswer(correctAnswerLetter))
        {
            this.correctAnswerLetter = correctAnswerLetter;
        }
        else
        {
            this.correctAnswerLetter = Question.defaultCorrectAnswer;
        }

    }

    public bool validAnswer(char answer)
    {

        bool isValid = false;

        if (answer == 'A' || answer == 'B' || answer == 'C' || answer == 'D')
        {
            isValid = true;
        }

        return isValid;

    }

    public Boolean areOptionsValid()
    {
        int nullCount = 0;
        if (this.optionA == null)
        {
            nullCount++;
        }
        if (this.optionB == null)
        {
            nullCount++;
        }
        if (this.optionC == null)
        {
            nullCount++;
        }
        if (this.optionD == null)
        {
            nullCount++;
        }

        if (nullCount > 2)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}


class Program
{

    static void Main()
    {

        Question question1 = new Question();
        Question question2 = new Question("Where is the letter A?");
        Question question3 = new Question("Where is the letter B?", "A", "B", "C", "D", 'B');
        Question question4 = new Question("Where is the letter C?") { optionA = "A", optionB = "B", optionC = "C", optionD = "D" };
        question4.correctAnswerLetter = 'C';

    }

}


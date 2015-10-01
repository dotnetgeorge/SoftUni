using System;

public class SimpleMathExam : Exam
{

    public SimpleMathExam(int problemsSolved)
    {
        if (problemsSolved < 0)
        {
            problemsSolved = 0;
        }
        if (problemsSolved > 2)
        {
            problemsSolved = 2;
        }

        this.ProblemsSolved = problemsSolved;
    }

    public int ProblemsSolved { get; private set; }

    public override ExamResult Check()
    {
        switch (this.ProblemsSolved)
        {
            case 0:
                return new ExamResult(2, 2, 6, "Bad result: nothing done.");
            case 1:
                return new ExamResult(4, 2, 6, "Average result: nothing done.");
            case 2:
                return new ExamResult(6, 2, 6, "Average result: nothing done.");
            default:
                throw new ArgumentOutOfRangeException(nameof(this.ProblemsSolved), "Invalid number of problems solved!");
        }
    }
}

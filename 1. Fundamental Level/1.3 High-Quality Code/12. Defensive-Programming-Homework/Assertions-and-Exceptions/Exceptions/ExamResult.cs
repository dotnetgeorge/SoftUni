using System;

public class ExamResult
{
    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        if (grade < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(grade), string.Format("Grade should be in range[{0}..{1}]!!!", MinGrade, MaxGrade));
        }

        if (minGrade < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(minGrade), "Min grade should be bigger than 0!!!");
        }

        if (maxGrade <= minGrade)
        {
            throw new ArgumentOutOfRangeException(nameof(maxGrade), "Max grade should be bigger than Min Grade: " + MinGrade);
        }

        if (string.IsNullOrEmpty(comments))
        {
            throw new ArgumentNullException(nameof(comments), "Comments can not be null or empty!!!");
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }

    public int Grade { get; private set; }

    public int MinGrade { get; private set; }

    public int MaxGrade { get; private set; }

    public string Comments { get; private set; }
}

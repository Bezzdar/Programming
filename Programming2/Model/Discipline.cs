using System;

/// <summary>
/// Представляет дисциплину.
/// </summary>
class Discipline
{
    string _disciplineName;
    int _grade;
    int _semester;
    string _instructor;

    public string DisciplineName
    {
        get { return _disciplineName; }
        set
        {
            if (value.Length == 0) throw new ArgumentException();
            _disciplineName = value;
        }
    }
    public int Grade
    {
        get { return _grade; }
        set
        {
            Validator.AssertValueInRange(value, 0, 6);
            _grade = value;
        }
    }
    public int Semester
    {
        get { return _semester; }
        set
        {
            Validator.AssertValueInRange(value, 0, 9);
            _semester = value;
        }
    }
    public string Instructor
    {
        get { return _instructor; }
        set
        {
            if (value.Length == 0) throw new ArgumentException();
            _instructor = value;
        }
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса Discipline с параметрами по умолчанию.
    /// </summary>
    public Discipline()
    {
        DisciplineName = "Programming";
        Grade = 5;
        Semester = 2;
        Instructor = "Goryainov Alexander Evgenievich";
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса Discipline с указанными параметрами.
    /// </summary>
    /// <param name="disciplineName">Название дисциплины.</param>
    /// <param name="grade">Оценка по дисциплине.</param>
    /// <param name="semester">Семестр, в котором изучается дисциплина.</param>
    /// <param name="instructor">Преподаватель дисциплины.</param>
    public Discipline(string disciplineName, int grade, int semester, string instructor)
    {
        DisciplineName = disciplineName;
        Grade = grade;
        Semester = semester;
        Instructor = instructor;
    }
}

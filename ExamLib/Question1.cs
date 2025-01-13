namespace ExamLib;

public class Employee
{
    private const decimal MIN_SALARY = 20_000;
    private decimal salary;
    public decimal Salary
    { get => salary < MIN_SALARY ? MIN_SALARY : salary; set => salary = value < MIN_SALARY ? MIN_SALARY : value; }
}



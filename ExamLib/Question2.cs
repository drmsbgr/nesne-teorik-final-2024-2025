namespace ExamLib;

//soruda tamamı verilmemiş ve cevapta tamamen yer almıyor.
//CRUD İŞLEMLERİNİ İÇERDİĞİ SÖYLENİYOR.
public class EmployeeRepository
{
    //private readonly DbContext _context;
    public IQueryable<Employee> GetAll()
    {
        //return _context.Employees.AsQueryable();

        //içerik basitçe dolduruldu
        return new List<Employee>().AsQueryable();
    }

    //....
    //....
    //....
    //....
}

//cevap
public static class Extensions
{
    public static Employee[] SalaryInRange(this EmployeeRepository emp, decimal min, decimal max)
    {
        return emp.GetAll().Where(x => x.Salary >= min && x.Salary <= max).ToArray();
    }
}


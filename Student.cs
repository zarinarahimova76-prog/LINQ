public enum Gender
{
    Male,
    Female
}

public enum Status
{
    Active,
    InActive
}

public class Student
{
    public int Id { get; set; }
    public string Name {get; set;} = null!;
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; }=null!;
    public int Age {get; set;}   
    public Gender Gender { get; set; }
    public Status Status { get; set; }
    public DateTime DateOfStart { get; set; }
    public DateTime DateOfFinish { get; set; }
    public DateTime DateOfBirth { get; set; }
}
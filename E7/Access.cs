namespace E7;

public class Access
{
    public string Name { get; set; }
    private string Surname { get; set; }
    internal string MiddleName { get; set; }
    protected string MiddleSurname { get; set; }

    public Access(string name, string surname, string middleName, string middleSurname)
    {
        Name = name;
        Surname = surname;
        MiddleName = middleName;
        MiddleSurname = middleSurname;
    }
}
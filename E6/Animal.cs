namespace E6;

public abstract class Animal
{
    protected Animal(string name)
    {
        this.Name = name;
    }

    public string Name { get; }

    public abstract void MakeSound();

    public abstract void Eat();
}
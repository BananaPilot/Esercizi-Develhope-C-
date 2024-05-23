using E6;

Animal cat = new Cat("Lucy");
Animal dog = new Dog("Luna");

dog.MakeSound();
dog.Eat();
cat.MakeSound();
cat.Eat();

Console.WriteLine(cat.Name);
Console.WriteLine(dog.Name);
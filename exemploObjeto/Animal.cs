namespace std;
public class Animal {
  // Herança
  protected string Name { get; set; }
  public Animal(string name) {
    Name = name;
  } // CONSTRUTOR
  public void Eat() {
    Console.WriteLine($"{Name} está comendo.");
  }

  // Plimorfismo
  public virtual void MakeSound() {
    Console.WriteLine("O animal faz algum som.");
  }
}

public class Cat : Animal {
  // Herança
  public Cat(string name) : base(name) {}

  public void Meow() {
    Console.WriteLine($"{Name} está miando.");
  }

  // Plimorfismo
  // override = sobrescreve|Reutiliza aquele que já tem na classe pai/principal
  public override void MakeSound() {
    Console.WriteLine("O gato faz 'Miau!'");
  }
}

public class Dog : Animal {
  // Herança
  public Dog(string name) : base(name) {}
  public void Bark() {
    Console.WriteLine($"{Name} está latindo.");
  }

  // Polimorfismo
  public override void MakeSound() {
    Console.WriteLine("O cachorro faz 'Au Au!'");
  }
}
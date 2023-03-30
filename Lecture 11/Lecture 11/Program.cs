

using System.ComponentModel.DataAnnotations;

var p1 = new Person("Daniel", "Hedin");
var p2 = new Person("Daniel", "Hedin");

var p3 = p1 with { FirstName = "Sven" };

Console.WriteLine($"{p3}");

var b = new Ball( new Point { X = 0, Y = 0 } );
b.Location = b.Location with { X = 15 };
b.Location = new Point { X = 15, Y = b.Location.X };
b.Location.X = -15;

Console.WriteLine($"{b.Location}");

struct Point
{
    public float X, Y;

    public override string ToString()
    {
        return $"<{X}, {Y}>";
    }
}

class Ball
{
    public Point Location;

    public Ball(Point location)
    {
        Location = location;
    }   

    public void ScalePoint(float x, float y)
    {
        Location.X *= x;
        Location.Y *= y;    
    }
}


record Person(string FirstName, string LastName);
record BoilerPerson
{
    public string FirstName { get; set; } = default!;
    public string LastName { get; init; } = default!;

    public BoilerPerson(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}
class BadPerson
{
    public string FirstName { get; init; }
    public string LastName { get; init; }

    public BadPerson(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public override bool Equals(object? obj)
    {
        if (!(obj is Person)) return false;
        var other = obj as Person;
        if (other == null) return false;    
        return FirstName.Equals(other.FirstName) && LastName.Equals(other.LastName);
      
    }


}

namespace FlyweightPattern.Videogame;

public class ParticleType
{
    private readonly string _sprite;
    private readonly string _color;
    public ParticleType(string sprite, string color)
    {
        this._sprite = sprite;
        this._color = color;
        Console.WriteLine("Initializing a Flyweight ParticleType instance with sprite {0} and color {1}", _sprite, _color);
    }

    public string GetKey()
    {
        string key = _sprite + "_" + _color;
        return key;
    }

    public void Draw(string canvas, string coordinates)
    {
        Console.WriteLine("Draw particle with sprite {0} and color {1} in canvas {2} with coordinates {3}", _sprite, _color, canvas, coordinates);
    }
}

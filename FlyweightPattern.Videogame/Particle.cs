namespace FlyweightPattern.Videogame;

public class Particle
{
    private readonly ParticleType _particleType;
    private readonly string _coordinates;
    private readonly string _vector;
    private readonly float _speed;

    public Particle(ParticleType particleType, string coordinates, string vector, float speed)
    {
        this._particleType = particleType;
        this._coordinates = coordinates;
        this._vector = vector;
        this._speed = speed;
        var key = _particleType.GetKey();
        Console.WriteLine("Initializing a Particle instance with key {3} coordinates {0}, vector {1} and speed {2}", _coordinates,_vector, _speed,key);
    }

    public void Draw(string canvas)
    {
        Console.WriteLine("Vector is {0} and speed is {1}", _vector, _speed);
        _particleType.Draw(canvas, _coordinates);
    }

}

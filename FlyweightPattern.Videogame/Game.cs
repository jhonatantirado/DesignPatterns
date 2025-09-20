using System;

namespace FlyweightPattern.Videogame;

public class Game
{
    private readonly string _name;
    public List<Particle> _particles;
    private readonly ParticleTypeFactory _particleTypeFactory;
    public Game(string name)
    {
        _name = name;
        _particles = [];
        _particleTypeFactory = ParticleTypeFactory.Instance();
        InitializeFactory();
    }

    private void InitializeFactory()
    {
        ParticleTypeFactory.GetParticleType("ammo01.jpg", "red");
        ParticleTypeFactory.GetParticleType("ammo02.jpg", "red");
        ParticleTypeFactory.GetParticleType("ammo03.jpg", "red");
        ParticleTypeFactory.GetParticleType("ammo01.jpg", "green");
        ParticleTypeFactory.GetParticleType("ammo02.jpg", "green");
        ParticleTypeFactory.GetParticleType("ammo03.jpg", "green");
        ParticleTypeFactory.GetParticleType("ammo01.jpg", "blue");
        ParticleTypeFactory.GetParticleType("ammo02.jpg", "blue");
        ParticleTypeFactory.GetParticleType("ammo03.jpg", "blue");
        var serializedFactory = ParticleTypeFactory.GetDictionaryToString();
        Console.WriteLine(serializedFactory);
    }

    public void AddParticle(string sprite, string color, string coordinates, string vector, float speed)
    {
        ParticleType type = ParticleTypeFactory.GetParticleType(sprite, color);
        Particle particle = new(type, coordinates, vector, speed);
        _particles.Add(particle);
    }

    public void Draw(string canvas)
    {
        var countParticleTypes = ParticleTypeFactory.Count();
        Console.WriteLine("Number of ParticleType elements according to Dictionary: {0}", countParticleTypes);

        var countParticles = _particles.Count;
        Console.WriteLine("Number of Particles elements in the list: {0}", countParticles);

        Console.WriteLine("Drawing all particles in canvas {0}", canvas);        
        foreach (var particle in _particles)
        {
            particle.Draw(canvas);
        }
    }
}

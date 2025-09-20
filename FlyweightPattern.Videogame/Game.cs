using System;

namespace FlyweightPattern.Videogame;

public class Game
{
    private readonly Particle[] _particles;
    private ParticleTypeFactory _particleTypeFactory;

    public Game()
    {
        _particles = [];
        InitializeFactory();
    }

    private void InitializeFactory()
    {
        _particleTypeFactory = new ParticleTypeFactory();
        _particleTypeFactory.GetParticleType("ammo01.jpg", "red");
        _particleTypeFactory.GetParticleType("ammo02.jpg", "red");
        _particleTypeFactory.GetParticleType("ammo03.jpg", "red");
        _particleTypeFactory.GetParticleType("ammo01.jpg", "green");
        _particleTypeFactory.GetParticleType("ammo02.jpg", "green");
        _particleTypeFactory.GetParticleType("ammo03.jpg", "green");
        _particleTypeFactory.GetParticleType("ammo01.jpg", "blue");
        _particleTypeFactory.GetParticleType("ammo02.jpg", "blue");
        _particleTypeFactory.GetParticleType("ammo03.jpg", "blue");
        var serializedFactory = _particleTypeFactory.GetDictionaryToString();
        Console.WriteLine(serializedFactory);
    }

    public void AddParticle(string sprite, string color, string coordinates, string vector, float speed)
    {
        ParticleType type = _particleTypeFactory.GetParticleType(sprite, color);
        Particle particle = new(type, coordinates, vector, speed);
        _particles.Append(particle);
    }

    public void Draw(string canvas)
    {
        Console.WriteLine("Drawing all particles in canvas {0}", canvas);
        var serializedFactory = _particleTypeFactory.GetDictionaryToString();
        Console.WriteLine(serializedFactory);
        
        foreach (var particle in _particles)
        {
            particle.Draw(canvas);
        }
    }
}

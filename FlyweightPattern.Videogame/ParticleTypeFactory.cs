using System;

namespace FlyweightPattern.Videogame;

public sealed class ParticleTypeFactory
{
    private static readonly ParticleTypeFactory instance = new ParticleTypeFactory();
    private static Dictionary<string, ParticleType> _particleTypes;

    static ParticleTypeFactory()
    {
        _particleTypes = new Dictionary<string, ParticleType>();
    }
    private ParticleTypeFactory()
    {
        _particleTypes = new Dictionary<string, ParticleType>();
    }

    public static ParticleTypeFactory Instance()
    {        
        return instance;
    }

    public static ParticleType GetParticleType(string sprite, string color)
    {
        string key = sprite + "_" + color;
        Console.WriteLine("Getting Particle Type with key {0}", key);

        if (!_particleTypes.ContainsKey(key))
            _particleTypes.Add(key, new ParticleType(sprite, color));

        return _particleTypes[key];
    }

    public static int Count()
    {
        return _particleTypes.Count;
    }

    public static string GetDictionaryToString()
    {
        string dictionaryString = "";

        if (_particleTypes != null)
        {
            dictionaryString = string.Join(", ", _particleTypes.Select(kvp => $"{kvp.Key}: {kvp.Value}"));
        }

        return dictionaryString;
    }

}

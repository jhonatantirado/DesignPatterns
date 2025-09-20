using System;

namespace FlyweightPattern.Videogame;

public class ParticleTypeFactory
{
    private static ParticleTypeFactory? instance = null;
    private readonly Dictionary<string, ParticleType> _particleTypes;
    private ParticleTypeFactory()
    {
        _particleTypes = new Dictionary<string, ParticleType>();
    }

    public static ParticleTypeFactory Instance()
    {
        if (instance == null)
        {
            instance = new ParticleTypeFactory();
        }
        return instance;
    }

    public ParticleType GetParticleType(string sprite, string color)
    {
        string key = sprite + "_" + color;
        Console.WriteLine("Getting Particle Type with key {0}", key);

        if (!_particleTypes.ContainsKey(key))
            _particleTypes.Add(key, new ParticleType(sprite, color));

        return _particleTypes[key];
    }

    public int Count()
    {
        return _particleTypes.Count;
    }

    public string GetDictionaryToString()
    {
        string dictionaryString = "";

        if (this._particleTypes != null)
        {
            dictionaryString = string.Join(", ", _particleTypes.Select(kvp => $"{kvp.Key}: {kvp.Value}"));
        }

        return dictionaryString;
    }

}

using System;

namespace FlyweightPattern.Videogame;

public class ParticleTypeFactory
{
    private readonly Dictionary<string, ParticleType> _particleTypes;
    public ParticleTypeFactory()
    {
        _particleTypes = new Dictionary<string, ParticleType>();
    }

    public ParticleType GetParticleType(string sprite, string color)
    {
        string key = sprite + "_" + color;
        Console.WriteLine("Getting Particle Type with key {0}", key);

        if (!_particleTypes.ContainsKey(key))
            _particleTypes.Add(key, new ParticleType(sprite, color));

        return _particleTypes[key];
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

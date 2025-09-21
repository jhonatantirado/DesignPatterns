// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using FlyweightPattern.Videogame;

Console.WriteLine("Welcome to the game Peru!");

string gameName = "Peru";
string canvas = "Amazon";
int particleCount = 100;

var game = new Game(gameName);
game.AddParticle("ammo01.jpg", "red", "10.45,20.67", "1", 100);
game.AddParticle("ammo02.jpg", "red", "10.45,20.67", "2", 100);
game.AddParticle("ammo03.jpg", "red", "10.45,20.67", "3", 100);
game.AddParticle("ammo01.jpg", "green", "10.45,20.67", "4", 200);
game.AddParticle("ammo02.jpg", "green", "10.45,20.67", "5", 200);
game.AddParticle("ammo03.jpg", "green", "10.45,20.67", "6", 200);
game.AddParticle("ammo01.jpg", "blue", "10.45,20.67", "7", 300);
game.AddParticle("ammo02.jpg", "blue", "10.45,20.67", "8", 300);
game.AddParticle("ammo03.jpg", "blue", "10.45,20.67", "9", 300);
game.AddParticle("ammo04.jpg", "blue", "10.45,20.67", "10", 300);
game.AddParticle("ammo01.jpg", "red", "10.45,20.67", "11", 1000);

Random random = new();

for (int i = 0; i < particleCount; i++)
{
    var rand = random.Next(0, 1000);
    game.AddParticle("ammo01.jpg", "red","10.45,20.67", i.ToString(), rand);
}

for (int i = 0; i < particleCount; i++)
{
    var rand = random.Next(0, 1000);
    game.AddParticle("ammo02.jpg", "red", "10.45,20.68", i.ToString(), rand);
}

for (int i = 0; i < particleCount; i++)
{
    var rand = random.Next(0, 1000);
    game.AddParticle("ammo03.jpg", "red","10.45,20.69", i.ToString(), rand);
}

for (int i = 0; i < particleCount; i++)
{
    var rand = random.Next(0, 1000);
    game.AddParticle("ammo04.jpg", "red", "10.45,20.70", i.ToString(), rand);
}

game.Draw(canvas);

var memoryUsageInBytes = Process.GetCurrentProcess().WorkingSet64;
var memoryUsage = memoryUsageInBytes / (1024*1024);
Console.WriteLine("Memory usage is {0} MB" ,memoryUsage);
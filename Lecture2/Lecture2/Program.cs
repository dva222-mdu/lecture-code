// See https://aka.ms/new-console-template for more information
using Lecture2;

var clock = new Clock(12, 0, 0);
clock.Tick();

Console.WriteLine(clock.GetTime());

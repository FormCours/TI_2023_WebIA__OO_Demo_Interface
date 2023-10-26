// See https://aka.ms/new-console-template for more information
using Demo_Interface.Interfaces;
using Demo_Interface.Models;

Console.WriteLine("Hello, World!");


VoitureFantomas voitureFantomas = new VoitureFantomas();
voitureFantomas.NbPorte = 3;
voitureFantomas.NbRoue = 4;
voitureFantomas.Immatriculation = "Bou";
voitureFantomas.Tourner();

IVoiture v = voitureFantomas;
v.Rouler();
v.Tourner();

IAvion a = voitureFantomas;
a.Decoller();
a.Tourner();
a.Atterrir();
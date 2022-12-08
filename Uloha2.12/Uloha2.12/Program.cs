// See https://aka.ms/new-console-template for more information

using System.Net.Http.Headers;
using System.Reflection;
using Uloha2._12;

Kocka kocka = new Kocka(5);
Console.WriteLine(kocka.povrch());
Console.WriteLine(kocka.objem());

Guľa gula = new Guľa(7);
Console.WriteLine("Objem gule je: "+gula.povrch());
Console.WriteLine(gula.objem());

Hranol hranol = new Hranol(2, 3, 4);
Console.WriteLine(hranol.povrch());
Console.WriteLine(hranol.objem());







// See https://aka.ms/new-console-template for more information
namespace jurnalmod6_1302210047;

using jurnalmod6_1302210047;
using System;
using System.Collections.Specialized;
using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

class Program
{
    static void Main(String[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Annabelle");
        SayaTubeVideo video1 = new SayaTubeVideo("Conjuring");
        SayaTubeVideo video2 = new SayaTubeVideo("Charlotte");
        SayaTubeVideo video3 = new SayaTubeVideo("Your Lie In April");
        SayaTubeVideo video4 = new SayaTubeVideo("Conjuring 2");
        SayaTubeVideo video5 = new SayaTubeVideo("Weathering With You");
        SayaTubeVideo video6 = new SayaTubeVideo("John Wick");
        SayaTubeVideo video7 = new SayaTubeVideo("John Wick 2");
        SayaTubeVideo video8 = new SayaTubeVideo("Breaking Bad");
        SayaTubeVideo video9 = new SayaTubeVideo("Peacky Blinder");
        Random rand = new Random();

        video.IncreasePlayCount(rand.Next(10000, 99999));
        video1.IncreasePlayCount(rand.Next(10000, 99999));
        video2.IncreasePlayCount(rand.Next(10000, 99999));
        video3.IncreasePlayCount(rand.Next(10000, 99999));
        video4.IncreasePlayCount(rand.Next(10000, 99999));
        video5.IncreasePlayCount(rand.Next(10000, 99999));
        video6.IncreasePlayCount(rand.Next(10000, 99999));
        video7.IncreasePlayCount(rand.Next(10000, 99999));
        video8.IncreasePlayCount(rand.Next(10000, 99999));
        video9.IncreasePlayCount(rand.Next(10000, 99999));
        Sayatubeuser user = new Sayatubeuser("ROZAN KURNIA PRATAMA");
        user.AddVideo(video);
        user.AddVideo(video1);
        user.AddVideo(video2);
        user.AddVideo(video3);
        user.AddVideo(video4);
        user.AddVideo(video5);
        user.AddVideo(video6);
        user.AddVideo(video7);
        user.AddVideo(video8);
        user.AddVideo(video9);
        Console.WriteLine("Review Film "+video.Gettitle()+" Oleh Rozan Kurnia Pratama");
        video.PrintVideoDetails();
        Console.WriteLine(" ");
        Console.WriteLine("Review Film " + video1.Gettitle() + " Oleh Rozan Kurnia Pratama");
        video1.PrintVideoDetails();
        Console.WriteLine(" ");
        Console.WriteLine("Review Film " + video2.Gettitle() + " Oleh Rozan Kurnia Pratama");
        video2.PrintVideoDetails();
        Console.WriteLine(" ");
        Console.WriteLine("Review Film " + video3.Gettitle() + " Oleh Rozan Kurnia Pratama");
        video3.PrintVideoDetails();
        Console.WriteLine(" ");
        Console.WriteLine("Review Film " + video4.Gettitle() + " Oleh Rozan Kurnia Pratama");
        video4.PrintVideoDetails();
        Console.WriteLine(" ");
        Console.WriteLine("Review Film " + video5.Gettitle() + " Oleh Rozan Kurnia Pratama");
        video5.PrintVideoDetails();
        Console.WriteLine(" ");
        Console.WriteLine("Review Film " + video6.Gettitle() + " Oleh Rozan Kurnia Pratama");
        video6.PrintVideoDetails();
        Console.WriteLine(" ");
        Console.WriteLine("Review Film " + video7.Gettitle() + " Oleh Rozan Kurnia Pratama");
        video7.PrintVideoDetails();
        Console.WriteLine(" ");
        Console.WriteLine("Review Film " + video8.Gettitle() + " Oleh Rozan Kurnia Pratama");
        video8.PrintVideoDetails();
        Console.WriteLine(" ");
        Console.WriteLine("Review Film " + video9.Gettitle() + " Oleh Rozan Kurnia Pratama");
        video9.PrintVideoDetails();
        Console.WriteLine(" ");
    }
}


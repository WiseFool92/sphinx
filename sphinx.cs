using System;

class Program
{
  static void Main()
  {
    Console.WriteLine("You have encountered a Sphinx. Answer the riddles correctly or be eaten");
    Console.WriteLine("What has roots as nobody sees, Is taller than trees,Up, up it goes,And yet never grows?");
    string riddle1 = Console.ReadLine();
    if (riddle1 == "mountain") {
      Console.WriteLine("Voiceless it cries, Wingless flutters, Toothless bites, Mouthless mutters.");
      string riddle2 = Console.ReadLine();
      if (riddle2 == "wind") {
        Console.WriteLine("I have an eye but I am blind.  I'm cold and hard and never kind.  Despite all this you should still see.  There is always a point to me.");
        string riddle3 = Console.ReadLine();
        if (riddle3 == "needle") {
           Console.WriteLine("I touch the earth.  I touch the sky.  But if I touch you, you'll surely die.");
            string riddle4 = Console.ReadLine();
          if (riddle4 == "lightning") {
            Console.WriteLine("Congratulations, you have solved the riddles. You were not eaten by the sphinx.");
          }
          else 
          {
          Console.WriteLine("You were eaten by the Sphinx.");
          }
        }
        else 
        {
        Console.WriteLine("You were eaten by the Sphinx.");
        }
      }
      else 
      { 
      Console.WriteLine("You were eaten by the Sphinx.");
      }
    }
    else 
    {
      Console.WriteLine("You were eaten by the Sphinx.");
    }
  }
}
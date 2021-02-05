using System;

namespace Hello {
  class Program {
    
    static string MESSAGE = "Welcome to my program!\n";
  
    static void Main(string[] args) {
      
      Wellcome();
      PrintInfo();
      
      Console.Write("\nPress ENTER to exit ");
      Console.ReadLine();
    }
    static void Wellcome() {
      char[] chars = MESSAGE.ToCharArray();
      for ( int i = 0; i < MESSAGE.Length; i++ ) {
        System.Threading.Thread.Sleep(60);
        Console.Write(chars[i]);
      }
    }
    static void PrintInfo() {
      var os = Environment.OSVersion;
      Console.Write (
        "\nPlatform: " + os.Platform +
        "\nVersion: " + os.Version + 
        "\nVersion name: " + os.VersionString + "\n"
      );
      
    }
  }
}
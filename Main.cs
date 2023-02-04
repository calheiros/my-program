using System;

namespace Hello {

  class Program {  
    static string WelcomeMessage = "Welcome to my program!\n";
  
    static void Main(string[] args) {
      Print(WelcomeMessage);
      Print(GetInfo());
      Print("\nPress ENTER to exit ");
      Console.ReadLine();
    }

    static void Print(string message) {
      char[] chars = message.ToCharArray();
      for ( int i = 0; i < message.Length; i++ ) {
        System.Threading.Thread.Sleep(60);
        Console.Write(chars[i]);
      }
    }

    static string GetInfo() {
      var os = Environment.OSVersion;
      return
        "\nPlatform: " + os.Platform +
        "\nVersion: " + os.Version + 
        "\nVersion name: " + os.VersionString + "\n";
    }
  }
}

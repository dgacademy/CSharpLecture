using System;

delegate void DisplayMessage(string message);

class MainClass {
   private static void ShowWindowsMessage(string message)
   {
      // MessageBox.Show(message);
      Console.WriteLine("Show message box in Windows");
   }  
  public static void Main (string[] args) {
    DisplayMessage messageTarget; 

    if (true)
       messageTarget = ShowWindowsMessage;
    else
       messageTarget = Console.WriteLine;

    messageTarget("Hello, World!");   
  }
}









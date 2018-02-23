// https://msdn.microsoft.com/ko-kr/library/018hxwa8(v=vs.110).aspx

using System;

public class TestAction1
{
   public static void Main()
   {
      System.Action<string> messageTarget; 

      // if (Environment.GetCommandLineArgs().Length > 1)
      if (true)
         messageTarget = ShowWindowsMessage;
      else
         messageTarget = Console.WriteLine;

      messageTarget("Hello, World!");   
   }      

   private static void ShowWindowsMessage(string message)
   {
      // MessageBox.Show(message);
      Console.WriteLine("{0} in MessageBox.Show()", message);
   }
}
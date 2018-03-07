using System;

  public static class TwoFer
  {
      public static string Name(string input = null)
      {
		bool inputMissing = input == null || input == string.Empty;
		return inputMissing ? "One for you, one for me." : "One for " + input + ", one for me.";
      }
  }

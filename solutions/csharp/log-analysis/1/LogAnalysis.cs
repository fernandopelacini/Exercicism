using System;

public static class LogAnalysis 
{
    public static string SubstringAfter(this string str, string delimiter){
        int index = str.IndexOf(delimiter) + delimiter.Length;
        return str.Substring(index, str.Length - index);
    }

    public static string SubstringBetween(this string str, string lmtStar, string lmtEnd) {
        string FinalString;     
        int Pos1 = str.IndexOf(lmtStar) + lmtStar.Length;
        int Pos2 = str.IndexOf(lmtEnd);
        FinalString = str.Substring(Pos1, Pos2 - Pos1);
        return FinalString;
    }
    
    public static string Message(this string str){
        int index = str.LastIndexOf(":") + 1;
        return str.Substring(index, str.Length - index).TrimStart();
    }

    public static string LogLevel(this string str){
         int index = str.LastIndexOf("]") ;
        return str.Substring(1, index -1);
    }
}
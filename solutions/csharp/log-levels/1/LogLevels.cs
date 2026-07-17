using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        int msgStarIndex = logLine.LastIndexOf(":");
        logLine = logLine.Remove(0, msgStarIndex + 1);
        logLine = System.Text.RegularExpressions.Regex.Replace(logLine,@"\t|\n|\r","");
        logLine = logLine.TrimStart().TrimEnd();
        return logLine;
    }

    public static string LogLevel(string logLine)
    {
       return logLine.Substring(1, logLine.LastIndexOf("]") - 1).ToLower();
    }

    public static string Reformat(string logLine)
    {
        
        int msgStartIndex = logLine.LastIndexOf("]");
        string newLog = System.Text.RegularExpressions.Regex.Replace(logLine,@"\t|\n|\r","").TrimEnd();
        newLog = newLog.Substring(msgStartIndex + 2, newLog.Length - (msgStartIndex + 2)) + " (" + newLog.Substring(1, msgStartIndex - 1).ToLower() + ")";
        return newLog.TrimStart();
    }
}

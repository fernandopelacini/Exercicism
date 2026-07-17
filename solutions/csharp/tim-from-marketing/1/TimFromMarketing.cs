using System;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
       string strId = "";
            if (id.HasValue) strId = "[" + id + "] - ";
            string strName = name + " - ";
            string strDepto =  department?.ToUpper() ?? "OWNER";
            return strId + strName + strDepto;
    }
}

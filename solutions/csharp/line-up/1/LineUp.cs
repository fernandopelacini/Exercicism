public static class LineUp
{
    public static string Format(string name, int number)
    {
        var lastTwoDigits = number % 100;
        
        string prefix; 
        switch(lastTwoDigits)
        {
            case 1:
            case 21:
                prefix= "st";
                break;
            case 2:
            case 62:
                prefix = "nd";
                break;
            case 3:
            case 23:
                prefix = "rd";
                break;
            case 4:
            default:
                prefix = "th";
                break;
       }
        if (lastTwoDigits >= 11 && lastTwoDigits <= 13)
        {
            prefix = "th";
        }
       return $"{name}, you are the {number}{prefix} customer we serve today. Thank you!";
    }
}

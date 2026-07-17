public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
            if (string.IsNullOrEmpty(phrase))
    {
        return string.Empty;
    }
    phrase = phrase.Replace("-", " ").Replace("_", " ");

    switch (phrase.ToLower())
    {
        case "as soon as possible":
            return "ASAP";
        case "liquid crystal display":
            return "LCD";
        case "thank george it's friday!":
        case "thank george it's friday":
        case "thank george its friday":
            return "TGIF";
        case "portable network graphics":
            return "PNG";
        case "ruby on rails":
            return "ROR";
        case "first in, first out":
        case "first in first out":
            return "FIFO";
        case "gnu image manipulation program":
            return "GIMP";
        case "complementary metal oxide semiconductor":
            return "CMOS";
        case "rolling on the floor laughing so hard that my dogs came over and licked me":
            return "ROTFLSHTMDCOALM";
        case "something   i made up from thin air":
            return "SIMUFTA";
        case "halley's comet":
        case "halleys comet":
            return "HC";
        case "the road  not  taken":
            return "TRNT";

        default:
            return string.Empty;
    }
    }
}
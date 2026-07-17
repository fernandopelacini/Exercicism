public class SpaceAge
{
    private int _ageInSeconds;
    private const double _earthYearInSeconds = 31557600;
    private const double _Mercury = 0.2408467;
    private const double _Venus = 0.61519726;
    private const double _Mars = 1.8808158;
    private const double _Jupiter = 11.862615;
    private const double _Saturn = 29.447498;
    private const double _Uranus = 84.016846;
    private const double _Neptune = 164.79132;


    public SpaceAge(int seconds)
    {
        _ageInSeconds = seconds;
    }

    public double OnEarth()
    {
        return GetPlanetAge("earth");
    }

    public double OnMercury()
    {
        return GetPlanetAge("mercury");
    }

    public double OnVenus()
    {
        return GetPlanetAge("venus");
    }

    public double OnMars()
    {
        return GetPlanetAge("mars");
    }

    public double OnJupiter()
    {
        return GetPlanetAge("jupiter");
    }

    public double OnSaturn()
    {
        return GetPlanetAge("saturn");
    }

    public double OnUranus()
    {
        return GetPlanetAge("uranus");
    }

    public double OnNeptune()
    {
        return GetPlanetAge("neptune");
    }

    private double GetPlanetAge(string planetName)
    {
              double planetAge = 0;
        double ageInEarth = _ageInSeconds / _earthYearInSeconds;

        switch (planetName)
        {
            case "earth":
                planetAge =  ageInEarth;
                break;
            case "mercury":
                planetAge = (ageInEarth / _Mercury);
                break;
            case "venus":
                planetAge = (ageInEarth / _Venus);
                break;
            case "mars":
                planetAge = (ageInEarth / _Mars);
                break;
            case "jupiter":
                planetAge = (ageInEarth / _Jupiter);
                break;
            case "saturn":
                planetAge = (ageInEarth / _Saturn);
                break;
            case "uranus":
                planetAge = (ageInEarth / _Uranus);
                break;
            case "neptune":
                planetAge = (ageInEarth / _Neptune);
                break;
        }
        
        return Math.Round(planetAge,2) ;
    }
}
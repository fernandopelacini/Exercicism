public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
         return SplitTelephoneNumber(phoneNumber);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }

     private static (bool isNewYor, bool isfate, string localNumber) SplitTelephoneNumber (string phoneNumber)
 {
     if (string.IsNullOrEmpty(phoneNumber))
     {
         return (false, true, string.Empty);
     }

     var telephone = phoneNumber.Split("-");

     if (telephone.Length < 3)
     {
         return (false, true, string.Empty);
     }

     var isNYork = telephone[0] == "212";
     var isFake = telephone[1] == "555";
     var localNumber = telephone[2];

     return (isNYork, isFake, localNumber); 
 }
}

using System;

static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        float returnedValue =(float) 3.213;
            if (balance >= 0 && balance < 1000) returnedValue=(float)0.5;
            if (balance >= 1000 && balance < 5000) returnedValue = (float)1.621;
            if (balance >= 5000 ) returnedValue = (float)2.475;
            return returnedValue;
    }

    public static decimal Interest(decimal balance)
    {
      float temp = InterestRate(balance);
            decimal interest =(decimal)temp * balance;
            return interest / 100;
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
            float temp = InterestRate(balance);
            decimal interest = ((decimal)temp * balance) / 100;
            return interest + balance;
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
       int years = 0;
            while (balance < targetBalance)
            {
                years+=1;
                balance += Interest(balance);
            }

            return years;
    }
}

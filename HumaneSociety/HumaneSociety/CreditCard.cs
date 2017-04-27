using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    //public class CreditCard
    //{
    //    private string nameOnCard;
    //    private int cardNumber;
    //    private string expiration;
    //    private int cvc;
    //    private string billingAddress;

    //    public string NameOnCard { get { return nameOnCard; } set { nameOnCard = value; } }
    //    public int CardNumber { get { return cardNumber; } set { cardNumber = value; } }
    //    public string Expiration { get { return expiration; } set { expiration = value; } }
    //    public int CVC { get { return cvc; } set { cvc = value; } }
    //    public string BillingAddress { get { return billingAddress; } set { billingAddress = value; } }

    //    public CreditCard(Adopter adopter)
    //    {
    //        this.nameOnCard = GetNameOnCard(adopter);
    //        this.cardNumber = GetCardNumber(adopter);
    //        this.expiration = GetCardExpiration();
    //        this.cvc = GetCVC();
    //        this.BillingAddress = GetBillingAddress(adopter);

    //    }

    //    public string GetNameOnCard(Adopter adopter)
    //    {
    //        Console.WriteLine($"\nEnter the full name on {adopter.FirstName}'s credit card.");
    //        Console.WriteLine("Example: 'John A Smith'");
    //        nameOnCard = Console.ReadLine();
    //        return nameOnCard;
    //    }

    //    public int GetCardNumber(Adopter adopter)
    //    {
    //        Console.WriteLine($"\nEnter {adopter.FirstName}'s credit card number.");
    //        Console.WriteLine("Example: '4147879087688762'");
    //        cardNumber = int.Parse(Console.ReadLine());
    //        return cardNumber;
    //    }

    //    public string GetCardExpiration()
    //    {
    //        Console.WriteLine("\nEnter the credit card's expiration date.");
    //        Console.WriteLine("Example: (month/year) => '06/18'");
    //        expiration = Console.ReadLine();
    //        return expiration;
    //    }

    //    public int GetCVC()
    //    {
    //        Console.WriteLine("\nEnter the credit card's CVC number.");
    //        Console.WriteLine("Example: '676'");
    //        cvc = int.Parse(Console.ReadLine());
    //        return cvc;
    //    }

    //    public string GetBillingAddress(Adopter adopter)
    //    {
    //        Console.WriteLine($"\nEnter {adopter.FirstName}'s billing address.");
    //        Console.WriteLine("Example: '676'");
    //        billingAddress = Console.ReadLine();
    //        return billingAddress;
    //    }
    //}
}

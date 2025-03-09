// See https://aka.ms/new-console-template for more information
using System;

class BankAccount
{
    public string AccountHolder { get; set; }
    public double Balance { get; set; }

    public BankAccount(string accountHolder, double balance)
    {
        AccountHolder = accountHolder;
        Balance = balance;
    }

    // Virtual method: Alt sınıflar tarafından override edilecek
    public virtual void CalculateInterest()
    {
        Console.WriteLine("This method should be overridden in derived classes.");
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Account Holder: {AccountHolder}, Balance: {Balance:C}");
    }
}

// Vadeli Hesap (SavingsAccount) sınıfı
class SavingsAccount : BankAccount
{
    public SavingsAccount(string accountHolder, double balance)
        : base(accountHolder, balance) { }

    // Faiz hesaplama: Bakiyenin %5'i
    public override void CalculateInterest()
    {
        double interest = Balance * 0.05;
        Console.WriteLine($"Interest earned: {interest:C}");
    }
}

// Vadesiz Hesap (CheckingAccount) sınıfı
class CheckingAccount : BankAccount
{
    public CheckingAccount(string accountHolder, double balance)
        : base(accountHolder, balance) { }

    // Vadesiz hesaplar faiz kazanmaz
    public override void CalculateInterest()
    {
        Console.WriteLine("Checking accounts do not earn interest.");
    }
}

// Program sınıfı (Main metodu burada)
class Program
{
    static void Main()
    {
        BankAccount savings = new SavingsAccount("Ahmet Yılmaz", 10000);
        BankAccount checking = new CheckingAccount("Mehmet Demir", 5000);

        // Bilgileri ekrana yazdır
        savings.DisplayInfo();
        savings.CalculateInterest();
        Console.WriteLine();

        checking.DisplayInfo();
        checking.CalculateInterest();
    }
}


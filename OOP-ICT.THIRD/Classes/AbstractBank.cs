namespace OOP_ICT.THIRD.Classes;

public class AbstractBank
{
    public BankAccount CreateAccount()
    {
        return new BankAccount();
    }
}
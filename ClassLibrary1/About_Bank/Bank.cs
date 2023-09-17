using ClassLibrary1.Human;

namespace ClassLibrary1.About_Bank;

public class Bank
{
    private string name;

    public string Name
    {
        get => this.name;
        set
        {
            if (value.Length >= 3)
                this.name = value;
            else
                throw new Exception("Invalid Bank Name");
        }
    }

    private float budget;

    public float Budget
    {
        get => this.budget;
        set
        {
            if (value >= 1000000)
                this.budget = value;
            else
                throw new Exception("Budget must be at least 1000000");
        }
    }

    public string Profit { get; set; }

    public void calculate_profit() { }

    public CEO ceo_of_bank;
    
    public List<Worker> workers;
    public List<Manager> managers;
    public List<Client> clients;

    public void ShowCLientCredit(string full_name) { }
    
    public void PayCredit(Client client, float money_amount) { }

    public void ShowAllCredit() { }

    // Constructor

    public Bank(string name,float budget,string Profit, CEO ceo)
    {
        this.Name = name;
        this.Budget = budget;
        this.Profit = Profit;
        this.ceo_of_bank = ceo;
    }
}
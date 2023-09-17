#nullable disable

using ClassLibrary1.Human;

namespace ClassLibrary1.Work;

public class Credit
{
    public Guid Id { get; set; }
    public Client client;

    private float amount;
    public float Amount { get; set; }

    private float percent;
    public float Percent { get; set; }

    private int months;
    public int Months { get; set; } 

    public void CalculatePercent() { }

    private float payment;
    public float Payment { get; set; }

    // Constructor

    public Credit(Client client, float amount,float percent,int months,float payment)
    {
        this.Id = Guid.NewGuid();
        this.client = client;
        this.Amount = amount;
        this.Percent = percent;
        this.Months = months;
        this.Payment = payment;
    }
}
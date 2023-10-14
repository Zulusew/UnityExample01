using UnityEngine;

public class HarmfulSales : ISell
{
    public void Sell()
    {
        Debug.Log("Я вредный, поэтому не буду с тобой торговать");
    }
}

using UnityEngine;

public class Player : MonoBehaviour, IReputationVerify
{
    [SerializeField, Range(0,100)] private int _playerReputations;
    private ISell _sell;
    public void TypesOfSell(ISell sell)
    {
        _sell = sell;
        _sell.Sell();
    }

    public void Check(int sellerReputations, ISell sell)
    {
        if (_playerReputations < sellerReputations)
        {
            TypesOfSell(new NoSales());
        }

        if (_playerReputations >= sellerReputations)
        {
            TypesOfSell(sell);
        }
    }
}

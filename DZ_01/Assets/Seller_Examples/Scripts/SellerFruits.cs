using UnityEngine;
public class SellerFruits : Seller
{
    [SerializeField, Range(0,100)] private int _reputationFruits;
    protected override void CheckReputation(IReputationVerify reputationVerify)
    {
        reputationVerify.Check(_reputationFruits, new FruitSales());
    }
}

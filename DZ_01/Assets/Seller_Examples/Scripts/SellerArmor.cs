using UnityEngine;

public class SellerArmor : Seller
{
    [SerializeField, Range(0, 100)] private int _reputationArmor;
    protected override void CheckReputation(IReputationVerify reputationVerify)
    {
        reputationVerify.Check(_reputationArmor, new ArmorSales());
    }
}

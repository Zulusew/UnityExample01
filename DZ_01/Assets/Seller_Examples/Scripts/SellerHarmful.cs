using UnityEngine;

public class SellerHarmful : Seller
{
    [SerializeField, Range(0, 100)] private int _reputationHramful;
    protected override void CheckReputation(IReputationVerify reputationVerify)
    {
        reputationVerify.Check(_reputationHramful, new HarmfulSales());
    }
}

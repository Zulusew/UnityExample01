using UnityEngine;
public abstract class Seller : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out IReputationVerify reputationVerify))
        {
            CheckReputation(reputationVerify);
        }
    }
    protected abstract void CheckReputation(IReputationVerify reputationVerify);
}

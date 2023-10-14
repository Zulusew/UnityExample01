using UnityEngine;

public abstract class Gun : MonoBehaviour
{
    protected float CurrentRechargeTime = 0;
    public abstract void AffectShoot();

    private void Update()
    {
        if (CurrentRechargeTime > 0)
        {
            CurrentRechargeTime -= Time.deltaTime;
        }
    }

}

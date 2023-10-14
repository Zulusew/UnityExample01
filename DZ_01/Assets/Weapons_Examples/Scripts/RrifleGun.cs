using UnityEngine;

public class RrifleGun : Gun
{
    [SerializeField] private Bullet _prefabBullet;
    [SerializeField] private Transform _spawnPointBullet;
    [SerializeField] private float _rechargeTime;
    public override void AffectShoot()
    {
        if (CurrentRechargeTime <= 0)
        {
            new OneShoot(_prefabBullet, _spawnPointBullet).Shoot();

            CurrentRechargeTime = _rechargeTime;

            Debug.Log("Время перезарядки: " + CurrentRechargeTime);
        }
    }
}

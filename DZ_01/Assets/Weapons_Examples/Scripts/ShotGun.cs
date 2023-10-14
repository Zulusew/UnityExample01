using UnityEngine;

public class ShotGun : Gun
{
    [SerializeField] private Bullet _prefabBullet;
    [SerializeField] private Transform _spawnPointBullet;
    [SerializeField] private float _rechargeTime;
    [SerializeField, Range(1, 20)] private int _maxAmmo;
    private int _currentAmmo = 0;
    public override void AffectShoot()
    {
        if (_currentAmmo < _maxAmmo)
        {
            if (CurrentRechargeTime <= 0)
            {
                new MultiShoot(_prefabBullet, _spawnPointBullet).Shoot();
                _currentAmmo++;
                CurrentRechargeTime = _rechargeTime;

                Debug.Log("Патронов осталось: " + (_maxAmmo - _currentAmmo));
                Debug.Log("Время перезарядки: " + CurrentRechargeTime);
            }
        }
        else
        {
            Debug.Log("Патроны закончились");
        }


    }
}

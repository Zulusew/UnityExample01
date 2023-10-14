using UnityEngine;

public class PistoletGun : Gun
{
    [SerializeField] private Bullet _prefabBullet;
    [SerializeField] private Transform _spawnPointBullet;
    [SerializeField] private float _rechargeTime;
    [SerializeField, Range(1, 20)] private int _maxAmmo;
    private int _currentAmmo = 0;
    public override void AffectShoot()
    {
        if(_currentAmmo < _maxAmmo)
        {
            if(CurrentRechargeTime <=0)
            {
                new OneShoot(_prefabBullet, _spawnPointBullet).Shoot();
                _currentAmmo++;
                CurrentRechargeTime = _rechargeTime;

                Debug.Log("Патронов осталось: " + (_maxAmmo - _currentAmmo));
            }
        }
        else
        {
            Debug.Log("Патроны закончились");
        }
    }

}

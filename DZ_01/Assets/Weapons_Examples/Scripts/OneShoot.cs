using UnityEngine;

public class OneShoot : MonoBehaviour, IGunShoot
{
    private Bullet _prefabBullet;
    private Transform _spawnPointBullet;

    public OneShoot(Bullet prefabBullet, Transform spawnPointBullet)
    {
        _prefabBullet = prefabBullet;
        _spawnPointBullet = spawnPointBullet;
    }

    public void Shoot()
    {
        Instantiate(_prefabBullet, _spawnPointBullet.position, Quaternion.identity);
    }


}

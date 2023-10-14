using UnityEngine;

public class MultiShoot : MonoBehaviour, IGunShoot
{
    private Bullet _prefabBullet;
    private Transform _spawnPoint;

    public MultiShoot(Bullet prefabBullet, Transform spawnPointBullet)
    {
        _prefabBullet = prefabBullet;
        _spawnPoint = spawnPointBullet;
    }

    public void Shoot()
    {
        for(int i=-1; i<=1; i++)
        {
            Bullet bullet = Instantiate(_prefabBullet, _spawnPoint.position + new Vector3(i,0,0), Quaternion.identity);
        }

    }
}

using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private Transform _spawnPointGun;

    private Gun _currentInstance;

    private void Start()
    {
        _currentInstance = null;
    }
    public void CreateGun(Gun gun)
    {
        if (_currentInstance != null)
        {
            ClearGun();
        }

        if (_currentInstance == null)
        {
            Gun instance = Instantiate(gun, _spawnPointGun.position, Quaternion.identity);
            _currentInstance = instance;
            _currentInstance.transform.parent = gameObject.transform;
        }
    }
    public void Shoot()
    {
        _currentInstance.AffectShoot();
    }
    private void ClearGun()
    {
        Destroy(_currentInstance.gameObject);
        _currentInstance = null;
    }


}

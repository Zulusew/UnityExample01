using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField, Range(0,100)] private int _speed;
    private float _randomDestroyTime;

    private void RandomDestroyTime()
    {
        _randomDestroyTime = Random.Range(1, 4);
    }

    private void OnEnable()
    {
        RandomDestroyTime();
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);

        if (_randomDestroyTime > 0)
        {
            _randomDestroyTime -= Time.deltaTime;
        }
        else Destroy(gameObject);
    }

}

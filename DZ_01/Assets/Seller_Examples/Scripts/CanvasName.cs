using UnityEngine;

public class CanvasName : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    private void LateUpdate()
    {
        transform.LookAt(new Vector3(_camera.transform.position.x, _camera.transform.position.y, _camera.transform.position.z));
        transform.Rotate(0, 180, 0);
    }
}

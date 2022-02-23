using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;

    private void LateUpdate()
    {
        if (!target) return;
        var pos = transform.position;
        pos.y = target.position.y;
        transform.position = pos;
    }
}
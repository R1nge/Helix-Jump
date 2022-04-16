using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float offset;

    private void LateUpdate()
    {
        if (!target) return;
        var pos = transform.position;
        if(target.transform.position.y > pos.y) return;
        pos.y = target.position.y + offset;
        transform.position = pos;
    }
}
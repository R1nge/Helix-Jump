using UnityEngine;

namespace Core
{
    public class CameraFollow : MonoBehaviour
    {
        [SerializeField] private Transform target;
        [SerializeField] private float offset;
        private Vector3 _pos;

        private void LateUpdate()
        {
            if (!target) return;
            _pos = transform.position;
            if (!(_pos.y >= target.transform.position.y + offset)) return;
            _pos.y = target.transform.position.y + offset;
            transform.position = _pos;
        }
    }
}
using UnityEngine;

namespace Platforms
{
    public class RotateController : MonoBehaviour
    {
        [SerializeField] private float speed;
        private Transform _target;
        private Camera _camera;

        private void Awake()
        {
            _camera = FindObjectOfType<Camera>();
            _target = GameObject.FindWithTag("Target").transform;
        }

        private void Update()
        {
            if (!Input.GetMouseButton(0)) return;

            var screenPosMouse = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
            var worldPosMouse = _camera.ScreenToWorldPoint(screenPosMouse);

            transform.RotateAround(
                _target.transform.position,
                -_target.transform.up,
                worldPosMouse.x * speed * Time.deltaTime);
        }
    }
}
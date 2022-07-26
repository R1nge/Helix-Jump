using UnityEngine;

namespace Core
{
    public class PlayerMovementController : MonoBehaviour
    {
        [SerializeField] private float forceY;
        private Rigidbody _rigidbody;

        private void Awake() => _rigidbody = GetComponent<Rigidbody>();
    
        public void AddForce() => _rigidbody.AddForce(0, forceY, 0, ForceMode.Impulse);
    }
}
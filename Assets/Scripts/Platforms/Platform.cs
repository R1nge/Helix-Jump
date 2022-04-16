using UnityEngine;

namespace Platforms
{
    public abstract class Platform : MonoBehaviour
    {
        [SerializeField] protected float velocityToDestroy;

        private void OnCollisionEnter(Collision other)
        {
            if (!other.gameObject.TryGetComponent(out PlayerMovementController playerMovement)) return;
            OnCollision(other);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (!other.gameObject.TryGetComponent(out PlayerMovementController playerMovement)) return;
            gameObject.SetActive(false);
        }

        protected abstract void OnCollision(Collision collision);
    }
}
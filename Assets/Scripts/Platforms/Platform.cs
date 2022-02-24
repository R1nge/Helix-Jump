using UnityEngine;

namespace Platforms
{
    public abstract class Platform : MonoBehaviour
    {
        [SerializeField] protected float velocityToDestroy;

        private void OnCollisionEnter(Collision other)
        {
            if (!other.gameObject.TryGetComponent(out PlayerMovementController playerMovement)) return;
            OnCollision(playerMovement);
        }

        protected abstract void OnCollision(PlayerMovementController playerMovement);
    }
}
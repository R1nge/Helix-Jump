using Core;
using UnityEngine;

namespace Platforms
{
    public abstract class Platform : MonoBehaviour
    {
        [SerializeField] protected float velocityToDestroy;

        protected abstract void OnCollisionEnter(Collision other);

        private void OnTriggerEnter(Collider other)
        {
            if (!other.gameObject.TryGetComponent(out PlayerMovementController playerMovement)) return;
            gameObject.SetActive(false);
        }
    }
}
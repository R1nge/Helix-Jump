using UnityEngine;

namespace Platforms
{
    public abstract class Platform : MonoBehaviour
    {
        [SerializeField] protected float velocityToDestroy;

        protected virtual void OnCollisionEnter(Collision other)
        {
            if (!other.gameObject.TryGetComponent(out PlayerMovementController playerMovement)) return;
            gameObject.SetActive(false);
        }
    }
}
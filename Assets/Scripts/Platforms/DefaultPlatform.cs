using Core;
using UnityEngine;

namespace Platforms
{
    public class DefaultPlatform : Platform
    {
        protected override void OnCollisionEnter(Collision other)
        {
            var velocity = Mathf.Abs(other.relativeVelocity.y);

            if (velocity > velocityToDestroy)
            {
                gameObject.SetActive(false);
            }

            if (!other.transform.TryGetComponent(out PlayerMovementController playerMovement)) return;
            playerMovement.AddForce();
        }
    }
}
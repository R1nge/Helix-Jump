using UnityEngine;

namespace Platforms
{
    public class DefaultPlatform : Platform
    {
        protected override void OnCollision(Collision collision)
        {
            var velocity = Mathf.Abs(collision.relativeVelocity.y);
            
            if (velocity > velocityToDestroy)
            {
                gameObject.SetActive(false);
            }
            print(velocity);
            if (!collision.transform.TryGetComponent(out PlayerMovementController playerMovement)) return;
            playerMovement.AddForce();
        }
    }
}
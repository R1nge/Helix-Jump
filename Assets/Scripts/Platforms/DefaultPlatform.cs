namespace Platforms
{
    public class DefaultPlatform : Platform
    {
        protected override void OnCollision(PlayerMovementController playerMovement)
        {
            if (playerMovement.GetVelocity() > velocityToDestroy)
            {
                Destroy(gameObject);
            }

            playerMovement.AddForce();
        }
    }
}
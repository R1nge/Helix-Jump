namespace Platforms
{
    public class DefaultPlatform : Platform
    {
        protected override void OnCollision(PlayerMovementController playerMovement)
        {
            if (playerMovement.GetVelocity() > velocityToDestroy)
            {
                gameObject.SetActive(false);
            }

            playerMovement.AddForce();
        }
    }
}
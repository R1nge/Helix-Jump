namespace Platforms
{
    public class PlatformKiller : Platform
    {
        protected override void OnCollision(PlayerMovementController playerMovement)
        {
            Destroy(playerMovement.GetVelocity() > velocityToDestroy ? gameObject : playerMovement.gameObject);
            playerMovement.AddForce();
        }
    }
}
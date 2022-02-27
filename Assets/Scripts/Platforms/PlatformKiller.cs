namespace Platforms
{
    public class PlatformKiller : Platform
    {
        protected override void OnCollision(PlayerMovementController playerMovement)
        {
            //TODO: GameOver
            //playerMovement.gameObject.SetActive(false);
        }
    }
}
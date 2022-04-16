using UnityEngine;

namespace Platforms
{
    public class KillerPlatform : Platform
    {
        protected override void OnCollision(Collision collision)
        {
            GameManager.GameOver();
        }
    }
}
using Platforms;
using UnityEngine;

public class WinPlatform : Platform
{
    protected override void OnCollision(Collision collision)
    {
        GameManager.WinGame();
    }
}
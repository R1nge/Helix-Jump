using Platforms;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinPlatform : Platform
{
    protected override void OnCollision(Collision collision)
    {
        GameManager.WinGame();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
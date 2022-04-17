using UnityEngine;
using UnityEngine.SceneManagement;

public class WinPlatform : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if(!other.transform.CompareTag("Player")) return;
        GameManager.WinGame();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
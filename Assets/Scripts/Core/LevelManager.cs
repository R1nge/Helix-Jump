using UnityEngine;
using UnityEngine.SceneManagement;

namespace Core
{
    public class LevelManager : MonoBehaviour
    {
        private GameManager _gameManager;

        private void Awake()
        {
            _gameManager = FindObjectOfType<GameManager>();
            _gameManager.OnGameOverEvent += Restart;
            _gameManager.OnWinGameEvent += Restart;
        }

        private void Restart() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        private void OnDestroy()
        {
            _gameManager.OnGameOverEvent -= Restart;
            _gameManager.OnWinGameEvent -= Restart;
        }
    }
}
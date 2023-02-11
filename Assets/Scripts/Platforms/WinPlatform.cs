using Core;
using UnityEngine;

namespace Platforms
{
    public class WinPlatform : MonoBehaviour
    {
        private GameManager _gameManager;

        private void Awake() => _gameManager = FindObjectOfType<GameManager>();

        private void OnCollisionEnter(Collision other)
        {
            if (!other.transform.CompareTag("Player")) return;
            _gameManager.WinGame();
        }
    }
}
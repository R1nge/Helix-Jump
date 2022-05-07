using Core;
using UnityEngine;

namespace Platforms
{
    public class KillerPlatform : Platform
    {
        private GameManager _gameManager;

        private void Awake() => _gameManager = FindObjectOfType<GameManager>();

        protected override void OnCollisionEnter(Collision other)
        {
            _gameManager.GameOver();
        }
    }
}
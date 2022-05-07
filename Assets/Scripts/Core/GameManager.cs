using System;
using UnityEngine;

namespace Core
{
    public class GameManager : MonoBehaviour
    {
        public event Action OnGameStartEvent;
        public event Action OnGameOverEvent;
        public event Action OnWinGameEvent;

        public void StartGame() => OnGameStartEvent?.Invoke();
        public void GameOver() => OnGameOverEvent?.Invoke();
        public void WinGame() => OnWinGameEvent?.Invoke();
    }
}

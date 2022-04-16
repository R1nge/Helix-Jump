using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static event Action OnGameStartEvent;
    public static event Action OnGameOverEvent;
    public static event Action OnWinGameEvent;

    public static void StartGame() => OnGameStartEvent?.Invoke();
    public static void GameOver() => OnGameOverEvent?.Invoke();
    public static void WinGame() => OnWinGameEvent?.Invoke();
}

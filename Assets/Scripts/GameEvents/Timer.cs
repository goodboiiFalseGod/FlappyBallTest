using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Timer : MonoBehaviour
{
    private GameDifficultySettings _difficulty;
    private GameEvents _gameEvents;
    private float _currentTimer = 0;
    private float _maxTimer;

    private float _startTime;

    public float StartTime { get { return _startTime; } }

    [Inject]
    private void Construct(GameDifficultySettings difficulty, GameEvents gameEvents)
    {
        _difficulty = difficulty;
        _gameEvents = gameEvents;

        _maxTimer = _difficulty.DifficultyUpdateTime;
        _gameEvents.GameStarted += OnGameStarted;
    }

    private void Update()
    {
        _currentTimer += Time.deltaTime;

        if (_currentTimer < _maxTimer) return;
        
        _gameEvents.OnDifficultyUpdated();
        _currentTimer = 0;
    }

    private void OnGameStarted()
    {
        _startTime = Time.time;
    }
}

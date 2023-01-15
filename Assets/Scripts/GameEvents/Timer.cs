using UnityEngine;
using Zenject;

public class Timer : MonoBehaviour
{
    private GameDifficultySettings _difficulty;
    private GameEvents _gameEvents;
    private TimeRecords _timeRecords;
    private float _currentTimer = 0;
    private float _maxTimer;

    private float _startTime;

    public float StartTime { get { return _startTime; } }

    [Inject]
    private void Construct(GameSettings difficulty, GameEvents gameEvents, TimeRecords timeRecords)
    {
        _difficulty = difficulty.GetCurrentDifficulty();
        _gameEvents = gameEvents;
        _timeRecords = timeRecords;

        _maxTimer = _difficulty.DifficultyUpdateTime;
        _gameEvents.GameEnded += OnGameEnd;
    }
    
    private void Update()
    {
        _currentTimer += Time.deltaTime;

        if (_currentTimer < _maxTimer) return;
        
        _gameEvents.OnDifficultyUpdated();
        _currentTimer = 0;
    }

    private void OnGameEnd()
    {
        _startTime = Time.time;
        _timeRecords.SetLevelTtme(_startTime);
    }
}

using System;
using UnityEngine;
using Zenject;

public class Player : MonoBehaviour
{
    private PlayerInputEvents _inputEvents;
    private GameDifficultySettings _difficulty;
    private GameEvents _gameEvents;

    private float _baseFallSpeed;
    private float _currentFallSpeed;

    [Inject]
    private void Construct(PlayerInputEvents inputEvents, GameDifficultySettings difficulty, GameEvents gameEvents)
    {
        _inputEvents = inputEvents;
        _difficulty = difficulty;
        _gameEvents = gameEvents;

        _baseFallSpeed = difficulty.BaseFallSpeed;
        _currentFallSpeed = _baseFallSpeed;

        _inputEvents.UpPressed += OnUpButtonPressed;
        _inputEvents.UpReleased += OnUpButtonReleased;
        _gameEvents.DifficultyUpdated += UpdateDifficulty;
    }

    private void Update()
    {
        if (_currentFallSpeed != 0)
            transform.Translate(Vector2.down * _currentFallSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter2D()
    {
        _currentFallSpeed = 0;
        _gameEvents.OnPlayerDied();
    }

    private void UpdateDifficulty()
    {
        _baseFallSpeed *= _difficulty.FallSpeedMultiplier;

        if (_currentFallSpeed != 0)
            _currentFallSpeed = _baseFallSpeed * Mathf.Sign(_currentFallSpeed);
    }

    private void OnUpButtonPressed() => SetFloating(true);
    private void OnUpButtonReleased() => SetFloating(false);

    private void SetFloating(bool state)
    {
        if (_currentFallSpeed <= 0) _currentFallSpeed = _baseFallSpeed * Mathf.Sign(_currentFallSpeed);

        if (!state) _currentFallSpeed = Mathf.Abs(_currentFallSpeed);
            else _currentFallSpeed = -Mathf.Abs(_currentFallSpeed);
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameSettings : MonoBehaviour
{
    [SerializeField] private GameDifficultySettings[] _gameDifficultySettings;
    private GameDifficultySettings _currentDifficulty;

    public void SetCurrentDifficulty(GameDifficultySettings settings) => _currentDifficulty = settings;

    public GameDifficultySettings[] GetAllDifficulties() => _gameDifficultySettings;

    public GameDifficultySettings GetCurrentDifficulty()
    {
        if (_currentDifficulty == null) return _gameDifficultySettings.FirstOrDefault();

        return _currentDifficulty;
    }
}

using System;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyScreen : MonoBehaviour
{
    [SerializeField] private ScrollRect _scrollRect;
    [SerializeField] private DifficultyButton _buttonPrefab;

    public event Action<GameDifficultySettings> ButtonPressed;

    public void Init(GameDifficultySettings[] allDifficulties)
    {
        foreach (var difficulty in allDifficulties)
        {
            DifficultyButton button = Instantiate(_buttonPrefab, _scrollRect.content);
            button.ChangeSettings(difficulty, this);
        }
    }

    public void OnButtonPressed(GameDifficultySettings settings)
    {
        ButtonPressed?.Invoke(settings);
    }
}

using System;

public class GameEvents
{
    public event Action DifficultyUpdated;
    public event Action GameEnded;

    public void OnPlayerDied()
    {
        GameEnded?.Invoke();
        SceneSwitcher.LoadEndScreen();
    }

    public void OnDifficultyUpdated()
    {
        DifficultyUpdated?.Invoke();
    }
}

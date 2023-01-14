using System;

public class GameEvents
{
    public event Action PlayerDied;
    public event Action DifficultyUpdated;
    public event Action GameStarted;

    public void OnPlayerDied()
    {
        PlayerDied?.Invoke();
    }

    public void OnDifficultyUpdated()
    {
        DifficultyUpdated?.Invoke();
    }
}

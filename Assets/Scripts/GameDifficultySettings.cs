using UnityEngine;

[CreateAssetMenu(menuName = "GameDifficultySettings")]
public class GameDifficultySettings : ScriptableObject
{
    [SerializeField] private float _gameSpeed;
    [SerializeField] private float _baseFallSpeed;
    [SerializeField] private float _fallSpeedMultiplier;
    [SerializeField] private float _difficultyUpdateTime;

    public float GameSpeed => _gameSpeed;
    public float BaseFallSpeed => _baseFallSpeed;
    public float FallSpeedMultiplier => _fallSpeedMultiplier;
    public float DifficultyUpdateTime => _difficultyUpdateTime;
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class ObstaclesManager : MonoBehaviour
{
    [SerializeField] private Obstacle _obstaclePrefab;
    private GameDifficultySettings _gameDifficultySettings;
    private WorldBorders _borders;

    [Inject]
    private void Construct(GameDifficultySettings gameDifficultySettings)
    {
        _gameDifficultySettings = gameDifficultySettings;
    }

    public void Init(WorldBorders borders)
    {
        _borders = borders;
    }

    public void Update()
    {
        if (Random.Range(1, 2000) != 10) return;

        Vector3 position = new Vector3(_borders.maxX + _obstaclePrefab.transform.localScale.x, Random.Range(_borders.minY + 1, _borders.maxY - 1));
        Instantiate(_obstaclePrefab, position, new Quaternion()).Init(_borders, _gameDifficultySettings);
    }
}

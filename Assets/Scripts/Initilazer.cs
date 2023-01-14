using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Initilazer : MonoBehaviour
{
    [SerializeField] private LinesInitilizer _linesInitilizer;
    private PlayerInitilazer _playerInitilazer; 
    private ObstaclesManager _obstaclesManager;
    private GameDifficultySettings _gameDifficultyDifficulty;

    [Inject]
    private void Construct(GameDifficultySettings difficulty, ObstaclesManager obstaclesManager, PlayerInitilazer playerInitilazer)
    {
        _gameDifficultyDifficulty = difficulty;
        _obstaclesManager = obstaclesManager;
        _playerInitilazer = playerInitilazer;
    }

    private void Awake()
    {
        var borders = ScreenCalculations.GetScreenToWorldPositions();
        _linesInitilizer.Init(borders, _gameDifficultyDifficulty);
        _playerInitilazer.Init(borders);
        _obstaclesManager.Init(borders);
    }
}

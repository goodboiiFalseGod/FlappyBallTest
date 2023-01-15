using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Initilazer : MonoBehaviour
{
    [SerializeField] private LinesInitilizer _linesInitilizer;
    private PlayerInitilazer _playerInitilazer; 
    private ObstaclesManager _obstaclesManager;
    private GameSettings _settings;

    [Inject]
    private void Construct(GameSettings settings, ObstaclesManager obstaclesManager, PlayerInitilazer playerInitilazer)
    {
        _settings = settings;
        _obstaclesManager = obstaclesManager;
        _playerInitilazer = playerInitilazer;
    }

    private void Awake()
    {
        var borders = ScreenCalculations.GetScreenToWorldPositions();
        _linesInitilizer.Init(borders, _settings);
        _playerInitilazer.Init(borders);
        _obstaclesManager.Init(borders);
    }
}

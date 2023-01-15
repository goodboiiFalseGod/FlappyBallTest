using UnityEngine;
using Zenject;

public class LevelInstaller : MonoInstaller
{
    [SerializeField] private PlayerInputEvents _playerInputEvents;
    [SerializeField] private PlayerInitilazer _playerInitilazer;
    [SerializeField] private ObstaclesManager _obstaclesManager;
    [SerializeField] private Timer _timer;

    public override void InstallBindings()
    {
        GameEvents gameEvents = new GameEvents(); 
        Container.Bind<PlayerInputEvents>().FromInstance(_playerInputEvents).AsSingle();
        Container.Bind<PlayerInitilazer>().FromInstance(_playerInitilazer).AsSingle();
        Container.Bind<GameEvents>().FromInstance(gameEvents).AsSingle();
        Container.Bind<ObstaclesManager>().FromInstance(_obstaclesManager).AsSingle();
        Container.Bind<Timer>().FromInstance(_timer).AsSingle();
    }
}
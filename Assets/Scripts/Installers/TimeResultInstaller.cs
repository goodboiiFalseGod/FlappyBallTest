using UnityEngine;
using Zenject;

public class TimeResultInstaller : MonoInstaller
{
    [SerializeField] private TimeResult _timeResult;

    public override void InstallBindings()
    {
        Container.Bind<TimeResult>().FromInstance(_timeResult).AsSingle();
    }
}
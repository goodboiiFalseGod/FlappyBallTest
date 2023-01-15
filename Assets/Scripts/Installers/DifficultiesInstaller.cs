using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class DifficultiesInstaller : MonoInstaller
{
    [SerializeField] private GameSettings _gameSettings;

    public override void InstallBindings()
    {
        Container.Bind<GameSettings>().FromInstance(_gameSettings).AsSingle();
    }
}

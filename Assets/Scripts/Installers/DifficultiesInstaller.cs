using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class DifficultiesInstaller : MonoInstaller
{
    [SerializeField] private GameDifficultySettings _gameDifficultySettings;

    public override void InstallBindings()
    {
        Container.Bind<GameDifficultySettings>().FromInstance(_gameDifficultySettings).AsSingle();
    }
}

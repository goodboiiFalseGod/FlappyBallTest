using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class ChangeDifficultyInstaller : MonoInstaller
{
    [SerializeField] private ChangeDifficultyButton _changeDifficultyButton;

    public override void InstallBindings()
    {
        Container.Bind<ChangeDifficultyButton>().FromInstance(_changeDifficultyButton).AsSingle();
    }
}

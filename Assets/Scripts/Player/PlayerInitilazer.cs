using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class PlayerInitilazer : MonoBehaviour
{
    [SerializeField] private Player _playerPrefab;

    private DiContainer _container;

    [Inject]
    private void Construct(DiContainer container)
    {
        _container = container;
    }

    public void Init(WorldBorders borders)
    {
        Vector2 playerPos = new Vector2(borders.minX + _playerPrefab.transform.localScale.x, borders.maxY / 2);
        Player player = Instantiate(_playerPrefab, playerPos, new Quaternion());
        _container.Inject(player);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInitilazer : MonoBehaviour
{
    [SerializeField] private Player _playerPrefab;

    public void Init(Vector2 startPlayerPosition)
    {
        Instantiate(_playerPrefab, startPlayerPosition, new Quaternion());
    }
}

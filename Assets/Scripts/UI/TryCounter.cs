using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TryCounter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    private int _tryCount;
    private string key = "TryCount";

    private void Awake()
    {
        if (!PlayerPrefs.HasKey(key)) PlayerPrefs.SetInt(key, 0);

        _tryCount = PlayerPrefs.GetInt(key);
        _tryCount++;
        PlayerPrefs.SetInt(key, _tryCount);

        _text.text = $"It's your {_tryCount} try";
    }
}

using UnityEngine;
using UnityEngine.UI;

public class ChangeDifficultyButton : MonoBehaviour
{
    [SerializeField] private ScrollRect _scrollRectPrefab;
    [SerializeField] private Button _button;

    private void Awake()
    {
        _button.onClick.AddListener(ShowDifficultyScreen);
    }

    private void ShowDifficultyScreen()
    {
        Instantiate(_scrollRectPrefab, transform);
    }
}

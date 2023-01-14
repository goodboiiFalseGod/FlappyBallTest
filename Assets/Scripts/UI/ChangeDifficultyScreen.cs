using UnityEngine;
using UnityEngine.UI;

public class ChangeDifficultyScreen : MonoBehaviour
{
    [SerializeField] private ScrollRect _scrollRect;
    [SerializeField] private DifficultyButton _buttonPrefab;

    private void Awake()
    {
        var ss = Resources.LoadAll("GameSettings", typeof(GameDifficultySettings));
        foreach (var s in ss)
        {
            DifficultyButton button = Instantiate(_buttonPrefab, _scrollRect.content);
            button.ChangeButtonText(((GameDifficultySettings)s).name);
        }
    }
}

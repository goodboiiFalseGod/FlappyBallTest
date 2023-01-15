using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class ChangeDifficultyButton : MonoBehaviour
{
    [SerializeField] private DifficultyScreen _difficultyScreenPrefab;
    [SerializeField] private Button _button;

    private DifficultyScreen _currentInstance;
    private GameSettings _settings;

    [Inject]
    private void Construct(GameSettings settings)
    {
        _settings = settings;
    }

    private void Awake()
    {
        _button.onClick.AddListener(ShowDifficultyScreen);
    }

    private void ShowDifficultyScreen()
    {
        _currentInstance = Instantiate(_difficultyScreenPrefab, transform);
        _currentInstance.Init(_settings.GetAllDifficulties());
        _currentInstance.ButtonPressed += OnChoosedDifficulty;
    }

    private void OnChoosedDifficulty(GameDifficultySettings settings)
    {
        _settings.SetCurrentDifficulty(settings);
        _currentInstance.ButtonPressed -= OnChoosedDifficulty;
        Destroy(_currentInstance.gameObject);
    }
}

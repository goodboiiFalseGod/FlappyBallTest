using UnityEngine.SceneManagement;

public static class SceneSwitcher
{
    public static void LoadGamePlay()
    {
        SceneManager.LoadSceneAsync("GamePlay");
    }

    public static void LoadStartingScreen()
    {
        SceneManager.LoadSceneAsync("StartGame");
    }

    public static void LoadEndScreen()
    {

    }
}

using UnityEngine;

public interface GameControllerScriptInterface
{
    void StartGame();
    void EndGame();
    bool IsGameRunning();
}

public class GameControllerScript : MonoBehaviour, GameControllerScriptInterface
{
    [SerializeField]
    public bool GameRunning;

    [SerializeField]
    public GameObject StartPage;

    [SerializeField]
    public GameObject GameOverPage;

    void Start()
	{
        ShowStartPage();
        HideGameOverPage();
	}

    public void EndGame()
    {
        GameRunning = false;
        GameOverPage.SetActive(true);
    }

    public void StartGame()
    {
        HideStartPage();
        HideGameOverPage();
        GameRunning = true;
    }

    private void HideStartPage()
    {
        StartPage.SetActive(false);
    }

    private void ShowStartPage()
    {
        StartPage.SetActive(true);
    }

    private void HideGameOverPage()
    {
        GameOverPage.SetActive(false);
    }

    private void ShowGameOverPage()
    {
        GameOverPage.SetActive(true);
    }

    public bool IsGameRunning()
    {
        return GameRunning;
    }
}

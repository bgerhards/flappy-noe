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
    public bool GameRunning = true;

    public void EndGame()
    {
        GameRunning = false;
    }

    public void StartGame()
    {
        GameRunning = true;
    }

    public bool IsGameRunning()
    {
        return GameRunning;
    }
}
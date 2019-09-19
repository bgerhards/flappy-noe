using UnityEngine;

public class StartGameController : MonoBehaviour
{
    [SerializeField]
    public GameObject NoeMovementController;

    [SerializeField]
    public GameObject GameController;

    [SerializeField]
    public GameObject PipeGeneratorController;

    [SerializeField]
    public GameObject ScoreController;

    public void Reset()
    {
        NoeMovementController.GetComponent<NoeMovementController>().ResetNoe();
        GameController.GetComponent<GameControllerScript>().StartGame();
        PipeGeneratorController.GetComponent<PipeGeneratorScript>().ResetPipes();
        ScoreController.GetComponent<ScoreControllerScript>().ResetScore();

    }
}


using UnityEngine;

public class PipeMovementController : MonoBehaviour
{
    private int movementSpeed = 2;
    private GameObject GameController;

    void Start()
    {
        GameController = GameObjectHelper.GetGameController();
    }

    void FixedUpdate()
    {
        if (GameController.GetComponent<GameControllerScript>().IsGameRunning())
        {
            MovePipe();
        }
    }

    private void MovePipe()
    {
        gameObject.transform.position += -Vector3.right * movementSpeed * Time.deltaTime;
    }
}

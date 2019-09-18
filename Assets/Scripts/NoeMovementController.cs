using UnityEngine;

public class NoeMovementController : MonoBehaviour
{
    [SerializeField]
    public float tapForce = 10;
    [SerializeField]
    public float tiltSmooth = 5;
    [SerializeField]
    public Vector3 startPos;
    private GameObject GameController;
    private GameObject ScoreController;

    Rigidbody2D rb;
    Quaternion downRotation;
    Quaternion forwardRotation;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        downRotation = Quaternion.Euler(0, 0, -90);
        forwardRotation = Quaternion.Euler(0, 0, 35);

        GameController = GameObjectHelper.GetGameController();
        ScoreController = GameObjectHelper.GetScoreController();

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            transform.rotation = forwardRotation;
            rb.velocity = Vector3.zero;
            rb.AddForce(Vector2.up * tapForce, ForceMode2D.Force);
        }

        transform.rotation = Quaternion.Lerp(transform.rotation, downRotation, tiltSmooth * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "DeadZone")
        {
            HandleDeadZoneCollision();
        }
        if (col.gameObject.tag == "ScoreZone")
        {
            HandleScoreZoneCollision();
        }
    }

    private void HandleDeadZoneCollision()
    {
        rb.simulated = false;
        GameController.GetComponent<GameControllerScript>().EndGame();
    }

    private void HandleScoreZoneCollision()
    {
        ScoreController.GetComponent<ScoreControllerScript>().AddPoint();
    }
}

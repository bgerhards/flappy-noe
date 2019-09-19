using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGeneratorScript : MonoBehaviour
{
    [SerializeField]
	public GameObject pipePrefab;

    private GameObject PipeGenerator;
    private GameObject GameController;

    private int lastGenerationSeconds;

    void Start()
    {
        GameController = GameObjectHelper.GetGameController();
        PipeGenerator = GameObject.Find("PipeGenerator");
        PipeGenerator.transform.position = Camera.main.ViewportToWorldPoint(new Vector3(1.1f, 0.5f, 0.0f));
        lastGenerationSeconds = 0;
        InstantiatePipe();
    }


    void FixedUpdate()
    {
        if (GameController.GetComponent<GameControllerScript>().IsGameRunning())
        {
            var timeSinceLevelLoad = (int)Time.timeSinceLevelLoad;
            if (timeSinceLevelLoad % 2 == 0 && timeSinceLevelLoad != lastGenerationSeconds)
            {
                lastGenerationSeconds = timeSinceLevelLoad;
                InstantiatePipe();
            }
        }
	}

    public void ResetPipes()
    {
        foreach (Transform child in PipeGenerator.transform)
        {
            Destroy(child.gameObject);
        }
    }

    private void InstantiatePipe()
    {
        var goPosition = new Vector3(PipeGenerator.transform.position.x, GetYPosition(), 0);
        GameObject go = Instantiate(pipePrefab, goPosition, Quaternion.identity) as GameObject;
        go.transform.parent = PipeGenerator.transform;
    }

    private int GetYPosition()
    {
        return Random.Range(-2, 2);
    }
}

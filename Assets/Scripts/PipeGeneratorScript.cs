using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGeneratorScript : MonoBehaviour
{
    [SerializeField]
	public GameObject pipePrefab;

    private GameObject pipeGenerator;

    private int lastGenerationSeconds;

    void Start()
    {
        pipeGenerator = GameObject.Find("PipeGenerator");
        lastGenerationSeconds = 0;
        InstantiatePipe();
    }


    void FixedUpdate()
    {
        var timeSinceLevelLoad = (int) Time.timeSinceLevelLoad;
        if (timeSinceLevelLoad % 3 == 0 && timeSinceLevelLoad != lastGenerationSeconds)
        {
            lastGenerationSeconds = timeSinceLevelLoad;
            InstantiatePipe();
        }
	}

    private void InstantiatePipe()
    {
        var goPosition = new Vector3(pipeGenerator.transform.position.x, GetYPosition(), 0);
        GameObject go = Instantiate(pipePrefab, goPosition, Quaternion.identity) as GameObject;
        go.transform.parent = GameObject.Find("PipeGenerator").transform;
    }

    private int GetYPosition()
    {
        return Random.Range(-2, 2);
    }
}

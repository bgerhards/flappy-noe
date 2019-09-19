using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeDestroyController : MonoBehaviour
{
    void Start()
    {
        var pipeDestroyer = GameObject.Find("PipeDestroyer");
        pipeDestroyer.transform.position = Camera.main.ViewportToWorldPoint(new Vector3(-0.2f, 0.5f, 0.0f));
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Should be destroying the object");
        Destroy(col.gameObject);
    }
}

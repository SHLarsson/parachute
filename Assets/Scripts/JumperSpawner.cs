using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumperSpawner : MonoBehaviour
{

    public GameObject[] jumper;

    float spawnDelay = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(jumper[Random.Range(0, 3)], new Vector3(0, 0, 0), Quaternion.identity);
        StartCoroutine(Spawn());
    }
}

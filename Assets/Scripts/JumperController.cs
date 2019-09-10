using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumperController : MonoBehaviour
{
    //public List<Transform> positions = new List<Transform>();
    public List<Vector2> positions = new List<Vector2>();

    public int pos = 0;
    float moveDelay = 1.0f;
    float deathDelay = 0.5f;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Move());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Move() {

       
        yield return new WaitForSeconds(moveDelay);
        UpdatePos();
    }

    void UpdatePos() {
        //transform.position = positions[pos].position;
        transform.position = positions[pos];
        Debug.Log("move");
        Debug.Log("pos: " + pos);
        pos++;
        StartCoroutine(Move());
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float PlayerTile = 0;
    public float GridSize = 3.25f;
    public Transform PlayerPos;

    // Start is called before the first frame update
    void Start()
    {
        UpdatePos();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.RightArrow) && PlayerTile < 2)
        {
            PlayerTile += 1;
            Debug.Log(PlayerTile);
            UpdatePos();
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) && PlayerTile > 0){
            PlayerTile -= 1;
            Debug.Log(PlayerTile);
            UpdatePos();
        }

    }
    private void UpdatePos()
    {
        transform.position = new Vector3(PlayerTile * GridSize, -1.5f,0);
    }
}

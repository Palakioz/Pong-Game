using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerLeftManager : MonoBehaviour
{
    private float speedPlayer = 10.0f;
    private bool up, down;
    private float movement;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        up = Input.GetKey(KeyCode.W);
        down = Input.GetKey(KeyCode.S);
        movement = (speedPlayer * Time.deltaTime);

        if (up == true)
        {
            Vector3 movementPlayer = new Vector3(0, movement, 0);
            transform.Translate(movementPlayer);

        }
        else if (down == true)
        {
            Vector3 movementPlayer = new Vector3(0, movement, 0);
            transform.Translate(-movementPlayer);
        }

    }
}

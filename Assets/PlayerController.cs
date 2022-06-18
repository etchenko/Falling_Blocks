using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 7;

    float screenHalfWidthWorldUnits;
    // Start is called before the first frame update
    void Start()
    {

        screenHalfWidthWorldUnits = Camera.main.aspect * Camera.main.orthographicSize + transform.localScale.x / 2f;

    }

    // Update is called once per frame
    void Update()
    {

        float inputX = Input.GetAxisRaw("Horizontal");
        float velocity = inputX * speed;
        transform.Translate(Vector2.right * velocity * Time.deltaTime);

        if (transform.position.x < -screenHalfWidthWorldUnits)
        {
            transform.position = new Vector2(screenHalfWidthWorldUnits, transform.position.y);
        }

        if (transform.position.x > screenHalfWidthWorldUnits)
        {
            transform.position = new Vector2(-screenHalfWidthWorldUnits, transform.position.y);
        }

    }
}

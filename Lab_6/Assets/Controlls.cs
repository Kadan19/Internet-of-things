using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlls : MonoBehaviour
{
    //Start is called before the first frame update
    public float speed = 40f;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent <Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update()
    {
        //Движение вправо и влево
        float moveX = Input.GetAxis ("Horizontal");
        rb.MovePosition(rb.position + Vector2.right * moveX * speed * Time.deltaTime);
        //Прыжок
        if (Input.GetKeyDown (KeyCode.Space))
        {
            rb.AddForce (Vector2.up * 5000);
        }
    }
}

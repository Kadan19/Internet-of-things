using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die_heroy : MonoBehaviour
{
    public GameObject respaun;
    public GameObject Player;
    public GameObject UI_game_over;

    void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.tag == Player.tag)
        {
            UI_game_over.SetActive(true);
            Time.timeScale = 0f;
           // Player.transform.position = respaun.transform.position;
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pob : MonoBehaviour
{
    public GameObject respaun;
    public GameObject Player;
    public GameObject UI_game_vic;

    void OnTriggerEnter2D (Collider2D collision)
    {
        if (Player.tag == collision.tag)
        {
            UI_game_vic.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}

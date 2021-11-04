using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pob : MonoBehaviour
{
    public GameObject Player;
    
    void OnTriggerEnter2D (Collider2D collision)
    {
        if (Player.tag == collision.tag)
        {
            SceneManager.LoadScene("Pobeda");
        }
    }
}

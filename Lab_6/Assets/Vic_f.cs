using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vic_f : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Player;
    public GameObject respaun;
    public GameObject UI_game_vic;
    public void Resume()
    {
        Player.transform.position = respaun.transform.position;
        UI_game_vic.SetActive(false);
        Time.timeScale = 1f;

    }
}

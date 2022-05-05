using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelFailed : MonoBehaviour

{
    public GameManager gameManager;
    PlayerMovement player;

    private void Start()
    {
        player = PlayerMovement.instance;
        player.isLevelFail = false;
    }



    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            gameManager.LevelFailed();
            player.isLevelFail = true;
        }
        
    }
}

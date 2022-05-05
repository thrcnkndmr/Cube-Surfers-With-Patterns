using UnityEngine;

public class FinishTrigger : MonoBehaviour

{
    public GameManager gameManager;
    PlayerMovement player;

    private void Start()
    {
        player = PlayerMovement.instance;
    }



    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
        player.isLevelDone = true;
    }
}
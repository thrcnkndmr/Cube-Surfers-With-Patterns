using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;
    public GameObject nextLevel;
    public GameObject levelFailedUI;
    public GameObject quit;
    public GameObject retryLevel;
   

    public void Start()
    {
        completeLevelUI.SetActive(false);
        levelFailedUI.SetActive(false);
        nextLevel.SetActive(false);
        quit.SetActive(false);
        retryLevel.SetActive(false);
    }

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        levelFailedUI.SetActive(false);
        nextLevel.SetActive(true);
        quit.SetActive(true);
        retryLevel.SetActive(false);

    }

    public void LevelFailed()
    {
        completeLevelUI.SetActive(false);
        levelFailedUI.SetActive(true);
        nextLevel.SetActive(false);
        quit.SetActive(true);
        retryLevel.SetActive(true);

    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("Restart", 2f);
        }

    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

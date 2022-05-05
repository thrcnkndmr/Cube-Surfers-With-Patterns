using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorePanelObserver : MonoBehaviour

    //Observer
{
    public Transform player;
    public Text scoreText;

    private void Start()
    {
        ScorePanel.OnScoreChange += Update;
    }

    public void Update () => scoreText.text = player.position.z.ToString("0");
}

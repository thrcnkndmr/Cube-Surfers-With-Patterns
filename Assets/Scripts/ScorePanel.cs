using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePanel : MonoBehaviour
{
    public static event Action OnScoreChange;

    //Subject  

    public void ScoreOnChanged()
    {
        OnScoreChange?.Invoke();
    }
}

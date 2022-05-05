using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float forwardSpeed;
    [SerializeField] private float sidewaysSpeed;
    public bool isLevelDone;
    public bool isLevelFail;
    public static PlayerMovement instance;

    private void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
    }

    void Start()
    {
        
    }


    void Update()
    {
        if (!isLevelDone && !isLevelFail)
        {
            float horizontal = Input.GetAxis("Horizontal") * sidewaysSpeed * Time.deltaTime;
            this.transform.Translate(horizontal, 0, forwardSpeed * Time.deltaTime);
        }
    }

    }

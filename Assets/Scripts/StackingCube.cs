using System.Collections;
using System.Collections.Generic;
using UnityEngine;using UnityEngine.SceneManagement;

public class StackingCube : MonoBehaviour
{
    bool didStacked;
    int index;
    public Stacker stacker;
    [SerializeField] private CubeType cubeType = null;

    void Start()
    {
        didStacked = false;
        GetComponent<Renderer>().material.color = cubeType.cubeColor;
        transform.localScale = cubeType.cubeScale;

    }

    void Update()
    {
        if(didStacked)
        {
            if (transform.parent != null)
            {
                transform.localPosition = new Vector3(0, -index, 0);

            }

        }






    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            stacker.decreaseHeight();
            transform.parent = null;
            GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
       
    }
    public bool GetDidStacked()
    {
        return didStacked;
    }
    public void Stacked()
    {
        didStacked = true;
    }

    public void IndexSetting(int index)
    {
        this.index = index;
    }

}

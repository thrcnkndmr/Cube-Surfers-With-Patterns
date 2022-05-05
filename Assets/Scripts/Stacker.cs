using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stacker : MonoBehaviour
{
    GameObject mainCube;
    int heigh;

    void Start()
    {
        mainCube = GameObject.Find("MainCube");
    }

    void Update()
    {
        mainCube.transform.position = new Vector3(transform.position.x, heigh + 1, transform.position.z);
        this.transform.localPosition = new Vector3(0, -heigh, 0);
    }
    public void decreaseHeight()
    {
        heigh--;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Stack" && other.gameObject.GetComponent<StackingCube>().GetDidStacked()==false)
        {
            heigh += 1;
            other.gameObject.GetComponent<StackingCube>().Stacked();
            other.gameObject.GetComponent<StackingCube>().IndexSetting(heigh);
            other.gameObject.transform.parent = mainCube.transform;
        }

    }
}

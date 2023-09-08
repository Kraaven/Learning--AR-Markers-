using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public GameObject FuseBox;

    public void Ini()
    {
        FuseBox = GameObject.FindGameObjectWithTag("Fuse");
        Debug.Log("Initialised the Box");
        Debug.Log(FuseBox.transform.rotation);
    }

    public void TurnLeft()
    {
        FuseBox.transform.Rotate(Vector3.up*15);
    }

    public void TurnRight()
    {
        FuseBox.transform.Rotate(Vector3.up*-15);
    }
}

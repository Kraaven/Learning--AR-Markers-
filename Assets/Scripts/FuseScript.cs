using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuseScript : MonoBehaviour
{
    public GameObject ButtonSystem;
    void Start()
    {
        ButtonSystem = GameObject.FindGameObjectWithTag("ButtonManager");
        ButtonSystem.GetComponent<ButtonScript>().Ini();
        Debug.Log("Found Button System");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

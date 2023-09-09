using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public GameObject FuseBox;
    public GameObject UI;
    public GameObject AudioSrc;
    public bool showUI;
    public bool PlayAudio;
    public void Ini()
    {
        FuseBox = GameObject.FindGameObjectWithTag("Fuse");
        Debug.Log("Initialised the Box");
        Debug.Log(FuseBox.transform.rotation);
        UI = GameObject.FindGameObjectWithTag("TaskUI");
        UI.SetActive(false);
        AudioSrc = GameObject.FindGameObjectWithTag("Audio");
        AudioSrc.GetComponent<AudioSource>().mute = true;
    }

    public void TurnLeft()
    {
        FuseBox.transform.Rotate(Vector3.up*15);
    }

    public void TurnRight()
    {
        FuseBox.transform.Rotate(Vector3.up*-15);
    }

    public void AlignDown()
    {
        FuseBox.transform.Rotate(90,0,0);
    }

    public void ShowTask()
    {
        showUI = !showUI;
        UI.SetActive(showUI);
    }

    public void ListenSound()
    {
        PlayAudio = !PlayAudio;

        AudioSrc.GetComponent<AudioSource>().mute = !PlayAudio;
    }
}

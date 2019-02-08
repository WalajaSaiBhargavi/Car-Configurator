using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class rimClick : MonoBehaviour {

    public GameObject replacewheel;
    public GameObject replacewheel1;
    public GameObject replacewheel2;
    public GameObject replacewheel3;
    public GameObject wheel1;
    public GameObject wheel2;
    public GameObject wheel3;
    public GameObject wheel4;
    public Texture Button1;
    public Texture Button2;

    void Start () {
        replacewheel.SetActive(false);
        replacewheel1.SetActive(false);
        replacewheel2.SetActive(false);
        replacewheel3.SetActive(false);
    }

    private void OnGUI()
    {
        if (GUI.Button(new Rect(1000, 40, 100, 100), Button1))
        {
            wheel1.SetActive(false);
            wheel2.SetActive(false);
            wheel3.SetActive(false);
            wheel4.SetActive(false);
            replacewheel.SetActive(true);
            replacewheel1.SetActive(true);
            replacewheel2.SetActive(true);
            replacewheel3.SetActive(true);
        }
        if (GUI.Button(new Rect(1000, 200, 100, 100), Button2))
        {
            replacewheel.SetActive(false);
            replacewheel1.SetActive(false);
            replacewheel2.SetActive(false);
            replacewheel3.SetActive(false);
            wheel1.SetActive(true);
            wheel2.SetActive(true);
            wheel3.SetActive(true);
            wheel4.SetActive(true);
        }
    }
}

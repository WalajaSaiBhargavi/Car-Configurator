using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {

    public GameObject[] bodycolorred;
    public GameObject[] bodycolorblack;
    public GameObject[] glasscolor;
    public GameObject[] steel;
    private int count = 0;
    public Texture Button;
    public Texture Button1;
    public Texture Button2;
    public Texture[] textures = new Texture[3];

    void Start()
    {
        for (count = 0; count < bodycolorred.Length; count++)
        {
            bodycolorred[count].GetComponent<Renderer>().material.mainTexture = textures[0];
            bodycolorred[count].GetComponent<Renderer>().material.color = Color.red;
        }
        count = 0;
        for (count = 0; count < bodycolorblack.Length; count++)
        {
            bodycolorblack[count].GetComponent<Renderer>().material.color = Color.black;
        }
        count = 0;
        for (count = 0; count < glasscolor.Length; count++)
        {
            glasscolor[count].GetComponent<Renderer>().material.color = Color.clear;
        }
        count = 0;
        for (count = 0; count < steel.Length; count++)
        {
            steel[count].GetComponent<Renderer>().material.color = Color.grey;
        }
    }


    public void OnGUI()
    {
        if (GUI.Button(new Rect(40, 40, 100, 100), Button))
        {
            for (count = 0; count < bodycolorred.Length; count++)
            {
                bodycolorred[count].GetComponent<Renderer>().material.mainTexture = textures[0];
                bodycolorred[count].GetComponent<Renderer>().material.color = Color.red;
            }
            count = 0;
            for (count = 0; count < bodycolorblack.Length; count++)
            {
                bodycolorblack[count].GetComponent<Renderer>().material.color = Color.black;
            }
            count = 0;
            for (count = 0; count < glasscolor.Length; count++)
            {
                glasscolor[count].GetComponent<Renderer>().material.color = Color.clear;
            }
            count = 0;
            for (count = 0; count < steel.Length; count++)
            {
                steel[count].GetComponent<Renderer>().material.color = Color.grey;
            }
        }
        if (GUI.Button(new Rect(40, 200, 100, 100), Button1))
        {
            for (count = 0; count < bodycolorred.Length; count++)
            {
                bodycolorred[count].GetComponent<Renderer>().material.mainTexture = textures[1];
                bodycolorred[count].GetComponent<Renderer>().material.color = Color.black;
            }
            count = 0;
            for (count = 0; count < bodycolorblack.Length; count++)
            {
                bodycolorblack[count].GetComponent<Renderer>().material.color = Color.black;
            }
            count = 0;
            for (count = 0; count < glasscolor.Length; count++)
            {
                glasscolor[count].GetComponent<Renderer>().material.color = Color.clear;
            }
            count = 0;
            for (count = 0; count < steel.Length; count++)
            {
                steel[count].GetComponent<Renderer>().material.color = Color.grey;
            }
        }
        if (GUI.Button(new Rect(40, 360, 100, 100), Button2))
        {
            for (count = 0; count < bodycolorred.Length; count++)
            {
                bodycolorred[count].GetComponent<Renderer>().material.mainTexture = textures[2];
                bodycolorred[count].GetComponent<Renderer>().material.color = Color.blue;
            }
            count = 0;
            for (count = 0; count < bodycolorblack.Length; count++)
            {
                bodycolorblack[count].GetComponent<Renderer>().material.color = Color.black;
            }
            count = 0;
            for (count = 0; count < glasscolor.Length; count++)
            {
                glasscolor[count].GetComponent<Renderer>().material.color = Color.clear;
            }
            count = 0;
            for (count = 0; count < steel.Length; count++)
            {
                steel[count].GetComponent<Renderer>().material.color = Color.grey;
            }
        }
    }
}

﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scoreCtrl : MonoBehaviour {

    public int score = 0;
    public Text text;
	// Use this for initialization
	void Start ()
    {
	    
	}
	
	// Update is called once per frame
	void Update ()
    {
        text.text = score.ToString();
    }
}

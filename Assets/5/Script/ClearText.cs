﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearText : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Return))
        {
            GM.Restart();
        }
	}

}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Ip_text : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Text>().text = "IP" + UnityEngine.Network.player.ipAddress;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

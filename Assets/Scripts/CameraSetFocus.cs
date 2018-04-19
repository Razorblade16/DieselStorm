﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSetFocus : MonoBehaviour {

    public Cinemachine.CinemachineFreeLook m_cam;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void setFocus(UnityEngine.Object[] args)
    {
        var sender = args[0] as GameObject;
        if(sender != null)
        {
            m_cam.m_Follow = sender.transform;
            m_cam.m_LookAt = sender.transform;
        }        
    }
}

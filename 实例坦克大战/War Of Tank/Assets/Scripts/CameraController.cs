﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Transform target;
	
	void LateUpdate () {
        if (target == null) return;

        transform.position = target.position;
	}
}

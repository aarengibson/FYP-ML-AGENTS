﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {
    private void OnTriggerEnter(Collider other) {  //-- On collision
        if (other.GetComponent<CheckpointManager>() != null) {
            other.GetComponent<CheckpointManager>().CheckPointReached(this);  //-- Set as reached
        }
    }
}

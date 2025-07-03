using System.Collections;
using System.Collections.Generic;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;
using UnityEngine;

public class KartAgent: Agent {
    public CheckpointManager _checkpointManager;
    private KartController _kartController;
    
    public override void Initialize() {  //-- Assign KartController on init
        _kartController = GetComponent<KartController>();
    }
    
    public override void OnEpisodeBegin() {  //-- Run when each episode begins
        _checkpointManager.ResetCheckpoints();
        _kartController.Respawn();
    }

    public override void CollectObservations(VectorSensor sensor) {  //-- Data collection    
        Vector3 diff = _checkpointManager.nextCheckPointToReach.transform.position - transform.position;
        sensor.AddObservation(diff/20f);
        AddReward(-0.001f);
    }

    public override void OnActionReceived(ActionBuffers actions) {  //-- Actions by the AI
        var input = actions.ContinuousActions;
        _kartController.ApplyAcceleration(input[1]);
        _kartController.Steer(input[0]);
    }
    
    public override void Heuristic(in ActionBuffers actionsOut) {  //-- Human input
        var action = actionsOut.ContinuousActions;
        action[0] = Input.GetAxis("Horizontal");        
        if (Input.GetKey(KeyCode.W)) {
            action[1] = 1;
        } else {
            action[1] = 0;
        }
    }
}

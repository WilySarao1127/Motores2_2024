using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OntriggerEnterDecision : AIDecision
{
    private bool hasPlayerEnter;
    public override bool Decide()
    {
       return true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            _brain.Target = other.transform;
            hasPlayerEnter = true;
        }
    }

    public override void OnExitState()
    {
        base.OnExitState();
        hasPlayerEnter = false;
    }
}

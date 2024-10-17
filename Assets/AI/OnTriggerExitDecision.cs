using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerExitDecision : AIDecision
{
    private bool PlayerExit;

    public override void Initialization()
    {
        base.Initialization();
    }
    public override bool Decide()
    {
        return true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player" && _brain.Target != null)
        {
            _brain.Target = other.transform;
            PlayerExit = true;
        }
    }

    public override void OnExitState()
    {
        base.OnExitState();
        PlayerExit = false;
    }
}

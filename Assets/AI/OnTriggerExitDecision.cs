using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerExitDecision : AIDecision
{
    private bool PlayerExit;


    public override bool Decide()
    {
        return PlayerExit;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player" && _brain.Target != null)
        {
            _brain.Target = null;
            PlayerExit = true;
        }
    }

    public override void OnExitState()
    {
        base.OnExitState();
        PlayerExit = false;
    }
}

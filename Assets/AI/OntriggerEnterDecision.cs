using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OntriggerEnterDecision : AIDecision
{
    private bool hasPlayerEnter;
    public override bool Decide()
    {
       return hasPlayerEnter;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            _brain.Target = other.transform;
            hasPlayerEnter = true;
            if (TryGetComponent<ReturnOriginAction>(out ReturnOriginAction returnOriginComponent))
            {
                returnOriginComponent.originPos = transform.position;
            }

            if (TryGetComponent<DistanceDecision>(out DistanceDecision distanceDecisionComponent ))
            {
                distanceDecisionComponent.originPos = transform.position;
            }


        }
    }

    public override void OnEnterState()
    {
        base.OnEnterState();
        hasPlayerEnter = false;
    }
}

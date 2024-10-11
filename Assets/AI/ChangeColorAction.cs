using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorAction : AIAction
{
    public override void PerformAction() { }
    public Color alertColor;
    private Color originalColor;

    public override void OnEnterState()
    {
        base.OnEnterState();
        originalColor = GetComponentInChildren<MeshRenderer>().material.color;
        GetComponentInChildren<MeshRenderer>().material.color = alertColor;

    }

    public override void OnExitState()
    {
        base.OnExitState();
        GetComponentInChildren<MeshRenderer>().material.color = originalColor;

    }

}

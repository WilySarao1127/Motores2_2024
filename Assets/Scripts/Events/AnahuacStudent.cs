using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnahuacStudent : GameMonoBehaviour
{

    private void Start()
    {
        AddEventListener<WinAnahuacRaffleEvent>(WinRaffle);
    }
    public void WinRaffle(WinAnahuacRaffleEvent _event)
    {
        Debug.Log("GANE UNA RIFA WAOS");
    }

}

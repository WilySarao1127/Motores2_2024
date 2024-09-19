using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    private static EnemyManager instance;
    public static EnemyManager Instance
    {
        get
        {
            if (instance == null)
                instance = GameObject.FindObjectOfType<EnemyManager>();
            return instance;
        }
    }
    public void SpawnEnemy()
    {
        EventManager.m_Instance.InvokeEvent<EnemySpawnEvent>(new EnemySpawnEvent());
    }
}


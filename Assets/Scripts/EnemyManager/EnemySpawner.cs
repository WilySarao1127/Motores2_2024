using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : GameMonoBehaviour
{
    private void Start()
    {
        AddEventListener<EnemySpawnEvent>(SpawnEnemy);
    }
    public void SpawnEnemy(EnemySpawnEvent _event)
    {
        EnemyManager newEnemyManager;
        PoolManager.Instance<EnemyManager>(out newEnemyManager, itemPrefab, this.transform);
    }
}

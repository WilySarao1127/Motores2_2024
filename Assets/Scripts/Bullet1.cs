using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Bullet : MonoBehaviour
{
    private float time = 10;
    private float variantTime = 0;

    private void Disable()
    {
        
    }


    private void Update()
    {
        if(variantTime < time)
        {
            variantTime += Time.deltaTime;
        }
        else
        {
            //Destroy(this.gameObject);
            variantTime = 0;
            PoolManager.Instance.ReturnObjectToPool(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //Destroy(this.gameObject);
        variantTime = 0;
        PoolManager.Instance.ReturnObjectToPool(this.gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CR_Destroy());
        
    }

    IEnumerator CR_Destroy()
    
    {
    yield return new WaitForSeconds(3.0f);
        DestroyImmediate(this.gameObject);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
        Destroy(other.gameObject);  
    }


}

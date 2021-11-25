using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereB : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(this.transform.position.y);
        if (this.transform.position.y < -1)
        {
            Destroy(this.gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zidan : MonoBehaviour
{
    //public Vector3 point;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,1.5f);
    }
    
    // Update is called once per frame
    void Update()
    {
        //print(transform.forward);
        //transform.position = Vector3.MoveTowards(transform.position,point,1f);
    }
    private void OnCollisionEnter(Collision collision)
    {
        
    }
}

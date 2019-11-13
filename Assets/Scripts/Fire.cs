using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject zidan;
    public float speed;
    RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        if (Input.GetMouseButtonDown(0)) {
            Ray ray = Camera.main.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
            if (Physics.Raycast(ray, out hit))
            {
                print(hit.collider.name);
                GameObject go = Instantiate(zidan, Input.mousePosition, Quaternion.identity);
                //go.GetComponent<zidan>().point = hit.point;
                go.transform.LookAt(hit.point);
                if (hit.collider.tag == "atsker") {
                    Destroy(hit.collider.gameObject);
                }
                //print(Input.mousePosition);
                //go.GetComponent<Rigidbody>().velocity = hit.point * speed;
            }
        }
    }
}

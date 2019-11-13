using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WaypointsNavMesh : MonoBehaviour
{
    Transform EndPoint3;
    NavMeshAgent nma;
    // Start is called before the first frame update
    void Start()
    {
        //print(transform.Find("atacker"));
        nma = transform.GetComponent<NavMeshAgent>();
        EndPoint3 = GameObject.Find("EndPoint").transform;
        print(EndPoint3);
        nma.SetDestination(EndPoint3.position);
        //print(nma.destination);
        //print(new Vector3(EndPoint3.localPosition.x, transform.localPosition.y, EndPoint3.localPosition.z));
    }

    // Update is called once per frame
    void Update()
    {
        //if (Vector3.Distance(transform.localPosition,new Vector3(EndPoint3.localPosition.x,transform.localPosition.y, EndPoint3.localPosition.z)) > 0.5f)
        //    transform.position = Vector3.MoveTowards(transform.position, new Vector3(EndPoint3.localPosition.x, transform.localPosition.y, EndPoint3.localPosition.z), 0.2f);
        //else { Destroy(gameObject); }
        //print(nma.remainingDistance + "   " + nma.stoppingDistance);
        //nma.SetDestination(EndPoint3);
        if (!nma.pathPending && nma.remainingDistance <= nma.stoppingDistance)
        {
            Destroy(gameObject);
        }
    }
}

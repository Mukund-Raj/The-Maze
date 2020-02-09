using UnityEngine.AI;
using UnityEngine;

public class audiosourcemoving : MonoBehaviour {

   // public Transform player;
   // public Transform source;
    public NavMeshSurface nav;
    private Vector3 pos1, pos2;
    private NavMeshAgent agent;
    public Transform[] destination;
    private int Count = 10;
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        Count = 0;
        agent.SetDestination(destination[Count].localPosition);
        Count += 1;
    }


    private void OnTriggerEnter(Collider other)
    {    if (destination.Length <= 13)
        {
            if ((other.gameObject.name == "FPSController" || other.gameObject.name== "RigidBodyFPSController") && agent.transform.position == destination[Count - 1].transform.position)
            {
               // Debug.Log(other.gameObject.name);
                agent.SetDestination(destination[Count++].localPosition);
                //Debug.Log(destination[Count]);
            }
        }
     
        
    }
}

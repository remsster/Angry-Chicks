using UnityEngine;
using UnityEngine.AI;

public class FollowDestination : MonoBehaviour
{
    public Transform Destination;
    private NavMeshAgent ThisAgent;

    private void Awake()
    {
        ThisAgent = gameObject.GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        ThisAgent.SetDestination(Destination.position);
    }
}

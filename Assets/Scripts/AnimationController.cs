using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent),typeof(Animator))]

public class AnimationController : MonoBehaviour
{
    public float RunVelocity = 0.1f;
    public string AnimationRunParamName = "Run";
    private NavMeshAgent ThisNavMeshAgent;
    private Animator ThisAnimator;

    public string AnimationSpeedParamName = "Speed";
    private float MaxSpeed;

    private void Awake()
    {
        ThisNavMeshAgent = gameObject.GetComponent<NavMeshAgent>();
        ThisAnimator = gameObject.GetComponent<Animator>();
        MaxSpeed = ThisNavMeshAgent.speed;
    }

    private void Update()
    {
        ThisAnimator.SetBool(AnimationRunParamName, ThisNavMeshAgent.velocity.magnitude > RunVelocity);
        ThisAnimator.SetFloat(AnimationSpeedParamName, ThisNavMeshAgent.velocity.magnitude / MaxSpeed);


    }
}

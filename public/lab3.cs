using UnityEngine;
using UnityEngine.AI;

public class Lab3 : MonoBehaviour
{
public Transform player;
public float roamRadius = 10f;
public float detectionRange = 8f;
NavMeshAgent agent;
Vector3 roamPoint;

void Start()
{
agent = GetComponent<NavMeshAgent>();
SetNewRoamPoint();
}
void Update()
{
float distance = Vector3.Distance(transform.position, player.position);

if (distance <= detectionRange)
{
agent.SetDestination(player.position);
}
else
{
if (!agent.pathPending && agent.remainingDistance < 0.5f)
{
SetNewRoamPoint();
}
}
}

void SetNewRoamPoint()
{
Vector3 randomDirection = Random.insideUnitSphere * roamRadius;
randomDirection += transform.position;

NavMeshHit hit;
NavMesh.SamplePosition(randomDirection, out hit, roamRadius, 1);
roamPoint = hit.position;

agent.SetDestination(roamPoint);
}
}

using UnityEngine;
public class AnimationController : MonoBehaviour
{
public Animator animator;
public ParticleSystem ps;
void Start()
{
animator=GetComponent<Animator>();
ps=GetComponentInChildren<ParticleSystem>();
}
void Update()
{
// Animation 1
if (Input.GetKeyDown(KeyCode.Alpha1))
{
animator.SetBool("a", true);
}
if (Input.GetKeyUp(KeyCode.Alpha1))
{
animator.SetBool("a", false);
}
// Animation 2
if (Input.GetKeyDown(KeyCode.Alpha2))
{
animator.SetBool("b", true);
}
if (Input.GetKeyUp(KeyCode.Alpha2))
{
animator.SetBool("b", false);
}
//Particle system
if (Input.GetKeyDown(KeyCode.P))
{
if (ps.isPlaying)
{
ps.Stop();
}
else
{
ps.Play();
}
}

}
}

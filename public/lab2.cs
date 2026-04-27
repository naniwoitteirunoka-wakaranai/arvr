using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Lab2 : MonoBehaviour
{
public float speed = 5f;
void Update()
{
// Get input from keyboard (old input system)
float moveX = Input.GetAxis("Horizontal"); // A/D or Left/Right arrow
float moveZ = Input.GetAxis("Vertical"); // W/S or Up/Down arrow

// Movement vector
Vector3 move = new Vector3(moveX, 0f, moveZ);

// Move the player
transform.Translate(move * speed * Time.deltaTime);
}
void OnCollisionEnter(Collision collision)
{
// Check if collided object has tag "Obstacle"
if (collision.gameObject.CompareTag("Obstacle"))
{
Debug.Log("Obstacle Found!");
}
}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot : MonoBehaviour
{
    public Transform ball;
    public float speed = 7f; 

    private Vector2 destination;

    public void MoveToBall()
    {
        
        destination = new Vector2(transform.position.x, ball.position.y);
        transform.position = Vector2.Lerp(transform.position, destination, speed * Time.deltaTime);
    }

    void Update()
    {
        MoveToBall();
    }
}

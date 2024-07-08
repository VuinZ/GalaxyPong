using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float minSpeed = 20f;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>(); //mengambil rigidbody component dari sebuah bole
        Invoke("GoBall", 2); //memanggil function GoBall dlm 2 detik
    }
    void GoBall()
    {
        float rand = Random.Range(0, 2); //akan random nilai diantara 0-1
        if (rand < 1)
        { 
            rb2d.AddForce(new Vector2(100, -30)); //add force memberikan tenaga
					
        }
        else
        {
            rb2d.AddForce(new Vector2(-100, -30));
        }
    }

    void ResetBall() //ini kita buat nilai transform jadi 0
    {
        rb2d.velocity = Vector2.zero;
        transform.position = Vector2.zero;
    }

    void RestartGame()
    {
        //Debug.Log("Restart!");
        ResetBall();
        Invoke("GoBall", 1);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.collider.CompareTag("Player")) //jika terkena player
        {

           // StartCoroutine(FireTriggger());
            Vector2 vel;
            vel.x = rb2d.velocity.x;
            vel.y = (rb2d.velocity.y / 2) + (coll.collider.attachedRigidbody.velocity.y / 3); //mengambil nilai velocity player
            rb2d.velocity = vel;

        }
        AdjustBallSpeed();
    }
    void AdjustBallSpeed()
    {
        // Mengambil kecepatan bola
        Vector2 currentVelocity = rb2d.velocity;

        // Jika kecepatan di bawah nilai minimum, sesuaikan
        if (currentVelocity.magnitude < minSpeed)
        {
            rb2d.velocity = currentVelocity.normalized * minSpeed;
        }
    }
}
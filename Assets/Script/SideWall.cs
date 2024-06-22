using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideWall : MonoBehaviour
{
    public AudioSource _audioSource;
    void OnTriggerEnter2D(Collider2D hitInfo)
    {

        if (hitInfo.name == "Ball")
        {
            string wallName = transform.name;
            //memanggil method Score di GameManager.cs
            GameManager.instance.Score(wallName);
            //memanggil method RestartGame() di BallControl.cs
            hitInfo.gameObject.SendMessage("RestartGame", 1.0f, SendMessageOptions.RequireReceiver);
            _audioSource.Play();
        }
    }
}
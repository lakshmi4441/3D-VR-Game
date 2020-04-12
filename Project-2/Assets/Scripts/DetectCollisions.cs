using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBehaviour : MonoBehaviour
{
    private AudioSource Source;
    // Start is called before the first frame update
    void Start()
    {
        Source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void onCollisionEnter2D(Collision2D col)
    {
        // When target is hit
        if (col.gameObject.tag == "Bullet")
        {
            Debug.Log("Target was Hit!");

           

            // play sound
            Source.Play();

            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}

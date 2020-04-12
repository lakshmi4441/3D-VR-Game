using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject Bullet;
    private AudioSource Source
        ;
   
    // Start is called before the first frame update
    void Start()
    {
        Source = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        // instantiate the appleFood object
        Instantiate(Bullet, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 0), new Quaternion(0, 0, 0, 0));

        //play the sound
        Source.Play();

       
    }

}

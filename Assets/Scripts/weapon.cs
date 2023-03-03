using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{

    public float dmg = 10f;
    public float range = 25f;
    public AudioSource source;
    public ParticleSystem particles;
    public Camera notcamera;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            Debug.Log("jeshot");
            source.Play();
            particles.Play();
            processRayCast();
        }
    }

    public void processRayCast()
    {
        RaycastHit hit;
        if (Physics.Raycast(notcamera.transform.position, notcamera.transform.forward, out hit, range)) {
            Debug.Log("hit" + hit.transform.name);
            EnemyHealth target = hit.transform.GetComponent<EnemyHealth>();
            if (target == null) return;
            target.damage(dmg);
        }else{
            return;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack1 : MonoBehaviour
{
    public Transform target;
    public float dmg = 5;
    public AudioSource source;

    // Start is called before the first frame update
    public void Attack()
    {
        source.Play();
        Debug.Log(name + "is attacking" + target.name);
    }
}

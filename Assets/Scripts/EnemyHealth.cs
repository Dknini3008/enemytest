using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public static float EnemyHP = 100f;
    public AudioSource source;

    public void damage(float dmg)
    {
        EnemyHP -= dmg;
        Debug.Log(EnemyHP);
        if (EnemyHP <= 0) 
        {
            Debug.Log("semurio");
            source.Play();
            Destroy(gameObject, 2);
        }
    }

}

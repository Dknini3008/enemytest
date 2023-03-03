using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public static int hp = 100;

    public static void damage(int dmg)
    {
        hp -= dmg;    
    }

}
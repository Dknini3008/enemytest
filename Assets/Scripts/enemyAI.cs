using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyAI : MonoBehaviour
{
    public Transform target;
    NavMeshAgent navMeshAgent;
    public float chaseRange = 10f;
    public float distanceToTarget = Mathf.Infinity;
    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update(){
        distanceToTarget = Vector3.Distance(target.position, transform.position);
        EngageTarget();
    }

    public void EngageTarget(){
        if(distanceToTarget < chaseRange){
            chase();
        }if(distanceToTarget < chaseRange){
            attackTarget();
        }else{
            StopChasing();
        }
    }

    public void chase(){
        navMeshAgent.SetDestination(target.position);
    }

    public void StopChasing(){
        navMeshAgent.SetDestination(transform.position);   
    }

    public void attackTarget(){
        Debug.Log(name + "is attacking" + target.name);
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBerat : MonoBehaviour
{

    [SerializeField] WaveConfig waveConfig;
    
    int waypointIndex = 0;
    List<Transform> waypoints;



    void Start()
    {
        waypoints = waveConfig.GetWayPoints();
        transform.position = waypoints[waypointIndex].transform.position;
        
    }


    
    void Update()
    {
        Move();
    }



    public void SetWaveConfig(WaveConfig waveConfig)
    {
        this.waveConfig = waveConfig;
    }
    private void Move()
    {
        if (waypointIndex <= waypoints.Count - 1)
        {
            var targetPosition = waypoints[waypointIndex].transform.position;
            var movementThisFrame = waveConfig.GetMoveSpeed() * Time.deltaTime;
            transform.position = Vector3.MoveTowards
                (transform.position, targetPosition, movementThisFrame);

            if (transform.position == targetPosition)
            {
                waypointIndex++;
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }
}	

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class butterflyMomvement : MonoBehaviour
{
    public Transform[] wayPoints;
    private int currentWaypointIndex = 0;
    private bool allowMove = false;
    public void Update()
    {
        if(wayPoints[currentWaypointIndex] != null)
            transform.position += wayPoints[currentWaypointIndex].position;
    }
    public void MoveButterFlyToNextPoint()
    {
        if (currentWaypointIndex + 1 < wayPoints.Length - 1)
        {
            currentWaypointIndex++;
        }
    }
    public void MoveButterFlyToPoint(int pointIndex)
    {
        if (pointIndex < wayPoints.Length - 1)
        {
            currentWaypointIndex = pointIndex;
        }
    }
    public void MoveButterFlyToPreviousPoint()
    {
        if (currentWaypointIndex - 1 < wayPoints.Length - 1)
        {
            currentWaypointIndex--;
        }
    }
}

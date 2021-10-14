using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Road")]
public class RoadMap : ScriptableObject
{
    [SerializeField] GameObject waypointsPrefab;

    

    public List<Transform> GetWayPoints()
    {
        var waypoints = new List<Transform>();
        foreach (Transform item in waypointsPrefab.transform)
        {
            waypoints.Add(item);
        }
        return waypoints;
    }
}

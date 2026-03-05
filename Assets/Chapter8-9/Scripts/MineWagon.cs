using UnityEngine;

public class MineWagon : MonoBehaviour
{
    public Transform[] waypoints;
    public float speed;

    private int currentIndex;
    private int NextIndex => (currentIndex + 1) % waypoints.Length;

    private void Update()
    {
        var lastWaypoint = waypoints[currentIndex];
        var nextWaypoint = waypoints[NextIndex];

        var direction = (nextWaypoint.position - lastWaypoint.position).normalized;

        transform.Translate(direction * speed * Time.deltaTime, Space.World);

        if ((transform.position - nextWaypoint.position).magnitude < 0.1)
        {
            transform.position = nextWaypoint.position;
            currentIndex = NextIndex;
        }
    }    
}

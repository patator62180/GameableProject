using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    private Vector3 worldPointA;
    private Vector3 worldPointB;
    public float speed = 2f;

    private Vector3 currentTarget;
    void Start()
    {
        worldPointA = pointA.position;
        worldPointB = pointB.position;
        currentTarget = worldPointB;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, currentTarget, speed * Time.deltaTime);
        
        if (Vector3.Distance(transform.position, currentTarget) < 0.01f)
        {
            currentTarget = currentTarget == worldPointA ? worldPointB : worldPointA;
        }
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene("Death");
        }
    }
}
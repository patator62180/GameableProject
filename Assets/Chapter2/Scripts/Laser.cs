using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Laser : MonoBehaviour
{
    private Transform startPoint; 
    public Transform endPoint;
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPoint = this.gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        float newX = Mathf.MoveTowards(
            transform.position.x,
            endPoint.position.x,
            speed * Time.deltaTime
        );

        transform.position = new Vector3(
            newX,
            transform.position.y,
            transform.position.z
        );
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene("Death");
        }
    }
}

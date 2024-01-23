using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsCube : MonoBehaviour
{
    public Player player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            player.score++;
            Destroy(collision.gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed;
    public float score;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateScore(0);
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -20f, 20f), Mathf.Clamp(transform.position.y, -3.9f, 3.9f));
        float verticalInput = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(0 , verticalInput * speed * Time.deltaTime, 0);

      

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene("GameOver");

        }
    }
    public void UpdateScore(int value)
    {
        score += value;
        scoreText.text = "Score : " + score;
    }
}

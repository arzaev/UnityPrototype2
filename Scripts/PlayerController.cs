using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    public float horzontalInput;
    public float verticalInput;
    public float speed = 10f;
    public float xRange = 10f;
    public float zRange = -1f;
    private int lives = 3;
    public static int score = 0;
    public int oldScore;


    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.z < zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }
        if (transform.position.z > 16f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 16f);
        }

        horzontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * horzontalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

        if (score != oldScore)
        {
            Debug.Log("score: " + score);
            oldScore = score;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "animal")
        {

            if (lives == 0)
            {
                Debug.Log("Game Over!");
                Destroy(gameObject);
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);

            }
            else
            {
                lives--;
                Debug.Log("lives: " + lives);
            }
            
        }
    }

}

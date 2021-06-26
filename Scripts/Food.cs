using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    HealthBar healthBar;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("animal"))
        {
            healthBar = other.GetComponent<HealthBar>();
            healthBar.health += 33f;
            if (healthBar.health == 99f)
            {
                Destroy(other.gameObject);
                PlayerController.score += 1;
            }
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public float health;
    public float maxHealth;

    public GameObject healtBarUI;
    public Slider slider;

    void Start()
    {
        health = maxHealth;
        healtBarUI.SetActive(true);
    }

    void Update()
    {
        slider.value = health;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
    }

}

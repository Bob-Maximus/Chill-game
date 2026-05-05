using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class HEalth : MonoBehaviour
{
    public float maxHealth;
    public float health;
    public int score;
    public GameObject deathEffect;

    public GameObject deathScreen;
    public AudioClip deathSound;

    public Scrollbar slider;

    float t = 0;

    public bool player = false;

    void Update()
    {
        if (health < 1)
        {
            if (gameObject.tag == "Player")
            {
                PlayerDeath();
            } else
            {             
                if (t == 0)
                {
                    transform.parent.GetComponent<AudioSource>().PlayOneShot(deathSound);
                    Instantiate(deathEffect, transform.position, transform.rotation);

                    foreach (Transform child in transform)
                    {
                        Destroy(child.gameObject);
                    }
                }

                t+= Time.unscaledTime;
                if (t == 5)
                {
                    Destroy(gameObject.transform.parent.gameObject);
                }
            }
        }

        if (player)
        {
            float x = 100f/health;
            slider.size = health/100f;
        }
    }

    public void PlayerDeath()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 0;
        deathScreen.SetActive(true);
        Camera.main.GetComponent<AudioListener>().enabled = false;
    }
}

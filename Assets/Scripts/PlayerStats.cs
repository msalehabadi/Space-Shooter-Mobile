using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private float maxHealth;
    private float health;

    [SerializeField] private Image healthFill;
    [SerializeField] private GameObject explostionPrefab;
    void Start()
    {
        health = maxHealth;
        healthFill.fillAmount = health / maxHealth;
    }

    // Update is called once per frame
    public void PlayerTakeDamage(float damage)
    {
        health -= damage;
        healthFill.fillAmount = health / maxHealth;
        if (health <= 0)
        {
            Instantiate(explostionPrefab, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}

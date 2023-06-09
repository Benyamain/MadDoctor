using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    private float health = 100f;
    private PlayerMovement playerMovement;
    [SerializeField]
    private Slider playerHealthSlider;

    private void Awake() {
        playerMovement = GetComponent<PlayerMovement>();
    }

    public void TakeDamage(float damageAmount) {
        if (health <= 0f) return;
        health -= damageAmount;
        if (health <= 0) {
            playerMovement.PlayerDied();
            GameplayController.instance.RestartGame();
        }

        playerHealthSlider.value = health;
    }
}

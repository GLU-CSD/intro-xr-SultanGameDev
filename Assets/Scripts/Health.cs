using UnityEngine;
using UnityEngine.UI; // Needed to use Image

public class Health : MonoBehaviour
{
    [Header("Health Settings")]
    public float maxHealth = 100f;
    public float currentHealth;

    [Header("UI Elements")]
    public Image healthbarFill;

    void Start()
    {
        // Initialize health
        currentHealth = maxHealth;
        UpdateHealthBar();
    }

    void UpdateHealthBar()
    {
        // Update the health bar UI
        healthbarFill.fillAmount = currentHealth / maxHealth;
    }

    public void TakeDamage(float amount)
    {
        // Decrease health and update health bar
        currentHealth -= amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        UpdateHealthBar();
    }

    public void RestoreHealth(float amount)
    {
        // Increase health and update health bar
        currentHealth += amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        UpdateHealthBar();
    }
}

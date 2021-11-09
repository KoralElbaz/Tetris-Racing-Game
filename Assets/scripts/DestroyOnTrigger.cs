using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyOnTrigger : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;

    public int HitPoints;
    public int MaxHitPoints = 3;

    public HealthBar healthBar;

    [SerializeField] string sceneName;

    // Start is called before the first frame update
    void Start()
    {
        HitPoints = MaxHitPoints;
        healthBar.SetMaxHealth(MaxHitPoints);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == triggeringTag && enabled)
        {
            Destroy(other.gameObject);
            TakeHit(1);
        }
    }

    public void TakeHit(int damage)
    {
        HitPoints -= damage;
        healthBar.SetHealth(HitPoints);
        if (HitPoints <= 0)
        {
            Destroy(gameObject);
           SceneManager.LoadScene(sceneName);
           // Debug.Log("Game over!");
           // Application.Quit();
           // UnityEditor.EditorApplication.isPlaying = false;
        }
    }
}

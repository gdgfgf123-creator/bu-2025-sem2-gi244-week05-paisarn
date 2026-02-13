using UnityEngine;

public class GameState : MonoBehaviour
{
    public int hitCount = 0;
    public const string ENEMY_TAG = "Enemy";
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            hitCount++;
        }
        
        if (hitCount >= 5)
        {
            Debug.Log("game over");
            Time.timeScale = 1f;
            
        }
    }
}

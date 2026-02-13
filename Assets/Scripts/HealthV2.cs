using UnityEngine;

public class HealthV2 : MonoBehaviour
{
    public int MaxHp = 100;
    private int accumDamage = 0;
    public void TakeDamage(int damage)
    {
        accumDamage += damage;
        if(accumDamage >= MaxHp) 
        {
            Destroy(gameObject);
        }
    }
}

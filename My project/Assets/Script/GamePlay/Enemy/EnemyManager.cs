using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] public float speedEnemy; //Tốc độ của quái
    
    
    void Start()
    {
        this.speedEnemy = 1.5f;
    }


    void Update()
    {
    }
}

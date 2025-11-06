using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] public float speedEnemy; //Tốc độ của quái.
    [SerializeField] public PlayerManager playerManager; //Class quản chung của player (chứa các thông tin cơ bản của player).
    [SerializeField] public List<GameObject> Enemys; // Chứa danh sách quái.
    [SerializeField] public GameObject EnemyRefab; //Refab của quái.
    
    
    void Start()
    {
        this.speedEnemy = 1.5f;
    }


    void Update()
    {
    }
}

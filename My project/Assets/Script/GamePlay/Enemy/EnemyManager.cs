using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{   
    [field: SerializeField] public GameObject enemyRefab { get; private set; } //Refab của quái.
    public List<GameObject> enemys { get; set; } = new(); // Chứa danh sách quái.
    public LayerMask layerMaskEnemy { get; private set; } //Layer của quái.
    
    public float speedEnemy{ get; private set; } //Tốc độ của quái.
    public float dameEnemy{ get; private set; } //Sat thuong cua quai.


    void Awake()
    {
        ServiceManager.Register<EnemyManager>(this); // Đăng ký service với ServiceManager.
    }


    void Start()
    {
        this.speedEnemy = 1.5f;
        this.dameEnemy = 20;
        this.layerMaskEnemy = LayerMask.GetMask("Enemy");

    }
}

using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{   
    public LayerMask layerMaskEnemy { get; private set; } //Layer của quái.


    void Awake()
    {
        this.layerMaskEnemy = LayerMask.GetMask("Enemy");
        ServiceManager.Register<EnemyManager>(this); // Đăng ký service với ServiceManager.
    }
}

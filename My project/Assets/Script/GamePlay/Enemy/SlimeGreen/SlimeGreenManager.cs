using System.Collections.Generic;
using UnityEngine;

public class SlimeGreenManager : MonoBehaviour
{
    public float speedSlimeGreen { get; private set; } //Tốc độ di chuyển của quái.
    [field : SerializeField] public List<EnemyBody> slimeGreens { get; private set; } = new(); //Danh sách tất cả các quái dạng slime green.
    [field : SerializeField] public GameObject slimeGreenRefab { get; private set; } //Refab của quái.


    void Awake()
    {
        ServiceManager.Register<SlimeGreenManager>(this); //Đăng ký service cho ServiceManager.
    }


    void Start()
    {
        SpawSlimeGreen();
        this.speedSlimeGreen = 1;
    }

    private void SpawSlimeGreen()
    {
        ServiceManager.Get<EnemyspawnManager>().SpawnEnemy(
            enemyRefab: slimeGreenRefab,
            enemys: slimeGreens,
            nameEnemy: "slimeGreen",
            parentEnemy: transform,
            hpEnemy: 100f,
            dameEnemy: 20f);
    }



}

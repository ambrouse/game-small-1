using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class enemyspawnManager : MonoBehaviour
{
    [SerializeField] private float delaySpawn;

    void Start()
    {
        this.delaySpawn = 0;
    }


    void Update()
    {
        SpawnEnemy();
    }


    private void SpawnEnemy()
    {
        /*
            Hàm spawn quái:
                - Random phương hướng quái sẽ xuất hiện (trên dưới trái phải).
                - Random vị trí xuất hiện theo phương hướng (ví dụ phía trên với x = random cách player 30 unit)
                - X cách player 30 unit, y cách 20.
        */


        if (this.delaySpawn >= 0)
        {
            this.delaySpawn -= 1f * Time.deltaTime;
            return;
        }

        this.delaySpawn = 5;
        
        if (Random.value > 0.5f)
        {
            int[] verticalDirection = { -1, 1 };

            ServiceManager.Get<EnemyManager>().enemys.Add(
                Instantiate(
                    ServiceManager.Get<EnemyManager>().enemyRefab,
                    new Vector3(
                        Random.Range(ServiceManager.Get<PlayerManager>().playerPos.x - 29, ServiceManager.Get<PlayerManager>().playerPos.x + 29),
                        (ServiceManager.Get<PlayerManager>().playerPos.y + 17) * verticalDirection[Random.Range(0, 1)],
                        0),
                    Quaternion.identity,
                    transform));
            ServiceManager.Get<EnemyManager>().enemys[ServiceManager.Get<EnemyManager>().enemys.Count - 1].SetActive(true);
        }
        else
        {
            int[] HorizontalDirection = { -1, 1 };
            ServiceManager.Get<EnemyManager>().enemys.Add(
                Instantiate(
                    ServiceManager.Get<EnemyManager>().enemyRefab,
                    new Vector3(
                        (ServiceManager.Get<PlayerManager>().playerPos.x + 29) * HorizontalDirection[Random.Range(0, 1)],
                        Random.Range(ServiceManager.Get<PlayerManager>().playerPos.y - 17, ServiceManager.Get<PlayerManager>().playerPos.y + 17),
                        0),
                    Quaternion.identity,
                    transform));
            ServiceManager.Get<EnemyManager>().enemys[ServiceManager.Get<EnemyManager>().enemys.Count - 1].SetActive(true);
        }
 
    }
}

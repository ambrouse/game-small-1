using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    [SerializeField] private EnemyManager enemyManager;
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
            Hàm spawn quái
                - Random phương hướng quái sẽ xuất hiện (trên dưới trái phải).
                - Random vị trí xuất hiện theo phương hướng (ví dụ phía trên với x = random cách player 30 unit)
                - X cách player 30 unit, y cách 20
        */


        if (this.delaySpawn >= 0)
        {
            this.delaySpawn -= 1f * Time.deltaTime;
        }
        else
        {
            if (Random.value > 0.5f)
            {
                int[] verticalDirection = { -1, 1 };

                enemyManager.Enemys.Add(Instantiate(enemyManager.EnemyRefab,
                new Vector3(Random.Range(enemyManager.playerManager.playerPos.x - 29, enemyManager.playerManager.playerPos.x + 29),
                            (enemyManager.playerManager.playerPos.y + 17) * verticalDirection[Random.Range(0, 1)],
                            0),
                                                    Quaternion.identity,
                                                    transform));
                enemyManager.Enemys[enemyManager.Enemys.Count - 1].SetActive(true);
                Debug.Log("Spawn enemy, pos: " + enemyManager.Enemys[enemyManager.Enemys.Count - 1].transform.position);
            }
            else
            {
                int[] HorizontalDirection = { -1, 1 };
                enemyManager.Enemys.Add(Instantiate(enemyManager.EnemyRefab,
                                                    new Vector3((enemyManager.playerManager.playerPos.x + 29) * HorizontalDirection[Random.Range(0, 1)],
                                                                Random.Range(enemyManager.playerManager.playerPos.y - 17, enemyManager.playerManager.playerPos.y + 17),
                                                                0),
                                                    Quaternion.identity,
                                                    transform));
                enemyManager.Enemys[enemyManager.Enemys.Count - 1].SetActive(true);
                Debug.Log("Spawn enemy, pos: " + enemyManager.Enemys[enemyManager.Enemys.Count - 1].transform.position);
            }

            this.delaySpawn = 5;
        }





        
        

        
    }


}

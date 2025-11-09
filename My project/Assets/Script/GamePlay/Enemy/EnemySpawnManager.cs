using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyspawnManager : MonoBehaviour
{
    private int[] direction;


    void Awake()
    {
        this.direction = new int[] { -1, 1 };
        ServiceManager.Register<EnemyspawnManager>(this);
    }


    public void SpawnEnemy(GameObject enemyRefab, List<EnemyBody> enemys, String nameEnemy, Transform parentEnemy, float hpEnemy, float dameEnemy)
    {
        /*
            Hàm spawn quái:
                - UnityEngine.Random phương hướng quái sẽ xuất hiện (trên dưới trái phải).
                - UnityEngine.Random vị trí xuất hiện theo phương hướng (ví dụ phía trên với x = UnityEngine.Random cách player 30 unit).
                - X cách player 30 unit, y cách 20. (sau này có thể thêm các thuật toán để spawn đa dạng hơn vd: spawn thành vòng tròn xung quanh player).
        */


        EnemyBody enemyBodyCurrent = new EnemyBody();
        if (UnityEngine.Random.value > 0.5f)
        {

            enemyBodyCurrent.transformEnemy = Instantiate(
                enemyRefab,
                new Vector3(
                    UnityEngine.Random.Range(ServiceManager.Get<PlayerBody>().playerPos.x - 30, ServiceManager.Get<PlayerBody>().playerPos.x + 30),
                    (ServiceManager.Get<PlayerBody>().playerPos.y + 17) * direction[UnityEngine.Random.Range(0, 2)],
                    0),
                Quaternion.identity,
                parentEnemy).transform;
            enemyBodyCurrent.dameEnemy = dameEnemy;
            enemyBodyCurrent.hpEnemy = hpEnemy;
            enemyBodyCurrent.barHpImage = enemyBodyCurrent.transformEnemy.Find("Canvas").Find("HpManager").Find("HpBar").GetComponent<Image>();
            enemyBodyCurrent.barHpImageBackgroundRed = enemyBodyCurrent.transformEnemy.Find("Canvas").Find("HpManager").Find("HpBackgroundRed").GetComponent<Image>();
            enemyBodyCurrent.barHpImageBackgroundGreen = enemyBodyCurrent.transformEnemy.Find("Canvas").Find("HpManager").Find("HpBackgroundGreen").GetComponent<Image>();
        }
        else
        {
            enemyBodyCurrent.transformEnemy = Instantiate(
                enemyRefab,
                new Vector3(
                    (ServiceManager.Get<PlayerBody>().playerPos.x + 29) * direction[UnityEngine.Random.Range(0, 2)],
                    UnityEngine.Random.Range(ServiceManager.Get<PlayerBody>().playerPos.y - 18, ServiceManager.Get<PlayerBody>().playerPos.y + 18),
                    0),
                Quaternion.identity,
                parentEnemy).transform;
            enemyBodyCurrent.dameEnemy = dameEnemy;
            enemyBodyCurrent.hpEnemy = hpEnemy;
            enemyBodyCurrent.barHpImage = enemyBodyCurrent.transformEnemy.Find("Canvas").Find("HpManager").Find("HpBar").GetComponent<Image>();
            enemyBodyCurrent.barHpImageBackgroundRed = enemyBodyCurrent.transformEnemy.Find("Canvas").Find("HpManager").Find("HpBackgroundRed").GetComponent<Image>();
            enemyBodyCurrent.barHpImageBackgroundGreen = enemyBodyCurrent.transformEnemy.Find("Canvas").Find("HpManager").Find("HpBackgroundGreen").GetComponent<Image>();
        }

        enemys.Add(enemyBodyCurrent);
        enemyBodyCurrent.transformEnemy.gameObject.name = nameEnemy;
        enemyBodyCurrent.transformEnemy.gameObject.SetActive(true);
    }
}

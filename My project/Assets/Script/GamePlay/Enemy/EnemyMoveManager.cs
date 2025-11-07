using UnityEngine;

public class EnemyMoveManager : MonoBehaviour
{   

    void Update()
    {
        EnemyMove();
    }
    

    private void EnemyMove()
    {
        /*
            Hàm di chuyển theo vị player:
                - Gọi biến theo dõi vị player từ PlayerMoveManager và kéo nhân vật theo vị trí đó.
        */


        if (ServiceManager.Get<EnemyManager>().enemys == null)
            return;

        foreach (var item in ServiceManager.Get<EnemyManager>().enemys)
        {
            item.transform.position = Vector3.MoveTowards(
                item.transform.position,
                ServiceManager.Get<PlayerManager>().playerPos,
                ServiceManager.Get<EnemyManager>().speedEnemy * Time.deltaTime
            );
        }

    }
}

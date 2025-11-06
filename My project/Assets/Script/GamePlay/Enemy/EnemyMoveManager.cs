using UnityEngine;

public class EnemyMoveManager : MonoBehaviour
{
    [SerializeField] private EnemyManager enemyManager; //Class chứa các thông tin cơ bản của quái.
    

    void Update()
    {
        moveMouse();
    }
    

    private void moveMouse()
    {
        /*
            Hàm di chuyển theo vị player:
                - Gọi biến theo dõi vị player từ PlayerMoveManager và kéo nhân vật theo vị trí đó.
        */


        foreach (var item in enemyManager.Enemys)
        {
            item.transform.position = Vector3.MoveTowards(
                item.transform.position,
                enemyManager.playerManager.playerPos,
                enemyManager.speedEnemy * Time.deltaTime
            );
        }

    }
}

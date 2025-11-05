using UnityEngine;

public class EnemyMoveManager : MonoBehaviour
{
    [SerializeField] private Transform[] enemyObject; //Danh sách quái.
    [SerializeField] private PlayerManager playerManager; //Class quản chung của player (chứa các thông tin cơ bản của player).
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


        foreach (var item in enemyObject)
        {
            item.transform.position = Vector3.MoveTowards(
                item.transform.position,
                playerManager.playerPos,
                enemyManager.speedEnemy * Time.deltaTime
            );
        }

    }
}

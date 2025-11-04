using UnityEngine;

public class EnemyManager : MonoBehaviour
{

    [SerializeField] private PlayerManager playerManager; //Class quản chung của player (chứa các thông tin cơ bản của player)
    [SerializeField] private int speedEnemy; //Tốc độ của quái
    [SerializeField] private Transform[] enemyObject; //Danh sách quái
    
    void Start()
    {
        
    }


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
                speedEnemy * Time.deltaTime
            );
        }

    }
}

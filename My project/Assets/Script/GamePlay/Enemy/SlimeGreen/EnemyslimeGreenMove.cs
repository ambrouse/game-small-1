using UnityEngine;

public class EnemyslimeGreenMove : MonoBehaviour
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


        if (ServiceManager.Get<SlimeGreenManager>().slimeGreens.Count == 0)
            return;

        foreach (var item in ServiceManager.Get<SlimeGreenManager>().slimeGreens)
        {
            ServiceManager.Get<MoveManager>().move(
                transformOnject: item.transformEnemy,
                targetPos: ServiceManager.Get<PlayerBody>().playerPos,
                ServiceManager.Get<SlimeGreenManager>().speedSlimeGreen);
        }

    }
}

using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] public Vector3 playerPos; //Vị trí của player
    [SerializeField] public float speedPlayer; // Tốc độ của player


    void Start()
    {
        this.speedPlayer = 0f;
    }



    void Update()
    {
        folowPlayerPos();
    }


    public void folowPlayerPos()
    {
        /*
            Hàm theo dõi vịt trí của player
        */


        this.playerPos = transform.position;
    }
}

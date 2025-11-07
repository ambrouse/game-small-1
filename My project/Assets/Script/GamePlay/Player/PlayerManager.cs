using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [field: SerializeField] public GameObject playerRefab { get; private set; } //Refab của player.
    [field: SerializeField] public Transform playerTransform { get; private set; } //Tranform của player.
    
    public float speedPlayer { get; private set; } // Tốc độ của player.
    public float hpPlayer{ get; set; } //Máu của player.
    public Vector3 playerPos{ get; private set; } //Vị trí của player.


    void Awake()
    {
        this.Spawn();
        ServiceManager.Register<PlayerManager>(this); // Đăng ký service với ServiceManager.
    }


    void Start()
    {
        this.speedPlayer = 0f;
        this.hpPlayer = 100f;
    }


    void Update()
    {
        FolowPlayerPos();
    }


    public void FolowPlayerPos()
    {
        /*
            Hàm theo dõi vịt trí của player.
        */


        this.playerPos = this.playerTransform.transform.position;
    }


    public void Spawn()
    {
        this.playerTransform = Instantiate(
            this.playerRefab,
            new Vector3(0, 0, 0),
            Quaternion.identity,
            transform).transform;
    }
}

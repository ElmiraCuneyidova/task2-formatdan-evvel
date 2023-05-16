
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject Player;
    [SerializeField] float EnemySpeed;


 
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, Player.transform.position,EnemySpeed);
        transform.LookAt(Player.transform.position);

        
    }
}


using UnityEngine;

public class Shooting : MonoBehaviour
{
   public GameObject BulletPrefab;
    public Transform BulletSpawn;

   [SerializeField] public float BulletForce;
    private void Update()
    {
      
        if (Input.GetMouseButtonUp(0))
        {
            GameObject bullet = Instantiate(BulletPrefab, BulletSpawn.position, BulletSpawn.rotation);

            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            rb.AddForce(BulletSpawn.forward * BulletForce, ForceMode.Impulse);


        }
    }

    

}

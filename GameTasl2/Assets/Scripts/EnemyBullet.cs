using System.Collections;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    [SerializeField] public float bulletSpeed;
    [SerializeField] float force;

    //Rigidbody rb;

    private void Start()
    {
        //rb = GetComponent<Rigidbody>();
       // rb.AddRelativeForce(Vector3.forward * force, ForceMode.Impulse);

        StartCoroutine(bulletSpawner());

    }
IEnumerator bulletSpawner()
    {
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.AddRelativeForce(bulletSpawn.forward * bulletSpeed, ForceMode.Impulse);
        yield return new WaitForSeconds(3f);
    }



}

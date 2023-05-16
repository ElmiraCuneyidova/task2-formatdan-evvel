using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float jumpForce;

    //private int spaceKeyPressCount = 0;

    [SerializeField] float mapWide;
    [SerializeField] float mapLength;

    private Rigidbody _rigidbody;

    private void Start()
    {
        transform.position = new Vector3(1f, 1f, 1f);

        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(horizontalInput, 0f, verticalInput) * Time.deltaTime, Space.World);

        //Vector3 movement = new Vector3(horizontalInput,0f, verticalInput) * speed * Time.deltaTime;

        //transform.position += movement;

        if (Input.GetKey(KeyCode.Q))
        {
            transform.rotation *= Quaternion.Euler(0f, 2f, 0f);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.rotation *= Quaternion.Euler(0f, -2f, 0f);
        }

        if (Input.GetKey (KeyCode.Space))
        {
            _rigidbody.AddForce(Vector3.up * jumpForce);
        //    spaceKeyPressCount++;
        //}
        //if(spaceKeyPressCount > 2)
        //{
        //    spaceKeyPressCount = 2;
        }

        Vector3 position = transform.position;

        position.x = Mathf.Clamp(position.x, -mapWide, mapWide);
        position.z = Mathf.Clamp(position.z, -mapLength, mapLength);
        transform .position = position;

    }
    //private void Start()
    //{
    //    //obyekt birbasa olaraq 1f,1f,1f positionuna teleport olar.
    //    transform.position = new Vector3(1f, 1f, 1f);
    //}
    //void Update()
    //{
    //    //obyektin z oxu uzre deyeri dayanmadan 1f qeder artar.

    //    transform.position += new Vector3(0f, 0f, 1f);

    //    // transform.Translate, transform position += ile eyni ishi icra edir, sadece olaraq Space.World ve ya Space.Self vasitesi ile 
    //    //daha kontrollu idare etmeye sahibik. Elave olaraq biz Time.DeltaTime vermishik hansi ki daha yumushaq
    //    //hereket etmeye yarayir.

    //    transform.Translate(new Vector3(0f, 0f, 5f) * Time.deltaTime, Space.World);

    //    //obyekti y oxu uzre dayanmadan firladar(Update-de yazildigi ucun dayanmadan firladir)

    //    transform.Rotate(0f, 1f, 0f);

    //    //obyektin olcusunu 1f,5f,1f olaraq teyin eder.

    //    transform.localScale = new Vector3(1f, 5f, 1f);
    //}


}

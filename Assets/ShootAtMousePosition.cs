using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAtMousePosition : MonoBehaviour
{
    public GameObject gunEnd;
    public GameObject bulletPrefab;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos += Camera.main.transform.forward * 10f; // Make sure to add some "depth" to the screen point
            Vector3 aim = Camera.main.ScreenToWorldPoint(mousePos);



            if (Input.GetKey(KeyCode.Mouse0))
            {
                gunEnd.transform.LookAt(aim);

                GameObject bullet = Instantiate(bulletPrefab, gunEnd.transform.position, Quaternion.identity);

                bullet.transform.LookAt(aim);


                Rigidbody b = bullet.GetComponent<Rigidbody>();
                //b.AddRelativeForce(-transform.forward * force);

            }
        }

    }
}
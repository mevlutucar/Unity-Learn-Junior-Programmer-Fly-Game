using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    [SerializeField] float speed;

    [SerializeField] GameObject propeller;

    [SerializeField] float propellerRotationSpeed;
    [SerializeField] float rotationSpeed;
    [SerializeField] float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        propeller.transform.Rotate(0, 0, 1 * propellerRotationSpeed * Time.deltaTime);

        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);
    }
}

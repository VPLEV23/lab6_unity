using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController cr;
    private Vector3 sink;
    public Transform cam;

    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;

    void Start()
    {
        sink = new Vector3(0, -1, 0);
        cr = GetComponent<CharacterController>();
    }

    void Update()
    {
        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        if (direction.magnitude > 0.05f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            Vector3 moveDir = Quaternion.Euler(0f, angle, 0f) * Vector3.forward;
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            cr.Move(moveDir * 5f * Time.deltaTime);
        }
        cr.Move(sink * Time.deltaTime);
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += new Vector3(0, 3, 0) * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.position += new Vector3(0, -2, 0) * Time.deltaTime;
        }
    }
}

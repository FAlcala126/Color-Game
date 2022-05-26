using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 0;


    private Rigidbody rb;
    private float movementX;
    private float movementY;
    public GameObject portal;
    private SceneTransfer portalScript;

    // Start is called before the first frame update
    void Awake() {
      portalScript = portal.GetComponent<SceneTransfer>();
    }

    void Start()
    {
      rb = GetComponent<Rigidbody>();
    }

    void OnMove(InputValue movementValue)
    {
      Vector2 movementVector = movementValue.Get<Vector2>();
      movementX = movementVector.x;
      movementY = movementVector.y;
    }



    void FixedUpdate()
    {
      Vector3 movement = new Vector3(movementX, 0.0f, movementY);
      rb.AddForce(movement * speed);
    }

    void OnEnable()
    {
      rb.velocity = Vector3.zero;
      rb.angularVelocity = Vector3.zero;
    }

    private void OnTriggerEnter(Collider other)
{
    if (other.gameObject.CompareTag("PickUp"))
    {
        other.gameObject.SetActive(false);
        portalScript.collectiblesCounter++;
    }
}
}

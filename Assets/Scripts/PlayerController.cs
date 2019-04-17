using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
    public float speed;
    public float jumpVelocity;
    public float fallMulitiplier;
    public Text winText;
    public GameObject supportStick1;
    public GameObject supportStick2;

    private Rigidbody rb;
    private bool isGrounded;

    void Start () {
        rb = GetComponent<Rigidbody>();
        winText.text = "";
        isGrounded = true;
    }

	void FixedUpdate () {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
	}
    void Update()
    {
        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.velocity += Vector3.up * jumpVelocity;
            isGrounded = false;
        }
        if (rb.velocity.y < 0)
        {
            rb.velocity += Physics.gravity * (fallMulitiplier - 1) * Time.deltaTime;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Win"))
        {
            winText.text = "You Win!";
        }
        if(other.gameObject.CompareTag("Swing"))
        {
            supportStick1.SetActive(false);
            supportStick2.SetActive(false);
        }
        if(other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}
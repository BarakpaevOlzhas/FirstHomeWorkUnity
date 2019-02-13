using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	[SerializeField]
	private Rigidbody rigidbody;

	[SerializeField]
	private float speed;
    // Use this for initialization
    private float constSpeed;


    [SerializeField]
	private float sideSpeed;
	private void Start () {

        constSpeed = speed;

    }
	
	// Update is called once per frame
	private void Update () {
		rigidbody.AddForce(0,0,speed * Time.deltaTime);

		if(Input.GetKey(KeyCode.A)){
			rigidbody.AddForce(-sideSpeed * Time.deltaTime,0,0, ForceMode.VelocityChange);
		}
		else if(Input.GetKey(KeyCode.D)){
			rigidbody.AddForce(sideSpeed * Time.deltaTime,0,0,ForceMode.VelocityChange);
		}
        
	}

	private void OnCollisionEnter(Collision other) {
		if(other.gameObject.tag == "Obstacle"){
			this.enabled = false;
		}
        else if (other.gameObject.tag == "Trap")
        {
            rigidbody.AddForce(0, 300 * Time.deltaTime, 0, ForceMode.VelocityChange);
        }
        else if (other.gameObject.tag == "Wall")
        {
            rigidbody.AddForce(0, 0, -350 * Time.deltaTime, ForceMode.VelocityChange);
        }
    }

	private void OnTriggerEnter(Collider other) {
		if(other.tag == "Coin"){
			Destroy(other.gameObject);
            speed++;

            Debug.Log("Pick up coin!");
		}
		else if(other.tag == "Finish"){
			Debug.Log("You win!");
		}
        else if (other.gameObject.tag == "Abyss")
        {
            transform.position = new Vector3(0.08f, 0.62f, 0);
            speed = constSpeed;                  
        }
    }
	

}

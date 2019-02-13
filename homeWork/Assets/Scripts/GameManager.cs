using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour {
	[SerializeField]
	private Text scoreText;

	[SerializeField]
	private Player player;

    [SerializeField]
    private Text speedText;

    [SerializeField]
    private Rigidbody rigidbody;

    private float score = 0;
	private void Update() {
		score = player.transform.position.z;

		scoreText.text = score.ToString("0");        

        speedText.text = rigidbody.velocity.magnitude.ToString();
    }
}

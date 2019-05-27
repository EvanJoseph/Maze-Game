using UnityEngine;
using UnityEngine.SceneManagement;

public class FixedPlayerMovement : MonoBehaviour {

    //Initialize variables
    Vector3 pos;

    bool canKill = false;
    bool retrievedKey = false;

	private int score = 0;
	private int lifeCount = 5;

    public Texture texture;
    public Texture texture2;

	// Use this for initialization
	void Start () {
	
		pos = transform.position;

	} //Start()
	
	void Update () {

        RaycastHit2D hitUp = Physics2D.Raycast(transform.position, Vector2.up, 1);
        RaycastHit2D hitDown = Physics2D.Raycast(transform.position, Vector2.down, 1);
        RaycastHit2D hitRight = Physics2D.Raycast(transform.position, Vector2.right, 1);
        RaycastHit2D hitLeft = Physics2D.Raycast(transform.position, Vector2.left, 1);


        if (Input.GetKeyDown (KeyCode.S) && transform.position == pos) {

            if (hitDown.collider == null) {

                transform.Translate(Vector3.down * 1);
            }
            else if (hitDown.collider.gameObject.tag == "Money Bag") {

                transform.Translate(Vector3.down * 1);
                hitDown.collider.gameObject.SetActive(false);
				score += 100;
            }
            else if (hitDown.collider.gameObject.tag == "Key") {

                transform.Translate(Vector3.down * 1);
                hitDown.collider.gameObject.SetActive(false);
                retrievedKey = true;
            }
            else if (hitDown.collider.gameObject.tag == "Machete") {

                transform.Translate(Vector3.down * 1);
                hitDown.collider.gameObject.SetActive(false);
                canKill = true;
            }
            else if (hitDown.collider.gameObject.tag == "Enemy" && canKill == false) {

                transform.Translate(Vector3.down * 1);
				SceneManager.LoadScene ("Player Died");
            }
            else if (hitDown.collider.gameObject.tag == "Enemy" && canKill == true) {

                transform.Translate(Vector3.down * 1);
                hitDown.collider.gameObject.SetActive(false);
				score += 250;
                canKill = false;
            }
            else if (hitDown.collider.gameObject.name == "Wall/Door" && retrievedKey == true) {

                transform.Translate(Vector3.down * 1);
                SceneManager.LoadScene("Main Menu");
            }
        } 

		if (Input.GetKeyDown (KeyCode.A) && transform.position == pos) {

            if (hitLeft.collider == null) {

                transform.Translate(Vector3.left * 1);
            }
            else if (hitLeft.collider.gameObject.tag == "Money Bag") {

                transform.Translate(Vector3.left * 1);
                hitLeft.collider.gameObject.SetActive(false);
				score += 100;
            }
            else if (hitLeft.collider.gameObject.tag == "Key") {

                transform.Translate(Vector3.left * 1);
                hitLeft.collider.gameObject.SetActive(false);
                retrievedKey = true;
            }
            else if (hitLeft.collider.gameObject.tag == "Machete") {

                transform.Translate(Vector3.left * 1);
                hitLeft.collider.gameObject.SetActive(false);
                canKill = true;
            }
            else if (hitLeft.collider.gameObject.tag == "Enemy" && canKill == false) {

                transform.Translate(Vector3.left * 1);
				SceneManager.LoadScene ("Player Died");
            }
            else if (hitLeft.collider.gameObject.tag == "Enemy" && canKill == true) {

                transform.Translate(Vector3.left * 1);
                hitLeft.collider.gameObject.SetActive(false);
				score += 250;
                canKill = false;
            }
            else if (hitLeft.collider.gameObject.name == "Wall/Door" && retrievedKey == true) {

                transform.Translate(Vector3.left * 1);
                SceneManager.LoadScene("Main Menu");
            }
        }

		if (Input.GetKeyDown (KeyCode.D) && transform.position == pos) {

            if (hitRight.collider == null) {

                transform.Translate(Vector3.right * 1);
            }
            else if (hitRight.collider.gameObject.tag == "Money Bag") {

                transform.Translate(Vector3.right * 1);
                hitRight.collider.gameObject.SetActive(false);
				score += 100;
            }
            else if (hitRight.collider.gameObject.tag == "Key") {

                transform.Translate(Vector3.right * 1);
                hitRight.collider.gameObject.SetActive(false);
                retrievedKey = true;
            }
            else if (hitRight.collider.gameObject.tag == "Machete") {

                transform.Translate(Vector3.right * 1);
                hitRight.collider.gameObject.SetActive(false);
                canKill = true;
            }
            else if (hitRight.collider.gameObject.tag == "Enemy" && canKill == false) {

                transform.Translate(Vector3.right * 1);
				SceneManager.LoadScene ("Player Died");
            }
            else if (hitRight.collider.gameObject.tag == "Enemy" && canKill == true) {

                transform.Translate(Vector3.right * 1);
                hitRight.collider.gameObject.SetActive(false);
				score += 250;
                canKill = false;
            }
            else if (hitRight.collider.gameObject.name == "Wall/Door" && retrievedKey == true) {

                transform.Translate(Vector3.right * 1);
                SceneManager.LoadScene("Main Menu");
            }
        }

		if (Input.GetKeyDown (KeyCode.W) && transform.position == pos) {

            if (hitUp.collider == null) {

                transform.Translate(Vector3.up * 1);
            }
            else if (hitUp.collider.gameObject.tag == "Money Bag") {

                transform.Translate(Vector3.up * 1);
                hitUp.collider.gameObject.SetActive(false);
				score += 100;
            }
            else if (hitUp.collider.gameObject.tag == "Key") {

                transform.Translate(Vector3.up * 1);
                hitUp.collider.gameObject.SetActive(false);
                retrievedKey = true;
            }
            else if (hitUp.collider.gameObject.tag == "Machete") {

                transform.Translate(Vector3.up * 1);
                hitUp.collider.gameObject.SetActive(false);
                canKill = true;
            }
            else if (hitUp.collider.gameObject.tag == "Enemy" && canKill == false) {

                transform.Translate(Vector3.up * 1);
				SceneManager.LoadScene ("Player Died");
            }
            else if (hitUp.collider.gameObject.tag == "Enemy" && canKill == true) {

                transform.Translate(Vector3.up * 1);
                hitUp.collider.gameObject.SetActive(false);
				score += 250;
                canKill = false;
            }
            else if (hitUp.collider.gameObject.name == "Wall/Door" && retrievedKey == true) {

                transform.Translate(Vector3.up * 1);
                SceneManager.LoadScene("Main Menu");
            }
        }

		pos = transform.position;

    } //Update()

	void OnCollisionEnter2D(Collision2D collision2D) {

		if (collision2D.gameObject.tag == "Enemy") {

			gameObject.SetActive (false);
			SceneManager.LoadScene ("Player Died");
		}

	} //onCollisionEnter()

	void OnGUI() {

		GUI.Box(new Rect (25, 15, 145, 23), "Current Level : " + SceneManager.GetActiveScene().name);
		GUI.Box(new Rect(175, 15, 85, 23), "Score : " + score);

        if (!canKill) {

            GUI.Box(new Rect(265, 15, 155, 23), "Machete Equipped : No");
        }
        else {

            GUI.Box(new Rect(265, 15, 155, 23), "Machete Equipped : Yes");
        }

        if (!retrievedKey) {

            GUI.Box(new Rect(425, 15, 140, 23), "Key Acquired : No");
        }
        else {

            GUI.Box(new Rect(425, 15, 140, 23), "Key Acquired : Yes");
        }

	} //OnGUI()

} //FixedPlayerMovement

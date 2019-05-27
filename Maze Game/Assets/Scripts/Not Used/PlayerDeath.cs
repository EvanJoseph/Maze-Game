using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour {

    Vector3 pos;

    // Use this for initialization
    void Start () {

        pos = transform.position;
		
	} //Start()
	
	// Update is called once per frame
	void FixedUpdate () {

        RaycastHit2D hitUp = Physics2D.Raycast(transform.position, Vector2.up, 1);
        RaycastHit2D hitDown = Physics2D.Raycast(transform.position, Vector2.down, 1);
        RaycastHit2D hitRight = Physics2D.Raycast(transform.position, Vector2.right, 1);
        RaycastHit2D hitLeft = Physics2D.Raycast(transform.position, Vector2.left, 1);

        if (Input.GetKeyDown(KeyCode.S) && transform.position == pos && hitDown.collider.gameObject.tag == "Enemy") {

            transform.Translate(Vector3.down * 1);
            SceneManager.LoadScene("Player Died");
        }
        else if (Input.GetKeyDown(KeyCode.A) && transform.position == pos && hitLeft.collider.gameObject.tag == "Enemy") {

            transform.Translate(Vector3.left * 1);
            SceneManager.LoadScene("Player Died");
        }
        else if (Input.GetKeyDown(KeyCode.D) && transform.position == pos && hitRight.collider.gameObject.tag == "Enemy") {

            transform.Translate(Vector3.right * 1);
            SceneManager.LoadScene("Player Died");
        }
        else if (Input.GetKeyDown(KeyCode.W) && transform.position == pos && hitUp.collider.gameObject.tag == "Enemy") {

            transform.Translate(Vector3.up * 1);
            SceneManager.LoadScene("Player Died");
        }

    } //FixedUpdate()

} //PlayerDeath

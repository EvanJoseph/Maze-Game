using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	//Initialize variables
	public Rigidbody2D rigidbody;

    [SerializeField]
    private float movementSpeed;

	//Use this for initialization
	void Start () {

		rigidbody = GetComponent<Rigidbody2D>();

	} //Start()

	//Update is called once per frame
	void Update () {
		
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");

		HandleMovement (horizontal, vertical);
	
	} //Update()

	private void HandleMovement(float horizontal, float vertical) {

		rigidbody.velocity = new Vector2(horizontal * movementSpeed, rigidbody.velocity.y);
		rigidbody.velocity = new Vector2(rigidbody.velocity.x, vertical * movementSpeed);

	} //HandleMovement()

} //PlayerMovement
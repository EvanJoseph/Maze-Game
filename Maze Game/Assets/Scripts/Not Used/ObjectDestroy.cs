using UnityEngine;

public class ObjectDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	} //Start()

	// Update is called once per frame
	void Update () {
		
	} //Update()

	void OnCollisionEnter2D(Collision2D collision2D) {

		if (collision2D.gameObject.tag == "Money Bag") {
			
			collision2D.gameObject.SetActive (false);
		}
        else if (collision2D.gameObject.tag == "Key") {

            collision2D.gameObject.SetActive(false);
        }
        else if (collision2D.gameObject.tag == "Machete") {

            collision2D.gameObject.SetActive(false);
        }

    } //onCollisionEnter()

} //ObjectDestroy

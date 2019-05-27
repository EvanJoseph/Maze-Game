using UnityEngine;
using UnityEngine.SceneManagement;

public class Zombie1 : MonoBehaviour {

    int routePosition = 1;
    string direction = "forward";

    //Use this for initialization
    void Start() {

        InvokeRepeating("Move", 1.0f, 1.0f);
        
    } //Start()

    //Update is called once per frame
    void Update() {} //Update()

    void Move() {

        if (routePosition == 1 && direction == "forward") {

            transform.Translate(Vector3.left * 1);
            routePosition = 2;
        }
        else if (routePosition == 2 && direction == "forward") {

            transform.Translate(Vector3.down * 1);
            routePosition = 3;
        }
        else if (routePosition == 3 && direction == "forward") {

            transform.Translate(Vector3.down * 1);
            routePosition = 4;
        }
        else if (routePosition == 4 && direction == "forward") {

            transform.Translate(Vector3.right * 1);
            routePosition = 5;
        }
        else if (routePosition == 5 && direction == "forward") {

            transform.Translate(Vector3.down * 1);
            routePosition = 6;
        }
        else if (routePosition == 6 && direction == "forward") {

            transform.Translate(Vector3.down * 1);
            routePosition = 7;
        }
        else if (routePosition == 7 && direction == "forward") {

            transform.Translate(Vector3.left * 1);
            routePosition = 8;
        }
        else if (routePosition == 8) {

            transform.Translate(Vector3.right * 1);
            routePosition = 7;
            direction = "backward";
        }
        else if (routePosition == 7 && direction == "backward") {

            transform.Translate(Vector3.up * 1);
            routePosition = 6;
        }
        else if (routePosition == 6 && direction == "backward") {

            transform.Translate(Vector3.up * 1);
            routePosition = 5;
        }
        else if (routePosition == 5 && direction == "backward") {

            transform.Translate(Vector3.left * 1);
            routePosition = 4;
        }
        else if (routePosition == 4 && direction == "backward") {

            transform.Translate(Vector3.up * 1);
            routePosition = 3;
        }
        else if (routePosition == 3 && direction == "backward") {

            transform.Translate(Vector3.up * 1);
            routePosition = 2;
        }
        else if (routePosition == 2 && direction == "backward") {

            transform.Translate(Vector3.right * 1);
            routePosition = 1;
            direction = "forward";
        }

    } //Move()
		
} //Zombie1


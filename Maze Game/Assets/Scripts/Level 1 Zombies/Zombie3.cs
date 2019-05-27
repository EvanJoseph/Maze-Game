using UnityEngine;
using UnityEngine.SceneManagement;

public class Zombie3 : MonoBehaviour {

    int routePosition = 1;
    string direction = "forward";

    //Use this for initialization
    void Start() {

        InvokeRepeating("Move", 1.0f, 1.0f);

    } //Start()

    //Update is called once per frame
    void Update() { } //Update()

    void Move() {

        if (routePosition >= 1 && routePosition <= 5 && direction == "forward") {

            transform.Translate(Vector3.up * 1);
            routePosition++;
        }
        else if ((routePosition == 6 || routePosition == 7) && direction == "forward") {

            transform.Translate(Vector3.left * 1);
            routePosition++;
        }
        else if (routePosition == 8) {

            transform.Translate(Vector3.right * 1);
            routePosition--;
            direction = "backward";
        }
        else if (routePosition == 7 && direction == "backward") {

            transform.Translate(Vector3.right * 1);
            routePosition--;
        }
        else if (routePosition <= 6 && routePosition >= 2 && direction == "backward") {

            transform.Translate(Vector3.down * 1);
            routePosition--;
        }
        else if (routePosition == 1 && direction == "backward") {

            transform.Translate(Vector3.up * 1);
            routePosition++;
            direction = "forward";
        }

    } //Move()

} //Zombie1



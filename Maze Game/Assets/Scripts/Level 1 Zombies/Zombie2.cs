using UnityEngine;
using UnityEngine.SceneManagement;

public class Zombie2 : MonoBehaviour {

    int routePosition = 1;

    //Use this for initialization
    void Start() {

        InvokeRepeating("Move", 1.0f, 1.0f);

    } //Start()

    //Update is called once per frame
    void Update() { } //Update()

    void Move() {

        if (routePosition == 1) {

            transform.Translate(Vector3.right * 1);
            routePosition = 2;
        }
        else if (routePosition == 2) {

            transform.Translate(Vector3.right * 1);
            routePosition = 3;
        }
        else if (routePosition == 3) {

            transform.Translate(Vector3.up * 1);
            routePosition = 4;
        }
        else if (routePosition == 4) {

            transform.Translate(Vector3.up * 1);
            routePosition = 5;
        }
        else if (routePosition == 5) {

            transform.Translate(Vector3.left * 1);
            routePosition = 6;
        }
        else if (routePosition == 6) {

            transform.Translate(Vector3.left * 1);
            routePosition = 7;
        }
        else if (routePosition == 7) {

            transform.Translate(Vector3.down * 1);
            routePosition = 8;
        }
        else if (routePosition == 8) {

            transform.Translate(Vector3.down * 1);
            routePosition = 1;
        }

    } //Move()

} //Zombie1
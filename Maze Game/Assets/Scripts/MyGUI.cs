using UnityEngine;
using System.Collections;

public class MyGUI : MonoBehaviour {

    int score = 0;

    //Use this for initialization
    void Start() {

    }

    //Update is called once per frame
    void Update() {

    }

    public void UpdateScore(int scoreAddition) {

        score = score + scoreAddition;
    }

    /*(void OnGUI() {

        GUI.Label(new Rect(25, 15, 100, 20), "Score : " + score);

    } //OnGUI()*/

} //GUI
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class uiHandler : MonoBehaviour {
    int score = 0;
    private Button _button;
    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    private void OnEnable() {
        Debug.Log("Enabled");

        var uiDocument = GetComponent<UIDocument>();

        _button = uiDocument.rootVisualElement.Q("ChangeScore") as Button;

        _button.clickable.clicked += ChangeScore;
    }
    public void ChangeScore() {
        Debug.Log("Button Clicked");
        var uiDocument = GetComponent<UIDocument>();
        var label = uiDocument.rootVisualElement.Q("score") as Label;
        label.text = "Score: " + score++;
    }
}
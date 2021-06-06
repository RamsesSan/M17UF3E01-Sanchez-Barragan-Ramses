using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour{

    private SpriteRenderer sprtRender;
    public Sprite defaultImage;
    public Sprite pressedImage;

    public KeyCode keyToPress;
    // Start is called before the first frame update
    void Start(){
        sprtRender = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            sprtRender.sprite = pressedImage;
        }
        if (Input.GetKeyUp(keyToPress))
        {
            sprtRender.sprite = defaultImage;
        }
    }
}

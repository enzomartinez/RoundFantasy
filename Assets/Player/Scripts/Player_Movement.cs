using UnityEngine;
using System.Collections;

public class Player_Movement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        bool rightPressed = Input.GetKey(KeyCode.RightArrow);
        bool leftPressed = Input.GetKey(KeyCode.LeftArrow);
        bool upPressed = Input.GetKey(KeyCode.UpArrow);
        bool downPressed = Input.GetKey(KeyCode.DownArrow);


        if (Input.GetKeyDown(KeyCode.Space))
        {

        }
        else if (upPressed && leftPressed == false && rightPressed == false && downPressed == false)
        {
            Vector3 position = this.transform.position;
            position.y += 0.1F;
            this.transform.position = position;
        }
        else if (downPressed && upPressed == false && leftPressed == false && rightPressed == false)
        {
            Vector3 position = this.transform.position;
            position.y -= 0.1F;
            this.transform.position = position;
        }
        else if (rightPressed && downPressed == false && upPressed == false && leftPressed == false)
        {
            Vector3 position = this.transform.position;
            position.x += 0.1F;
            this.transform.position = position;
        }
        else if (leftPressed && rightPressed == false && downPressed == false && upPressed == false)
        {
            Vector3 position = this.transform.position;
            position.x -= 0.1F;
            this.transform.position = position;
        }
        else if (leftPressed == true && upPressed == true)
        {
            Vector3 position = this.transform.position;
            position.x -= 0.1F;
            position.y += 0.1F;
            this.transform.position = position;
        }
        else if (leftPressed == true && downPressed == true)
        {
            Vector3 position = this.transform.position;
            position.x -= 0.1F;
            position.y -= 0.1F;
            this.transform.position = position;
        }
        else if (rightPressed == true && downPressed == true)
        {
            Vector3 position = this.transform.position;
            position.x += 0.1F;
            position.y -= 0.1F;
            this.transform.position = position;
        }
        else if (rightPressed == true && upPressed == true)
        {
            Vector3 position = this.transform.position;
            position.x += 0.1F;
            position.y += 0.1F;
            this.transform.position = position;
        }
	}
}

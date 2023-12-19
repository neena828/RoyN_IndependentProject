using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeViewScript : MonoBehaviour
{
    public Vector3 toFrontView;
    public Vector3 toSideView;
    private new GameObject camera;    
    private GameObject player;

    private MoveForwardScriptCamera cameraMovementScript;
    private PlayerMovementScript playerMovementScript;
    // Start is called before the first frame update
    void Start()
    {
        camera = GameObject.Find("Main Camera");
        player = GameObject.Find("Player");
        cameraMovementScript = camera.GetComponent<MoveForwardScriptCamera>();
        playerMovementScript = player.GetComponent<PlayerMovementScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject == player)
        {
            cameraMovementScript.frontView = !cameraMovementScript.frontView;
            playerMovementScript.frontView = !playerMovementScript.frontView;
            if (cameraMovementScript.frontView == false){
                camera.transform.Translate(toFrontView);
                camera.transform.Rotate(0f, 90f, 0f);
            }
            if (cameraMovementScript.frontView == true){
                camera.transform.Translate(toSideView);
                camera.transform.Rotate(0f, -90f, 0f);
                player.transform.Translate(0f, 0f, -(player.transform.position.z - 2.5f));
            }
        }
    }
}

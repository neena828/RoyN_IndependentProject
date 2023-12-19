using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerDeathScript : MonoBehaviour
{
    private new GameObject particleSystem;
    private GameObject player;
    private new GameObject camera;
    private GameObject pauseButton;
    private GameObject resultLabel;
    private GameObject restartButton;
    // Start is called before the first frame update
    void Awake()
    {
        particleSystem = GameObject.Find("Particle System");
        player = GameObject.Find("Player");
        camera = GameObject.Find("Main Camera");
        pauseButton = GameObject.Find("Pause Button");
        resultLabel = GameObject.Find("Result Label");
        restartButton = GameObject.Find("Restart Button");
        particleSystem.GetComponent<ParticleSystem>().Stop();

    }
    void Start()
    {
        pauseButton.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
        resultLabel.GetComponent<RectTransform>().localScale = new Vector3(0, 0, 0);
        restartButton.GetComponent<RectTransform>().localScale = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject == player)
        {
            Debug.Log("Player Hit");
            player.GetComponent<MeshRenderer>().enabled = false;
            player.GetComponent<MoveForwardScriptPlayer>().enabled = false;
            player.GetComponent<PlayerMovementScript>().enabled = false;
            camera.GetComponent<MoveForwardScriptCamera>().enabled = false;
            particleSystem.GetComponent<ParticleSystem>().Play();
            pauseButton.GetComponent<RectTransform>().localScale = new Vector3(0, 0, 0);
            resultLabel.GetComponent<RectTransform>().localScale = new Vector3(2, 2, 2);
            resultLabel.GetComponent<TMP_Text>().text = "YOU LOSE";
            restartButton.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
        }
    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject == player)
        {
            Debug.Log("Player Hit");
            player.GetComponent<MeshRenderer>().enabled = false;
            player.GetComponent<MoveForwardScriptPlayer>().enabled = false;
            player.GetComponent<PlayerMovementScript>().enabled = false;
            camera.GetComponent<MoveForwardScriptCamera>().enabled = false;
            particleSystem.GetComponent<ParticleSystem>().Play();
            pauseButton.GetComponent<RectTransform>().localScale = new Vector3(0, 0, 0);
            resultLabel.GetComponent<RectTransform>().localScale = new Vector3(2, 2, 2);
            resultLabel.GetComponent<TMP_Text>().text = "YOU LOSE";
            restartButton.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
        }
    }
}

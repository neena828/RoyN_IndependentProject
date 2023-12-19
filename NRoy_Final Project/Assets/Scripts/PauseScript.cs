using UnityEngine;
using UnityEngine.UI;

public class PauseScript : MonoBehaviour
{
    private GameObject player;
    private new GameObject camera;
    public bool play;
    public Button button;
    // Start is called before the first frame update

    void Start()
    {
        player = GameObject.Find("Player");
        camera = GameObject.Find("Main Camera");
        button.onClick.AddListener(Pause);
        play = true;
        GameObject.Find("Pause Button").GetComponent<PauseScript>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Pause()
    {
        play = !play;
        Debug.Log(play);
        if (play == true)
        {
            player.GetComponent<PlayerMovementScript>().enabled = true; 
            player.GetComponent<MoveForwardScriptPlayer>().enabled = true;
            camera.GetComponent<MoveForwardScriptCamera>().enabled = true;
        } else 
        {
            player.GetComponent<PlayerMovementScript>().enabled = false; 
            player.GetComponent<MoveForwardScriptPlayer>().enabled = false;
            camera.GetComponent<MoveForwardScriptCamera>().enabled = false;
        }
    }
}

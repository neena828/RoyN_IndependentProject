using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartScript : MonoBehaviour
{
    public Button button;
    // Start is called before the first frame update

    void Start()
    {
        button.onClick.AddListener(Restart);
        GameObject.Find("Pause Button").GetComponent<PauseScript>().enabled = false;
    }

    public void Restart()
    {
        SceneManager.LoadScene("Gameplay");
    }
}

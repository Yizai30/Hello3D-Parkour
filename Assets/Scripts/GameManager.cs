using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public float restartDelay = 1f;

    bool gamehasEnded = false;

    public GameObject completeLevelUI;

    public void CompleteLevel() {
        completeLevelUI.SetActive(true);
    }

    public void EndGame() {
        if (gamehasEnded == false) {
            gamehasEnded = true;
            Debug.Log("Game Over.");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {
	public Text roundsText;

	void OnEnable(){
		roundsText.text = Currency.Rounds.ToString ();
	}

	public void Retry(){
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
	}

	public void Menu(){
		Time.timeScale = 1f;
		SceneManager.LoadScene ("MainMenu");
	}
}

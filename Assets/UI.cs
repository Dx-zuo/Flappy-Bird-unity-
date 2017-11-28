using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UI : MonoBehaviour {
    public GameObject hero;
    public GameManager Gamemanager;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void refGame() {
        this.gameObject.SetActive(false);
        Gamemanager.gamestate = GameState.Run;
        hero.transform.position = new Vector3(3.294275f, 0, -0.691f);
        hero.GetComponent<HeroInput>().state1.SetActive(true);
        hero.GetComponent<HeroInput>().state3.SetActive(false);
        hero.GetComponent<HeroInput>().Ondead = true;
    }
}

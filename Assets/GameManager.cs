using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState
{
    Run,
    Stop,
}
public class GameManager : MonoBehaviour {
    public List<GameObject> backgroundlist;
    public GameObject trigger;
    public GameState gamestate;
    public float seepd;
    public float reftime;
	void Start () {
        gamestate = GameState.Run;
    }
    private void LateUpdate()
    {
        if (gamestate == GameState.Run)
        {
            if (trigger.GetComponent<Collider>().bounds.Intersects(backgroundlist[0].GetComponent<Collider>().bounds))
            {
                backgroundlist[0].GetComponent<backgroundScript>().clear();
                backgroundlist[0].transform.position = backgroundlist[backgroundlist.Count - 1].transform.position + Vector3.right * 9.87f;
                backgroundlist[0].GetComponent<backgroundScript>().InitKeep();

                backgroundlist.Add(backgroundlist[0]);
                backgroundlist.RemoveAt(0);
            }
            foreach (GameObject item in backgroundlist)
            {
                item.transform.position -= Vector3.right * 0.1f;
            }
        }
    }
    void Update () {
        if (Input.GetKey(KeyCode.F))
        {
            gamestate = GameState.Stop;
        }
	}

}

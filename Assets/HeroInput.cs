using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroInput : MonoBehaviour {


    public GameState gameState;
    public GameManager gameManager;
    private Rigidbody rigidbodys;
    public GameObject state1;
    public GameObject state2;
    public GameObject state3;
    public GameObject canvas;
    public float seepd;
    public bool Onfeifly;
    private float times;
    public bool Ondead;
    void Start () {
        rigidbodys = GetComponent<Rigidbody>();
        seepd = gameManager.seepd +0.1f;
        Ondead = true;
    }
    private void LateUpdate()
    {
        if (Ondead)
        {
            times += Time.deltaTime;
            if (times >= 0.2)
            {
                if (state1.activeSelf)
                {
                    state1.SetActive(false);
                    state2.SetActive(true);
                }
                else
                {
                    state1.SetActive(true);
                    state2.SetActive(false);
                }
                times = 0;
            }
        }
    }
    private void Update()
    {
        if (gameManager.gamestate == GameState.Run)
        {
            transform.position += Vector3.down * 0.1f * seepd;
        }
        if (Input.GetMouseButtonDown(0))
        {
            Onfeifly = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            Onfeifly = false;

        }
        if (Onfeifly && Ondead){ RunFeifly(); }
    }
    void RunFeifly() {
        transform.position += Vector3.up * 0.15f;
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "Keep(Clone)" || collision.gameObject.name == "Keep")
        {
            gameManager.gamestate = GameState.Stop;
            canvas.SetActive(true);
            Ondead = false;
            state1.SetActive(false);
            state2.SetActive(false);
            state3.SetActive(true);
        }
    }
}

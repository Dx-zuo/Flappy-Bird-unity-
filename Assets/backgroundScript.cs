using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundScript : MonoBehaviour {
    public GameObject Keep;
    public List<GameObject> keeplist;

    // Use this for initialization
    void Start() {
        InitKeep();
    }
    public void clear() {
        foreach (var item in keeplist)
        {
            Destroy(item);
        }
    }
    public void InitKeep() {

        if (Random.Range(1, 99) >= 70)
        {
            for (int i = 0; i < 2; i++)
            {
                Vector3 pos = transform.localPosition + Random.Range(-4.5f, 4.5f) * Vector3.right;
                pos += Vector3.up * Random.Range(-9.0f, -5.5f);
                pos += Vector3.back * 0.5f;
                GameObject ss = Instantiate(Keep, pos, Keep.transform.rotation);
                ss.transform.SetParent(this.transform);
                keeplist.Add(ss);
            }
        }
        else {
            Vector3 pos = transform.position + Random.Range(-4.5f, 4.5f) * Vector3.right;
            pos += Vector3.up * Random.Range(-8, -3);
            pos += Vector3.back * 0.5f;

            GameObject ss =  Instantiate(Keep, pos, Keep.transform.rotation);
            ss.transform.SetParent(this.transform);
            keeplist.Add(ss);
        }
    }
}

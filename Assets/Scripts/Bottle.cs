using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bottle : MonoBehaviour
{
    [Header("Set in Inspector")]

    public float rangeDestroyBottleY = -150f;




    void Update()
    {
        OnDestroyBottle();
    }

    public void OnDestroyBottle()
    {
        if (transform.position.y < rangeDestroyBottleY)
        {
            Destroy(this.gameObject);
            BottlePicker script = Camera.main.GetComponent<BottlePicker>();
            script.ItakeYourHarts();

        }
    }
}

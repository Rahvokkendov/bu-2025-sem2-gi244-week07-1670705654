using UnityEngine;
using UnityEngine.InputSystem;

public class MoveLeft : MonoBehaviour
{
    public float speed = 10f;
    GameObject go;
    PlayerController player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        go = GameObject.FindGameObjectWithTag("Player");
        player = go.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        //GameObject go = GameObject.Find("Player");
        //PlayerController player = go.GetComponent<PlayerController>();
        if(player.isGameOver == false)
        {
            transform.Translate(speed * Time.deltaTime * Vector3.left);
        }
        

    }
}

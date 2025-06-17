using UnityEngine;

public class PlayrController : MonoBehaviour
{
    public int speed = 30;
    void Start()
     
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
    }
}

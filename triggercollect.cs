using UnityEngine;

public class Triggercollect : MonoBehaviour
{
     private void OnTriggerEnter(Collider other) {
    Debug.Log("Trigger entered!");
    Destroy(this.gameObject);
}

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using UnityEngine;
using System.Collections;
using najva;

public class CameraController : MonoBehaviour 

{
	public GameObject player;
	private Vector3 offset;
    // Use this for initialization
    void Start()
    {
        offset = transform.position;

        Najva.init();

        string token = Najva.GetSubscribedToken();

        Debug.Log(token);
    }
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}

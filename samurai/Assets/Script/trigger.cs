using UnityEngine;

public class trigger : MonoBehaviour
{
	[System.Obsolete]
	void OnTriggerEnter2D(Collider2D col)
	{
			Application.LoadLevel(Application.loadedLevel);
	}
}
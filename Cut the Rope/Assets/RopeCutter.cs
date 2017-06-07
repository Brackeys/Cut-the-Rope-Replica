using UnityEngine;

public class RopeCutter : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0))
		{
			RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
			if (hit.collider != null)
			{
				if (hit.collider.tag == "Link")
				{
					Destroy(hit.collider.gameObject);
				}
			}
		}
	}
}

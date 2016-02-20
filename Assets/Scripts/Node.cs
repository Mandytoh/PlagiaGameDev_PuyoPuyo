using UnityEngine;
using System.Collections;

public class Node : MonoBehaviour {

	public Color[] colors = new Color[]{
		new Color (1, 0, 0),
		new Color (0, 1, 0),
		new Color (0, 0, 1)
	};

	public string[] types = new string[]{
		"Cerise",
		"Pomme",
		"Chewing gum"
	};

	public Vector2 position = Vector2.zero;
	public string type;

	void Start () {
		int randIndex = Random.Range(0, colors.Length);
		this.GetComponent<MeshRenderer> ().material.color = colors [randIndex];
		this.type = types [randIndex];
	}
}

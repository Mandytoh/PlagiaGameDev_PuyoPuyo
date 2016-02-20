using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Grid : MonoBehaviour {

	public int initialLineFilled = 4;
	public Vector2 size = new Vector2(6, 12);
	public List<List<Node>> grid = new List<List<Node>>();
	public Node nodePrefab;

	// Use this for initialization
	void Start () {
		for (int y = 0; y < this.size.y; y++) {
			for (int x = 0; x < this.size.x; x++) {
				if(y >= this.size.y - this.initialLineFilled){
					nodePrefab.position = new Vector2(x, y);
					GameObject node = Instantiate(nodePrefab.gameObject,
						new Vector3(x, this.size.y - y, 0),
		            	Quaternion.identity);
					this.grid[y][x] = nodePrefab;
					searchSameNodes(node);
				}
			}
		}
	}

	public Node searchSameNodes( Node node ){
		Vector2 actualPosition = node.position;
		for (int y = -1; y <= 1; y++) {
			for (int x = -1; x <= 1; x++) {
				if(x != 0 && y != 0){
					if(this.grid[y][x] != null){
						Node controlledNode = this.grid[y][x];
						if(controlledNode.type == node.type){
							controlledNode.GetComponent<MeshRenderer>().material.color = Color(2,2,2);
							Debug.Log(controlledNode.position);
							Debug.Log(controlledNode.type);
						}
					}
				}
			}
		}
	}
}

using UnityEngine;
using System.Collections;

public class MoveTerrain : MonoBehaviour {

	private Material material;
	public float speed;
	private float offset;

	void Start () {
		material = GetComponent<Renderer>().material;
	}

	void Update () {
		offset += (speed * Time.deltaTime);
		material.SetTextureOffset("_MainText", new Vector2(offset,0));
	}
}

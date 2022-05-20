using UnityEngine;

// Marching Squares

public class VoxelGrid : MonoBehaviour {

	public int resolution;

	private bool[] voxels;

	private void Awake () {
		voxels = new bool[resolution * resolution];
	}
}

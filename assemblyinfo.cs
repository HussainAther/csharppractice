using UnityEngine;

// Marching Squares

public class VoxelGrid : MonoBehaviour {

	public int resolution;

	private bool[] voxels;

	private void Awake () {
		voxels = new bool[resolution * resolution];
	}
}

public GameObject voxelPrefab;

private float voxelSize;

private void Awake () {
	voxelSize = 1f / resolution;
	voxels = new bool[resolution * resolution];
}

		for (int i = 0, y = 0; y < resolution; y++) {
			for (int x = 0; x < resolution; x++, i++) {
				CreateVoxel(i, x, y);
			}
		}

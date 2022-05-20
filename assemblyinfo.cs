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

[SelectionBase]
public class VoxelGrid : MonoBehaviour {
	…
}

	public void Initialize (int resolution, float size) {
		this.resolution = resolution;
		voxelSize = size / resolution;
		voxels = new bool[resolution * resolution];

		for (int i = 0, y = 0; y < resolution; y++) {
			for (int x = 0; x < resolution; x++, i++) {
				CreateVoxel(i, x, y);
			}
		}
	}

	private VoxelGrid[] chunks;
		
	private float chunkSize, voxelSize, halfSize;
	
	private void Awake () {
		halfSize = size * 0.5f;
		chunkSize = size / chunkResolution;
		voxelSize = chunkSize / voxelResolution;
		
		chunks = new VoxelGrid[chunkResolution * chunkResolution];
		for (int i = 0, y = 0; y < chunkResolution; y++) {
			for (int x = 0; x < chunkResolution; x++, i++) {
				CreateChunk(i, x, y);
			}
		}
	}

	private void CreateChunk (int i, int x, int y) {
		VoxelGrid chunk = Instantiate(voxelGridPrefab) as VoxelGrid;
		chunk.Initialize(voxelResolution, chunkSize);
		chunk.transform.parent = transform;
		chunk.transform.localPosition = new Vector3(x * chunkSize - halfSize, y * chunkSize - halfSize);
		chunks[i] = chunk;
	}


using UnityEngine;

[AddComponentMenu("Terrain/Terrain Manager")]
public class TerrainManager : MonoBehaviour {
    public Transform terrainTiles, player;

    /// <summary>
    /// All tiles within this radius of the player will be loaded; in world space.
    /// </summary>
    public float LoadDistance {
        set {
            loadDistance_ = value;
            sqrLoadDistance = value * value;
        }
        get {
            return loadDistance_;
        }
    }
    [SerializeField]
    private float loadDistance_;

    /// <summary>
    /// All tiles outside of this radius of the player will be unloaded; in world space.
    /// </summary>
    public float UnloadDistance {
        set {
            unloadDistance_ = value;
            sqrUnloadDistance = value * value;
        }
        get {
            return unloadDistance_;
        }
    }
    [SerializeField]
    private float unloadDistance_;

    private float sqrLoadDistance, sqrUnloadDistance;

    /// <summary>
    /// The displacement from the min and center points of a terrain tile on the XZ plane.
    /// </summary>
    private Vector3 tileMidpoint;


    void Start() {
        // Update properties from inspector
        LoadDistance = loadDistance_;
        UnloadDistance = unloadDistance_;

        Transform aTile = terrainTiles.GetChild(0);
        tileMidpoint = aTile.GetComponent<Terrain>().terrainData.size / 2;
        tileMidpoint.y = 0; // no verticle displacement in this context
    }

    void Update() {
        if (UnloadDistance <= LoadDistance) {
            Debug.LogWarning("Unload distance should be greater than load distance");
        }

        LoadTiles();
        UnloadTiles();
    }

    private void LoadTiles() {
        foreach (Transform tile in terrainTiles) {
            Vector3 playerPosXZ = player.position;
            playerPosXZ.y = 0;
            Vector3 tilePosXZ = tile.position;
            tilePosXZ.y = 0;
            Vector3 displacementXZ = playerPosXZ - tilePosXZ;

            if (displacementXZ.sqrMagnitude <= sqrLoadDistance) 
                tile.gameObject.SetActive(true);
        }
    }

    private void UnloadTiles() {
        foreach (Transform tile in terrainTiles) {
            Vector3 playerPosXZ = player.position;
            playerPosXZ.y = 0;
            Vector3 tilePosXZ = tile.position;
            tilePosXZ.y = 0;
            Vector3 displacementXZ = playerPosXZ - tilePosXZ;

            if (displacementXZ.sqrMagnitude >= sqrUnloadDistance) 
                tile.gameObject.SetActive(false);
        }
    }
}

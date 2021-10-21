using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGrid : MonoBehaviour
{
    [SerializeField] GridLogic.InGridType type;
    GridLogic.GameGrid gameGrid;
    // Start is called before the first frame update
    void Start()
    {
        gameGrid = GameObject.FindObjectOfType<GridLogic.GameGrid>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateGridLocToPos()
    {
        gameGrid.UpdatePosition(this, (Vector2Int) gameGrid.grid.WorldToCell( this.transform.position));
    }
    public void UpdatePosToGridloc()
        // updates the worldspace position of the gameobject to the centre of its
        // gamegrid space
    {
        this.transform.position = gameGrid.grid.CellToWorld((Vector3Int)gameGrid.SearchForInGrid(this));
    }
    public void SetGridLoc(Vector2Int location)
    {
        gameGrid.UpdatePosition(this, location);
    }
}

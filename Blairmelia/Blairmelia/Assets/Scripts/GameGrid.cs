using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GridLogic
{
    public enum InGridType
    {
        player,
        cursor,
        furniture,
        environment,
        station
    }

    public class GameGrid : MonoBehaviour
    {
        public Grid grid { get; }
        private Dictionary<Vector2Int, List<InGrid>> locatedObjects = new Dictionary<Vector2Int, List<InGrid>>();
        //private SerializeField
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        public Vector2Int? SearchForInGrid(InGrid inGrid)
        {
            foreach (var list in locatedObjects)
            {
                if (list.Value.Contains(inGrid))
                {
                    return list.Key;
                }
            }
            return null;
        }

        public List<InGrid> ObjectsInCell(Vector2Int location)
        {
            if (locatedObjects.ContainsKey(location))
            {
                List<InGrid> result = locatedObjects[location];
                return result;
            }
            else return new List<InGrid> { };
        }

        public void UpdatePosition(InGrid objectInGrid, Vector2Int location)
        {
            Vector2Int? currentLocation = SearchForInGrid(objectInGrid);
            if (currentLocation == null)
            {
                Debug.LogWarning("Object attempted to update position when object is not in GameGrid, adding object to GameGrid.");
                AddObject(objectInGrid, location);
            }
            else
            {
                RemoveObject(objectInGrid);
                AddObject(objectInGrid, location);
            }
        }

        public void RemoveObject(InGrid objectToRemove)
        {
            Vector2Int? currentLocation = SearchForInGrid(objectToRemove);
            if (currentLocation == null)
            {
                Debug.LogError("attempted to remove " + objectToRemove + " which isn't in the GameGrid");
                return;
            }
            locatedObjects[(Vector2Int)currentLocation].Remove(objectToRemove);
            if (locatedObjects[(Vector2Int)currentLocation].Count == 0)
            {
                locatedObjects.Remove((Vector2Int)currentLocation);
            }
        }

        public void AddObject(InGrid objetToAdd, Vector2Int locationToAddIt)
        {
            if (!locatedObjects.ContainsKey(locationToAddIt))
            {
                locatedObjects.Add(locationToAddIt, new List<InGrid> { });
            }
            locatedObjects[locationToAddIt].Add(objetToAdd);
        }
    }
}


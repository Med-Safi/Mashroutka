
using System.Globalization;
using UnityEngine;

public class CarModel : MonoBehaviour
{
    [SerializeField] string carName = null;
    [SerializeField] float carPrice = 0f;
    string label;
    int numberOfCheckPointsHit;
    float distanceToNextCheckpoint;

    public string GetCarName()
    {
        return carName;
    }

    public string GetCarLabel()
    {
        return label;
    }

    public void SetCarLabel(string label) 
    {  
        this.label = label;
    }

    public int GetNumberOfCheckpointsHit()
    {
        return numberOfCheckPointsHit;
    }

    public float GetCarPrice()
    {
        return carPrice;
    }
    public void CheckpointWasHit()
    {
        numberOfCheckPointsHit++;
    }

    public float GetDistanceToNextCheckpoint()
    {
        return distanceToNextCheckpoint;
    }

    public void SetDistanceToNextCheckPoint(float distance)
    {
        distanceToNextCheckpoint = distance;
    }
}

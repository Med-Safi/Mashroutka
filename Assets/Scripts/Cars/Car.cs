using UnityEngine;

public class Car : MonoBehaviour
{
    float originalYPos;
    bool hasOriginalYPosBeenSet;

    public  virtual void Start()
    {
        Invoke("SetOriginalYPos", 1.5f);

    }

    public virtual void Update()
    {
        if (hasOriginalYPosBeenSet)
        {
            Vector3 positionZithConstantYPos = new Vector3(transform.position.x, originalYPos,transform.position.z);
            transform.position = positionZithConstantYPos;
        }
    }

    private void SetOriginalYPos()
    {
        originalYPos = transform.position.y;
        hasOriginalYPosBeenSet = true;
    }


}

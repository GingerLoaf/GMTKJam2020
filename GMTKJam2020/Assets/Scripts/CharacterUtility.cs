using UnityEngine;

public static class CharacterUtility
{
    public static void UpdateWobble(Transform visualsParent, Vector3 velocity, float speed, float amount, bool isScared)
    {
        var angles = visualsParent.transform.localRotation;
        var normalizedDesiredVelocity = velocity.normalized;

        Quaternion newRot = Quaternion.identity;
        if (normalizedDesiredVelocity.magnitude > 0f && !isScared)
        {
            var eulerAngles = angles.eulerAngles;
            eulerAngles.z = Mathf.Sin(Time.time * speed) * amount;
            newRot = Quaternion.Euler(eulerAngles * normalizedDesiredVelocity.magnitude);
        }
        else
        {
            newRot = Quaternion.Slerp(visualsParent.transform.localRotation, newRot, Time.deltaTime * 10f);
        }

        visualsParent.transform.localRotation = newRot;
    }
}

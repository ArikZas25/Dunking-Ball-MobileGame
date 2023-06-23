using UnityEngine;

public class CameraShakeScript : MonoBehaviour
{
    public Transform cameraTransform;
    private Vector3 originalCameraPos;
    public float shakeDuration = 1.0f;
    public float shakeAmount = 0.1f;
    private bool canShake = false;
    private float shakeTimer;

    void Start()
    {
        originalCameraPos = cameraTransform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (ScorePoints.CameraShake) 
        {
            ShakeCamera();
        }
        if (canShake)
        {
            StartCameraShakeEffect();
        }

        void ShakeCamera()
        {
            canShake = true;
            shakeTimer = shakeDuration;
        } 
    }
    void StartCameraShakeEffect()
    {
        if (shakeTimer > 0)
        {
            cameraTransform.localPosition = originalCameraPos + Random.insideUnitSphere * shakeAmount * (ScorePoints.ComboNum * 0.2f);
            shakeTimer -= Time.deltaTime;

        }
        else
        {
            shakeTimer = 0f;
            cameraTransform.localPosition = originalCameraPos;
            canShake = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class CharacterControllerHandler : MonoBehaviour
{
    private XRRig m_XRRig;
    private CharacterController m_CharacterController;
    private CharacterControllerDriver driver;

    private void Update()
    {
        UpdateCharacterController();
    }
    protected virtual void UpdateCharacterController()
    {
        if (m_XRRig == null || m_CharacterController == null)
            return;

        var height = Mathf.Clamp(m_XRRig.cameraInRigSpaceHeight, driver.minHeight, driver.maxHeight);

        Vector3 center = m_XRRig.cameraInRigSpacePos;
        center.y = height / 2f + m_CharacterController.skinWidth;

        m_CharacterController.height = height;
        m_CharacterController.center = center;
    }
}

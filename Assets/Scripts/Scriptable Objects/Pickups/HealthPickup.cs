﻿using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    public int incrementHealthAmt;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (other.gameObject.GetComponent<TankView>() != null)
            {
                UIManager.Instance.HealthMode();
                TankView tankView = other.gameObject.GetComponent<TankView>();
                tankView.ModifyHealth(+incrementHealthAmt);
                gameObject.SetActive(false);

            }
        }

    }
}


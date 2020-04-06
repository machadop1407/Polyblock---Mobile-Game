using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;

public class RestoreIAP : MonoBehaviour
{
    public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
    {
        extensions.GetExtension<IAppleExtensions>().RestoreTransactions(result => {
            if (result)
            {
                // This does not mean anything was restored,
                // merely that the restoration process succeeded.
            }
            else
            {
                // Restoration failed.
            }
        });
    }
}
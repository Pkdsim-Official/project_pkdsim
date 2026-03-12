using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

namespace Project_Pkdsim.USys.LOVESys.Modules.LOVESys.Lovescripts.Hearts
{
	public class HeartBarUI : MonoBehaviour
	{
		[SerializeField] private List<Image> heartImages; // Drag heart images in the inspector.

		public void UpdateHearts(int activeHearts)
		{
			for (int i = 0; i < heartImages.Count; i++)
			{
				heartImages[i].enabled = i < activeHearts;
			}
		}
	}
}
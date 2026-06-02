using project_pkdsim.ANIMATOR.NPC.Leafeon.converteranimations.WalkingTo;
using project_pkdsim.ANIMATOR.NPC.Leafeon.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.NPC.Leafeon.converteranimations._SittingTo;
using UnityEngine;


namespace project_pkdsim.ANIMATOR.NPC.Leafeon.converteranimations
{
	public class Leafeon_ConverterAnimatorController : MonoBehaviour 
	{
		private LE_SittingTo LeafeonSittingto;
		
		private LE_WalkingTo LeafeonWalkingto;
		
		private LE_IdleTo LeafeonIdleto;

		private void LE_Base_IdleAnimatorController()
		{
			LeafeonWalkingto.LE_WalkingToController();

			LeafeonIdleto.LE_IdleToController();
			
			LeafeonSittingto.LE_SittingToController();	
		}
	}
}
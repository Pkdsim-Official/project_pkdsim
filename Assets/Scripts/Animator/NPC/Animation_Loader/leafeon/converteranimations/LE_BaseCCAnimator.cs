using project_pkdsim.ANIMATOR.Npcs.Leafeon.converteranimations.WalkingTo;
using project_pkdsim.ANIMATOR.Npcs.Leafeon.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Npcs.Leafeon.converteranimations.SittingTo;
using UnityEngine;


namespace project_pkdsim.ANIMATOR.Npcs.Leafeon.converteranimations
{
	public class Leafeon_CoverterAnimatorController : MonoBehaviour 
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
using project_pkdsim.ANIMATOR.Parents.Leafeon.converteranimations.WalkingTo;
using project_pkdsim.ANIMATOR.Parents.Leafeon.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Leafeon.converteranimations.SittingTo;
using UnityEngine;


namespace project_pkdsim.ANIMATOR.Parents.Leafeon.converteranimations
{
	public class Leafeon_ConverterAnimatorController : MonoBehaviour 
	{
		private LE_SittingTo Leafeon_sittingto;
		
		private LE_WalkingTo Leafeon_walkingto;
		
		private LE_IdleTo Leafeon_idleto;

		private void LE_Base_IdleAnimatorController()
		{
			Leafeon_walkingto.LE_WalkingToController();

			Leafeon_idleto.LE_IdleToController();
			
			Leafeon_sittingto.LE_SittingToController();	
		}
	}
}
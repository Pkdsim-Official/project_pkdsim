using  project_pkdsim.ANIMATOR.Parents.Leafeon.Mom.converteranimations.WalkingTo;
using  project_pkdsim.ANIMATOR.Parents.Leafeon.Mom.converteranimations.IdleTo;
using  project_pkdsim.ANIMATOR.Parents.Leafeon.Mom.converteranimations.SittingTo;
using UnityEngine;


namespace  project_pkdsim.ANIMATOR.Parents.Leafeon.Mom.converteranimations
{
	public class Leafeon_ConverterToAnimatorController : MonoBehaviour 
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
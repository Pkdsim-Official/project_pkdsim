using project_pkdsim.ANIMATOR.Parents.Vespiquen.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.converteranimations
{
	public class VespiquenConverterAnimatorController : MonoBehaviour 
	{
		private VESittingTo Vespiquensittingto;
		
		private VEWalkingTo Vespiquenwalkingto;
		
		private VEIdleTo Vespiquenidleto;

		public void VEConverterToAnimatorController()
		{
			Vespiquenwalkingto.VEWalkingToController();

			Vespiquenidleto.VE_IdleToController();
			
			Vespiquensittingto.VESittingToController();	
		}
	}
}
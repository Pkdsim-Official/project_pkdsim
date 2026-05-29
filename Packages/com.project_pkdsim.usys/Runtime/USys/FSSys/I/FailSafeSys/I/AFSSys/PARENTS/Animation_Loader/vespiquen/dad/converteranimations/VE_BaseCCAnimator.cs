using project_pkdsim.ANIMATOR.Parents.Vespiquen.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.converteranimations
{
	public class Vespiquen_ConverterToAnimatorController : MonoBehaviour 
	{
		private VESittingTo Vespiquensittingto;
		
		private VEWalkingTo Vespiquenwalkingto;
		
		private VEIdleTo Vespiquenidleto;

		public void VE_ConverterToAnimatorController()
		{
			Vespiquenwalkingto.VEWalkingToController();

			Vespiquenidleto.VE_IdleToController();
			
			Vespiquensittingto.VESittingToController();	
		}
	}
}
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations
{
	public class Vespiquen_ConverterAnimatorController : MonoBehaviour 
	{
		private VESittingTo Vespiquensittingto;
		
		private VEWalkingTo Vespiquenwalkingto;
		
		private VEIdleTo Vespiquenidleto;

		public void VE_ConverterAnimatorController()
		{
			Vespiquenwalkingto.VEWalkingToController();

			Vespiquenidleto.VE_IdleToController();
			
			Vespiquensittingto.VESittingToController();	
		}
	}
}
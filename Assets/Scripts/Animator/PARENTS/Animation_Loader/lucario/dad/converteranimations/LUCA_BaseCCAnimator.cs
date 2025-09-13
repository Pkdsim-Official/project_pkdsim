using project_pkdsim.ANIMATOR.Parents.Lucario.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Lucario.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Lucario.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Lucario.converteranimations
{
	public class LucarioCoverterAnimatorController : MonoBehaviour 
	{
		private LUCASittingTo Lucariosittingto;
		
		private LUCAWalkingTo Lucariowalkingto;
		
		private LUCAIdleTo Lucarioidleto;

		public void LUCACoverterToAnimatorController()
		{
			Lucariowalkingto.LUCAWalkingToController();

			Lucarioidleto.LUCA_IdleToController();
			
			Lucariosittingto.LUCASittingToController();	
		}
	}
}
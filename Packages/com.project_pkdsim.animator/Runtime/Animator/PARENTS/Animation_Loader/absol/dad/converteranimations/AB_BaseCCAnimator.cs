using project_pkdsim.ANIMATOR.Parents.Absol.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Absol.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Absol.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Absol.converteranimations
{
	public class AbsolCoverterAnimatorController : MonoBehaviour 
	{
		private AB_SittingTo AbsolSittingto;
		
		private AB_WalkingTo AbsolWalkingto;
		
		private AB_IdleTo AbsolIdleto;

		public void ABCoverterToAnimatorController()
		{
			AbsolWalkingto.AB_WalkingToController();

			AbsolIdleto.AB_IdleToController();
			
			AbsolSittingto.AB_SittingToController();	
		}
	}
}
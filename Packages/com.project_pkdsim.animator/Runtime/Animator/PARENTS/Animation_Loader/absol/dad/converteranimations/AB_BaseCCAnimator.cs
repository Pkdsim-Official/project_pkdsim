using project_pkdsim.ANIMATOR.Parents.Absol.Dad.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Absol.Dad.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Absol.Dad.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Absol.Dad.converteranimations
{
	public class AbsolParent_ConverterToAnimatorController : MonoBehaviour 
	{
		private AB_SittingTo AbsolSittingto;
		
		private AB_WalkingTo AbsolWalkingto;
		
		private AB_IdleTo AbsolIdleto;

		public void AB_ConverterToAnimatorController()
		{
			AbsolWalkingto.AB_WalkingToController();

			AbsolIdleto.AB_IdleToController();
			
			AbsolSittingto.AB_SittingToController();	
		}
	}
}
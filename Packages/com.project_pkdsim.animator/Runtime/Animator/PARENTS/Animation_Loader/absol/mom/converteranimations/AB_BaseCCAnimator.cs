using project_pkdsim.ANIMATOR.Parents.Absol.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Absol.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Absol.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Absol.Mom.converteranimations
{
	public class AbsolParent_ConverterAnimatorController : MonoBehaviour 
	{
		private AB_SittingTo AbsolSittingto;
		
		private AB_WalkingTo AbsolWalkingto;
		
		private AB_IdleTo AbsolIdleto;

		public void AB_ConverterAnimatorController()
		{
			AbsolWalkingto.AB_WalkingToController();

			AbsolIdleto.AB_IdleToController();
			
			AbsolSittingto.AB_SittingToController();	
		}
	}
}
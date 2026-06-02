using project_pkdsim.ANIMATOR.Parents.Salazzle.Dad.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Salazzle.Dad.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Salazzle.Dad.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Salazzle.Dad.converteranimations
{
	public class SalazzleParentDad_ConverterAnimatorController : MonoBehaviour 
	{
		private SA_SittingTo sittingto;
		
		private SA_WalkingTo walkingto;
		
		private SA_IdleTo idleto;

		public void SA_ConverterAnimatorController()
		{
			walkingto.SA_WalkingToController();

			idleto.SA_IdleToController();
			
			sittingto.SA_SittingToController();	
		}
	}
}
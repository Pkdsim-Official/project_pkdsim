using project_pkdsim.ANIMATOR.Parents.Blaziken.Dad.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Blaziken.Dad.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Blaziken.Dad.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Blaziken.Dad.converteranimations
{
	public class BlazikenParentDad_ConverterAnimatorController : MonoBehaviour 
	{
		private BL_SittingTo BlazikenSittingto;
		
		private BL_WalkingTo BlazikenWalkingto;
		
		private BL_IdleTo BlazikenIdleto;

		public void BL_ConverterAnimatorController()
		{
			BlazikenWalkingto.BL_WalkingToController();

			BlazikenIdleto.BL_IdleToController();
			
			BlazikenSittingto.BL_SittingToController();	
		}
	}
}
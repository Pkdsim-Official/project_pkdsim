using project_pkdsim.ANIMATOR.Parents.Blaziken.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Blaziken.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Blaziken.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Blaziken.Mom.converteranimations
{
	public class BlazikenParentMom_ConverterToAnimatorController : MonoBehaviour 
	{
		private BL_SittingTo BlazikenSittingto;
		
		private BL_WalkingTo BlazikenWalkingto;
		
		private BL_IdleTo BlazikenIdleto;

		public void BL_ConverterToAnimatorController()
		{
			BlazikenWalkingto.BL_WalkingToController();

			BlazikenIdleto.BL_IdleToController();
			
			BlazikenSittingto.BL_SittingToController();	
		}
	}
}
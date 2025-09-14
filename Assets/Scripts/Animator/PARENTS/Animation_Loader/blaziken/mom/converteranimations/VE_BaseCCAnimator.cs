using project_pkdsim.ANIMATOR.Parents.Blaziken.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Blaziken.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Blaziken.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Blaziken.Mom.converteranimations
{
	public class BlazikenParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private BLParentMom_SittingTo BlazikenParentMomSittingto;
		
		private BLParentMom_WalkingTo BlazikenParentMomWalkingto;
		
		private BLParentMom_IdleTo BlazikenParentMomIdleto;

		public void BLParentMom_ConverterAnimatorController()
		{
			BlazikenParentMomWalkingto.BLParentMom_WalkingToController();

			BlazikenParentMomIdleto.BLParentMom_IdleToController();
			
			BlazikenParentMomSittingto.BLParentMom_SittingToController();	
		}
	}
}
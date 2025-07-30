using project_pkdsim.ANIMATOR.Parents.Braixen.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Braixen.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Braixen.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Braixen.Mom.converteranimations
{
	public class BraixenParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private BRParentMom_SittingTo BraixenParentMomSittingto;
		
		private BRParentMom_WalkingTo BraixenParentMomWalkingto;
		
		private BRParentMom_IdleTo BraixenParentMomIdleto;

		public void BRParentMom_ConverterAnimatorController()
		{
			BraixenParentMomWalkingto.BRParentMom_WalkingToController();

			BraixenParentMomIdleto.BRParentMom_IdleToController();
			
			BraixenParentMomSittingto.BRParentMom_SittingToController();	
		}
	}
}
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Blaziken.Mom.converteranimations.IdleTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Blaziken.Mom.converteranimations.SittingTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Blaziken.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Blaziken.Mom.converteranimations
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
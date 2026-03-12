using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Mom.converteranimations.IdleTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Mom.converteranimations.SittingTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Mom.converteranimations
{
	public class LeafeonParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private LEParentMom_SittingTo LeafeonParentMomSittingto;
		
		private LEParentMom_WalkingTo LeafeonParentMomWalkingto;
		
		private LEParentMom_IdleTo LeafeonParentMomIdleto;

		public void LEParentMom_ConverterAnimatorController()
		{
			LeafeonParentMomWalkingto.LEParentMom_WalkingToController();

			LeafeonParentMomIdleto.LEParentMom_IdleToController();
			
			LeafeonParentMomSittingto.LEParentMom_SittingToController();	
		}
	}
}
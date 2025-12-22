using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Mom.converteranimations.IdleTo;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Mom.converteranimations.SittingTo;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Mom.converteranimations
{
	public class BeedrillParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private BEParentMom_SittingTo BeedrillParentMomSittingto;
		
		private BEParentMom_WalkingTo BeedrillParentMomWalkingto;
		
		private BEParentMom_IdleTo BeedrillParentMomIdleto;

		public void BEParentMom_ConverterAnimatorController()
		{
			BeedrillParentMomWalkingto.BEParentMom_WalkingToController();

			BeedrillParentMomIdleto.BEParentMom_IdleToController();
			
			BeedrillParentMomSittingto.BEParentMom_SittingToController();	
		}
	}
}
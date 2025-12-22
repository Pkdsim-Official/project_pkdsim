using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Dad.converteranimations.IdleTo;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Dad.converteranimations.SittingTo;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Dad.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Dad.converteranimations
{
	public class BeedrillParentDad_ConverterAnimatorController : MonoBehaviour 
	{
		private BEParentDad_SittingTo BeedrillParentDadSittingto;
		
		private BEParentDad_WalkingTo BeedrillParentDadWalkingto;
		
		private BEParentDad_IdleTo BeedrillParentDadIdleto;

		public void BEParentDad_ConverterAnimatorController()
		{
			BeedrillParentDadWalkingto.BEParentDad_WalkingToController();

			BeedrillParentDadIdleto.BEParentDad_IdleToController();
			
			BeedrillParentDadSittingto.BEParentDad_SittingToController();	
		}
	}
}
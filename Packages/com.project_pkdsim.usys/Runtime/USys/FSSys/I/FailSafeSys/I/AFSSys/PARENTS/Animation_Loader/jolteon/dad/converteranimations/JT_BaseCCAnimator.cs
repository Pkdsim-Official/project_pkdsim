using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Dad.converteranimations.IdleTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Dad.converteranimations.SittingTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Dad.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Dad.converteranimations
{
	public class JolteonParentDad_ConverterAnimatorController : MonoBehaviour 
	{
		private JTParentDad_SittingTo JolteonParentDad_sittingto;
		
		private JTParentDad_WalkingTo JolteonParentDad_walkingto;
		
		private JTParentDad_IdleTo JolteonParentDad_idleto;

		public void JTParentDad_ConverterAnimatorController()
		{
			JolteonParentDad_walkingto.JTParentDad_WalkingToController();

			JolteonParentDad_idleto.JTParentDad_IdleToController();
			
			JolteonParentDad_sittingto.JTParentDad_SittingToController();	
		}
	}
}
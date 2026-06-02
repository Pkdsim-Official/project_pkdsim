using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Mom.converteranimations.IdleTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Mom.converteranimations.SittingTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Mom.converteranimations
{
	public class JolteonParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private JTParentMom_SittingTo JolteonParentMom_sittingto;
		
		private JTParentMom_WalkingTo JolteonParentMom_walkingto;
		
		private JTParentMom_IdleTo JolteonParentMom_idleto;

		public void JTParentMom_ConverterAnimatorController()
		{
			JolteonParentMom_walkingto.JTParentMom_WalkingToController();

			JolteonParentMom_idleto.JTParentMom_IdleToController();
			
			JolteonParentMom_sittingto.JTParentMom_SittingToController();	
		}
	}
}
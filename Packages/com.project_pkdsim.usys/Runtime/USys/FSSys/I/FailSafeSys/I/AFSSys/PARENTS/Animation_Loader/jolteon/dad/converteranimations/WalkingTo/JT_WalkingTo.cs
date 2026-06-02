using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Dad.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Dad.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Dad.converteranimations.WalkingTo
{
	public class JTParentDad_WalkingTo : MonoBehaviour 
	{
		private JTParentDad_WalkingToSitting JTParentDad_WalkingToSitting;
		private JTParentDad_WalkingToStanding JTParentDad_WalkingToStanding;
		public void JTParentDad_WalkingToController()
		{
			Load_JTParentDad_WalkingToSitting();
			Load_JTParentDad_WalkingToStanding();	
		}
		private void Load_JTParentDad_WalkingToSitting()
		{

		}
		private void Load_JTParentDad_WalkingToStanding()
		{
			
		}
	}
}
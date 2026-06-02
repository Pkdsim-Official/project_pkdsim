using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Dad.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Mom.Animator_I;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa
{
	public class LFS_PheromosaParentsFailSafe : MonoBehaviour 
	{
		private PheromosaParentDad_FailSafe PheromosaParentDad_FailSafe;
		private PheromosaParentMom_FailSafe PheromosaParentMom_FailSafe;
		public void Load_PheromosaParentsFailSafe()
		{
			Load_PheromosaParentDad_FailSafe();
			Load_PheromosaParentMom_FailSafe();	
		}
		private void Load_PheromosaParentDad_FailSafe()
		{
			PheromosaParentDad_FailSafe.LoadFailSafePheromosaParentDad_AnimatorController();
		}
		private void Load_PheromosaParentMom_FailSafe()
		{
			PheromosaParentMom_FailSafe.LoadFailSafePheromosaParentMom_AnimatorController();
		}	
	}
}
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon.Dad.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon.Mom.Animator_I;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon
{
	public class LFS_FlareonParentsFailSafe : MonoBehaviour
	{
		private FlareonParentDad_FailSafe FlareonParentDad_FailSafe;
		private FlareonParentMom_FailSafe FlareonParentMom_FailSafe;
		public void Load_FlareonParentsFailSafe()
		{
			Load_FlareonParentDad_FailSafe();
			Load_FlareonParentMom_FailSafe();	
		}
		private void Load_FlareonParentDad_FailSafe()
		{
			FlareonParentDad_FailSafe.LoadFailSafeFlareonParentDad_AnimatorController();
		}
		private void Load_FlareonParentMom_FailSafe()
		{
			FlareonParentMom_FailSafe.LoadFailSafeFlareonParentMom_AnimatorController();
		}
	}
}
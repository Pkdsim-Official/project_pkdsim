using project_pkdsim.ANIMATOR.Parents.Vaporeon.Dad.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.ANIMATOR.Parents.Vaporeon.Dad.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vaporeon.Dad.converteranimations.IdleTo
{
	public class VPParentDad_IdleTo : MonoBehaviour 
	{
		private VPParentDad_IdleToWalk VPParentDad_idletowalk;
		
		private VPParentDad_IdleToRun VPParentDad_idletorun;
		public void VPParentDad_IdleToController()
		{
			Load_VPParentDad_idleToRun();
			Load_VPParentDad_idleToWalk();
		}
		private void Load_VPParentDad_idleToRun()
		{
			VPParentDad_idletorun.VPParentDad_IdleToRunController();
		}
		private void Load_VPParentDad_idleToWalk()
		{
			VPParentDad_idletowalk.VPParentDad_IdleToWalkController();
		}
	}
}
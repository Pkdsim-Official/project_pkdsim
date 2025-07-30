using project_pkdsim.ANIMATOR.Npcs.Glaceon.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.ANIMATOR.Npcs.Glaceon.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Glaceon.converteranimations.SittingTo
{
	public class GL_SittingTo : MonoBehaviour 
	{
		private GL_SittingToStartWalking GL_sittingToStartWalking;
		private GL_SittingToStanding GL_sittingToStanding;
		
		public void GL_SittingToController()
		{
			Load_GL_SittingToStanding();
			Load_GL_SittingToStartWalking();
		}
		private void Load_GL_SittingToStanding()
		{
			GL_sittingToStanding.GL_SittingToStandingController();
		}
		private void Load_GL_SittingToStartWalking()
		{
			GL_sittingToStartWalking.GL_SittingToStartWalkingController();
		}
	}
}
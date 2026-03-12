using Project_Pkdsim.ANIMATOR.Npcs.Glaceon.converteranimations.SittingTo.SittingToStartWalking;
using Project_Pkdsim.ANIMATOR.Npcs.Glaceon.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Glaceon.converteranimations.SittingTo
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
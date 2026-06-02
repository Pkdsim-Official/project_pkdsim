using project_pkdsim.ANIMATOR.Parents.Leafeon.Dad.converteranimations.SittingTo.SittingToStanding;
using project_pkdsim.ANIMATOR.Parents.Leafeon.Dad.converteranimations.SittingTo.SittingToStartWalking;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Leafeon.Dad.converteranimations.SittingTo
{
	public class LEParentDad_SittingTo : MonoBehaviour 
	{
		
		private LEParentDad_SittingToStanding LEParentDad_sittingToStanding;
		private LEParentDad_SittingToStartWalking LEParentDad_sittingToWalking;
		public void LEParentDad_SittingToController()
		{
			Load_LEParentDad_SittingToStartWalking();
			Load_LEParentDad_SittingToStanding();
		}
		private void Load_LEParentDad_SittingToStanding()
		{
			
		}
		private void Load_LEParentDad_SittingToStartWalking()
		{
			
		}
	}
}
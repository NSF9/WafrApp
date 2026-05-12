using Wafr.DTOs.SavingGoals;

namespace Wafr.Business.Interfaces
{
    public interface ISavingGoalService
    {
        SavingGoalResponseDTO CreateSavingGoal(int UserID, CreateSavingGoalRequestDTO CreateSavingGoalDTO);

        List<SavingGoalResponseDTO> GetSavingGoalsByUserID(int UserID);

        SavingGoalDetailsResponseDTO GetSavingGoalDetailsBySavingGoalID(int SavingGoalID);

        bool UseSavingGoal(int SavingGoalID);

        bool CloseSavingGoal(int SavingGoalID);

    }
}
using APPLICATION.DTO;

namespace APPLICATION.Interfaces
{
    public interface IReviewService
    {
        Task<ReviewDTO> GetById(Guid id);

        Task<Guid> Create(CreateReviewDTO dto);

        Task<bool> Patch(Guid id, PatchReviewDTO dto);

        Task<bool> Delete(Guid id);

        Task<bool> PatchReviewDetails(Guid reviewId, PatchReviewDetailsDTO dto);
    }
}

using DOMAIN.Entities;
namespace APPLICATION.Interfaces
{
    public interface IReviewRepository
    {
        Task<Review> GetById(Guid id);

        Task<Guid> Create(Review review);

        Task<bool> Patch(Guid id, Dictionary<string, object> fields);

        Task<bool> Delete(Guid id);

        Task<bool> PatchReviewDetails(Guid reviewId, Dictionary<string, object> fields);
    }
}

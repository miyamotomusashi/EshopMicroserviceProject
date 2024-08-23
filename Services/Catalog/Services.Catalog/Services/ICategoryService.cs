using Services.Catalog.Dtos;
using SharedLibrary.Dtos;

namespace Services.Catalog.Services
{
  public interface ICategoryService
    {
        Task<ResponseDto<List<CategoryDto>>> GetAllAsync();

        Task<ResponseDto<CategoryDto>> CreateAsync(CategoryDto category);

        Task<ResponseDto<CategoryDto>> GetByIdAsync(string id);
    }
}
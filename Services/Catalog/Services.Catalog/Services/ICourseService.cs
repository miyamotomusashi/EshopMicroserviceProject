using Services.Catalog.Dtos;
using SharedLibrary.Dtos;

namespace Services.Catalog.Services
{
  public interface ICourseService
    {
        Task<ResponseDto<List<CourseDto>>> GetAllAsync();

        Task<ResponseDto<CourseDto>> GetByIdAsync(string id);

        Task<ResponseDto<List<CourseDto>>> GetAllByUserIdAsync(string userId);

        Task<ResponseDto<CourseDto>> CreateAsync(CourseCreateDto courseCreateDto);

        Task<ResponseDto<NoContentDto>> UpdateAsync(CourseUpdateDto courseUpdateDto);

        Task<ResponseDto<NoContentDto>> DeleteAsync(string id);
    }
}
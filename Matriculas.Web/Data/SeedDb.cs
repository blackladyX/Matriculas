using Matriculas.Web.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Matriculas.Web.Data
{
    public class SeedDb
    {
        private readonly ApplicationDbContext _context;
        public SeedDb(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckCountriesAsync();
        }
        private async Task CheckCountriesAsync()
        {
            if (!_context.Courses.Any())
            {
                _context.Courses.Add(new Course
                {
                    CourseCode = "123",
                    CourseName = "programación",
                    InicialDate = "10/10/2020",
                    FinalDate = "11/11/2020",
                    Description = "Description del curso",
                    CourseCost = 50000,
                    DateInscripcion = "09/09/2020",
                    Capacity = 50,
                    Intensity = 5,
                    ClassSchedule = "lunes a viernes de 8 a 12 ",

                    Teachers = new List<Teacher>
                   {
                    new Teacher
                    {
                    TeacherIdentification = 123456789,
                    TeacherFullName = "Juan Manuel Betancur",
                    Dateofbirth = "27/10/1994",
                    Experience= "Trabajó como docente en Gobierno",
                    TeacherAddress = "Calle 31D # 89D - 30",
                    TeacherCellPhone = "3053224270",
                    ArtisticArea = "Programación",
                    },
                    },
                });
                await _context.SaveChangesAsync();
            }
        }
    }
}


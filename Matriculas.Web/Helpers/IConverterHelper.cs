using System;
using DocumentFormat.OpenXml.Wordprocessing;
using Matriculas.Web.Models;

public interface IConverterHelper
{
    Category ToCategory(CategoryViewModel model, Guid imageId, bool isNew);

    CategoryViewModel ToCategoryViewModel(Category category);
}

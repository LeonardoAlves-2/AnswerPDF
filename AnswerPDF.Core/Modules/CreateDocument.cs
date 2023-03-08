using AnswerPDF.Core.Modules.Models;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace AnswerPDF.Core.Modules;

public static class CreateDocument
{
    public static void DrawDocument(this IDocumentContainer documentContainer, params IGenericDrawModel[] drawModels)
    {
        documentContainer.Page(page =>
        {
            foreach (var drawModel in drawModels)
            {
                page.Content().DrawExtension(drawModel);
            }
        });
    }
}

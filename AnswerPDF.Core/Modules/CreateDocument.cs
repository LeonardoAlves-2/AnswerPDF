using AnswerPDF.Core.Modules.Models;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace AnswerPDF.Core.Modules;

public class CreateDocument
{
    public void DrawDocument(IDocumentContainer documentContainer, params GenericDrawModel[] drawModels)
    {
        documentContainer.Page(page =>
        {
            foreach (var drawModel in drawModels)
            {
            }
        });
    }
}

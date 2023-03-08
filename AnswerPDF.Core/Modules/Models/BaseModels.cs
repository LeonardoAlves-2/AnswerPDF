using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using System;

namespace AnswerPDF.Core.Modules.Models;

public interface IGenericDrawModel
{
    IContainer Draw(IContainer container);
}

public static class DrawModelExtensions
{
    public static IContainer DrawExtension(this IContainer container, IGenericDrawModel model)
    {
        return model.Draw(container);
    }
}

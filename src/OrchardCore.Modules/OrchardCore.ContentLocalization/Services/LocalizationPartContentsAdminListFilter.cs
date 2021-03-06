using System;
using System.Linq;
using System.Threading.Tasks;
using OrchardCore.ContentLocalization.Models;
using OrchardCore.ContentLocalization.Records;
using OrchardCore.ContentLocalization.ViewModels;
using OrchardCore.ContentManagement;
using OrchardCore.ContentManagement.Metadata;
using OrchardCore.ContentManagement.Records;
using OrchardCore.Contents.Services;
using OrchardCore.DisplayManagement.ModelBinding;
using YesSql;
using YesSql.Services;

namespace OrchardCore.ContentLocalization.Services
{
    public class LocalizationPartContentsAdminListFilter : IContentsAdminListFilter
    {
        private readonly IContentDefinitionManager _contentDefinitionManager;

        public LocalizationPartContentsAdminListFilter(IContentDefinitionManager contentDefinitionManager)
        {
            _contentDefinitionManager = contentDefinitionManager;
        }

        public async Task FilterAsync(IQuery<ContentItem> query, IUpdateModel updateModel)
        {
            var viewModel = new LocalizationContentsAdminFilterViewModel();
            if (await updateModel.TryUpdateModelAsync(viewModel, "Localization"))
            {
                // Show localization content items
                // This is intended to be used by adding ?Localization.ShowLocalizedContentTypes to an AdminMenu url.
                if (viewModel.ShowLocalizedContentTypes)
                {
                    var localizedTypes = _contentDefinitionManager
                        .ListTypeDefinitions()
                        .Where(x =>
                            x.Parts.Any(p =>
                                p.PartDefinition.Name == nameof(LocalizationPart)))
                        .Select(x => x.Name);

                    query.With<ContentItemIndex>(x => x.ContentType.IsIn(localizedTypes));
                }

                // Show contained elements for the specified culture
                else if (!String.IsNullOrEmpty(viewModel.SelectedCulture))
                {
                    query.With<LocalizedContentItemIndex>(x => x.Culture == viewModel.SelectedCulture);
                }
            }
        }
    }
}

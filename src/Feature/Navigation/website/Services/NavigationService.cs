using MDigital.Feature.Navigation.Models;
using MDigital.Foundation.Content.Repositories;
using MDigital.Foundation.Logging.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MDigital.Feature.Navigation.Constants;

namespace MDigital.Feature.Navigation.Services
{
    /// <summary>
    /// Navigation Service Class.
    /// </summary>
    public class NavigationService : INavigationService
    {
        private readonly IContextRepository _contextRepository;
        private readonly ILogRepository _logRepository;
        private readonly IRenderingRepository _renderingRepository;

        public NavigationService(IContextRepository contextRepository,
            ILogRepository logRepository, IRenderingRepository renderingRepository)
        {
            _contextRepository = contextRepository;
            _logRepository = logRepository;
            _renderingRepository = renderingRepository;
        }

        /// <summary>
        /// Getting the experiance editor bool value
        /// </summary>
        public bool IsExperienceEditor => _contextRepository.IsExperienceEditor;

        /// <summary>
        /// Getting Header Navigation Datasource Item.
        /// </summary>
        /// <returns>Header Navigation Model.</returns>
        public IHeaderNavigation GetHeaderNavigationItems()
        {
            var dataSource = _renderingRepository.GetDataSourceItem<IHeaderNavigation>();

            if (dataSource == null)
                _logRepository.Warn(Logging.Error.DataSourceError);

            return dataSource;
        }
    }
}

using MDigital.Foundation.Content.Repositories;
using MDigital.Foundation.Logging.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDigital.Feautre.Navigation.Services
{
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

        public bool IsExperienceEditor => _contextRepository.IsExperienceEditor;

        public object GetHeaderNavigationItems()
        {
            throw new NotImplementedException();
        }
    }
}

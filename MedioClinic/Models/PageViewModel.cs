﻿using System.Collections.Generic;
using Kentico.Dto.Company;
using Kentico.Dto.Culture;
using Kentico.Dto.Menu;
using Kentico.Dto.Page;
using Kentico.Dto.Social;

namespace MedioClinic.Models
{
    public class PageViewModel 
    {
        public IEnumerable<MenuItemDto> MenuItems { get; set; }
        public PageMetadataDto Metadata { get; set; }
        public CompanyDto Company { get; set; }
        public IEnumerable<CultureDto> Cultures { get; set; }
        public IEnumerable<SocialLinkDto> SocialLinks { get; set; }
    }

    public class PageViewModel<TViewModel> : PageViewModel where TViewModel : IViewModel
    {
        public TViewModel Data { get; set; }
    }
}
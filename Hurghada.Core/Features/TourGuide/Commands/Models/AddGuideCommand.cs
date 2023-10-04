﻿using Hurghada.Core.Bases;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Hurghada.Core.Features.TourGuide.Commands.Models
{
    public class AddGuideCommand : IRequest<Response<string>>
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string MotherLanguage { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ProfilePhoto { get; set; } = string.Empty;
        public string IDPhoto { get; set; } = string.Empty;
        public bool IsCertified { get; set; }

        public List<GuideLanguageCommand> GuideLanguages { get; set; } = new List<GuideLanguageCommand>();

    }
    public class GuideLanguageCommand
    {
        public int Id { get; set; }
        [Range(1, 5)]
        public int LanguageLevel { get; set; }
    }

}
